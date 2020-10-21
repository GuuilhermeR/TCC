<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroNutricional
    Inherits MvtWindowsForms.MvtForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastroNutricional))
        Me.txtGramas = New MvtWindowsForms.TextBoxNumberWithLabel()
        Me.txtQtde = New MvtWindowsForms.TextBoxNumberWithLabel()
        Me.txtKcal = New MvtWindowsForms.TextBoxNumberWithLabel()
        Me.txtLipidio = New MvtWindowsForms.TextBoxNumberWithLabel()
        Me.txtCarboidrato = New MvtWindowsForms.TextBoxNumberWithLabel()
        Me.txtProteina = New MvtWindowsForms.TextBoxNumberWithLabel()
        Me.btnSalvar = New MvtWindowsForms.ButtonSave()
        Me.txtVitC = New MvtWindowsForms.TextBoxNumberWithLabel()
        Me.txtFerro = New MvtWindowsForms.TextBoxNumberWithLabel()
        Me.txtCalcio = New MvtWindowsForms.TextBoxNumberWithLabel()
        Me.btnConsultar = New MvtWindowsForms.ButtonFind()
        Me.txtAlimento = New MvtWindowsForms.TextBoxStringWithLabel()
        Me.SuspendLayout()
        '
        'txtGramas
        '
        Me.txtGramas.AutoSize = True
        Me.txtGramas.Conexao = Nothing
        Me.txtGramas.ConnectionString = Nothing
        Me.txtGramas.FieldFilter = Nothing
        Me.txtGramas.FieldFind = Nothing
        Me.txtGramas.FieldReturn = Nothing
        Me.txtGramas.FormatCustom = Nothing
        Me.txtGramas.KeepValue = False
        Me.txtGramas.Location = New System.Drawing.Point(12, 70)
        Me.txtGramas.Name = "txtGramas"
        Me.txtGramas.NameExibition = "Gramas:"
        Me.txtGramas.OrderManual = Nothing
        Me.txtGramas.OthersFilters = Nothing
        Me.txtGramas.Size = New System.Drawing.Size(200, 24)
        Me.txtGramas.SizeTextBox = 0
        Me.txtGramas.SQLSelectFind = Nothing
        Me.txtGramas.TabIndex = 1
        Me.txtGramas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtGramas.ToolTipHelp = Nothing
        Me.txtGramas.UseF3 = False
        Me.txtGramas.ValueReturn = Nothing
        Me.txtGramas.ZIniciar = True
        '
        'txtQtde
        '
        Me.txtQtde.AutoSize = True
        Me.txtQtde.Conexao = Nothing
        Me.txtQtde.ConnectionString = Nothing
        Me.txtQtde.FieldFilter = Nothing
        Me.txtQtde.FieldFind = Nothing
        Me.txtQtde.FieldReturn = Nothing
        Me.txtQtde.FormatCustom = Nothing
        Me.txtQtde.KeepValue = False
        Me.txtQtde.Location = New System.Drawing.Point(12, 97)
        Me.txtQtde.Name = "txtQtde"
        Me.txtQtde.NameExibition = "Quantidade:"
        Me.txtQtde.OrderManual = Nothing
        Me.txtQtde.OthersFilters = Nothing
        Me.txtQtde.Size = New System.Drawing.Size(200, 24)
        Me.txtQtde.SizeTextBox = 0
        Me.txtQtde.SQLSelectFind = Nothing
        Me.txtQtde.TabIndex = 3
        Me.txtQtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtQtde.ToolTipHelp = Nothing
        Me.txtQtde.UseF3 = False
        Me.txtQtde.ValueReturn = Nothing
        Me.txtQtde.ZIniciar = True
        '
        'txtKcal
        '
        Me.txtKcal.AutoSize = True
        Me.txtKcal.Conexao = Nothing
        Me.txtKcal.ConnectionString = Nothing
        Me.txtKcal.FieldFilter = Nothing
        Me.txtKcal.FieldFind = Nothing
        Me.txtKcal.FieldReturn = Nothing
        Me.txtKcal.FormatCustom = Nothing
        Me.txtKcal.KeepValue = False
        Me.txtKcal.Location = New System.Drawing.Point(12, 124)
        Me.txtKcal.Name = "txtKcal"
        Me.txtKcal.NameExibition = "Kcal:"
        Me.txtKcal.OrderManual = Nothing
        Me.txtKcal.OthersFilters = Nothing
        Me.txtKcal.Size = New System.Drawing.Size(200, 24)
        Me.txtKcal.SizeTextBox = 0
        Me.txtKcal.SQLSelectFind = Nothing
        Me.txtKcal.TabIndex = 4
        Me.txtKcal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtKcal.ToolTipHelp = Nothing
        Me.txtKcal.UseF3 = False
        Me.txtKcal.ValueReturn = Nothing
        Me.txtKcal.ZIniciar = True
        '
        'txtLipidio
        '
        Me.txtLipidio.AutoSize = True
        Me.txtLipidio.Conexao = Nothing
        Me.txtLipidio.ConnectionString = Nothing
        Me.txtLipidio.FieldFilter = Nothing
        Me.txtLipidio.FieldFind = Nothing
        Me.txtLipidio.FieldReturn = Nothing
        Me.txtLipidio.FormatCustom = Nothing
        Me.txtLipidio.KeepValue = False
        Me.txtLipidio.Location = New System.Drawing.Point(243, 114)
        Me.txtLipidio.Name = "txtLipidio"
        Me.txtLipidio.NameExibition = "Lipídio (g):"
        Me.txtLipidio.OrderManual = Nothing
        Me.txtLipidio.OthersFilters = Nothing
        Me.txtLipidio.Size = New System.Drawing.Size(200, 24)
        Me.txtLipidio.SizeTextBox = 0
        Me.txtLipidio.SQLSelectFind = Nothing
        Me.txtLipidio.TabIndex = 7
        Me.txtLipidio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtLipidio.ToolTipHelp = Nothing
        Me.txtLipidio.UseF3 = False
        Me.txtLipidio.ValueReturn = Nothing
        Me.txtLipidio.ZIniciar = True
        '
        'txtCarboidrato
        '
        Me.txtCarboidrato.AutoSize = True
        Me.txtCarboidrato.Conexao = Nothing
        Me.txtCarboidrato.ConnectionString = Nothing
        Me.txtCarboidrato.FieldFilter = Nothing
        Me.txtCarboidrato.FieldFind = Nothing
        Me.txtCarboidrato.FieldReturn = Nothing
        Me.txtCarboidrato.FormatCustom = Nothing
        Me.txtCarboidrato.KeepValue = False
        Me.txtCarboidrato.Location = New System.Drawing.Point(243, 87)
        Me.txtCarboidrato.Name = "txtCarboidrato"
        Me.txtCarboidrato.NameExibition = "Carboidrato (g):"
        Me.txtCarboidrato.OrderManual = Nothing
        Me.txtCarboidrato.OthersFilters = Nothing
        Me.txtCarboidrato.Size = New System.Drawing.Size(200, 24)
        Me.txtCarboidrato.SizeTextBox = 0
        Me.txtCarboidrato.SQLSelectFind = Nothing
        Me.txtCarboidrato.TabIndex = 6
        Me.txtCarboidrato.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtCarboidrato.ToolTipHelp = Nothing
        Me.txtCarboidrato.UseF3 = False
        Me.txtCarboidrato.ValueReturn = Nothing
        Me.txtCarboidrato.ZIniciar = True
        '
        'txtProteina
        '
        Me.txtProteina.AutoSize = True
        Me.txtProteina.Conexao = Nothing
        Me.txtProteina.ConnectionString = Nothing
        Me.txtProteina.FieldFilter = Nothing
        Me.txtProteina.FieldFind = Nothing
        Me.txtProteina.FieldReturn = Nothing
        Me.txtProteina.FormatCustom = Nothing
        Me.txtProteina.KeepValue = False
        Me.txtProteina.Location = New System.Drawing.Point(243, 60)
        Me.txtProteina.Name = "txtProteina"
        Me.txtProteina.NameExibition = "Proteína (g):"
        Me.txtProteina.OrderManual = Nothing
        Me.txtProteina.OthersFilters = Nothing
        Me.txtProteina.Size = New System.Drawing.Size(200, 24)
        Me.txtProteina.SizeTextBox = 0
        Me.txtProteina.SQLSelectFind = Nothing
        Me.txtProteina.TabIndex = 5
        Me.txtProteina.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtProteina.ToolTipHelp = Nothing
        Me.txtProteina.UseF3 = False
        Me.txtProteina.ValueReturn = Nothing
        Me.txtProteina.ZIniciar = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.Location = New System.Drawing.Point(343, 248)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(100, 31)
        Me.btnSalvar.TabIndex = 9
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvar.ToolTipHelp = Nothing
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'txtVitC
        '
        Me.txtVitC.AutoSize = True
        Me.txtVitC.Conexao = Nothing
        Me.txtVitC.ConnectionString = Nothing
        Me.txtVitC.FieldFilter = Nothing
        Me.txtVitC.FieldFind = Nothing
        Me.txtVitC.FieldReturn = Nothing
        Me.txtVitC.FormatCustom = Nothing
        Me.txtVitC.KeepValue = False
        Me.txtVitC.Location = New System.Drawing.Point(243, 195)
        Me.txtVitC.Name = "txtVitC"
        Me.txtVitC.NameExibition = "Vit. C (mg):"
        Me.txtVitC.OrderManual = Nothing
        Me.txtVitC.OthersFilters = Nothing
        Me.txtVitC.Size = New System.Drawing.Size(200, 24)
        Me.txtVitC.SizeTextBox = 0
        Me.txtVitC.SQLSelectFind = Nothing
        Me.txtVitC.TabIndex = 10
        Me.txtVitC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtVitC.ToolTipHelp = Nothing
        Me.txtVitC.UseF3 = False
        Me.txtVitC.ValueReturn = Nothing
        Me.txtVitC.ZIniciar = True
        '
        'txtFerro
        '
        Me.txtFerro.AutoSize = True
        Me.txtFerro.Conexao = Nothing
        Me.txtFerro.ConnectionString = Nothing
        Me.txtFerro.FieldFilter = Nothing
        Me.txtFerro.FieldFind = Nothing
        Me.txtFerro.FieldReturn = Nothing
        Me.txtFerro.FormatCustom = Nothing
        Me.txtFerro.KeepValue = False
        Me.txtFerro.Location = New System.Drawing.Point(243, 168)
        Me.txtFerro.Name = "txtFerro"
        Me.txtFerro.NameExibition = "Ferro (mg):"
        Me.txtFerro.OrderManual = Nothing
        Me.txtFerro.OthersFilters = Nothing
        Me.txtFerro.Size = New System.Drawing.Size(200, 24)
        Me.txtFerro.SizeTextBox = 0
        Me.txtFerro.SQLSelectFind = Nothing
        Me.txtFerro.TabIndex = 9
        Me.txtFerro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtFerro.ToolTipHelp = Nothing
        Me.txtFerro.UseF3 = False
        Me.txtFerro.ValueReturn = Nothing
        Me.txtFerro.ZIniciar = True
        '
        'txtCalcio
        '
        Me.txtCalcio.AutoSize = True
        Me.txtCalcio.Conexao = Nothing
        Me.txtCalcio.ConnectionString = Nothing
        Me.txtCalcio.FieldFilter = Nothing
        Me.txtCalcio.FieldFind = Nothing
        Me.txtCalcio.FieldReturn = Nothing
        Me.txtCalcio.FormatCustom = Nothing
        Me.txtCalcio.KeepValue = False
        Me.txtCalcio.Location = New System.Drawing.Point(243, 141)
        Me.txtCalcio.Name = "txtCalcio"
        Me.txtCalcio.NameExibition = "Cálcio (mg):"
        Me.txtCalcio.OrderManual = Nothing
        Me.txtCalcio.OthersFilters = Nothing
        Me.txtCalcio.Size = New System.Drawing.Size(200, 24)
        Me.txtCalcio.SizeTextBox = 0
        Me.txtCalcio.SQLSelectFind = Nothing
        Me.txtCalcio.TabIndex = 8
        Me.txtCalcio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtCalcio.ToolTipHelp = Nothing
        Me.txtCalcio.UseF3 = False
        Me.txtCalcio.ValueReturn = Nothing
        Me.txtCalcio.ZIniciar = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Image = CType(resources.GetObject("btnConsultar.Image"), System.Drawing.Image)
        Me.btnConsultar.Location = New System.Drawing.Point(1, 248)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(100, 31)
        Me.btnConsultar.TabIndex = 11
        Me.btnConsultar.Text = "ButtonFind1"
        Me.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConsultar.ToolTipHelp = Nothing
        Me.btnConsultar.UseVisualStyleBackColor = True
        Me.btnConsultar.Visible = False
        Me.btnConsultar.WaitText = "Aguarde... " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Estamos salvando as informações..."
        '
        'txtAlimento
        '
        Me.txtAlimento.AutoSize = True
        Me.txtAlimento.Conexao = Nothing
        Me.txtAlimento.ConnectionString = Nothing
        Me.txtAlimento.FieldFilter = Nothing
        Me.txtAlimento.FieldFind = Nothing
        Me.txtAlimento.FieldReturn = Nothing
        Me.txtAlimento.KeepValue = False
        Me.txtAlimento.LCaseText = False
        Me.txtAlimento.Location = New System.Drawing.Point(12, 12)
        Me.txtAlimento.Name = "txtAlimento"
        Me.txtAlimento.NameExibition = "Alimento:"
        Me.txtAlimento.OrderManual = Nothing
        Me.txtAlimento.OthersFilters = Nothing
        Me.txtAlimento.Size = New System.Drawing.Size(353, 24)
        Me.txtAlimento.SizeTextBox = 250
        Me.txtAlimento.SQLSelectFind = Nothing
        Me.txtAlimento.TabIndex = 8
        Me.txtAlimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtAlimento.ToolTipHelp = Nothing
        Me.txtAlimento.UCaseFirstCharText = False
        Me.txtAlimento.UCaseText = False
        Me.txtAlimento.UseF3 = False
        Me.txtAlimento.ValueReturn = Nothing
        Me.txtAlimento.ZIniciar = True
        '
        'frmCadastroNutricional
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(455, 291)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.txtVitC)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.txtFerro)
        Me.Controls.Add(Me.txtCalcio)
        Me.Controls.Add(Me.txtAlimento)
        Me.Controls.Add(Me.txtLipidio)
        Me.Controls.Add(Me.txtCarboidrato)
        Me.Controls.Add(Me.txtKcal)
        Me.Controls.Add(Me.txtProteina)
        Me.Controls.Add(Me.txtQtde)
        Me.Controls.Add(Me.txtGramas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCadastroNutricional"
        Me.Text = "Cadastro Nutricional"
        Me.Controls.SetChildIndex(Me.txtGramas, 0)
        Me.Controls.SetChildIndex(Me.txtQtde, 0)
        Me.Controls.SetChildIndex(Me.txtProteina, 0)
        Me.Controls.SetChildIndex(Me.txtKcal, 0)
        Me.Controls.SetChildIndex(Me.txtCarboidrato, 0)
        Me.Controls.SetChildIndex(Me.txtLipidio, 0)
        Me.Controls.SetChildIndex(Me.txtAlimento, 0)
        Me.Controls.SetChildIndex(Me.txtCalcio, 0)
        Me.Controls.SetChildIndex(Me.txtFerro, 0)
        Me.Controls.SetChildIndex(Me.btnSalvar, 0)
        Me.Controls.SetChildIndex(Me.txtVitC, 0)
        Me.Controls.SetChildIndex(Me.btnConsultar, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtGramas As MvtWindowsForms.TextBoxNumberWithLabel
    Friend WithEvents txtQtde As MvtWindowsForms.TextBoxNumberWithLabel
    Friend WithEvents txtKcal As MvtWindowsForms.TextBoxNumberWithLabel
    Friend WithEvents txtLipidio As MvtWindowsForms.TextBoxNumberWithLabel
    Friend WithEvents txtCarboidrato As MvtWindowsForms.TextBoxNumberWithLabel
    Friend WithEvents txtProteina As MvtWindowsForms.TextBoxNumberWithLabel
    Friend WithEvents btnSalvar As MvtWindowsForms.ButtonSave
    Friend WithEvents txtVitC As MvtWindowsForms.TextBoxNumberWithLabel
    Friend WithEvents txtFerro As MvtWindowsForms.TextBoxNumberWithLabel
    Friend WithEvents txtCalcio As MvtWindowsForms.TextBoxNumberWithLabel
    Friend WithEvents btnConsultar As MvtWindowsForms.ButtonFind
    Friend WithEvents txtAlimento As MvtWindowsForms.TextBoxStringWithLabel
End Class
