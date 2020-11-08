<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConsultaMedidasCaseiras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaMedidasCaseiras))
        Me.dtgConsultaAlimentos = New System.Windows.Forms.DataGridView()
        Me.lblAlimento = New System.Windows.Forms.Label()
        Me.txtAlimento = New System.Windows.Forms.TextBox()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnRecalcular = New System.Windows.Forms.Button()
        CType(Me.dtgConsultaAlimentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgConsultaAlimentos
        '
        Me.dtgConsultaAlimentos.AllowUserToAddRows = False
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
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(764, 106)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(86, 31)
        Me.btnConsultar.TabIndex = 4
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'btnRecalcular
        '
        Me.btnRecalcular.Location = New System.Drawing.Point(764, 480)
        Me.btnRecalcular.Name = "btnRecalcular"
        Me.btnRecalcular.Size = New System.Drawing.Size(86, 31)
        Me.btnRecalcular.TabIndex = 1
        Me.btnRecalcular.Text = "Recalcular"
        Me.btnRecalcular.UseVisualStyleBackColor = True
        '
        'frmConsultaMedidasCaseiras
        '
        Me.ClientSize = New System.Drawing.Size(862, 523)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.txtAlimento)
        Me.Controls.Add(Me.lblAlimento)
        Me.Controls.Add(Me.btnRecalcular)
        Me.Controls.Add(Me.dtgConsultaAlimentos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConsultaMedidasCaseiras"
        Me.Text = "Consulta Medias Caseiras"
        CType(Me.dtgConsultaAlimentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtgConsultaAlimentos As DataGridView
    Friend WithEvents btnRecalcular As Button
    Friend WithEvents lblAlimento As Label
    Friend WithEvents txtAlimento As TextBox
    Friend WithEvents btnConsultar As Button
End Class
