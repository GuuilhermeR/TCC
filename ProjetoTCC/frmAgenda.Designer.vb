<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgenda
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgenda))
        Me.lvAgendamento = New System.Windows.Forms.ListView()
        Me.btnVoltar = New System.Windows.Forms.Button()
        Me.btnAvançar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lvAgendamento
        '
        Me.lvAgendamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvAgendamento.HideSelection = False
        Me.lvAgendamento.Location = New System.Drawing.Point(12, 35)
        Me.lvAgendamento.Name = "lvAgendamento"
        Me.lvAgendamento.Size = New System.Drawing.Size(488, 613)
        Me.lvAgendamento.TabIndex = 0
        Me.lvAgendamento.UseCompatibleStateImageBehavior = False
        Me.lvAgendamento.View = System.Windows.Forms.View.Details
        '
        'btnVoltar
        '
        Me.btnVoltar.Location = New System.Drawing.Point(12, 6)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(75, 23)
        Me.btnVoltar.TabIndex = 1
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.UseVisualStyleBackColor = True
        '
        'btnAvançar
        '
        Me.btnAvançar.Location = New System.Drawing.Point(425, 6)
        Me.btnAvançar.Name = "btnAvançar"
        Me.btnAvançar.Size = New System.Drawing.Size(75, 23)
        Me.btnAvançar.TabIndex = 2
        Me.btnAvançar.Text = "Avançar"
        Me.btnAvançar.UseVisualStyleBackColor = True
        '
        'frmAgenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 660)
        Me.Controls.Add(Me.btnAvançar)
        Me.Controls.Add(Me.btnVoltar)
        Me.Controls.Add(Me.lvAgendamento)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAgenda"
        Me.Text = "frmAgenda"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lvAgendamento As ListView
    Friend WithEvents btnVoltar As Button
    Friend WithEvents btnAvançar As Button
End Class
