﻿Imports System
Imports System.ComponentModel

Imports DevExpress.ExpressApp

Namespace WebExample.Module.Web
    <ToolboxItemFilter("Xaf.Platform.Web")> _
    Public NotInheritable Partial Class WebExampleAspNetModule
        Inherits ModuleBase

        Public Sub New()
            ModelDifferenceResourceName = "WebExample.Module.Web.Model.DesignedDiffs"
            InitializeComponent()
        End Sub
    End Class
End Namespace
