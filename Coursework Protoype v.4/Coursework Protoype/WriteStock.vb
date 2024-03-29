﻿Imports System.Runtime.Intrinsics.X86

Public Class WriteStock
    'initialise when we are writing a stock part that will immediately be transfered to an order
    Sub selectInit(type As String)
        'set the selecting variable to true
        selecting = True
        'set the type combobox to the right type and disable it
        cmb_type.SelectedItem = type
        cmb_type.Enabled = False
        btn_part.Show()
        txt_part.Hide()
    End Sub
    'initialise the page
    Sub init()
        'show the button to select the part and hide the textbox
        btn_part.Show()
        txt_part.Hide()

    End Sub
    'store whether this is a stock part that will immediately be transfered to an order
    Dim selecting As Boolean = False
    Private Sub btn_AddOrder_Click(sender As Object, e As EventArgs) Handles btn_AddOrder.Click
        'if the user has selected a type
        If cmb_type.SelectedIndex >= 0 Then
            'if the user has entered a part
            If txt_part.Text.Length > 0 Then
                'if the user has entered the price
                If txt_price.Text.Length > 0 Then
                    'create a new stock item
                    Dim s As New Stock
                    'if the user has selected a type
                    If cmb_type.SelectedIndex >= 0 Then
                        'if the user has entered a part
                        If txt_part.Text.Length > 0 Then
                            'if the user has entered a price
                            If txt_price.Text.Length > 0 Then

                                'set the stock item's ID to the amount of stock plus one
                                s.ID = AllStock.Count
                                'set the rest of the data according to what the user has entered
                                s.ordered = date_ordered.Value
                                s.Due = date_due.Value
                                s.cost = Convert.ToDecimal(txt_price.Text)
                                s.arrived = chk_arrived.Checked
                                s.type = cmb_type.SelectedItem
                                s.part = partIndex
                                AllStock.Add(s)
                                 
                                'clear the UI elements
                                txt_part.Clear()
                                txt_price.Clear()
                                chk_arrived.Checked = False
                                cmb_type.SelectedIndex = -1
                                cmb_type.Text = ""
                                'store the log item
                                Dim l As log

                                l.id = findNextIndex("AllLogs")
                                l.user = Form1.currentUser
                                l.action = "Delete"
                                l.data = s.ID & s.part & s.cost
                                l.time = Now
                                AllLogs.Add(l)
                                writeLogs()
                            Else
                                'ask the user to enter a price
                                MsgBox("Please Enter a Price")
                            End If
                        Else
                            'ask the user to enter a part
                            MsgBox("Please Enter a Part")
                        End If
                    Else
                        'ask the user to enter a type
                        MsgBox("Please Select A Type")
                    End If
                    If selecting Then
                        Me.Hide()
                        Write.Show()
                        Write.onReturn(s.ID)
                    Else
                        Me.Hide()
                        seeStock.Show()
                    End If
                    FileHandler.writeStockFile()
                Else
                    'if the user didn't enter a type ask them to
                    MsgBox("Please Enter a Price")
                End If
            Else
                'if the user didnt enter a part ask them to
                MsgBox("Please Enter a Part")
            End If
        Else
            'if the user didn't enter a type ask them to
            MsgBox("Please Select A Type")
        End If
    End Sub

    'go back to the main database
    Private Sub btn_navi_Click(sender As Object, e As EventArgs) Handles btn_navi.Click
        Me.Close()
        seeStock.Show()
    End Sub
    'when the user presses the part select button
    Private Sub btn_part_Click(sender As Object, e As EventArgs) Handles btn_part.Click
        'if the user has selected an item
        If cmb_type.SelectedIndex <> -1 Then
            'navigate to the parts page and set it up
            parts.Show()
            Me.Hide()
            parts.setup(cmb_type.SelectedItem)
            parts.selecting = True
            parts.editing = False
        End If

    End Sub
    'store the index of the part
    Dim partIndex As Integer
    'when returning from the parts page
    Public Sub onreturn(index As Integer)
        'store the index of the part
        partIndex = index
        'loop through the correct file and set the price and part text boxes according to the part data
        Select Case cmb_type.SelectedItem
            Case "CPU"
                For i = 0 To AllCPUs.Count - 1
                    If index = AllCPUs(i).ID Then
                        txt_part.Text = AllCPUs(i).name
                        txt_price.Text = AllCPUs(i).price
                    End If
                Next
            Case "GPU"
                For i = 0 To AllGPUs.Count - 1
                    If index = AllGPUs(i).ID Then
                        txt_part.Text = AllGPUs(i).Series
                        txt_price.Text = AllGPUs(i).price
                    End If
                Next
            Case "RAM"
                For i = 0 To AllRAMs.Count - 1
                    If index = AllRAMs(i).ID Then
                        txt_part.Text = AllRAMs(i).name
                        txt_price.Text = AllRAMs(i).price
                    End If
                Next
            Case "PSU"
                For i = 0 To AllPSUs.Count - 1
                    If index = AllPSUs(i).ID Then
                        txt_part.Text = AllPSUs(i).name
                        txt_price.Text = AllPSUs(i).price
                    End If
                Next
            Case "Motherboard"
                For i = 0 To AllMoba.Count - 1
                    If index = AllMoba(i).id Then
                        txt_part.Text = AllMoba(i).name
                        txt_price.Text = AllMoba(i).price
                    End If
                Next
            Case "Storage"
                For i = 0 To AllStorage.Count - 1
                    If index = AllStorage(i).ID Then
                        txt_part.Text = AllStorage(i).name
                        txt_price.Text = AllStorage(i).price
                    End If
                Next
            Case "Case"
                For i = 0 To AllCases.Count - 1
                    If index = AllCases(i).id Then
                        txt_part.Text = AllCases(i).name
                        txt_price.Text = AllCases(i).price
                    End If
                Next
        End Select
        btn_part.Hide()
        txt_part.Show()
    End Sub
End Class