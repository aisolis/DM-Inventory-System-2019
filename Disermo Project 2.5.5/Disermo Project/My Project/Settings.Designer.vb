'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "Funcionalidad para autoguardar de My.Settings"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(ByVal sender As Global.System.Object, ByVal e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Data Source=LAPTOP-12N297OH\SQLEXPRESS;Initial Catalog=Disermo;Integrated Securit"& _ 
            "y=True")>  _
        Public ReadOnly Property DisermoConnectionString() As String
            Get
                Return CType(Me("DisermoConnectionString"),String)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property ConfigPosicionamiento() As Boolean
            Get
                Return CType(Me("ConfigPosicionamiento"),Boolean)
            End Get
            Set
                Me("ConfigPosicionamiento") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Disermo Proyect")>  _
        Public Property ConfigNombrePrograma() As String
            Get
                Return CType(Me("ConfigNombrePrograma"),String)
            End Get
            Set
                Me("ConfigNombrePrograma") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("USUARIO")>  _
        Public Property NombreUsuario() As String
            Get
                Return CType(Me("NombreUsuario"),String)
            End Get
            Set
                Me("NombreUsuario") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0.12")>  _
        Public Property ConfigIVA() As Double
            Get
                Return CType(Me("ConfigIVA"),Double)
            End Get
            Set
                Me("ConfigIVA") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property ConfigTema() As Boolean
            Get
                Return CType(Me("ConfigTema"),Boolean)
            End Get
            Set
                Me("ConfigTema") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("7.5")>  _
        Public Property ConfigValorQuetzal() As String
            Get
                Return CType(Me("ConfigValorQuetzal"),String)
            End Get
            Set
                Me("ConfigValorQuetzal") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Ingresa nota")>  _
        Public Property NotasInicio() As String
            Get
                Return CType(Me("NotasInicio"),String)
            End Get
            Set
                Me("NotasInicio") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property code() As String
            Get
                Return CType(Me("code"),String)
            End Get
            Set
                Me("code") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-6JQE72N\SWORDS;Initial Catalog=Disermo2;Persist Security Info"& _ 
            "=True;User ID=DisermoUwU;Password=DisermoLogin")>  _
        Public ReadOnly Property Disermo2ConnectionString() As String
            Get
                Return CType(Me("Disermo2ConnectionString"),String)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property Valor() As String
            Get
                Return CType(Me("Valor"),String)
            End Get
            Set
                Me("Valor") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-6JQE72N\SWORDS;Initial Catalog=Disermo;Persist Security Info="& _ 
            "True;User ID=DisermoUwU;Password=DisermoLogin")>  _
        Public ReadOnly Property DisermoConnectionString1() As String
            Get
                Return CType(Me("DisermoConnectionString1"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-9R7M7SC\SWORDS;Initial Catalog=Disermo;Persist Security Info="& _ 
            "True;User ID=DisermoLogin;Password=12345")>  _
        Public ReadOnly Property DisermoConnectionString2() As String
            Get
                Return CType(Me("DisermoConnectionString2"),String)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-21LHCT1;Initial Catalog=Disermo;Integrated Security=True")>  _
        Public Property conexionglobal() As String
            Get
                Return CType(Me("conexionglobal"),String)
            End Get
            Set
                Me("conexionglobal") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property errordb() As String
            Get
                Return CType(Me("errordb"),String)
            End Get
            Set
                Me("errordb") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Data Source=LAPTOP-BIAFSCF5;Initial Catalog=Disermo;Persist Security Info=True;Us"& _ 
            "er ID=dmm;Password=12345")>  _
        Public ReadOnly Property DisermoConnectionString3() As String
            Get
                Return CType(Me("DisermoConnectionString3"),String)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property CargaConexDB() As Boolean
            Get
                Return CType(Me("CargaConexDB"),Boolean)
            End Get
            Set
                Me("CargaConexDB") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property CargaInternet() As Boolean
            Get
                Return CType(Me("CargaInternet"),Boolean)
            End Get
            Set
                Me("CargaInternet") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property CargaArchivos() As Boolean
            Get
                Return CType(Me("CargaArchivos"),Boolean)
            End Get
            Set
                Me("CargaArchivos") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property CargaRed() As Boolean
            Get
                Return CType(Me("CargaRed"),Boolean)
            End Get
            Set
                Me("CargaRed") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("v2.5.4")>  _
        Public Property ProgramVersion() As String
            Get
                Return CType(Me("ProgramVersion"),String)
            End Get
            Set
                Me("ProgramVersion") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Data Source=TOCAY;Initial Catalog=Disermo;Integrated Security=True")>  _
        Public ReadOnly Property DisermoConnectionString4() As String
            Get
                Return CType(Me("DisermoConnectionString4"),String)
            End Get
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.Disermo_Project.My.MySettings
            Get
                Return Global.Disermo_Project.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
