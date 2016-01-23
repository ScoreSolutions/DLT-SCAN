Imports Linq.TABLE
Imports Para.TABLE
Imports Linq.Common.Utilities

Namespace Master

    Public Class ScanHistoryFunc

        Dim _err As String = ""

        Public ReadOnly Property ErrorMessage() As String
            Get
                Return _err
            End Get
        End Property

        Public Function SaveScanHistory(ByVal para As ScanHistoryPara) As Boolean
            Dim ret As Boolean = False
            Dim trans As New TransactionDB
            trans.CreateTransaction()

            Dim lnq As New ScanHistoryLinq
            Dim dupData As Boolean = lnq.ChkDataByDOCTYPE_CODE_STAFF_CODE(para.DOCTYPE_CODE, para.STAFF_CODE, trans.Trans)

            Dim sta As New PersonalLinq
            sta.ChkDataBySTAFF_CODE(para.STAFF_CODE, trans.Trans)

            Dim doc As New DocTypeLinq
            doc.ChkDataByDOCTYPE_CODE(para.DOCTYPE_CODE, trans.Trans)

            lnq.PERSONAL_ID = sta.ID
            lnq.STAFF_CODE = para.STAFF_CODE
            lnq.DOC_TYPE_ID = doc.ID
            lnq.DOCTYPE_CODE = para.DOCTYPE_CODE
            lnq.CLIENT_SCAN = para.CLIENT_SCAN
            lnq.CLIENT_IP = para.CLIENT_IP
            lnq.OUTPUT_FOLDER = para.OUTPUT_FOLDER
            lnq.PDF_FILENAME = para.PDF_FILENAME
            lnq.PDF_PAGE = lnq.PDF_PAGE + 1

            If dupData = False Then
                ret = lnq.InsertData(My.Computer.Name, trans.Trans)
            Else
                ret = lnq.UpdateByPK(My.Computer.Name, trans.Trans)
            End If

            If ret = False Then
                _err = lnq.ErrorMessage
                trans.RollbackTransaction()
            Else
                trans.CommitTransaction()
            End If

            Return ret
        End Function

        Public Function GetDataBySql(ByVal sql As String) As DataTable
            Dim lnq As New ScanHistoryLinq()
            Return lnq.GetListBySql(sql, Nothing)
        End Function
    End Class
End Namespace
