Imports Linq.TABLE
Imports Para.TABLE
Imports Linq.Common.Utilities

Namespace Master


    Public Class DocTypeFunc
        Dim _err As String = ""
        Dim _information As String = ""


        Public ReadOnly Property ErrorMessage() As String
            Get
                Return _err
            End Get
        End Property

        Public ReadOnly Property InfoMessage() As String
            Get
                Return _information
            End Get
        End Property

        Public Function SaveDocType(ByVal para As DocTypePara) As Boolean
            Dim ret As Boolean = False
            Dim trans As New TransactionDB
            trans.CreateTransaction()

            Dim lnq As New DocTypeLinq
            If para.ID <> 0 Then
                lnq.GetDataByPK(para.ID, trans.Trans)
            End If
            lnq.DOCTYPE_CODE = para.DOCTYPE_CODE
            lnq.DOCTYPE_NAME = para.DOCTYPE_NAME
            lnq.ACTIVE = para.ACTIVE

            If para.ID <> 0 Then
                ret = lnq.UpdateByPK("Admin", trans.Trans)
            Else
                ret = lnq.InsertData("Admin", trans.Trans)
            End If

            If ret = True Then
                trans.CommitTransaction()
            Else
                _err = lnq.ErrorMessage
                trans.RollbackTransaction()
            End If

            Return ret

        End Function

        Public Function GetDocTypeAll(ByVal trans As SqlClient.SqlTransaction) As DataTable
            Dim lnq As New DocTypeLinq
            Return lnq.GetDataList("1=1", "doctype_code", trans)
        End Function

        Public Function GetDocTypePara(ByVal ID As Long, ByVal trans As SqlClient.SqlTransaction) As DocTypePara
            Dim lnq As New DocTypeLinq
            Dim para As New DocTypePara
            para = lnq.GetParameter(ID, trans)
            Return para
        End Function

        Public Function GetDocTypeByDocTypeCode(ByVal DocTypeCode As String) As DocTypePara
            Dim lnq As New DocTypeLinq
            Dim para As New DocTypePara
            lnq.ChkDataByDOCTYPE_CODE(DocTypeCode, Nothing)
            para = lnq.GetParameter(lnq.ID, Nothing)
            Return para
        End Function

        Public Function DeleteDocType(ByVal ID As Long) As Boolean
            Dim ret As Boolean = False
            Dim trans As New TransactionDB
            trans.CreateTransaction()

            Dim lnq As New DocTypeLinq
            ret = lnq.DeleteByPK(ID, trans.Trans)
            If ret = False Then
                _err = lnq.ErrorMessage
                trans.RollbackTransaction()
            Else
                trans.CommitTransaction()
            End If

            Return ret
        End Function

        Public Function ChkDupData(ByVal para As DocTypePara) As Boolean
            Dim ret As Boolean = False

            Dim lnq As New DocTypeLinq
            ret = lnq.ChkDuplicateByDOCTYPE_CODE(para.DOCTYPE_CODE, para.ID, Nothing)
            If ret = False Then
                ret = lnq.ChkDuplicateByDOCTYPE_NAME(para.DOCTYPE_NAME, para.ID, Nothing)
                If ret = True Then
                    _information = "ชื่อเอกสารซ้ำ"
                End If
            Else
                _information = "รหัสเอกสารซ้ำ"
            End If

            Return ret
        End Function
        Public Function ChkDataByDoctypeName(ByVal DoctypeName As String) As Boolean
            Dim lnq As New DocTypeLinq
            Return lnq.ChkDataByDOCTYPE_NAME(DoctypeName, Nothing)
        End Function

    End Class
End Namespace