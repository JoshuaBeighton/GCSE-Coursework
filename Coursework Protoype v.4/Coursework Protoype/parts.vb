Imports System.ComponentModel
Imports System.Data.SqlTypes
Imports System.Threading.Tasks.Dataflow

Public Class parts
    Sub setup(type As String)
        ListView1.Columns.Clear()
        ListView1.Columns.Add("ID", 60)
        if type <> "GPU" then
            ListView1.Columns.Add("Name", 150)
            ListView1.Columns.Add("Brand", 150)
        end if
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
            ListView1.Columns.Add("TPD", 100)
            For i = 0 To AllGPUs.Count - 1
                Dim l As New ListViewItem
                l.SubItems(0).Text = AllGPUs(i).ID
                l.SubItems.Add(AllGPUs(i).Series)
                l.SubItems.Add(AllGPUs(i).Model)
                l.SubItems.Add(AllGPUs(i).manufacturer)
                l.SubItems.Add(AllGPUs(i).chipManufacturer)
                l.SubItems.Add(AllGPUs(i).baseClock)
                l.SubItems.Add(AllGPUs(i).VRAM)
                l.SubItems.Add(AllGPUs(i).TPD)
                l.SubItems.Add(AllGPUs(i).price)
                ListView1.Items.Add(l)
            Next

        ElseIf type = "RAM" Then
            ListView1.Columns.Add("Latency", 150)
            ListView1.Columns.Add("Speed", 150)
            ListView1.Columns.Add("DDR", 75)
            ListView1.Columns.Add("TPD", 100)
            ListView1.Columns.Add("DIMMs", 100)
            Dim l As New ListViewItem
            For i = 0 To AllRAMs.Count - 1

                l.SubItems(0).Text = AllRAMs(i).ID
                l.SubItems.Add(AllRAMs(i).name)
                l.SubItems.Add(AllRAMs(i).manufacturer)
                l.SubItems.Add(AllRAMs(i).latency)
                l.SubItems.Add(AllRAMs(i).speed)
                l.SubItems.Add(AllRAMs(i).ddr)
                l.SubItems.Add(AllRAMs(i).tpd)
                l.SubItems.Add(AllRAMs(i).dims)
                ListView1.Items.Add(l)
            Next
        ElseIf type = "PSU" Then
            ListView1.Columns.Add("Efficiency", 150)
            ListView1.Columns.Add("Modular", 120)
            ListView1.Columns.Add("Power", 150)
            Dim l As New ListViewItem
            For i = 0 To AllPSUs.Count - 1
                l.SubItems(0).Text = AllPSUs(i).ID
                l.SubItems.Add(AllPSUs(i).name)
                l.SubItems.Add(AllPSUs(i).manufacturer)
                l.SubItems.Add(AllPSUs(i).efficiency)
                l.SubItems.Add(AllPSUs(i).modular)
                l.SubItems.Add(AllPSUs(i).power)
                l.SubItems.Add(AllPSUs(i).price)
                ListView1.Items.Add(l)
            Next
        ElseIf type = "Motherboard" Then
            ListView1.Columns.Add("RAM Slots", 100)
            ListView1.Columns.Add("Socket", 100)
            ListView1.Columns.Add("SATAs", 100)
            ListView1.Columns.Add("M.2s", 100)
            Dim l As New ListViewItem
            For i = 0 To AllMoba.Count - 1

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

    Public selecting As Boolean

    Private Sub ListView1_ItemActivate(sender As Object, e As EventArgs) Handles ListView1.ItemActivate
        If ListView1.SelectedItems.Count = 1 Then
            If selecting Then
                WriteStock.onreturn(ListView1.SelectedItems(0).Index)
            End If
        End If
    End Sub
End Class