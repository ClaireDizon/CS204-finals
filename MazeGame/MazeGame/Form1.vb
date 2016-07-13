Public Class Form2

    Private Sub Wall_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label17.MouseEnter, Panel1.MouseEnter, Label9.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label64.MouseEnter, Label63.MouseEnter, Label61.MouseEnter, Label60.MouseEnter, Label6.MouseEnter, Label59.MouseEnter, Label56.MouseEnter, Label55.MouseEnter, Label54.MouseEnter, Label53.MouseEnter, Label52.MouseEnter, Label51.MouseEnter, Label50.MouseEnter, Label5.MouseEnter, Label49.MouseEnter, Label48.MouseEnter, Label46.MouseEnter, Label45.MouseEnter, Label44.MouseEnter, Label43.MouseEnter, Label42.MouseEnter, Label41.MouseEnter, Label40.MouseEnter, Label4.MouseEnter, Label39.MouseEnter, Label38.MouseEnter, Label37.MouseEnter, Label36.MouseEnter, Label35.MouseEnter, Label34.MouseEnter, Label33.MouseEnter, Label32.MouseEnter, Label31.MouseEnter, Label30.MouseEnter, Label3.MouseEnter, Label29.MouseEnter, Label28.MouseEnter, Label27.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label23.MouseEnter, Label22.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label2.MouseEnter, Label19.MouseEnter, Label18.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter, Label1.MouseEnter, Label62.MouseEnter, Label67.MouseEnter, Label66.MouseEnter, Label65.MouseEnter
        MoveToStart()
    End Sub

    Private Sub FINISH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FINISH.Click
        MessageBox.Show("Next Level!", "Nice One")
        Dim a As New Form2
        Me.Hide()
        a.Show()
    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        MoveToStart()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub MoveToStart()
        Dim StartingPoint = Panel1.Location
        StartingPoint.Offset(10, 10)
        Cursor.Position = PointToScreen(StartingPoint)

    End Sub




    Private Sub Label26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label26.Click

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Angry_Birds_Rio_Background_music, AudioPlayMode.BackgroundLoop)
    End Sub

End Class
