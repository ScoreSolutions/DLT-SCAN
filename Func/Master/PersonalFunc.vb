Imports Linq.TABLE
Imports Para.TABLE
Imports Linq.Common.Utilities

Namespace Master
    Public Class PersonalFunc
        Dim _err As String = ""

        Public ReadOnly Property ErrorMessage() As String
            Get
                Return _err
            End Get
        End Property


        Public Function SavePersonal(ByVal para As PersonalPara) As Boolean
            Dim ret As Boolean = False
            Dim trans As New TransactionDB
            trans.CreateTransaction()

            Dim lnq As New PersonalLinq
            If para.ID <> 0 Then
                lnq = lnq.GetDataByPK(para.ID, trans.Trans)
            End If
            lnq.STAFF_CODE = para.STAFF_CODE
            lnq.TITLE_NAME = para.TITLE_NAME
            lnq.FIRST_NAME = para.FIRST_NAME
            lnq.LAST_NAME = para.LAST_NAME

            If para.ID <> 0 Then
                ret = lnq.UpdateByPK(My.Computer.Name, trans.Trans)
            Else
                ret = lnq.InsertData(My.Computer.Name, trans.Trans)
            End If

            If ret = False Then
                _err = lnq.ErrorMessage
                trans.RollbackTransaction()
            Else
                trans.CommitTransaction()
            End If

            Return ret
        End Function

        Public Function GetDataByStaffCode(ByVal StaffCode As String) As PersonalPara
            Dim lnq As New PersonalLinq
            lnq.ChkDataBySTAFF_CODE(StaffCode, Nothing)
            Return lnq.GetParameter(lnq.ID, Nothing)
        End Function
    End Class
End Namespace

