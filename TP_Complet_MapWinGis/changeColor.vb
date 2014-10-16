Public Class changeColor
    


    Private Sub changeColor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll, TrackBar3.Scroll, TrackBar2.Scroll
        Dim c As Color = Color.FromArgb(TrackBar1.Value, TrackBar2.Value, TrackBar3.Value)
        Panel1.BackColor = c










    End Sub

    Private Sub changeColor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.set_color(Convert.ToInt32(RGB(TrackBar1.Value, TrackBar2.Value, TrackBar3.Value)))
        Form1.AxMap1.set_ShapeLayerFillColor(0, Form1.get_color())




    End Sub
End Class