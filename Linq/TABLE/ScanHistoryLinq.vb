Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports DB = Linq.Common.Utilities.SqlDB
Imports Para.TABLE
Imports Para.Common.Utilities

Namespace TABLE
    'Represents a transaction for scan_history table Linq.
    '[Create by  on June, 22 2011]
    Public Class ScanHistoryLinq
        Public Sub ScanHistoryLinq()

        End Sub
        ' scan_history
        Const _tableName As String = "scan_history"
        Dim _deletedRow As Int16 = 0

        'Set Common Property
        Dim _error As String = ""
        Dim _information As String = ""
        Dim _haveData As Boolean = False

        Public ReadOnly Property TableName() As String
            Get
                Return _tableName
            End Get
        End Property
        Public ReadOnly Property ErrorMessage() As String
            Get
                Return _error
            End Get
        End Property
        Public ReadOnly Property InfoMessage() As String
            Get
                Return _information
            End Get
        End Property
        Public ReadOnly Property HaveData() As Boolean
            Get
                Return _haveData
            End Get
        End Property


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


        'Clear All Data
        Private Sub ClearData()
            _ID = 0
            _CREATE_BY = ""
            _CREATE_ON = New DateTime(1, 1, 1)
            _UPDATE_BY = ""
            _UPDATE_ON = New DateTime(1, 1, 1)
            _PERSONAL_ID = 0
            _STAFF_CODE = ""
            _DOC_TYPE_ID = 0
            _DOCTYPE_CODE = ""
            _CLIENT_SCAN = ""
            _CLIENT_IP = ""
            _OUTPUT_FOLDER = ""
            _PDF_FILENAME = ""
            _PDF_PAGE = 0
        End Sub

        'Define Public Method 
        'Execute the select statement with the specified condition and return a System.Data.DataTable.
        '/// <param name=whereClause>The condition for execute select statement.</param>
        '/// <param name=orderBy>The fields for sort data.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>The System.Data.DataTable object for specified condition.</returns>
        Public Function GetDataList(ByVal whClause As String, ByVal orderBy As String, ByVal trans As SQLTransaction) As DataTable
            Return DB.ExecuteTable(SqlSelect & IIf(whClause = "", "", " WHERE " & whClause) & IIF(orderBy = "", "", " ORDER BY  " & orderBy), trans)
        End Function


        'Execute the select statement with the specified condition and return a System.Data.DataTable.
        '/// <param name=whereClause>The condition for execute select statement.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>The System.Data.DataTable object for specified condition.</returns>
        Public Function GetListBySql(ByVal Sql As String, ByVal trans As SQLTransaction) As DataTable
            Return DB.ExecuteTable(Sql, trans)
        End Function


        '/// Returns an indication whether the current data is inserted into scan_history table successfully.
        '/// <param name=userID>The current user.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if insert data successfully; otherwise, false.</returns>
        Public Function InsertData(ByVal UserID As String, ByVal trans As SQLTransaction) As Boolean
            If trans IsNot Nothing Then
                _id = DB.GetNextID("id", tableName, trans)
                _CREATE_BY = UserID
                _CREATE_ON = DateTime.Now
                Return doInsert(trans)
            Else
                _error = "Transaction Is not null"
                Return False
            End If
        End Function


        '/// Returns an indication whether the current data is updated to scan_history table successfully.
        '/// <param name=userID>The current user.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if update data successfully; otherwise, false.</returns>
        Public Function UpdateByPK(ByVal UserID As String, ByVal trans As SQLTransaction) As Boolean
            If trans IsNot Nothing Then
                _UPDATE_BY = UserID
                _UPDATE_ON = DateTime.Now
                Return doUpdate("id = " & DB.SetDouble(_id) & " ", trans)
            Else
                _error = "Transaction Is not null"
                Return False
            End If
        End Function


        '/// Returns an indication whether the current data is deleted from scan_history table successfully.
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if delete data successfully; otherwise, false.</returns>
        Public Function DeleteByPK(ByVal cPK As Long, ByVal trans As SQLTransaction) As Boolean
            If trans IsNot Nothing Then
                Return doDelete("id = " & cPK, trans)
            Else
                _error = "Transaction Is not null"
                Return False
            End If
        End Function


        '/// Returns an indication whether the record of scan_history by specified id key is retrieved successfully.
        '/// <param name=cid>The id key.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Public Function ChkDataByPK(ByVal cid As Long, ByVal trans As SQLTransaction) As Boolean
            Return doChkData("id = " & DB.SetDouble(cid) & " ", trans)
        End Function


        '/// Returns an indication whether the record and Mapping field to Data Class of scan_history by specified id key is retrieved successfully.
        '/// <param name=cid>The id key.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Public Function GetDataByPK(ByVal cid As Long, ByVal trans As SQLTransaction) As ScanHistoryLinq
            Return doGetData("id = " & DB.SetDouble(cid) & " ", trans)
        End Function


        '/// Returns an indication whether the record and Mapping field to Para Class of scan_history by specified id key is retrieved successfully.
        '/// <param name=cid>The id key.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Public Function GetParameter(ByVal cid As Long, ByVal trans As SQLTransaction) As ScanHistoryPara
            Return doMappingParameter("id = " & DB.SetDouble(cid) & " ", trans)
        End Function


        '/// Returns an indication whether the record of scan_history by specified DOCTYPE_CODE_STAFF_CODE key is retrieved successfully.
        '/// <param name=cDOCTYPE_CODE_STAFF_CODE>The DOCTYPE_CODE_STAFF_CODE key.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Public Function ChkDataByDOCTYPE_CODE_STAFF_CODE(ByVal cDOCTYPE_CODE As String, ByVal cSTAFF_CODE As String, ByVal trans As SQLTransaction) As Boolean
            Return doChkData("DOCTYPE_CODE = " & DB.SetString(cDOCTYPE_CODE) & " AND STAFF_CODE = " & DB.SetString(cSTAFF_CODE), trans)
        End Function

        '/// Returns an duplicate data record of scan_history by specified DOCTYPE_CODE_STAFF_CODE key is retrieved successfully.
        '/// <param name=cDOCTYPE_CODE_STAFF_CODE>The DOCTYPE_CODE_STAFF_CODE key.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Public Function ChkDuplicateByDOCTYPE_CODE_STAFF_CODE(ByVal cDOCTYPE_CODE As String, ByVal cSTAFF_CODE As String, ByVal cid As Long, ByVal trans As SQLTransaction) As Boolean
            Return doChkData("DOCTYPE_CODE = " & DB.SetString(cDOCTYPE_CODE) & " AND STAFF_CODE = " & DB.SetString(cSTAFF_CODE) & " And id <> " & DB.SetDouble(cid) & " ", trans)
        End Function


        '/// Returns an indication whether the record of scan_history by specified condition is retrieved successfully.
        '/// <param name=whText>The condition specify the deleting record(s).</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Public Function ChkDataByWhere(ByVal whText As String, ByVal trans As SQLTransaction) As Boolean
            Return doChkData(whText, trans)
        End Function



        '/// Returns an indication whether the current data is inserted into scan_history table successfully.
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if insert data successfully; otherwise, false.</returns>
        Private Function doInsert(ByVal trans As SQLTransaction) As Boolean
            Dim ret As Boolean = True
            If _haveData = False Then
                Try
                    ret = (DB.ExecuteNonQuery(SqlInsert, trans) > 0)
                    If ret = False Then
                        _error = MessageResources.MSGEN001
                    Else
                        _haveData = True
                    End If
                    _information = MessageResources.MSGIN001
                Catch ex As ApplicationException
                    ret = False
                    _error = ex.Message
                Catch ex As Exception
                    ex.ToString()
                    ret = False
                    _error = MessageResources.MSGEC101
                End Try
            Else
                ret = False
                _error = MessageResources.MSGEN002
            End If

            Return ret
        End Function


        '/// Returns an indication whether the current data is updated to scan_history table successfully.
        '/// <param name=whText>The condition specify the updating record(s).</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if update data successfully; otherwise, false.</returns>
        Private Function doUpdate(ByVal whText As String, ByVal trans As SQLTransaction) As Boolean
            Dim ret As Boolean = True
            If _haveData = True Then
                If whText.Trim() <> "" Then
                    Dim tmpWhere As String = " Where " & whText
                    Try
                        ret = (DB.ExecuteNonQuery(SqlUpdate & tmpWhere, trans) > 0)
                        If ret = False Then
                            _error = MessageResources.MSGEU001
                        End If
                        _information = MessageResources.MSGIU001
                    Catch ex As ApplicationException
                        ret = False
                        _error = ex.Message
                    Catch ex As Exception
                        ex.ToString()
                        ret = False
                        _error = MessageResources.MSGEC102
                    End Try
                Else
                    ret = False
                    _error = MessageResources.MSGEU003
                End If
            Else
                ret = False
                _error = MessageResources.MSGEU002
            End If

            Return ret
        End Function


        '/// Returns an indication whether the current data is deleted from scan_history table successfully.
        '/// <param name=whText>The condition specify the deleting record(s).</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if delete data successfully; otherwise, false.</returns>
        Private Function doDelete(ByVal whText As String, ByVal trans As SQLTransaction) As Boolean
            Dim ret As Boolean = True
            If doChkData(whText, trans) = True Then
                If whText.Trim() <> "" Then
                    Dim tmpWhere As String = " Where " & whText
                    Try
                        ret = (DB.ExecuteNonQuery(SqlDelete & tmpWhere, trans) > 0)
                        If ret = False Then
                            _error = MessageResources.MSGED001
                        End If
                        _information = MessageResources.MSGID001
                    Catch ex As ApplicationException
                        ret = False
                        _error = ex.Message
                    Catch ex As Exception
                        ex.ToString()
                        ret = False
                        _error = MessageResources.MSGEC103
                    End Try
                Else
                    ret = False
                    _error = MessageResources.MSGED003
                End If
            Else
                ret = False
                _error = MessageResources.MSGEU002
            End If

            Return ret
        End Function


        '/// Returns an indication whether the record of scan_history by specified condition is retrieved successfully.
        '/// <param name=whText>The condition specify the deleting record(s).</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Private Function doChkData(ByVal whText As String, ByVal trans As SQLTransaction) As Boolean
            Dim ret As Boolean = True
            ClearData()
            _haveData = False
            If whText.Trim() <> "" Then
                Dim tmpWhere As String = " WHERE " & whText
                Dim Rdr As SQLDataReader
                Try
                    Rdr = DB.ExecuteReader(SqlSelect() & tmpWhere, trans)
                    If Rdr.Read() Then
                        _haveData = True
                        If Convert.IsDBNull(Rdr("id")) = False Then _id = Convert.ToInt64(Rdr("id"))
                        If Convert.IsDBNull(Rdr("create_by")) = False Then _create_by = Rdr("create_by").ToString()
                        If Convert.IsDBNull(Rdr("create_on")) = False Then _create_on = Convert.ToDateTime(Rdr("create_on"))
                        If Convert.IsDBNull(Rdr("update_by")) = False Then _update_by = Rdr("update_by").ToString()
                        If Convert.IsDBNull(Rdr("update_on")) = False Then _update_on = Convert.ToDateTime(Rdr("update_on"))
                        If Convert.IsDBNull(Rdr("personal_id")) = False Then _personal_id = Convert.ToInt64(Rdr("personal_id"))
                        If Convert.IsDBNull(Rdr("staff_code")) = False Then _staff_code = Rdr("staff_code").ToString()
                        If Convert.IsDBNull(Rdr("doc_type_id")) = False Then _doc_type_id = Convert.ToInt64(Rdr("doc_type_id"))
                        If Convert.IsDBNull(Rdr("doctype_code")) = False Then _doctype_code = Rdr("doctype_code").ToString()
                        If Convert.IsDBNull(Rdr("client_scan")) = False Then _client_scan = Rdr("client_scan").ToString()
                        If Convert.IsDBNull(Rdr("client_ip")) = False Then _client_ip = Rdr("client_ip").ToString()
                        If Convert.IsDBNull(Rdr("output_folder")) = False Then _output_folder = Rdr("output_folder").ToString()
                        If Convert.IsDBNull(Rdr("pdf_filename")) = False Then _pdf_filename = Rdr("pdf_filename").ToString()
                        If Convert.IsDBNull(Rdr("pdf_page")) = False Then _pdf_page = Convert.ToInt64(Rdr("pdf_page"))
                    Else
                        ret = False
                        _error = MessageResources.MSGEV002
                    End If

                    Rdr.Close()
                Catch ex As Exception
                    ex.ToString()
                    ret = False
                    _error = MessageResources.MSGEC104
                    If Rdr IsNot Nothing And Rdr.IsClosed = False Then
                        Rdr.Close()
                    End If
                End Try
            Else
                ret = False
                _error = MessageResources.MSGEV001
            End If

            Return ret
        End Function


        '/// Returns an indication whether the record of scan_history by specified condition is retrieved successfully.
        '/// <param name=whText>The condition specify the deleting record(s).</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Private Function doGetData(ByVal whText As String, ByVal trans As SQLTransaction) As ScanHistoryLinq
            ClearData()
            _haveData = False
            If whText.Trim() <> "" Then
                Dim tmpWhere As String = " WHERE " & whText
                Dim Rdr As SQLDataReader
                Try
                    Rdr = DB.ExecuteReader(SqlSelect() & tmpWhere, trans)
                    If Rdr.Read() Then
                        _haveData = True
                        If Convert.IsDBNull(Rdr("id")) = False Then _id = Convert.ToInt64(Rdr("id"))
                        If Convert.IsDBNull(Rdr("create_by")) = False Then _create_by = Rdr("create_by").ToString()
                        If Convert.IsDBNull(Rdr("create_on")) = False Then _create_on = Convert.ToDateTime(Rdr("create_on"))
                        If Convert.IsDBNull(Rdr("update_by")) = False Then _update_by = Rdr("update_by").ToString()
                        If Convert.IsDBNull(Rdr("update_on")) = False Then _update_on = Convert.ToDateTime(Rdr("update_on"))
                        If Convert.IsDBNull(Rdr("personal_id")) = False Then _personal_id = Convert.ToInt64(Rdr("personal_id"))
                        If Convert.IsDBNull(Rdr("staff_code")) = False Then _staff_code = Rdr("staff_code").ToString()
                        If Convert.IsDBNull(Rdr("doc_type_id")) = False Then _doc_type_id = Convert.ToInt64(Rdr("doc_type_id"))
                        If Convert.IsDBNull(Rdr("doctype_code")) = False Then _doctype_code = Rdr("doctype_code").ToString()
                        If Convert.IsDBNull(Rdr("client_scan")) = False Then _client_scan = Rdr("client_scan").ToString()
                        If Convert.IsDBNull(Rdr("client_ip")) = False Then _client_ip = Rdr("client_ip").ToString()
                        If Convert.IsDBNull(Rdr("output_folder")) = False Then _output_folder = Rdr("output_folder").ToString()
                        If Convert.IsDBNull(Rdr("pdf_filename")) = False Then _pdf_filename = Rdr("pdf_filename").ToString()
                        If Convert.IsDBNull(Rdr("pdf_page")) = False Then _pdf_page = Convert.ToInt64(Rdr("pdf_page"))

                        'Generate Item For Child Table
                    Else
                        _error = MessageResources.MSGEV002
                    End If

                    Rdr.Close()
                Catch ex As Exception
                    ex.ToString()
                    _error = MessageResources.MSGEC104
                    If Rdr IsNot Nothing And Rdr.IsClosed = False Then
                        Rdr.Close()
                    End If
                End Try
            Else
                _error = MessageResources.MSGEV001
            End If
            Return Me
        End Function


        '/// Returns an indication whether the Class Data of scan_history by specified condition is retrieved successfully.
        '/// <param name=whText>The condition specify the deleting record(s).</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Private Function doMappingParameter(ByVal whText As String, ByVal trans As SQLTransaction) As ScanHistoryPara
            ClearData()
            _haveData = False
            Dim ret As New ScanHistoryPara
            If whText.Trim() <> "" Then
                Dim tmpWhere As String = " WHERE " & whText
                Dim Rdr As SQLDataReader
                Try
                    Rdr = DB.ExecuteReader(SqlSelect() & tmpWhere, trans)
                    If Rdr.Read() Then
                        _haveData = True
                        If Convert.IsDBNull(Rdr("id")) = False Then ret.id = Convert.ToInt64(Rdr("id"))
                        If Convert.IsDBNull(Rdr("create_by")) = False Then ret.create_by = Rdr("create_by").ToString()
                        If Convert.IsDBNull(Rdr("create_on")) = False Then ret.create_on = Convert.ToDateTime(Rdr("create_on"))
                        If Convert.IsDBNull(Rdr("update_by")) = False Then ret.update_by = Rdr("update_by").ToString()
                        If Convert.IsDBNull(Rdr("update_on")) = False Then ret.update_on = Convert.ToDateTime(Rdr("update_on"))
                        If Convert.IsDBNull(Rdr("personal_id")) = False Then ret.personal_id = Convert.ToInt64(Rdr("personal_id"))
                        If Convert.IsDBNull(Rdr("staff_code")) = False Then ret.staff_code = Rdr("staff_code").ToString()
                        If Convert.IsDBNull(Rdr("doc_type_id")) = False Then ret.doc_type_id = Convert.ToInt64(Rdr("doc_type_id"))
                        If Convert.IsDBNull(Rdr("doctype_code")) = False Then ret.doctype_code = Rdr("doctype_code").ToString()
                        If Convert.IsDBNull(Rdr("client_scan")) = False Then ret.client_scan = Rdr("client_scan").ToString()
                        If Convert.IsDBNull(Rdr("client_ip")) = False Then ret.client_ip = Rdr("client_ip").ToString()
                        If Convert.IsDBNull(Rdr("output_folder")) = False Then ret.output_folder = Rdr("output_folder").ToString()
                        If Convert.IsDBNull(Rdr("pdf_filename")) = False Then ret.pdf_filename = Rdr("pdf_filename").ToString()
                        If Convert.IsDBNull(Rdr("pdf_page")) = False Then ret.pdf_page = Convert.ToInt64(Rdr("pdf_page"))

                    Else
                        _error = MessageResources.MSGEV002
                    End If

                    Rdr.Close()
                Catch ex As Exception
                    ex.ToString()
                    _error = MessageResources.MSGEC104
                    If Rdr IsNot Nothing And Rdr.IsClosed = False Then
                        Rdr.Close()
                    End If
                End Try
            Else
                _error = MessageResources.MSGEV001
            End If
            Return ret
        End Function

        ' SQL Statements


        'Get Insert Statement for table scan_history
        Private ReadOnly Property SqlInsert() As String
            Get
                Dim Sql As String = ""
                Sql += "INSERT INTO " & tableName & " (ID, CREATE_BY, CREATE_ON, UPDATE_BY, UPDATE_ON, PERSONAL_ID, STAFF_CODE, DOC_TYPE_ID, DOCTYPE_CODE, CLIENT_SCAN, CLIENT_IP, OUTPUT_FOLDER, PDF_FILENAME, PDF_PAGE)"
                Sql += " VALUES("
                sql += DB.SetDouble(_ID) & ", "
                sql += DB.SetString(_CREATE_BY) & ", "
                sql += DB.SetDateTime(_CREATE_ON) & ", "
                sql += DB.SetString(_UPDATE_BY) & ", "
                sql += DB.SetDateTime(_UPDATE_ON) & ", "
                sql += DB.SetDouble(_PERSONAL_ID) & ", "
                sql += DB.SetString(_STAFF_CODE) & ", "
                sql += DB.SetDouble(_DOC_TYPE_ID) & ", "
                sql += DB.SetString(_DOCTYPE_CODE) & ", "
                sql += DB.SetString(_CLIENT_SCAN) & ", "
                sql += DB.SetString(_CLIENT_IP) & ", "
                sql += DB.SetString(_OUTPUT_FOLDER) & ", "
                sql += DB.SetString(_PDF_FILENAME) & ", "
                sql += DB.SetDouble(_PDF_PAGE)
                sql += ")"
                Return sql
            End Get
        End Property


        'Get update statement form table scan_history
        Private ReadOnly Property SqlUpdate() As String
            Get
                Dim Sql As String = ""
                Sql += "UPDATE " & tableName & " SET "
                Sql += "ID = " & DB.SetDouble(_ID) & ", "
                Sql += "CREATE_BY = " & DB.SetString(_CREATE_BY) & ", "
                Sql += "CREATE_ON = " & DB.SetDateTime(_CREATE_ON) & ", "
                Sql += "UPDATE_BY = " & DB.SetString(_UPDATE_BY) & ", "
                Sql += "UPDATE_ON = " & DB.SetDateTime(_UPDATE_ON) & ", "
                Sql += "PERSONAL_ID = " & DB.SetDouble(_PERSONAL_ID) & ", "
                Sql += "STAFF_CODE = " & DB.SetString(_STAFF_CODE) & ", "
                Sql += "DOC_TYPE_ID = " & DB.SetDouble(_DOC_TYPE_ID) & ", "
                Sql += "DOCTYPE_CODE = " & DB.SetString(_DOCTYPE_CODE) & ", "
                Sql += "CLIENT_SCAN = " & DB.SetString(_CLIENT_SCAN) & ", "
                Sql += "CLIENT_IP = " & DB.SetString(_CLIENT_IP) & ", "
                Sql += "OUTPUT_FOLDER = " & DB.SetString(_OUTPUT_FOLDER) & ", "
                Sql += "PDF_FILENAME = " & DB.SetString(_PDF_FILENAME) & ", "
                Sql += "PDF_PAGE = " & DB.SetDouble(_PDF_PAGE) + ""
                Return Sql
            End Get
        End Property


        'Get Delete Record in table scan_history
        Private ReadOnly Property SqlDelete() As String
            Get
                Dim Sql As String = "DELETE FROM " & tableName
                Return Sql
            End Get
        End Property


        'Get Select Statement for table scan_history
        Private ReadOnly Property SqlSelect() As String
            Get
                Dim Sql As String = "SELECT * FROM " & tableName
                Return Sql
            End Get
        End Property


    End Class
End Namespace