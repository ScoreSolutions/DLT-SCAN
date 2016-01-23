
Imports System.Data.Linq 
Imports System.Data.Linq.Mapping 
Imports System.Linq 
Imports System.Linq.Expressions 

Namespace TABLE
    'Represents a transaction for personal table Parameter.
    '[Create by  on June, 20 2011]

    <Table(Name:="personal")>  _
    Public Class PersonalPara

        'Generate Field List
        Dim _ID As Long = 0
        Dim _CREATE_BY As String = ""
        Dim _CREATE_ON As DateTime = New DateTime(1,1,1)
        Dim _UPDATE_BY As  String  = ""
        Dim _UPDATE_ON As  System.Nullable(Of DateTime)  = New DateTime(1,1,1)
        Dim _STAFF_CODE As String = ""
        Dim _TITLE_NAME As  String  = ""
        Dim _FIRST_NAME As String = ""
        Dim _LAST_NAME As  String  = ""

        'Generate Field Property 
        <Column(Storage:="_ID", DbType:="BigInt NOT NULL ",CanBeNull:=false)>  _
        Public Property ID() As Long
            Get
                Return _ID
            End Get
            Set(ByVal value As Long)
               _ID = value
            End Set
        End Property 
        <Column(Storage:="_CREATE_BY", DbType:="VarChar(50) NOT NULL ",CanBeNull:=false)>  _
        Public Property CREATE_BY() As String
            Get
                Return _CREATE_BY
            End Get
            Set(ByVal value As String)
               _CREATE_BY = value
            End Set
        End Property 
        <Column(Storage:="_CREATE_ON", DbType:="DateTime2 NOT NULL ",CanBeNull:=false)>  _
        Public Property CREATE_ON() As DateTime
            Get
                Return _CREATE_ON
            End Get
            Set(ByVal value As DateTime)
               _CREATE_ON = value
            End Set
        End Property 
        <Column(Storage:="_UPDATE_BY", DbType:="VarChar(50)")>  _
        Public Property UPDATE_BY() As  String 
            Get
                Return _UPDATE_BY
            End Get
            Set(ByVal value As  String )
               _UPDATE_BY = value
            End Set
        End Property 
        <Column(Storage:="_UPDATE_ON", DbType:="DateTime2")>  _
        Public Property UPDATE_ON() As  System.Nullable(Of DateTime) 
            Get
                Return _UPDATE_ON
            End Get
            Set(ByVal value As  System.Nullable(Of DateTime) )
               _UPDATE_ON = value
            End Set
        End Property 
        <Column(Storage:="_STAFF_CODE", DbType:="VarChar(50) NOT NULL ",CanBeNull:=false)>  _
        Public Property STAFF_CODE() As String
            Get
                Return _STAFF_CODE
            End Get
            Set(ByVal value As String)
               _STAFF_CODE = value
            End Set
        End Property 
        <Column(Storage:="_TITLE_NAME", DbType:="VarChar(50)")>  _
        Public Property TITLE_NAME() As  String 
            Get
                Return _TITLE_NAME
            End Get
            Set(ByVal value As  String )
               _TITLE_NAME = value
            End Set
        End Property 
        <Column(Storage:="_FIRST_NAME", DbType:="VarChar(100) NOT NULL ",CanBeNull:=false)>  _
        Public Property FIRST_NAME() As String
            Get
                Return _FIRST_NAME
            End Get
            Set(ByVal value As String)
               _FIRST_NAME = value
            End Set
        End Property 
        <Column(Storage:="_LAST_NAME", DbType:="VarChar(100)")>  _
        Public Property LAST_NAME() As  String 
            Get
                Return _LAST_NAME
            End Get
            Set(ByVal value As  String )
               _LAST_NAME = value
            End Set
        End Property 


            'Define Child Table 

       Dim _SCAN_HISTORY As DataTable

       Public Property SCAN_HISTORY() As DataTable
           Get
               Return _SCAN_HISTORY
           End Get
           Set(ByVal value As DataTable)
               _SCAN_HISTORY = value
           End Set
       End Property
    End Class
End Namespace
