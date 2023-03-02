Imports System.ComponentModel
Imports System.Data.SqlTypes
Imports System.Threading.Tasks.Dataflow

Public Class parts
    'setup the parts form
    Sub setup(type As String)
        ptype = type
        ListView1.Items.Clear()
        ListView1.Columns.Clear()
        'add the ID column
        ListView1.Columns.Add("ID", 60)
        If type <> "GPU" Then
            ListView1.Columns.Add("Name", 150)
            ListView1.Columns.Add("Brand", 150)
        End If
        If type <> "Storage" And type <> "RAM" Then
            'set the text of the form to the type we're dealing with plus a "S"
            Me.Text = type + "s"
        Else
            'otherwise just call the form the type of item
            Me.Text = type
        End If
        'if the type is a CPU
        If type = "CPU" Then
            'add the relavent columns
            ListView1.Columns.Add("Socket", 150)
            ListView1.Columns.Add("Cores", 100)
            ListView1.Columns.Add("Base Speed", 175)
            ListView1.Columns.Add("Boost Speed", 175)
            ListView1.Columns.Add("TPD", 100)
            'loop through the cpus
            For i = 0 To AllCPUs.Count - 1
                'create a new listviewitem
                Dim l As New ListViewItem
                'add all of the data to the listviewitem
                l.SubItems(0).Text = AllCPUs(i).ID
                l.SubItems.Add(AllCPUs(i).name)
                l.SubItems.Add(AllCPUs(i).manufacturer)
                l.SubItems.Add(AllCPUs(i).socket)
                l.SubItems.Add(AllCPUs(i).cores)
                l.SubItems.Add(AllCPUs(i).baseSpeed)
                l.SubItems.Add(AllCPUs(i).boostSpeed)
                l.SubItems.Add(AllCPUs(i).TPD)
                l.SubItems.Add(AllCPUs(i).price)
                'add the temporary item to the listview
                ListView1.Items.Add(l)
            Next
        'if the type is a GPU
        ElseIf type = "GPU" Then
            'add the relevant columns
            ListView1.Columns.Add("Series", 100)
            ListView1.Columns.Add("Model", 100)
            ListView1.Columns.Add("Manufacturer", 125)
            ListView1.Columns.Add("Chip Manufacturer", 175)
            ListView1.Columns.Add("Base Clock", 100)
            ListView1.Columns.Add("VRAM", 100)
            ListView1.Columns.Add("TPD", 100)
            'loop through all of the GPUs
            For i = 0 To AllGPUs.Count - 1
                'declare a temporary list item
                Dim l As New ListViewItem
                'set the sub items of the listviewitem to the data
                l.SubItems(0).Text = AllGPUs(i).ID
                l.SubItems.Add(AllGPUs(i).Series)
                l.SubItems.Add(AllGPUs(i).Model)
                l.SubItems.Add(AllGPUs(i).manufacturer)
                l.SubItems.Add(AllGPUs(i).chipManufacturer)
                l.SubItems.Add(AllGPUs(i).baseClock)
                l.SubItems.Add(AllGPUs(i).VRAM)
                l.SubItems.Add(AllGPUs(i).TPD)
                l.SubItems.Add(AllGPUs(i).price)
                'add the temporary item to the listview
                ListView1.Items.Add(l)
            Next
        'if the type is RAM
        ElseIf type = "RAM" Then
            'add the relevant columns
            ListView1.Columns.Add("Latency", 150)
            ListView1.Columns.Add("Speed", 150)
            ListView1.Columns.Add("DDR", 75)
            ListView1.Columns.Add("TPD", 100)
            ListView1.Columns.Add("DIMMs", 100)
            ListView1.Columns.Add("Capacity", 100)
            'declare a temporary list view item
            Dim l As New ListViewItem
            'loop through all of the RAM data
            For i = 0 To AllRAMs.Count - 1
                'add the data to the listviewitem
                l.SubItems(0).Text = AllRAMs(i).ID
                l.SubItems.Add(AllRAMs(i).name)
                l.SubItems.Add(AllRAMs(i).manufacturer)
                l.SubItems.Add(AllRAMs(i).latency)
                l.SubItems.Add(AllRAMs(i).speed)
                l.SubItems.Add(AllRAMs(i).ddr)
                l.SubItems.Add(AllRAMs(i).tpd)
                l.SubItems.Add(AllRAMs(i).dims)
                l.SubItems.Add(AllRAMs(i).capacity)
                l.SubItems.Add(AllRAMs(i).price)
                'add the listviewitem to the listview
                ListView1.Items.Add(l)
            Next
        'if the type is a psu
        ElseIf type = "PSU" Then
            'add the relevant columns
            ListView1.Columns.Add("Efficiency", 150)
            ListView1.Columns.Add("Modular", 120)
            ListView1.Columns.Add("Power", 150)
            'declare a temporary listviewitem
            Dim l As New ListViewItem
            'loop through the PSUs
            For i = 0 To AllPSUs.Count - 1
                'set the data in the listviewitem equal to the data from the PSUs
                l.SubItems(0).Text = AllPSUs(i).ID
                l.SubItems.Add(AllPSUs(i).name)
                l.SubItems.Add(AllPSUs(i).manufacturer)
                l.SubItems.Add(AllPSUs(i).efficiency)
                l.SubItems.Add(AllPSUs(i).modular)
                l.SubItems.Add(AllPSUs(i).power)
                l.SubItems.Add(AllPSUs(i).price)
                'add the listviewitem
                ListView1.Items.Add(l)
            Next
        'if the type is a motherboard
        ElseIf type = "Motherboard" Then
            'add the relevant columns
            ListView1.Columns.Add("RAM Slots", 100)
            ListView1.Columns.Add("Socket", 100)
            ListView1.Columns.Add("SATAs", 100)
            ListView1.Columns.Add("M.2s", 100)
            'declare a temporary listviewitem
            Dim l As New ListViewItem
            'loop through the motherboards
            For i = 0 To AllMoba.Count - 1
                'add the relevant data to the temporary listviewitem
                l.SubItems(0).Text = AllMoba(i).id
                l.SubItems.Add(AllMoba(i).name)
                l.SubItems.Add(AllMoba(i).manufacturer)
                l.SubItems.Add(AllMoba(i).ramSlots)
                l.SubItems.Add(AllMoba(i).socket)
                l.SubItems.Add(AllMoba(i).SATAs)
                l.SubItems.Add(AllMoba(i).m2s)
                l.SubItems.Add(AllMoba(i).price)
                ListView1.Items.Add(l)
            Next
        'if the type is case
        ElseIf type = "Case" Then
            'add the relevant columns
            ListView1.Columns.Add("HDDs", 100)
            ListView1.Columns.Add("SSDs", 100)
            'declare a temporary listviewitem
            Dim l As New ListViewItem
            'loop through the cases
            For i = 0 To AllCases.Count - 1
                'add the relevant data to the temporary listviewitem
                l.SubItems(0).Text = AllCases(i).id
                l.SubItems.Add(AllCases(i).name)
                l.SubItems.Add(AllCases(i).manufacturer)
                l.SubItems.Add(AllCases(i).HDDs)
                l.SubItems.Add(AllCases(i).SSDs)
                l.SubItems.Add(AllCases(i).price)
                ListView1.Items.Add(l)
            Next
            'if the type is storage
        ElseIf type = "Storage" Then
            'add the relevant columns
            ListView1.Columns.Add("Type", 100)
            ListView1.Columns.Add("Read", 100)
            ListView1.Columns.Add("Write", 100)
            ListView1.Columns.Add("Capacity", 150)
            ListView1.Columns.Add("Interface", 100)
            'declare a temporary listviewitem
            Dim l As New ListViewItem
            'loop through the storage
            For i = 0 To AllStorage.Count - 1
                'add the relevant data to the temporary listviewitem
                l.SubItems(0).Text = AllStorage(i).ID
                l.SubItems.Add(AllStorage(i).name)
                l.SubItems.Add(AllStorage(i).manufacturer)
                l.SubItems.Add(AllStorage(i).type)
                l.SubItems.Add(AllStorage(i).read)
                l.SubItems.Add(AllStorage(i).write)
                l.SubItems.Add(AllStorage(i).capacity)
                l.SubItems.Add(AllStorage(i).connection)
                l.SubItems.Add(AllCases(i).price)
                ListView1.Items.Add(l)
            Next
        End If
        'a variable to store the width that has been used so far
        Dim width As Integer
        For i = 0 To ListView1.Columns.Count - 1
            'calculate the width that has been used so far
            width += ListView1.Columns(i).Width
        Next
        'add the price column
        ListView1.Columns.Add("Price", ListView1.Width - width)
    End Sub

    'go back
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        PartsNaviagtion.Show()
        Me.Hide()
    End Sub

    'store whether we are selecting a part or simply browsing
    Public selecting As Boolean

    'when a listviewitem is double clicked
    Private Sub ListView1_ItemActivate(sender As Object, e As EventArgs) Handles ListView1.ItemActivate
        'if the user has clicked an item
        If ListView1.SelectedItems.Count = 1 Then
            'if we are trying to select an item
            If selecting Then
                'go back to writestock and pass it the ID of the part item the user selected
                WriteStock.onreturn(ListView1.SelectedItems(0).SubItems(0).Text)
                Me.Hide()
                WriteStock.Show()
            End If
        End If
    End Sub
    'store the type part of type being looked at
    Public ptype As String

    'add a part
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case ptype
            Case "CPU"
                AddCPU.Show()
                Me.Hide()
            Case "GPU"
                AddGPU.Show()
                Me.Hide()
            Case "PSU"
                AddPSU.Show()
                Me.Hide()
            Case "RAM"
                AddRAM.Show()
                Me.Hide()
            Case "Case"
                AddCase.Show()
                Me.Hide()
            Case "Motherboard"
                AddMoba.Show()
                Me.Hide()
            Case "Storage"
                AddStorage.Show()
                Me.Hide()
        End Select
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Select Case ptype
            Case "CPU"
                While ListView1.SelectedItems.Count > 0
                    For i = 0 To AllCPUs.Count - 1
                        If AllCPUs(i).ID = ListView1.SelectedItems(0).SubItems(0).Text Then
                            Dim item As CPU = AllCPUs(i)
                            item.ID = -1 - item.ID
                            AllCPUs(i) = item
                        End If
                        ListView1.SelectedItems(0).Remove()
                    Next
                End While
            Case "GPU"
                While ListView1.SelectedItems.Count > 0
                    For i = 0 To AllGPUs.Count - 1
                        If AllGPUs(i).ID = ListView1.SelectedItems(0).SubItems(0).Text Then
                            Dim item As GPU = AllGPUs(i)
                            item.ID = -1 - item.ID
                            AllGPUs(i) = item
                        End If
                        ListView1.SelectedItems(0).Remove()
                    Next
                End While
            Case "PSU"
                While ListView1.SelectedItems.Count > 0
                    For i = 0 To AllPSUs.Count - 1
                        If AllPSUs(i).ID = ListView1.SelectedItems(0).SubItems(0).Text Then
                            Dim item As PSU = AllPSUs(i)
                            item.ID = -1 - item.ID
                            AllPSUs(i) = item
                        End If
                        ListView1.SelectedItems(0).Remove()
                    Next
                End While
            Case "RAM"
                While ListView1.SelectedItems.Count > 0
                    For i = 0 To AllRAMs.Count - 1
                        If AllRAMs(i).ID = ListView1.SelectedItems(0).SubItems(0).Text Then
                            Dim item As RAM = AllRAMs(i)
                            item.ID = -1 - item.ID
                            AllRAMs(i) = item
                        End If
                        ListView1.SelectedItems(0).Remove()
                    Next
                End While
            Case "Case"
                While ListView1.SelectedItems.Count > 0
                    For i = 0 To AllCases.Count - 1
                        If AllCases(i).id = ListView1.SelectedItems(0).SubItems(0).Text Then
                            Dim item As cases = AllCases(i)
                            item.ID = -1 - item.ID
                            AllCases(i) = item
                        End If
                        ListView1.SelectedItems(0).Remove()
                    Next
                End While
            Case "Motherboard"
                While ListView1.SelectedItems.Count > 0
                    For i = 0 To AllMoba.Count - 1
                        If AllMoba(i).id = ListView1.SelectedItems(0).SubItems(0).Text Then
                            Dim item As motherboard = AllMoba(i)
                            item.id = -1 - item.id
                            AllMoba(i) = item
                        End If
                        ListView1.SelectedItems(0).Remove()
                    Next
                End While
            Case "Storage"
                While ListView1.SelectedItems.Count > 0
                    For i = 0 To AllStorage.Count - 1
                        If AllStorage(i).ID = ListView1.SelectedItems(0).SubItems(0).Text Then
                            Dim item As store = AllStorage(i)
                            item.ID = -1 - item.ID
                            AllStorage(i) = item
                        End If
                        ListView1.SelectedItems(0).Remove()
                    Next
                End While
        End Select
    End Sub


End Class