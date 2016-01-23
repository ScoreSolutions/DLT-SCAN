Imports System.IO
Imports System.Linq
Imports Func.Utilities
Imports Linq.TABLE
Imports Para.TABLE
Imports iTextSharp.text.pdf
Imports Linq.Common.Utilities

Namespace Master
    Public Class FileFunc
        Dim _err As String = ""
        Public ReadOnly Property ErrorMessage() As String
            Get
                Return _err
            End Get
        End Property


        Public Function GetPDFFileList(ByVal folderName As String) As DataTable
            Dim dt As New DataTable()
            dt.Columns.Add("id")
            dt.Columns.Add("name")
            dt.Columns.Add("doctype_name")
            dt.Columns.Add("date")
            dt.Columns.Add("page", GetType(Int16))
            dt.Columns.Add("dateFrom")
            dt.Columns.Add("dateTo")
            dt.Columns.Add("SortDate")
            dt.Columns.Add("filePath")

            Dim file() As String = Directory.GetFiles(folderName, "*", SearchOption.AllDirectories)
            Dim fle = From f In file Where f.ToUpper().EndsWith("PDF") Select f
            For Each ff In fle
                Dim prop As New FileInfo(ff)
                'If Convert.ToInt64(prop.LastWriteTime.ToString("yyyyMMdd")) >= Convert.ToInt64(dateFrom.ToString("yyyyMMdd")) And Convert.ToInt64(prop.LastWriteTime.ToString("yyyyMMdd")) <= Convert.ToInt64(dateTo.ToString("yyyyMMdd")) Then
                Dim staffCode = prop.Name.Substring(0, Config.StaffCodeLength)
                Dim doctypeCode = prop.Name.Substring(Config.StaffCodeLength + 1).ToUpper.Replace(".PDF", "")
                Dim dr = dt.NewRow
                dr("id") = staffCode
                dr("name") = GetStaffName(staffCode)
                dr("doctype_name") = GetDocTypeName(doctypeCode)
                dr("date") = prop.LastWriteTime.ToString("dd/MM/yyyy")
                dr("page") = GetPDFPageCount(ff)
                'dr("dateFrom") = dateFrom.ToString("dd/MM/yyyy")
                'dr("dateTo") = dateTo.ToString("dd/MM/yyyy")
                dr("SortDate") = prop.LastWriteTime.ToString("yyyyMMdd")
                dr("filePath") = ff
                dt.Rows.Add(dr)
                'End If
            Next
            dt.DefaultView.Sort = "id asc"
            Return dt.DefaultView.ToTable()
        End Function

        Public Function GetFileList(ByVal dateFrom As DateTime, ByVal dateTo As DateTime, ByVal folderName As String, ByVal fileExtension As String) As DataTable
            Dim dt As New DataTable()
            dt.Columns.Add("id")
            dt.Columns.Add("name")
            dt.Columns.Add("doctype_name")
            dt.Columns.Add("date")
            dt.Columns.Add("page", GetType(Int16))
            dt.Columns.Add("dateFrom")
            dt.Columns.Add("dateTo")
            dt.Columns.Add("SortDate")
            dt.Columns.Add("filePath")

            Dim file() As String = Directory.GetFiles(folderName, "*", SearchOption.AllDirectories)
            Dim fle = From f In file Where f.ToUpper().EndsWith(fileExtension) Select f
            For Each ff In fle
                Dim prop As New FileInfo(ff)
                If Convert.ToInt64(prop.LastWriteTime.ToString("yyyyMMdd")) >= Convert.ToInt64(dateFrom.ToString("yyyyMMdd")) And Convert.ToInt64(prop.LastWriteTime.ToString("yyyyMMdd")) <= Convert.ToInt64(dateTo.ToString("yyyyMMdd")) Then
                    Dim staffCode = prop.Name.Substring(0, Config.StaffCodeLength)
                    Dim doctypeCode = prop.Name.Substring(Config.StaffCodeLength + 1).ToUpper.Replace("." & fileExtension, "")
                    Dim dr = dt.NewRow
                    dr("id") = staffCode
                    dr("name") = GetStaffName(staffCode)
                    dr("doctype_name") = GetDocTypeName(doctypeCode)
                    dr("date") = prop.LastWriteTime.ToString("dd/MM/yyyy")
                    'dr("page") = GetPDFPageCount(ff)
                    dr("dateFrom") = dateFrom.ToString("dd/MM/yyyy")
                    dr("dateTo") = dateTo.ToString("dd/MM/yyyy")
                    dr("SortDate") = prop.LastWriteTime.ToString("yyyyMMdd")
                    dr("filePath") = ff
                    dt.Rows.Add(dr)
                End If
            Next
            dt.DefaultView.Sort = "id asc"
            Return dt.DefaultView.ToTable()
        End Function

        Private Function GetStaffName(ByVal staffCode As String) As String
            Dim ret As String = ""
            Dim para = New PersonalPara
            Dim fnc As New PersonalFunc
            para = fnc.GetDataByStaffCode(staffCode)
            ret = para.TITLE_NAME + para.FIRST_NAME + " " + para.LAST_NAME
            Return ret
        End Function

        Private Function GetDocTypeName(ByVal doctypeCode As String) As String
            Dim ret As String = ""
            Dim para As New DocTypePara
            Dim fnc As New DocTypeFunc
            para = fnc.GetDocTypeByDocTypeCode(doctypeCode)
            ret = para.DOCTYPE_NAME
            Return ret
        End Function
        Private Function GetPDFPageCount(ByVal FileName As String) As Integer
            'On Error GoTo ErrPDF
            Dim page_count As Integer = 0
            Try
                Dim extension As String = Path.GetExtension(FileName)
                If (extension.ToUpper = ".PDF") Then
                    Dim pdfFile As New PdfReader(FileName)
                    page_count = pdfFile.NumberOfPages
                    pdfFile.Close()
                End If
            Catch ex As PdfException
                _err = ex.Message
                Dim logLnq As New ScanErrorLogLinq
                logLnq.ERR_TIME = DateTime.Now
                logLnq.ERR_DESC = ex.Message
                logLnq.FILE_NAME = FileName

                Dim trans As New TransactionDB
                trans.CreateTransaction()
                Dim ret As Boolean = logLnq.InsertData("Admin", trans.Trans)
                If ret = True Then
                    trans.CommitTransaction()
                Else
                    trans.RollbackTransaction()
                End If
            Catch ex As Exception
                _err = ex.Message
                Dim logLnq As New ScanErrorLogLinq
                logLnq.ERR_TIME = DateTime.Now
                logLnq.ERR_DESC = ex.Message
                logLnq.FILE_NAME = FileName

                Dim trans As New TransactionDB
                trans.CreateTransaction()
                Dim ret As Boolean = logLnq.InsertData("Admin", trans.Trans)
                If ret = True Then
                    trans.CommitTransaction()
                Else
                    trans.RollbackTransaction()
                End If
            End Try

            Return page_count
        End Function
    End Class
End Namespace
