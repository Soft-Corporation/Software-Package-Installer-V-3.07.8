﻿Imports MaterialSkin
Imports System.IO
Public Class Configurazione
    Private Sub Configurazione_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Directory.CreateDirectory(Application.StartupPath & "\Dark")
        Directory.CreateDirectory(Application.StartupPath & "\Blue")
        Directory.CreateDirectory(Application.StartupPath & "\Conf")
        Directory.CreateDirectory(Application.StartupPath & "\Up")
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance



        SkinManager.AddFormToManage(Me)



        SkinManager.Theme = MaterialSkinManager.Themes.DARK

        SkinManager.ColorScheme = New ColorScheme(Primary.Blue900, Primary.Blue900, Primary.Blue900, Accent.LightBlue200, TextShade.WHITE)


        Process.Start(Application.StartupPath & "\Software Package Installer.exe")

        Form1.Close()

    End Sub
End Class