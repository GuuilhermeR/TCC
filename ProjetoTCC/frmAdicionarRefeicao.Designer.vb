<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdicionarRefeição
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdicionarRefeição))
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.txtHora = New System.Windows.Forms.TextBox()
        Me.txtAlimento = New System.Windows.Forms.TextBox()
        Me.lblAlimento = New System.Windows.Forms.Label()
        Me.btnProcurarPaciente = New System.Windows.Forms.Button()
        Me.btnAdicionarRefeição = New MvtWindowsForms.ButtonInserir()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblObs = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Location = New System.Drawing.Point(13, 28)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(44, 13)
        Me.lblHora.TabIndex = 1
        Me.lblHora.Text = "Horário:"
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(205, 28)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(58, 13)
        Me.lblDescricao.TabIndex = 2
        Me.lblDescricao.Text = "Descrição:"
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(269, 25)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(291, 20)
        Me.txtDescricao.TabIndex = 3
        '
        'txtHora
        '
        Me.txtHora.Location = New System.Drawing.Point(63, 25)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Size = New System.Drawing.Size(100, 20)
        Me.txtHora.TabIndex = 4
        '
        'txtAlimento
        '
        Me.txtAlimento.Location = New System.Drawing.Point(69, 74)
        Me.txtAlimento.Name = "txtAlimento"
        Me.txtAlimento.Size = New System.Drawing.Size(370, 20)
        Me.txtAlimento.TabIndex = 6
        '
        'lblAlimento
        '
        Me.lblAlimento.AutoSize = True
        Me.lblAlimento.Location = New System.Drawing.Point(13, 77)
        Me.lblAlimento.Name = "lblAlimento"
        Me.lblAlimento.Size = New System.Drawing.Size(50, 13)
        Me.lblAlimento.TabIndex = 5
        Me.lblAlimento.Text = "Alimento:"
        '
        'btnProcurarPaciente
        '
        Me.btnProcurarPaciente.Image = Global.ProjetoTCC.My.Resources.Resources.consultar
        Me.btnProcurarPaciente.Location = New System.Drawing.Point(445, 72)
        Me.btnProcurarPaciente.Name = "btnProcurarPaciente"
        Me.btnProcurarPaciente.Size = New System.Drawing.Size(30, 23)
        Me.btnProcurarPaciente.TabIndex = 266
        Me.btnProcurarPaciente.UseVisualStyleBackColor = True
        '
        'btnAdicionarRefeição
        '
        Me.btnAdicionarRefeição.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdicionarRefeição.Image = CType(resources.GetObject("btnAdicionarRefeição.Image"), System.Drawing.Image)
        Me.btnAdicionarRefeição.Location = New System.Drawing.Point(456, 123)
        Me.btnAdicionarRefeição.MaximumSize = New System.Drawing.Size(100, 30)
        Me.btnAdicionarRefeição.MinimumSize = New System.Drawing.Size(100, 30)
        Me.btnAdicionarRefeição.Name = "btnAdicionarRefeição"
        Me.btnAdicionarRefeição.Size = New System.Drawing.Size(100, 30)
        Me.btnAdicionarRefeição.TabIndex = 267
        Me.btnAdicionarRefeição.Text = "Adicionar"
        Me.btnAdicionarRefeição.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdicionarRefeição.ToolTipHelp = Nothing
        Me.btnAdicionarRefeição.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(127, 120)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(72, 20)
        Me.TextBox1.TabIndex = 269
        '
        'lblObs
        '
        Me.lblObs.AutoSize = True
        Me.lblObs.Location = New System.Drawing.Point(13, 123)
        Me.lblObs.Name = "lblObs"
        Me.lblObs.Size = New System.Drawing.Size(108, 13)
        Me.lblObs.TabIndex = 268
        Me.lblObs.Text = "Quantidade (gramas):"
        '
        'frmAdicionarRefeição
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 165)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblObs)
        Me.Controls.Add(Me.btnAdicionarRefeição)
        Me.Controls.Add(Me.btnProcurarPaciente)
        Me.Controls.Add(Me.txtAlimento)
        Me.Controls.Add(Me.lblAlimento)
        Me.Controls.Add(Me.txtHora)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.lblDescricao)
        Me.Controls.Add(Me.lblHora)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAdicionarRefeição"
        Me.Text = "Adicionar Refeição"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHora As Label
    Friend WithEvents lblDescricao As Label
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents txtHora As TextBox
    Friend WithEvents txtAlimento As TextBox
    Friend WithEvents lblAlimento As Label
    Friend WithEvents btnProcurarPaciente As Button
    Friend WithEvents btnAdicionarRefeição As MvtWindowsForms.ButtonInserir
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblObs As Label
End Class
