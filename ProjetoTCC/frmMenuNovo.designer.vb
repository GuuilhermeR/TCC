<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuNovo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuNovo))
        Me.PanelChildForm = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.panelLogo = New System.Windows.Forms.Panel()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCadastrar = New System.Windows.Forms.Button()
        Me.PanelMediaSubmenu = New System.Windows.Forms.Panel()
        Me.btnCadPaciente = New System.Windows.Forms.Button()
        Me.btnCardapio = New System.Windows.Forms.Button()
        Me.btnCadastrarAlimento = New System.Windows.Forms.Button()
        Me.PanelPlaylistSubmenu = New System.Windows.Forms.Panel()
        Me.btnPaciente = New System.Windows.Forms.Button()
        Me.btnConsCardápio = New System.Windows.Forms.Button()
        Me.button8 = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PanelSideMenu = New System.Windows.Forms.Panel()
        Me.btnConfigurações = New System.Windows.Forms.Button()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.PanelChildForm.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelLogo.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMediaSubmenu.SuspendLayout()
        Me.PanelPlaylistSubmenu.SuspendLayout()
        Me.PanelSideMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelChildForm
        '
        Me.PanelChildForm.BackColor = System.Drawing.Color.Transparent
        Me.PanelChildForm.Controls.Add(Me.PictureBox2)
        Me.PanelChildForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelChildForm.Location = New System.Drawing.Point(250, 0)
        Me.PanelChildForm.Name = "PanelChildForm"
        Me.PanelChildForm.Size = New System.Drawing.Size(878, 749)
        Me.PanelChildForm.TabIndex = 3
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = Global.ProjetoTCC.My.Resources.Resources.iconTCC_removebg_preview__1____Copia
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(878, 749)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'panelLogo
        '
        Me.panelLogo.BackColor = System.Drawing.Color.GreenYellow
        Me.panelLogo.Controls.Add(Me.pictureBox1)
        Me.panelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelLogo.Location = New System.Drawing.Point(0, 0)
        Me.panelLogo.Name = "panelLogo"
        Me.panelLogo.Size = New System.Drawing.Size(250, 92)
        Me.panelLogo.TabIndex = 0
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = Global.ProjetoTCC.My.Resources.Resources.iconTCC_removebg_preview__1____Copia
        Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(250, 92)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 0
        Me.pictureBox1.TabStop = False
        '
        'btnCadastrar
        '
        Me.btnCadastrar.BackColor = System.Drawing.Color.Green
        Me.btnCadastrar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCadastrar.FlatAppearance.BorderSize = 0
        Me.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnCadastrar.ForeColor = System.Drawing.Color.Black
        Me.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCadastrar.Location = New System.Drawing.Point(0, 92)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnCadastrar.Size = New System.Drawing.Size(250, 57)
        Me.btnCadastrar.TabIndex = 1
        Me.btnCadastrar.Text = "  Cadastrar"
        Me.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCadastrar.UseVisualStyleBackColor = False
        '
        'PanelMediaSubmenu
        '
        Me.PanelMediaSubmenu.BackColor = System.Drawing.Color.GreenYellow
        Me.PanelMediaSubmenu.Controls.Add(Me.btnCadPaciente)
        Me.PanelMediaSubmenu.Controls.Add(Me.btnCardapio)
        Me.PanelMediaSubmenu.Controls.Add(Me.btnCadastrarAlimento)
        Me.PanelMediaSubmenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMediaSubmenu.Location = New System.Drawing.Point(0, 149)
        Me.PanelMediaSubmenu.Name = "PanelMediaSubmenu"
        Me.PanelMediaSubmenu.Size = New System.Drawing.Size(250, 165)
        Me.PanelMediaSubmenu.TabIndex = 2
        '
        'btnCadPaciente
        '
        Me.btnCadPaciente.BackColor = System.Drawing.Color.LimeGreen
        Me.btnCadPaciente.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCadPaciente.FlatAppearance.BorderSize = 0
        Me.btnCadPaciente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnCadPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnCadPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadPaciente.ForeColor = System.Drawing.Color.Black
        Me.btnCadPaciente.Location = New System.Drawing.Point(0, 80)
        Me.btnCadPaciente.Name = "btnCadPaciente"
        Me.btnCadPaciente.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnCadPaciente.Size = New System.Drawing.Size(250, 40)
        Me.btnCadPaciente.TabIndex = 2
        Me.btnCadPaciente.Text = "Paciente"
        Me.btnCadPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCadPaciente.UseVisualStyleBackColor = False
        '
        'btnCardapio
        '
        Me.btnCardapio.BackColor = System.Drawing.Color.LimeGreen
        Me.btnCardapio.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCardapio.FlatAppearance.BorderSize = 0
        Me.btnCardapio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnCardapio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnCardapio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCardapio.ForeColor = System.Drawing.Color.Black
        Me.btnCardapio.Location = New System.Drawing.Point(0, 40)
        Me.btnCardapio.Name = "btnCardapio"
        Me.btnCardapio.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnCardapio.Size = New System.Drawing.Size(250, 40)
        Me.btnCardapio.TabIndex = 1
        Me.btnCardapio.Text = "Cardápio"
        Me.btnCardapio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCardapio.UseVisualStyleBackColor = False
        '
        'btnCadastrarAlimento
        '
        Me.btnCadastrarAlimento.BackColor = System.Drawing.Color.LimeGreen
        Me.btnCadastrarAlimento.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCadastrarAlimento.FlatAppearance.BorderSize = 0
        Me.btnCadastrarAlimento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnCadastrarAlimento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnCadastrarAlimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarAlimento.ForeColor = System.Drawing.Color.Black
        Me.btnCadastrarAlimento.Location = New System.Drawing.Point(0, 0)
        Me.btnCadastrarAlimento.Name = "btnCadastrarAlimento"
        Me.btnCadastrarAlimento.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnCadastrarAlimento.Size = New System.Drawing.Size(250, 40)
        Me.btnCadastrarAlimento.TabIndex = 0
        Me.btnCadastrarAlimento.Text = "Alimentos"
        Me.btnCadastrarAlimento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCadastrarAlimento.UseVisualStyleBackColor = False
        '
        'PanelPlaylistSubmenu
        '
        Me.PanelPlaylistSubmenu.BackColor = System.Drawing.Color.GreenYellow
        Me.PanelPlaylistSubmenu.Controls.Add(Me.btnPaciente)
        Me.PanelPlaylistSubmenu.Controls.Add(Me.btnConsCardápio)
        Me.PanelPlaylistSubmenu.Controls.Add(Me.button8)
        Me.PanelPlaylistSubmenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelPlaylistSubmenu.Location = New System.Drawing.Point(0, 379)
        Me.PanelPlaylistSubmenu.Name = "PanelPlaylistSubmenu"
        Me.PanelPlaylistSubmenu.Size = New System.Drawing.Size(250, 119)
        Me.PanelPlaylistSubmenu.TabIndex = 4
        '
        'btnPaciente
        '
        Me.btnPaciente.BackColor = System.Drawing.Color.LimeGreen
        Me.btnPaciente.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPaciente.FlatAppearance.BorderSize = 0
        Me.btnPaciente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPaciente.ForeColor = System.Drawing.Color.Black
        Me.btnPaciente.Location = New System.Drawing.Point(0, 80)
        Me.btnPaciente.Name = "btnPaciente"
        Me.btnPaciente.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnPaciente.Size = New System.Drawing.Size(250, 40)
        Me.btnPaciente.TabIndex = 2
        Me.btnPaciente.Text = "Paciente"
        Me.btnPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPaciente.UseVisualStyleBackColor = False
        '
        'btnConsCardápio
        '
        Me.btnConsCardápio.BackColor = System.Drawing.Color.LimeGreen
        Me.btnConsCardápio.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConsCardápio.FlatAppearance.BorderSize = 0
        Me.btnConsCardápio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnConsCardápio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnConsCardápio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsCardápio.ForeColor = System.Drawing.Color.Black
        Me.btnConsCardápio.Location = New System.Drawing.Point(0, 40)
        Me.btnConsCardápio.Name = "btnConsCardápio"
        Me.btnConsCardápio.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnConsCardápio.Size = New System.Drawing.Size(250, 40)
        Me.btnConsCardápio.TabIndex = 1
        Me.btnConsCardápio.Text = "Cardápio"
        Me.btnConsCardápio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsCardápio.UseVisualStyleBackColor = False
        '
        'button8
        '
        Me.button8.BackColor = System.Drawing.Color.LimeGreen
        Me.button8.Dock = System.Windows.Forms.DockStyle.Top
        Me.button8.FlatAppearance.BorderSize = 0
        Me.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button8.ForeColor = System.Drawing.Color.Black
        Me.button8.Location = New System.Drawing.Point(0, 0)
        Me.button8.Name = "button8"
        Me.button8.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.button8.Size = New System.Drawing.Size(250, 40)
        Me.button8.TabIndex = 0
        Me.button8.Text = "Alimentos"
        Me.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button8.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Green
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(0, 704)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnExit.Size = New System.Drawing.Size(250, 45)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "  Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'PanelSideMenu
        '
        Me.PanelSideMenu.AutoScroll = True
        Me.PanelSideMenu.BackColor = System.Drawing.Color.GreenYellow
        Me.PanelSideMenu.Controls.Add(Me.btnConfigurações)
        Me.PanelSideMenu.Controls.Add(Me.btnExit)
        Me.PanelSideMenu.Controls.Add(Me.PanelPlaylistSubmenu)
        Me.PanelSideMenu.Controls.Add(Me.btnConsultar)
        Me.PanelSideMenu.Controls.Add(Me.PanelMediaSubmenu)
        Me.PanelSideMenu.Controls.Add(Me.btnCadastrar)
        Me.PanelSideMenu.Controls.Add(Me.panelLogo)
        Me.PanelSideMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelSideMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelSideMenu.Name = "PanelSideMenu"
        Me.PanelSideMenu.Size = New System.Drawing.Size(250, 749)
        Me.PanelSideMenu.TabIndex = 0
        '
        'btnConfigurações
        '
        Me.btnConfigurações.BackColor = System.Drawing.Color.Green
        Me.btnConfigurações.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnConfigurações.FlatAppearance.BorderSize = 0
        Me.btnConfigurações.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnConfigurações.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnConfigurações.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurações.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnConfigurações.ForeColor = System.Drawing.Color.Black
        Me.btnConfigurações.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfigurações.Location = New System.Drawing.Point(0, 659)
        Me.btnConfigurações.Name = "btnConfigurações"
        Me.btnConfigurações.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnConfigurações.Size = New System.Drawing.Size(250, 45)
        Me.btnConfigurações.TabIndex = 10
        Me.btnConfigurações.Text = "Configurações"
        Me.btnConfigurações.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfigurações.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConfigurações.UseVisualStyleBackColor = False
        '
        'btnConsultar
        '
        Me.btnConsultar.BackColor = System.Drawing.Color.Green
        Me.btnConsultar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConsultar.FlatAppearance.BorderSize = 0
        Me.btnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnConsultar.ForeColor = System.Drawing.Color.Black
        Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultar.Location = New System.Drawing.Point(0, 314)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnConsultar.Size = New System.Drawing.Size(250, 65)
        Me.btnConsultar.TabIndex = 3
        Me.btnConsultar.Text = "  Consultar"
        Me.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConsultar.UseVisualStyleBackColor = False
        '
        'frmMenuNovo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1128, 749)
        Me.Controls.Add(Me.PanelChildForm)
        Me.Controls.Add(Me.PanelSideMenu)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(950, 600)
        Me.Name = "frmMenuNovo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal"
        Me.PanelChildForm.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelLogo.ResumeLayout(False)
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMediaSubmenu.ResumeLayout(False)
        Me.PanelPlaylistSubmenu.ResumeLayout(False)
        Me.PanelSideMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelChildForm As Panel
    Private WithEvents PictureBox2 As PictureBox
    Private WithEvents panelLogo As Panel
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents btnCadastrar As Button
    Private WithEvents PanelMediaSubmenu As Panel
    Private WithEvents btnCadPaciente As Button
    Private WithEvents btnCardapio As Button
    Private WithEvents btnCadastrarAlimento As Button
    Private WithEvents PanelPlaylistSubmenu As Panel
    Private WithEvents btnPaciente As Button
    Private WithEvents btnConsCardápio As Button
    Private WithEvents button8 As Button
    Private WithEvents btnExit As Button
    Private WithEvents PanelSideMenu As Panel
    Private WithEvents btnConfigurações As Button
    Private WithEvents btnConsultar As Button
End Class
