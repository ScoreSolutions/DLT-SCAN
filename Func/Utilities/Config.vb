
Imports Linq.Common.Utilities

Namespace Utilities

    Partial Public Class Config

        Public Shared ConfigFlieName As String = Linq.Common.Utilities.SqlDB.ConfigFlieName
        Public Const ConfigSecsion As String = "Config"
        Public Const ConfigReportFolder As String = "ReportFolder"

        Public Shared Sub CreateNewConfig()
            Dim ini = New Linq.Utilities.IniReader(Config.ConfigFlieName)
            ini.Section = Config.ConfigSecsion
            ini.Write("StaffCodeLength", 4)
            ini.Write("BarcodeStartDigit", "12")
            ini.Write("FileRunningLength", 3)
            ini.Write("DocTypeCodeLength", 5)
            ini.Write("ShowScanUI", 1)
            ini.Write("SelectScanDriver", 1)
            ini.Write("DefaultOutput", "")
        End Sub

        Public Shared Sub CreateReportFolder(ByVal txtFolder As String)
            Dim ini = New Linq.Utilities.IniReader(ConfigFlieName)
            ini.Section = ConfigReportFolder
            ini.Write("ReportFolder", txtFolder)
        End Sub

        Public Shared Sub CreateDefaultOutput(ByVal txtFolder As String)
            Dim ini = New Linq.Utilities.IniReader(ConfigFlieName)
            ini.Section = ConfigSecsion
            ini.Write("DefaultOutput", txtFolder.Trim())
        End Sub

        Public Shared ReadOnly Property StaffCodeLength() As Integer
            Get
                Return GetConfigValue(ConfigSecsion, "StaffCodeLength")
            End Get
        End Property
        Public Shared ReadOnly Property BarcodeLength() As Integer
            Get
                'Return StaffCodeLength + BarcodeStartDigit.Length + DocTypeCodeLength
                Return BarcodeStartDigit.Length + DocTypeCodeLength
            End Get
        End Property
        Public Shared ReadOnly Property BarcodeStartDigit() As String
            Get
                Return GetConfigValue(ConfigSecsion, "BarcodeStartDigit")
            End Get
        End Property
        Public Shared ReadOnly Property FileRunningLength() As Integer
            Get
                Return GetConfigValue(ConfigSecsion, "FileRunningLength")
            End Get
        End Property
        Public Shared ReadOnly Property DocTypeCodeLength() As Integer
            Get
                Return GetConfigValue(ConfigSecsion, "DocTypeCodeLength")
            End Get
        End Property
        Public Shared ReadOnly Property DefaultOutput() As String
            Get
                Return GetConfigValue(ConfigSecsion, "DefaultOutput")
            End Get
        End Property

        Public Shared Function GetConfigValue(ByVal section As String, ByVal key As String) As String
            Dim ini As New Linq.Utilities.IniReader(ConfigFlieName)
            ini.Section = section

            Return ini.ReadString(key)

        End Function

        Public Shared ReadOnly Property DbGetDataSource() As String
            Get
                Return SqlDB.DataSource
            End Get
        End Property
        Public Shared ReadOnly Property DbGetDbName() As String
            Get
                Return SqlDB.DbName
            End Get
        End Property
        Public Shared ReadOnly Property DbGetUserID() As String
            Get
                Return SqlDB.DbUserID
            End Get
        End Property
        Public Shared ReadOnly Property DbGetPwd() As String
            Get
                Return SqlDB.DbPwd
            End Get
        End Property
    End Class

End Namespace
