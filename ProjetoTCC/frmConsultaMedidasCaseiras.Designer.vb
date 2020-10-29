<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaMedidasCaseiras
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaMedidasCaseiras))
        Me.dtgMedidasCaseiras = New MvtWindowsForms.MvtDataGridView()
        Me.btnConsultar = New MvtWindowsForms.ButtonFind()
        Me.gbxImprimir = New MvtWindowsForms.MvtDataGridViewPrinter()
        Me.txtCodAlimento = New MvtWindowsForms.TextBoxNumberWithLabel()
        Me.btnRecalcular = New MvtWindowsForms.ButtonConfig()
        CType(Me.dtgMedidasCaseiras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgMedidasCaseiras
        '
        Me.dtgMedidasCaseiras.AllowUserToAddRows = False
        Me.dtgMedidasCaseiras.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgMedidasCaseiras.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dtgMedidasCaseiras.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtgMedidasCaseiras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgMedidasCaseiras.Location = New System.Drawing.Point(12, 105)
        Me.dtgMedidasCaseiras.Name = "dtgMedidasCaseiras"
        Me.dtgMedidasCaseiras.RowHeadersWidth = 20
        Me.dtgMedidasCaseiras.Size = New System.Drawing.Size(877, 420)
        Me.dtgMedidasCaseiras.TabIndex = 2
        Me.dtgMedidasCaseiras.ValidateFormattedColumns = False
        '
        'btnConsultar
        '
        Me.btnConsultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConsultar.Image = CType(resources.GetObject("btnConsultar.Image"), System.Drawing.Image)
        Me.btnConsultar.Location = New System.Drawing.Point(789, 68)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(100, 31)
        Me.btnConsultar.TabIndex = 1
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConsultar.ToolTipHelp = Nothing
        Me.btnConsultar.UseVisualStyleBackColor = True
        Me.btnConsultar.WaitText = "Aguarde enquanto buscamos seus dados ...."
        '
        'gbxImprimir
        '
        Me.gbxImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxImprimir.Location = New System.Drawing.Point(789, 12)
        Me.gbxImprimir.MinimumSize = New System.Drawing.Size(100, 50)
        Me.gbxImprimir.Name = "gbxImprimir"
        Me.gbxImprimir.Size = New System.Drawing.Size(100, 50)
        Me.gbxImprimir.TabIndex = 4
        Me.gbxImprimir.TabStop = False
        Me.gbxImprimir.Tag = "Imprimir"
        Me.gbxImprimir.Text = "Imprimir"
        '
        'txtCodAlimento
        '
        Me.txtCodAlimento.AutoSize = True
        Me.txtCodAlimento.Conexao = Nothing
        Me.txtCodAlimento.ConnectionString = Nothing
        Me.txtCodAlimento.FieldFilter = "Alimento"
        Me.txtCodAlimento.FieldFind = "Alimento"
        Me.txtCodAlimento.FieldReturn = "codAlimento"
        Me.txtCodAlimento.FormatCustom = Nothing
        Me.txtCodAlimento.KeepValue = False
        Me.txtCodAlimento.Location = New System.Drawing.Point(12, 12)
        Me.txtCodAlimento.Name = "txtCodAlimento"
        Me.txtCodAlimento.NameExibition = "Alimento:"
        Me.txtCodAlimento.OrderManual = Nothing
        Me.txtCodAlimento.OthersFilters = Nothing
        Me.txtCodAlimento.Size = New System.Drawing.Size(204, 24)
        Me.txtCodAlimento.SizeTextBox = 0
        Me.txtCodAlimento.SQLSelectFind = "SELECT codAlimento, Alimento FROM InfosAlimentosNutricionais"
        Me.txtCodAlimento.TabIndex = 0
        Me.txtCodAlimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtCodAlimento.ToolTipHelp = Nothing
        Me.txtCodAlimento.UseF3 = True
        Me.txtCodAlimento.ValueReturn = Nothing
        Me.txtCodAlimento.ZIniciar = True
        '
        'btnRecalcular
        '
        Me.btnRecalcular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRecalcular.Image = CType(resources.GetObject("btnRecalcular.Image"), System.Drawing.Image)
        Me.btnRecalcular.Location = New System.Drawing.Point(789, 531)
        Me.btnRecalcular.Name = "btnRecalcular"
        Me.btnRecalcular.Size = New System.Drawing.Size(100, 31)
        Me.btnRecalcular.TabIndex = 3
        Me.btnRecalcular.Text = "Recalcular"
        Me.btnRecalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRecalcular.ToolTipHelp = Nothing
        Me.btnRecalcular.UseVisualStyleBackColor = True
        '
        'frmConsultaMedidasCaseiras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(901, 574)
        Me.Controls.Add(Me.btnRecalcular)
        Me.Controls.Add(Me.txtCodAlimento)
        Me.Controls.Add(Me.gbxImprimir)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.dtgMedidasCaseiras)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConsultaMedidasCaseiras"
        Me.Text = "Consulta de Medidas Caseiras"
        Me.Controls.SetChildIndex(Me.dtgMedidasCaseiras, 0)
        Me.Controls.SetChildIndex(Me.btnConsultar, 0)
        Me.Controls.SetChildIndex(Me.gbxImprimir, 0)
        Me.Controls.SetChildIndex(Me.txtCodAlimento, 0)
        Me.Controls.SetChildIndex(Me.btnRecalcular, 0)
        CType(Me.dtgMedidasCaseiras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtgMedidasCaseiras As MvtWindowsForms.MvtDataGridView
    Friend WithEvents btnConsultar As MvtWindowsForms.ButtonFind
    Friend WithEvents gbxImprimir As MvtWindowsForms.MvtDataGridViewPrinter
    Friend WithEvents txtCodAlimento As MvtWindowsForms.TextBoxNumberWithLabel
    Friend WithEvents btnRecalcular As MvtWindowsForms.ButtonConfig
End Class
