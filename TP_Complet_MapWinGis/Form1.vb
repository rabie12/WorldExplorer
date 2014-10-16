Imports MapWinGIS

Public Class Form1
    Dim sfWorld As New Shapefile
    Dim sfCity As New Shapefile
    Private Sub checkAll()
        '' c'est une procedure qui permet de checker tout les composant du CheckBoxList
        For i As Integer = 0 To CheckedListBox1.Items.Count - 1
            CheckedListBox1.SetItemChecked(i, True)
        Next
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '' checkAll procedure 
        checkAll()


        sfWorld.Open("Data/Shapefiles/world_adm0.shp")
        sfCity.Open("Data/Shapefiles/cities_capital_pt.shp")
        AxMap1.AddLayer(sfWorld, True)
        AxMap1.AddLayer(sfCity, True)

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        If (CheckedListBox1.CheckedItems.Contains("World")) Then
            AxMap1.set_LayerVisible(0, True)
        Else
            AxMap1.set_LayerVisible(0, False)
        End If
        If CheckedListBox1.CheckedItems.Contains("City") Then
            AxMap1.set_LayerVisible(1, True)
        Else
            AxMap1.set_LayerVisible(1, False)
        End If







    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click, ToolStripButton3.Click, ToolStripButton2.Click

        For i As Integer = 0 To ToolStrip1.Items.Count - 2
            ToolStrip1.Items(i).Enabled = True
        Next

        Dim btn As ToolStripButton = sender
        btn.Enabled = Not btn.Enabled
        Select Case btn.Text
            Case "zoomIn"
                AxMap1.CursorMode = tkCursorMode.cmZoomIn
            Case "zoomOut"
                AxMap1.CursorMode = tkCursorMode.cmZoomOut
            Case "pan"
                AxMap1.CursorMode = tkCursorMode.cmPan
            
        End Select


    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        AxMap1.ZoomToMaxExtents()
    End Sub
End Class
