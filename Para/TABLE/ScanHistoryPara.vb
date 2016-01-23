Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions

Namespace TABLE
    'Represents a transaction for scan_history table Parameter.
    '[Create by  on June, 22 2011]

    <Table(Name:="scan_history")> _
    Public Class ScanHistoryPara

        'Generate Field List
        Dim _ID As Long = 0
        Dim _CREATE_BY As String = ""
        Dim _CREATE_ON As DateTime = New DateTime(1, 1, 1)
        Dim _UPDATE_BY As String = ""
        Dim _UPDATE_ON As System.Nullable(Of DateTime) = New DateTime(1, 1, 1)
        Dim _PERSONAL_ID As Long = 0
        Dim _STAFF_CODE As String = ""
        Dim _DOC_TYPE_ID As Long = 0
        Dim _DOCTYPE_CODE As String = ""
        Dim _CLIENT_SCAN As String = ""
        Dim _CLIENT_IP As String = ""
        Dim _OUTPUT_FOLDER As String = ""
        Dim _PDF_FILENAME As String = ""
        Dim _PDF_PAGE As Long = 0

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
        <Column(Storage:="_CREATE_ON", DbType:="DateTime2 NOT NULL ", CanBeNull:=False)> _
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
        <Column(Storage:="_UPDATE_ON", DbType:="DateTime2")> _
        Public Property UPDATE_ON() As System.Nullable(Of DateTime)
            Get
                Return _UPDATE_ON
            End Get
            Set(ByVal value As System.Nullable(Of DateTime))
                _UPDATE_ON = value
            End Set
        End Property
        <Column(Storage:="_PERSONAL_ID", DbType:="BigInt NOT NULL ", CanBeNull:=False)> _
        Public Property PERSONAL_ID() As Long
            Get
                Return _PERSONAL_ID
            End Get
            Set(ByVal value As Long)
                _PERSONAL_ID = value
            End Set
        End Property
        <Column(Storage:="_STAFF_CODE", DbType:="VarChar(50) NOT NULL ", CanBeNull:=False)> _
        Public Property STAFF_CODE() As String
            Get
                Return _STAFF_CODE
            End Get
            Set(ByVal value As String)
                _STAFF_CODE = value
            End Set
        End Property
        <Column(Storage:="_DOC_TYPE_ID", DbType:="BigInt NOT NULL ", CanBeNull:=False)> _
        Public Property DOC_TYPE_ID() As Long
            Get
                Return _DOC_TYPE_ID
            End Get
            Set(ByVal value As Long)
                _DOC_TYPE_ID = value
            End Set
        End Property
        <Column(Storage:="_DOCTYPE_CODE", DbType:="VarChar(50) NOT NULL ", CanBeNull:=False)> _
        Public Property DOCTYPE_CODE() As String
            Get
                Return _DOCTYPE_CODE
            End Get
            Set(ByVal value As String)
                _DOCTYPE_CODE = value
            End Set
        End Property
        <Column(Storage:="_CLIENT_SCAN", DbType:="VarChar(100) NOT NULL ", CanBeNull:=False)> _
        Public Property CLIENT_SCAN() As String
            Get
                Return _CLIENT_SCAN
            End Get
            Set(ByVal value As String)
                _CLIENT_SCAN = value
            End Set
        End Property
        <Column(Storage:="_CLIENT_IP", DbType:="VarChar(20) NOT NULL ", CanBeNull:=False)> _
        Public Property CLIENT_IP() As String
            Get
                Return _CLIENT_IP
            End Get
            Set(ByVal value As String)
                _CLIENT_IP = value
            End Set
        End Property
        <Column(Storage:="_OUTPUT_FOLDER", DbType:="VarChar(500) NOT NULL ", CanBeNull:=False)> _
        Public Property OUTPUT_FOLDER() As String
            Get
                Return _OUTPUT_FOLDER
            End Get
            Set(ByVal value As String)
                _OUTPUT_FOLDER = value
            End Set
        End Property
        <Column(Storage:="_PDF_FILENAME", DbType:="VarChar(200) NOT NULL ", CanBeNull:=False)> _
        Public Property PDF_FILENAME() As String
            Get
                Return _PDF_FILENAME
            End Get
            Set(ByVal value As String)
                _PDF_FILENAME = value
            End Set
        End Property
        <Column(Storage:="_PDF_PAGE", DbType:="BigInt NOT NULL ", CanBeNull:=False)> _
        Public Property PDF_PAGE() As Long
            Get
                Return _PDF_PAGE
            End Get
            Set(ByVal value As Long)
                _PDF_PAGE = value
            End Set
        End Property


    End Class
End Namespace