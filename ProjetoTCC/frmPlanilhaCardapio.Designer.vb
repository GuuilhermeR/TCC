<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPlanilhaCardapio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPlanilhaCardapio))
        Me.txtCodPaciente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnAdicionar = New MvtWindowsForms.ButtonInserir()
        Me.btnProcurarPaciente = New System.Windows.Forms.Button()
        Me.dtgRefeicoes = New System.Windows.Forms.DataGridView()
        CType(Me.dtgRefeicoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCodPaciente
        '
        Me.txtCodPaciente.Enabled = False
        Me.txtCodPaciente.Location = New System.Drawing.Point(106, 6)
        Me.txtCodPaciente.Name = "txtCodPaciente"
        Me.txtCodPaciente.Size = New System.Drawing.Size(75, 20)
        Me.txtCodPaciente.TabIndex = 263
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 13)
        Me.Label6.TabIndex = 264
        Me.Label6.Text = "Código Paciente:"
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(106, 44)
        Me.txtDescricao.Multiline = True
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(362, 61)
        Me.txtDescricao.TabIndex = 266
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(12, 47)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(58, 13)
        Me.lblDescricao.TabIndex = 267
        Me.lblDescricao.Text = "Descrição:"
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.ProjetoTCC.My.Resources.Resources.mvtSaveGreen_16
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalvar.Location = New System.Drawing.Point(788, 478)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(89, 30)
        Me.btnSalvar.TabIndex = 270
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Image = CType(resources.GetObject("btnAdicionar.Image"), System.Drawing.Image)
        Me.btnAdicionar.Location = New System.Drawing.Point(777, 102)
        Me.btnAdicionar.MaximumSize = New System.Drawing.Size(100, 30)
        Me.btnAdicionar.MinimumSize = New System.Drawing.Size(100, 30)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(100, 30)
        Me.btnAdicionar.TabIndex = 269
        Me.btnAdicionar.Text = "Adicionar"
        Me.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdicionar.ToolTipHelp = Nothing
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'btnProcurarPaciente
        '
        Me.btnProcurarPaciente.Image = Global.ProjetoTCC.My.Resources.Resources.consultar
        Me.btnProcurarPaciente.Location = New System.Drawing.Point(187, 4)
        Me.btnProcurarPaciente.Name = "btnProcurarPaciente"
        Me.btnProcurarPaciente.Size = New System.Drawing.Size(30, 23)
        Me.btnProcurarPaciente.TabIndex = 265
        Me.btnProcurarPaciente.UseVisualStyleBackColor = True
        '
        'dtgRefeicoes
        '
        Me.dtgRefeicoes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgRefeicoes.BackgroundColor = System.Drawing.Color.White
        Me.dtgRefeicoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgRefeicoes.Location = New System.Drawing.Point(12, 138)
        Me.dtgRefeicoes.Name = "dtgRefeicoes"
        Me.dtgRefeicoes.Size = New System.Drawing.Size(865, 334)
        Me.dtgRefeicoes.TabIndex = 274
        '
        'frmPlanilhaCardapio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 520)
        Me.Controls.Add(Me.dtgRefeicoes)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnAdicionar)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.lblDescricao)
        Me.Controls.Add(Me.btnProcurarPaciente)
        Me.Controls.Add(Me.txtCodPaciente)
        Me.Controls.Add(Me.Label6)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPlanilhaCardapio"
        Me.Text = "Cardápio"
        CType(Me.dtgRefeicoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnProcurarPaciente As Button
    Friend WithEvents txtCodPaciente As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents lblDescricao As Label
    Friend WithEvents btnAdicionar As MvtWindowsForms.ButtonInserir
    Friend WithEvents btnSalvar As Button
    Friend WithEvents dtgRefeicoes As DataGridView
End Class
