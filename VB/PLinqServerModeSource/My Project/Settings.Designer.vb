﻿' Developer Express Code Central Example:
' How to implement CRUD operations using XtraGrid and PLinqServerModeSource
' 
' This example demonstrates how to implement the Create, Update and Delete
' operations using PLinqServerModeSource.
' This example works with the standard
' SQL Northwind database.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E4500

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.296
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------


Imports Microsoft.VisualBasic
Imports System
Namespace My


	<Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")> _
	Friend NotInheritable Partial Class Settings
		Inherits System.Configuration.ApplicationSettingsBase

		Private Shared defaultInstance As Settings = (CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New Settings()), Settings))

		Public Shared ReadOnly Property [Default]() As Settings
			Get
				Return defaultInstance
			End Get
		End Property

		<Global.System.Configuration.ApplicationScopedSettingAttribute(), Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString), Global.System.Configuration.DefaultSettingValueAttribute("Data Source=KURCHENKO-SV;Initial Catalog=Northwind;Integrated Security=True")> _
		Public ReadOnly Property NorthwindConnectionString() As String
			Get
				Return (CStr(Me("NorthwindConnectionString")))
			End Get
		End Property
	End Class
End Namespace
