<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConsultaAlimentos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaAlimentos))
        Me.dtgConsultaAlimentos = New System.Windows.Forms.DataGridView()
        Me.lblAlimento = New System.Windows.Forms.Label()
        Me.txtAlimento = New System.Windows.Forms.TextBox()
        Me.btnRecalcular = New System.Windows.Forms.Button()
        Me.btnProcurarAlimento = New System.Windows.Forms.Button()
        Me.btnConsultar = New System.Windows.Forms.Button()
        CType(Me.dtgConsultaAlimentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgConsultaAlimentos
        '
        Me.dtgConsultaAlimentos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtgConsultaAlimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgConsultaAlimentos.GridColor = System.Drawing.SystemColors.Control
        Me.dtgConsultaAlimentos.Location = New System.Drawing.Point(12, 143)
        Me.dtgConsultaAlimentos.Name = "dtgConsultaAlimentos"
        Me.dtgConsultaAlimentos.Size = New System.Drawing.Size(838, 331)
        Me.dtgConsultaAlimentos.TabIndex = 0
        '
        'lblAlimento
        '
        Me.lblAlimento.AutoSize = True
        Me.lblAlimento.Location = New System.Drawing.Point(12, 20)
        Me.lblAlimento.Name = "lblAlimento"
        Me.lblAlimento.Size = New System.Drawing.Size(50, 13)
        Me.lblAlimento.TabIndex = 2
        Me.lblAlimento.Text = "Alimento:"
        '
        'txtAlimento
        '
        Me.txtAlimento.Location = New System.Drawing.Point(68, 17)
        Me.txtAlimento.Name = "txtAlimento"
        Me.txtAlimento.Size = New System.Drawing.Size(262, 20)
        Me.txtAlimento.TabIndex = 3
        '
        'btnRecalcular
        '
        Me.btnRecalcular.Location = New System.Drawing.Point(746, 480)
        Me.btnRecalcular.Name = "btnRecalcular"
        Me.btnRecalcular.Size = New System.Drawing.Size(104, 31)
        Me.btnRecalcular.TabIndex = 1
        Me.btnRecalcular.Text = "Recalcular"
        Me.btnRecalcular.UseVisualStyleBackColor = True
        '
        'btnProcurarAlimento
        '
        Me.btnProcurarAlimento.Image = Global.ProjetoTCC.My.Resources.Resources.consultar
        Me.btnProcurarAlimento.Location = New System.Drawing.Point(336, 15)
        Me.btnProcurarAlimento.Name = "btnProcurarAlimento"
        Me.btnProcurarAlimento.Size = New System.Drawing.Size(30, 23)
        Me.btnProcurarAlimento.TabIndex = 25
        Me.btnProcurarAlimento.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Image = Global.ProjetoTCC.My.Resources.Resources.consultar1
        Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultar.Location = New System.Drawing.Point(746, 106)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(104, 31)
        Me.btnConsultar.TabIndex = 4
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'frmConsultaAlimentos
        '
        Me.ClientSize = New System.Drawing.Size(862, 523)
        Me.Controls.Add(Me.btnProcurarAlimento)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.txtAlimento)
        Me.Controls.Add(Me.lblAlimento)
        Me.Controls.Add(Me.btnRecalcular)
        Me.Controls.Add(Me.dtgConsultaAlimentos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConsultaAlimentos"
        Me.Text = "Consulta Alimentos"
        CType(Me.dtgConsultaAlimentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtgConsultaAlimentos As DataGridView
    Friend WithEvents btnRecalcular As Button
    Friend WithEvents lblAlimento As Label
    Friend WithEvents txtAlimento As TextBox
    Friend WithEvents btnConsultar As Button
    Friend WithEvents btnProcurarAlimento As Button
End Class
