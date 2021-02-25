Public Class frmAgenda
    Private Sub frmAgenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lvAgendamento.Columns.Add("Horário")
        lvAgendamento.Items.Add($"{Now.ToString("hh:mm")} ")
        Me.lvAgendamento.Columns(0).Width = 90
    End Sub
End Class