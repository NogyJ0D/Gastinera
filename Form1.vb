Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Audio.Play(My.Resources.Sonidos.Siuc, AudioPlayMode.Background)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.Audio.Play(My.Resources.Sonidos.Sambabaram, AudioPlayMode.Background)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Computer.Audio.Play(My.Resources.Sonidos.Tum, AudioPlayMode.Background)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        My.Computer.Audio.Play(My.Resources.Sonidos.Sócrates, AudioPlayMode.Background)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        My.Computer.Audio.Play(My.Resources.Sonidos.Suculini, AudioPlayMode.Background)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        My.Computer.Audio.Play(My.Resources.Sonidos.Silvio_Rodriguez, AudioPlayMode.Background)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        My.Computer.Audio.Play(My.Resources.Sonidos.Fiumba, AudioPlayMode.Background)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        My.Computer.Audio.Play(My.Resources.Sonidos.Chumba, AudioPlayMode.Background)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        My.Computer.Audio.Play(My.Resources.Sonidos.Geman_Garmendia, AudioPlayMode.Background)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        My.Computer.Audio.Play(My.Resources.Sonidos.Paulo_Londra, AudioPlayMode.Background)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        My.Computer.Audio.Play(My.Resources.Sonidos.Paulo_Londra_Transexual, AudioPlayMode.Background)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        My.Computer.Audio.Play(My.Resources.Sonidos.Fernanflo, AudioPlayMode.Background)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        My.Computer.Audio.Play(My.Resources.Sonidos.Fernanfloo, AudioPlayMode.Background)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Randomize()
        Dim Numero As Integer = Int((13 * Rnd()) + 1)
        Select Case (Numero)
            Case 1
                My.Computer.Audio.Play(My.Resources.Sonidos.Siuc, AudioPlayMode.Background)
            Case 2
                My.Computer.Audio.Play(My.Resources.Sonidos.Sambabaram, AudioPlayMode.Background)
            Case 3
                My.Computer.Audio.Play(My.Resources.Sonidos.Tum, AudioPlayMode.Background)
            Case 4
                My.Computer.Audio.Play(My.Resources.Sonidos.Sócrates, AudioPlayMode.Background)
            Case 5
                My.Computer.Audio.Play(My.Resources.Sonidos.Suculini, AudioPlayMode.Background)
            Case 6
                My.Computer.Audio.Play(My.Resources.Sonidos.Silvio_Rodriguez, AudioPlayMode.Background)
            Case 7
                My.Computer.Audio.Play(My.Resources.Sonidos.Fiumba, AudioPlayMode.Background)
            Case 8
                My.Computer.Audio.Play(My.Resources.Sonidos.Chumba, AudioPlayMode.Background)
            Case 9
                My.Computer.Audio.Play(My.Resources.Sonidos.Geman_Garmendia, AudioPlayMode.Background)
            Case 10
                My.Computer.Audio.Play(My.Resources.Sonidos.Paulo_Londra, AudioPlayMode.Background)
            Case 11
                My.Computer.Audio.Play(My.Resources.Sonidos.Paulo_Londra_Transexual, AudioPlayMode.Background)
            Case 12
                My.Computer.Audio.Play(My.Resources.Sonidos.Fernanflo, AudioPlayMode.Background)
            Case 13
                My.Computer.Audio.Play(My.Resources.Sonidos.Fernanfloo, AudioPlayMode.Background)
        End Select
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs)
        My.Computer.Audio.Play(My.Resources.Sonidos.Todo, AudioPlayMode.Background)
    End Sub
End Class
