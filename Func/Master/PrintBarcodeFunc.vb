Imports Para.TABLE
Imports Linq.TABLE

Namespace Master
    Public Class PrintBarcodeFunc
        Public Function GetTitleNameList() As DataTable
            Dim sql As String = "select distinct title_name from personal order by title_name"
            Dim lnq As New PersonalLinq
            Return lnq.GetListBySql(sql, Nothing)
        End Function
    End Class
End Namespace
