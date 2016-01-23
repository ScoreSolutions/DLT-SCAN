Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions

Namespace TABLE
    'Represents a transaction for scan_error_log table Parameter.
    '[Create by  on August, 30 2011]

    <Table(Name:="scan_error_log")> _
    Public Class ScanErrorLogPara

        'Generate Field List
        Dim _ID As Long = 0
        Dim _CREATE_BY As String = ""
        Dim _CREATE_ON As DateTime = New DateTime(1, 1, 1)
        Dim _UPDATE_BY As String = ""
        Dim _UPDATE_ON As System.Nullable(Of DateTime) = New DateTime(1, 1, 1)
        Dim _ERR_TIME As System.Nullable(Of DateTime) = New DateTime(1, 1, 1)
        Dim _FILE_NAME As String = ""
        Dim _ERR_DESC As String = ""

        'Generate Field Property 
        <Column(Storage:="_ID", DbType:="BigInt NOT NULL ", CanBeNull:=False)> _
        Public Property ID() As Long
            Get
                Return _ID
            End Get
            Set(ByVal value As Long)
                _ID = value
            End Set
        End Property
        <Column(Storage:="_CREATE_BY", DbType:="VarChar(50) NOT NULL ", CanBeNull:=False)> _
        Public Property CREATE_BY() As String
            Get
                Return _CREATE_BY
            End Get
            Set(ByVal value As String)
                _CREATE_BY = value
            End Set
        End Property
        <Column(Storage:="_CREATE_ON", DbType:="DateTime NOT NULL ", CanBeNull:=False)> _
        Public Property CREATE_ON() As DateTime
            Get
                Return _CREATE_ON
            End Get
            Set(ByVal value As DateTime)
                _CREATE_ON = value
            End Set
        End Property
        <Column(Storage:="_UPDATE_BY", DbType:="VarChar(50)")> _
        Public Property UPDATE_BY() As String
            Get
                Return _UPDATE_BY
            End Get
            Set(ByVal value As String)
                _UPDATE_BY = value
            End Set
        End Property
        <Column(Storage:="_UPDATE_ON", DbType:="DateTime")> _
        Public Property UPDATE_ON() As System.Nullable(Of DateTime)
            Get
                Return _UPDATE_ON
            End Get
            Set(ByVal value As System.Nullable(Of DateTime))
                _UPDATE_ON = value
            End Set
        End Property
        <Column(Storage:="_ERR_TIME", DbType:="DateTime")> _
        Public Property ERR_TIME() As System.Nullable(Of DateTime)
            Get
                Return _ERR_TIME
            End Get
            Set(ByVal value As System.Nullable(Of DateTime))
                _ERR_TIME = value
            End Set
        End Property
        <Column(Storage:="_FILE_NAME", DbType:="VarChar(500)")> _
        Public Property FILE_NAME() As String
            Get
                Return _FILE_NAME
            End Get
            Set(ByVal value As String)
                _FILE_NAME = value
            End Set
        End Property
        <Column(Storage:="_ERR_DESC", DbType:="VarChar(500)")> _
        Public Property ERR_DESC() As String
            Get
                Return _ERR_DESC
            End Get
            Set(ByVal value As String)
                _ERR_DESC = value
            End Set
        End Property


    End Class
End Namespace