<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlimento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAlimento))
        Me.tbAlimento = New System.Windows.Forms.TabControl()
        Me.tbCadastro = New System.Windows.Forms.TabPage()
        Me.tbConsulta = New System.Windows.Forms.TabPage()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.txtCalcio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtVitC = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFerro = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtProteina = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLipidio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCarboidrato = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtQtde = New System.Windows.Forms.TextBox()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.txtKCal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMedidaCaseira = New System.Windows.Forms.TextBox()
        Me.lblMedidaCaseira = New System.Windows.Forms.Label()
        Me.txtAlimento = New System.Windows.Forms.TextBox()
        Me.lblAlimento = New System.Windows.Forms.Label()
        Me.btnProcurarAlimento = New System.Windows.Forms.Button()
        Me.txtCodAlimento = New System.Windows.Forms.TextBox()
        Me.lblCodAlimento = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtAlimentoFiltro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbAlimento.SuspendLayout()
        Me.tbCadastro.SuspendLayout()
        Me.tbConsulta.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbAlimento
        '
        Me.tbAlimento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbAlimento.Controls.Add(Me.tbCadastro)
        Me.tbAlimento.Controls.Add(Me.tbConsulta)
        Me.tbAlimento.Location = New System.Drawing.Point(3, 3)
        Me.tbAlimento.Name = "tbAlimento"
        Me.tbAlimento.SelectedIndex = 0
        Me.tbAlimento.Size = New System.Drawing.Size(681, 412)
        Me.tbAlimento.TabIndex = 0
        '
        'tbCadastro
        '
        Me.tbCadastro.Controls.Add(Me.btnExcluir)
        Me.tbCadastro.Controls.Add(Me.btnSalvar)
        Me.tbCadastro.Controls.Add(Me.txtCalcio)
        Me.tbCadastro.Controls.Add(Me.Label7)
        Me.tbCadastro.Controls.Add(Me.txtVitC)
        Me.tbCadastro.Controls.Add(Me.Label8)
        Me.tbCadastro.Controls.Add(Me.txtFerro)
        Me.tbCadastro.Controls.Add(Me.Label9)
        Me.tbCadastro.Controls.Add(Me.txtProteina)
        Me.tbCadastro.Controls.Add(Me.Label4)
        Me.tbCadastro.Controls.Add(Me.txtLipidio)
        Me.tbCadastro.Controls.Add(Me.Label5)
        Me.tbCadastro.Controls.Add(Me.txtCarboidrato)
        Me.tbCadastro.Controls.Add(Me.Label6)
        Me.tbCadastro.Controls.Add(Me.txtQtde)
        Me.tbCadastro.Controls.Add(Me.lblQuantidade)
        Me.tbCadastro.Controls.Add(Me.txtKCal)
        Me.tbCadastro.Controls.Add(Me.Label2)
        Me.tbCadastro.Controls.Add(Me.txtMedidaCaseira)
        Me.tbCadastro.Controls.Add(Me.lblMedidaCaseira)
        Me.tbCadastro.Controls.Add(Me.txtAlimento)
        Me.tbCadastro.Controls.Add(Me.lblAlimento)
        Me.tbCadastro.Controls.Add(Me.btnProcurarAlimento)
        Me.tbCadastro.Controls.Add(Me.txtCodAlimento)
        Me.tbCadastro.Controls.Add(Me.lblCodAlimento)
        Me.tbCadastro.Location = New System.Drawing.Point(4, 22)
        Me.tbCadastro.Name = "tbCadastro"
        Me.tbCadastro.Padding = New System.Windows.Forms.Padding(3)
        Me.tbCadastro.Size = New System.Drawing.Size(673, 386)
        Me.tbCadastro.TabIndex = 0
        Me.tbCadastro.Text = "Cadastro"
        Me.tbCadastro.UseVisualStyleBackColor = True
        '
        'tbConsulta
        '
        Me.tbConsulta.Controls.Add(Me.Label1)
        Me.tbConsulta.Controls.Add(Me.txtAlimentoFiltro)
        Me.tbConsulta.Controls.Add(Me.DataGridView1)
        Me.tbConsulta.Location = New System.Drawing.Point(4, 22)
        Me.tbConsulta.Name = "tbConsulta"
        Me.tbConsulta.Padding = New System.Windows.Forms.Padding(3)
        Me.tbConsulta.Size = New System.Drawing.Size(673, 386)
        Me.tbConsulta.TabIndex = 1
        Me.tbConsulta.Text = "Consulta"
        Me.tbConsulta.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.Image = Global.ProjetoTCC.My.Resources.Resources.DeleteRed
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcluir.Location = New System.Drawing.Point(578, 350)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(89, 30)
        Me.btnExcluir.TabIndex = 49
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.ProjetoTCC.My.Resources.Resources.mvtSaveGreen_16
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalvar.Location = New System.Drawing.Point(483, 350)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(89, 30)
        Me.btnSalvar.TabIndex = 48
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'txtCalcio
        '
        Me.txtCalcio.Location = New System.Drawing.Point(466, 223)
        Me.txtCalcio.Name = "txtCalcio"
        Me.txtCalcio.Size = New System.Drawing.Size(79, 20)
        Me.txtCalcio.TabIndex = 47
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(370, 226)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Cálcio (mg):"
        '
        'txtVitC
        '
        Me.txtVitC.Location = New System.Drawing.Point(466, 294)
        Me.txtVitC.Name = "txtVitC"
        Me.txtVitC.Size = New System.Drawing.Size(79, 20)
        Me.txtVitC.TabIndex = 45
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(370, 297)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Vitamina C:"
        '
        'txtFerro
        '
        Me.txtFerro.Location = New System.Drawing.Point(466, 258)
        Me.txtFerro.Name = "txtFerro"
        Me.txtFerro.Size = New System.Drawing.Size(79, 20)
        Me.txtFerro.TabIndex = 43
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(370, 261)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Ferro (mg):"
        '
        'txtProteina
        '
        Me.txtProteina.Location = New System.Drawing.Point(466, 120)
        Me.txtProteina.Name = "txtProteina"
        Me.txtProteina.Size = New System.Drawing.Size(79, 20)
        Me.txtProteina.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(370, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Proteína (g):"
        '
        'txtLipidio
        '
        Me.txtLipidio.Location = New System.Drawing.Point(466, 191)
        Me.txtLipidio.Name = "txtLipidio"
        Me.txtLipidio.Size = New System.Drawing.Size(79, 20)
        Me.txtLipidio.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(370, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Lipídio (g):"
        '
        'txtCarboidrato
        '
        Me.txtCarboidrato.Location = New System.Drawing.Point(466, 155)
        Me.txtCarboidrato.Name = "txtCarboidrato"
        Me.txtCarboidrato.Size = New System.Drawing.Size(79, 20)
        Me.txtCarboidrato.TabIndex = 37
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(370, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Carboidrato (g):"
        '
        'txtQtde
        '
        Me.txtQtde.Location = New System.Drawing.Point(102, 152)
        Me.txtQtde.Name = "txtQtde"
        Me.txtQtde.Size = New System.Drawing.Size(79, 20)
        Me.txtQtde.TabIndex = 35
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.Location = New System.Drawing.Point(6, 155)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(62, 13)
        Me.lblQuantidade.TabIndex = 34
        Me.lblQuantidade.Text = "Quantidade"
        '
        'txtKCal
        '
        Me.txtKCal.Location = New System.Drawing.Point(102, 223)
        Me.txtKCal.Name = "txtKCal"
        Me.txtKCal.Size = New System.Drawing.Size(79, 20)
        Me.txtKCal.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 226)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "KCal:"
        '
        'txtMedidaCaseira
        '
        Me.txtMedidaCaseira.Location = New System.Drawing.Point(102, 187)
        Me.txtMedidaCaseira.Name = "txtMedidaCaseira"
        Me.txtMedidaCaseira.Size = New System.Drawing.Size(79, 20)
        Me.txtMedidaCaseira.TabIndex = 31
        '
        'lblMedidaCaseira
        '
        Me.lblMedidaCaseira.AutoSize = True
        Me.lblMedidaCaseira.Location = New System.Drawing.Point(6, 190)
        Me.lblMedidaCaseira.Name = "lblMedidaCaseira"
        Me.lblMedidaCaseira.Size = New System.Drawing.Size(83, 13)
        Me.lblMedidaCaseira.TabIndex = 30
        Me.lblMedidaCaseira.Text = "Medida Caseira:"
        '
        'txtAlimento
        '
        Me.txtAlimento.Location = New System.Drawing.Point(85, 76)
        Me.txtAlimento.Name = "txtAlimento"
        Me.txtAlimento.Size = New System.Drawing.Size(242, 20)
        Me.txtAlimento.TabIndex = 29
        '
        'lblAlimento
        '
        Me.lblAlimento.AutoSize = True
        Me.lblAlimento.Location = New System.Drawing.Point(4, 79)
        Me.lblAlimento.Name = "lblAlimento"
        Me.lblAlimento.Size = New System.Drawing.Size(50, 13)
        Me.lblAlimento.TabIndex = 28
        Me.lblAlimento.Text = "Alimento:"
        '
        'btnProcurarAlimento
        '
        Me.btnProcurarAlimento.Image = Global.ProjetoTCC.My.Resources.Resources.consultar
        Me.btnProcurarAlimento.Location = New System.Drawing.Point(171, 29)
        Me.btnProcurarAlimento.Name = "btnProcurarAlimento"
        Me.btnProcurarAlimento.Size = New System.Drawing.Size(30, 23)
        Me.btnProcurarAlimento.TabIndex = 27
        Me.btnProcurarAlimento.UseVisualStyleBackColor = True
        '
        'txtCodAlimento
        '
        Me.txtCodAlimento.Location = New System.Drawing.Point(86, 31)
        Me.txtCodAlimento.Name = "txtCodAlimento"
        Me.txtCodAlimento.Size = New System.Drawing.Size(79, 20)
        Me.txtCodAlimento.TabIndex = 26
        '
        'lblCodAlimento
        '
        Me.lblCodAlimento.AutoSize = True
        Me.lblCodAlimento.Location = New System.Drawing.Point(5, 34)
        Me.lblCodAlimento.Name = "lblCodAlimento"
        Me.lblCodAlimento.Size = New System.Drawing.Size(75, 13)
        Me.lblCodAlimento.TabIndex = 25
        Me.lblCodAlimento.Text = "Cód. Alimento:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 32)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(661, 348)
        Me.DataGridView1.TabIndex = 0
        '
        'txtAlimentoFiltro
        '
        Me.txtAlimentoFiltro.Location = New System.Drawing.Point(64, 6)
        Me.txtAlimentoFiltro.Name = "txtAlimentoFiltro"
        Me.txtAlimentoFiltro.Size = New System.Drawing.Size(603, 20)
        Me.txtAlimentoFiltro.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Alimento:"
        '
        'frmAlimento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 418)
        Me.Controls.Add(Me.tbAlimento)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAlimento"
        Me.Text = "Alimento"
        Me.tbAlimento.ResumeLayout(False)
        Me.tbCadastro.ResumeLayout(False)
        Me.tbCadastro.PerformLayout()
        Me.tbConsulta.ResumeLayout(False)
        Me.tbConsulta.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbAlimento As TabControl
    Friend WithEvents tbCadastro As TabPage
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents txtCalcio As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtVitC As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtFerro As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtProteina As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLipidio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCarboidrato As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtQtde As TextBox
    Friend WithEvents lblQuantidade As Label
    Friend WithEvents txtKCal As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMedidaCaseira As TextBox
    Friend WithEvents lblMedidaCaseira As Label
    Friend WithEvents txtAlimento As TextBox
    Friend WithEvents lblAlimento As Label
    Friend WithEvents btnProcurarAlimento As Button
    Friend WithEvents txtCodAlimento As TextBox
    Friend WithEvents lblCodAlimento As Label
    Friend WithEvents tbConsulta As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAlimentoFiltro As TextBox
End Class
