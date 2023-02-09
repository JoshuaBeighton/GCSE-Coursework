﻿Imports System.ComponentModel
Imports System.Data.SqlTypes
Imports System.Threading.Tasks.Dataflow

Public Class parts
    Sub setup(type As String)
        ListView1.Columns.Clear()
        ListView1.Columns.Add("ID", 60)
        ListView1.Columns.Add("Name", 150)
        ListView1.Columns.Add("Brand", 150)
        If type <> "Storage" And type <> "RAM" Then
            Me.Text = type + "s"
        Else
            Me.Text = type
        End If
        If type = "CPU" Then
            ListView1.Columns.Add("Socket", 150)
            ListView1.Columns.Add("Cores", 100)
            ListView1.Columns.Add("Base Speed", 175)
            ListView1.Columns.Add("Boost Speed", 175)
            ListView1.Columns.Add("TPD", 100)

        ElseIf type = "GPU" Then
            ListView1.Columns.Add("Series", 100)
            ListView1.Columns.Add("Model", 100)
            ListView1.Columns.Add("Manufacturer", 125)
            ListView1.Columns.Add("Chip Manufacturer", 175)
            ListView1.Columns.Add("Base Clock", 100)
            ListView1.Columns.Add("VRAM", 100)
        ElseIf type = "RAM" Then
            ListView1.Columns.Add("Latency", 150)
            ListView1.Columns.Add("Speed", 150)
            ListView1.Columns.Add("DDR", 75)
            ListView1.Columns.Add("TPD", 100)
            ListView1.Columns.Add("DIMMs", 100)
        ElseIf type = "PSU" Then
            ListView1.Columns.Add("Efficiency", 150)
            ListView1.Columns.Add("Modular", 120)
            ListView1.Columns.Add("Power", 150)
        ElseIf type = "Motherboard" Then
            ListView1.Columns.Add("RAM Slots", 100)
            ListView1.Columns.Add("Socket", 100)
            ListView1.Columns.Add("SATAs", 100)
            ListView1.Columns.Add("M.2s", 100)
            ListView1.Columns.Add("TPD", 100)
        ElseIf type = "Case" Then
            ListView1.Columns.Add("HDDs", 100)
            ListView1.Columns.Add("SSDs", 100)
        ElseIf type = "Storage" Then
            ListView1.Columns.Add("Type", 100)
            ListView1.Columns.Add("Read", 100)
            ListView1.Columns.Add("Write", 100)
            ListView1.Columns.Add("Capacity", 150)
            ListView1.Columns.Add("Interface", 100)
        End If
        Dim width As Integer
        For i = 0 To ListView1.Columns.Count - 1
            width += ListView1.Columns(i).Width
        Next
        ListView1.Columns.Add("Price", ListView1.Width - width)
    End Sub
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        PartsNaviagtion.Show()
        Me.Hide()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class