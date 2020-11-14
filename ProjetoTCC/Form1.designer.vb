<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.panelLogo = New System.Windows.Forms.Panel()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.button5 = New System.Windows.Forms.Button()
        Me.btnCadPaciente = New System.Windows.Forms.Button()
        Me.btnCardapio = New System.Windows.Forms.Button()
        Me.btnCadastrarAlimento = New System.Windows.Forms.Button()
        Me.PanelSideMenu = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.PanelToolsSubmenu = New System.Windows.Forms.Panel()
        Me.button10 = New System.Windows.Forms.Button()
        Me.button12 = New System.Windows.Forms.Button()
        Me.button13 = New System.Windows.Forms.Button()
        Me.btnTools = New System.Windows.Forms.Button()
        Me.btnEqualizer = New System.Windows.Forms.Button()
        Me.PanelPlaylistSubmenu = New System.Windows.Forms.Panel()
        Me.button1 = New System.Windows.Forms.Button()
        Me.btnPaciente = New System.Windows.Forms.Button()
        Me.btnConsCardápio = New System.Windows.Forms.Button()
        Me.button8 = New System.Windows.Forms.Button()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.PanelMediaSubmenu = New System.Windows.Forms.Panel()
        Me.btnCadastrar = New System.Windows.Forms.Button()
        Me.PanelChildForm = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.panelLogo.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSideMenu.SuspendLayout()
        Me.PanelToolsSubmenu.SuspendLayout()
        Me.PanelPlaylistSubmenu.SuspendLayout()
        Me.PanelMediaSubmenu.SuspendLayout()
        Me.PanelChildForm.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelLogo
        '
        Me.panelLogo.BackColor = System.Drawing.Color.GreenYellow
        Me.panelLogo.Controls.Add(Me.pictureBox1)
        Me.panelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelLogo.Location = New System.Drawing.Point(0, 0)
        Me.panelLogo.Name = "panelLogo"
        Me.panelLogo.Size = New System.Drawing.Size(233, 92)
        Me.panelLogo.TabIndex = 0
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = Global.ProjetoTCC.My.Resources.Resources.iconTCC_removebg_preview__1____Copia
        Me.pictureBox1.Location = New System.Drawing.Point(35, 9)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(171, 77)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 0
        Me.pictureBox1.TabStop = False
        '
        'button5
        '
        Me.button5.BackColor = System.Drawing.Color.LimeGreen
        Me.button5.Dock = System.Windows.Forms.DockStyle.Top
        Me.button5.FlatAppearance.BorderSize = 0
        Me.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button5.ForeColor = System.Drawing.Color.Silver
        Me.button5.Location = New System.Drawing.Point(0, 120)
        Me.button5.Name = "button5"
        Me.button5.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.button5.Size = New System.Drawing.Size(233, 40)
        Me.button5.TabIndex = 3
        Me.button5.Text = "Open recent media"
        Me.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button5.UseVisualStyleBackColor = False
        '
        'btnCadPaciente
        '
        Me.btnCadPaciente.BackColor = System.Drawing.Color.LimeGreen
        Me.btnCadPaciente.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCadPaciente.FlatAppearance.BorderSize = 0
        Me.btnCadPaciente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnCadPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnCadPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadPaciente.ForeColor = System.Drawing.Color.Silver
        Me.btnCadPaciente.Location = New System.Drawing.Point(0, 80)
        Me.btnCadPaciente.Name = "btnCadPaciente"
        Me.btnCadPaciente.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnCadPaciente.Size = New System.Drawing.Size(233, 40)
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
        Me.btnCardapio.ForeColor = System.Drawing.Color.Silver
        Me.btnCardapio.Location = New System.Drawing.Point(0, 40)
        Me.btnCardapio.Name = "btnCardapio"
        Me.btnCardapio.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnCardapio.Size = New System.Drawing.Size(233, 40)
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
        Me.btnCadastrarAlimento.ForeColor = System.Drawing.Color.Silver
        Me.btnCadastrarAlimento.Location = New System.Drawing.Point(0, 0)
        Me.btnCadastrarAlimento.Name = "btnCadastrarAlimento"
        Me.btnCadastrarAlimento.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnCadastrarAlimento.Size = New System.Drawing.Size(233, 40)
        Me.btnCadastrarAlimento.TabIndex = 0
        Me.btnCadastrarAlimento.Text = "Alimentos"
        Me.btnCadastrarAlimento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCadastrarAlimento.UseVisualStyleBackColor = False
        '
        'PanelSideMenu
        '
        Me.PanelSideMenu.AutoScroll = True
        Me.PanelSideMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.PanelSideMenu.Controls.Add(Me.btnExit)
        Me.PanelSideMenu.Controls.Add(Me.btnHelp)
        Me.PanelSideMenu.Controls.Add(Me.PanelToolsSubmenu)
        Me.PanelSideMenu.Controls.Add(Me.btnTools)
        Me.PanelSideMenu.Controls.Add(Me.btnEqualizer)
        Me.PanelSideMenu.Controls.Add(Me.PanelPlaylistSubmenu)
        Me.PanelSideMenu.Controls.Add(Me.btnConsultar)
        Me.PanelSideMenu.Controls.Add(Me.PanelMediaSubmenu)
        Me.PanelSideMenu.Controls.Add(Me.btnCadastrar)
        Me.PanelSideMenu.Controls.Add(Me.panelLogo)
        Me.PanelSideMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelSideMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelSideMenu.Name = "PanelSideMenu"
        Me.PanelSideMenu.Size = New System.Drawing.Size(250, 561)
        Me.PanelSideMenu.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Green
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.ForeColor = System.Drawing.Color.Silver
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(0, 777)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnExit.Size = New System.Drawing.Size(233, 45)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "  Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.Green
        Me.btnHelp.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnHelp.FlatAppearance.BorderSize = 0
        Me.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.ForeColor = System.Drawing.Color.Silver
        Me.btnHelp.Image = CType(resources.GetObject("btnHelp.Image"), System.Drawing.Image)
        Me.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHelp.Location = New System.Drawing.Point(0, 732)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnHelp.Size = New System.Drawing.Size(233, 45)
        Me.btnHelp.TabIndex = 8
        Me.btnHelp.Text = "  Help"
        Me.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'PanelToolsSubmenu
        '
        Me.PanelToolsSubmenu.BackColor = System.Drawing.Color.GreenYellow
        Me.PanelToolsSubmenu.Controls.Add(Me.button10)
        Me.PanelToolsSubmenu.Controls.Add(Me.button12)
        Me.PanelToolsSubmenu.Controls.Add(Me.button13)
        Me.PanelToolsSubmenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelToolsSubmenu.Location = New System.Drawing.Point(0, 602)
        Me.PanelToolsSubmenu.Name = "PanelToolsSubmenu"
        Me.PanelToolsSubmenu.Size = New System.Drawing.Size(233, 130)
        Me.PanelToolsSubmenu.TabIndex = 7
        '
        'button10
        '
        Me.button10.BackColor = System.Drawing.Color.LimeGreen
        Me.button10.Dock = System.Windows.Forms.DockStyle.Top
        Me.button10.FlatAppearance.BorderSize = 0
        Me.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button10.ForeColor = System.Drawing.Color.Silver
        Me.button10.Location = New System.Drawing.Point(0, 80)
        Me.button10.Name = "button10"
        Me.button10.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.button10.Size = New System.Drawing.Size(233, 40)
        Me.button10.TabIndex = 2
        Me.button10.Text = "Preferences"
        Me.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button10.UseVisualStyleBackColor = False
        '
        'button12
        '
        Me.button12.BackColor = System.Drawing.Color.LimeGreen
        Me.button12.Dock = System.Windows.Forms.DockStyle.Top
        Me.button12.FlatAppearance.BorderSize = 0
        Me.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button12.ForeColor = System.Drawing.Color.Silver
        Me.button12.Location = New System.Drawing.Point(0, 40)
        Me.button12.Name = "button12"
        Me.button12.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.button12.Size = New System.Drawing.Size(233, 40)
        Me.button12.TabIndex = 1
        Me.button12.Text = "Effects and filters"
        Me.button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button12.UseVisualStyleBackColor = False
        '
        'button13
        '
        Me.button13.BackColor = System.Drawing.Color.LimeGreen
        Me.button13.Dock = System.Windows.Forms.DockStyle.Top
        Me.button13.FlatAppearance.BorderSize = 0
        Me.button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button13.ForeColor = System.Drawing.Color.Silver
        Me.button13.Location = New System.Drawing.Point(0, 0)
        Me.button13.Name = "button13"
        Me.button13.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.button13.Size = New System.Drawing.Size(233, 40)
        Me.button13.TabIndex = 0
        Me.button13.Text = "Media converter"
        Me.button13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button13.UseVisualStyleBackColor = False
        '
        'btnTools
        '
        Me.btnTools.BackColor = System.Drawing.Color.Green
        Me.btnTools.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTools.FlatAppearance.BorderSize = 0
        Me.btnTools.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnTools.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTools.ForeColor = System.Drawing.Color.Silver
        Me.btnTools.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTools.Location = New System.Drawing.Point(0, 557)
        Me.btnTools.Name = "btnTools"
        Me.btnTools.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnTools.Size = New System.Drawing.Size(233, 45)
        Me.btnTools.TabIndex = 6
        Me.btnTools.Text = "  Tools"
        Me.btnTools.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTools.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTools.UseVisualStyleBackColor = False
        '
        'btnEqualizer
        '
        Me.btnEqualizer.BackColor = System.Drawing.Color.Green
        Me.btnEqualizer.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEqualizer.FlatAppearance.BorderSize = 0
        Me.btnEqualizer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnEqualizer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnEqualizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEqualizer.ForeColor = System.Drawing.Color.Silver
        Me.btnEqualizer.Image = CType(resources.GetObject("btnEqualizer.Image"), System.Drawing.Image)
        Me.btnEqualizer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEqualizer.Location = New System.Drawing.Point(0, 512)
        Me.btnEqualizer.Name = "btnEqualizer"
        Me.btnEqualizer.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnEqualizer.Size = New System.Drawing.Size(233, 45)
        Me.btnEqualizer.TabIndex = 5
        Me.btnEqualizer.Text = "  Equalizer"
        Me.btnEqualizer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEqualizer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEqualizer.UseVisualStyleBackColor = False
        '
        'PanelPlaylistSubmenu
        '
        Me.PanelPlaylistSubmenu.BackColor = System.Drawing.Color.GreenYellow
        Me.PanelPlaylistSubmenu.Controls.Add(Me.button1)
        Me.PanelPlaylistSubmenu.Controls.Add(Me.btnPaciente)
        Me.PanelPlaylistSubmenu.Controls.Add(Me.btnConsCardápio)
        Me.PanelPlaylistSubmenu.Controls.Add(Me.button8)
        Me.PanelPlaylistSubmenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelPlaylistSubmenu.Location = New System.Drawing.Point(0, 347)
        Me.PanelPlaylistSubmenu.Name = "PanelPlaylistSubmenu"
        Me.PanelPlaylistSubmenu.Size = New System.Drawing.Size(233, 165)
        Me.PanelPlaylistSubmenu.TabIndex = 4
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.LimeGreen
        Me.button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.button1.FlatAppearance.BorderSize = 0
        Me.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.ForeColor = System.Drawing.Color.Silver
        Me.button1.Location = New System.Drawing.Point(0, 120)
        Me.button1.Name = "button1"
        Me.button1.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.button1.Size = New System.Drawing.Size(233, 40)
        Me.button1.TabIndex = 3
        Me.button1.Text = "Export playlist"
        Me.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button1.UseVisualStyleBackColor = False
        '
        'btnPaciente
        '
        Me.btnPaciente.BackColor = System.Drawing.Color.LimeGreen
        Me.btnPaciente.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPaciente.FlatAppearance.BorderSize = 0
        Me.btnPaciente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPaciente.ForeColor = System.Drawing.Color.Silver
        Me.btnPaciente.Location = New System.Drawing.Point(0, 80)
        Me.btnPaciente.Name = "btnPaciente"
        Me.btnPaciente.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnPaciente.Size = New System.Drawing.Size(233, 40)
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
        Me.btnConsCardápio.ForeColor = System.Drawing.Color.Silver
        Me.btnConsCardápio.Location = New System.Drawing.Point(0, 40)
        Me.btnConsCardápio.Name = "btnConsCardápio"
        Me.btnConsCardápio.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnConsCardápio.Size = New System.Drawing.Size(233, 40)
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
        Me.button8.ForeColor = System.Drawing.Color.Silver
        Me.button8.Location = New System.Drawing.Point(0, 0)
        Me.button8.Name = "button8"
        Me.button8.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.button8.Size = New System.Drawing.Size(233, 40)
        Me.button8.TabIndex = 0
        Me.button8.Text = "Alimentos"
        Me.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button8.UseVisualStyleBackColor = False
        '
        'btnConsultar
        '
        Me.btnConsultar.BackColor = System.Drawing.Color.Green
        Me.btnConsultar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConsultar.FlatAppearance.BorderSize = 0
        Me.btnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultar.ForeColor = System.Drawing.Color.Silver
        Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultar.Location = New System.Drawing.Point(0, 302)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnConsultar.Size = New System.Drawing.Size(233, 45)
        Me.btnConsultar.TabIndex = 3
        Me.btnConsultar.Text = "  Consultar"
        Me.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConsultar.UseVisualStyleBackColor = False
        '
        'PanelMediaSubmenu
        '
        Me.PanelMediaSubmenu.BackColor = System.Drawing.Color.GreenYellow
        Me.PanelMediaSubmenu.Controls.Add(Me.button5)
        Me.PanelMediaSubmenu.Controls.Add(Me.btnCadPaciente)
        Me.PanelMediaSubmenu.Controls.Add(Me.btnCardapio)
        Me.PanelMediaSubmenu.Controls.Add(Me.btnCadastrarAlimento)
        Me.PanelMediaSubmenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMediaSubmenu.Location = New System.Drawing.Point(0, 137)
        Me.PanelMediaSubmenu.Name = "PanelMediaSubmenu"
        Me.PanelMediaSubmenu.Size = New System.Drawing.Size(233, 165)
        Me.PanelMediaSubmenu.TabIndex = 2
        '
        'btnCadastrar
        '
        Me.btnCadastrar.BackColor = System.Drawing.Color.Green
        Me.btnCadastrar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCadastrar.FlatAppearance.BorderSize = 0
        Me.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrar.ForeColor = System.Drawing.Color.Silver
        Me.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCadastrar.Location = New System.Drawing.Point(0, 92)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnCadastrar.Size = New System.Drawing.Size(233, 45)
        Me.btnCadastrar.TabIndex = 1
        Me.btnCadastrar.Text = "  Cadastrar"
        Me.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCadastrar.UseVisualStyleBackColor = False
        '
        'PanelChildForm
        '
        Me.PanelChildForm.BackColor = System.Drawing.Color.GreenYellow
        Me.PanelChildForm.Controls.Add(Me.PictureBox2)
        Me.PanelChildForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelChildForm.Location = New System.Drawing.Point(250, 0)
        Me.PanelChildForm.Name = "PanelChildForm"
        Me.PanelChildForm.Size = New System.Drawing.Size(684, 561)
        Me.PanelChildForm.TabIndex = 3
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ProjetoTCC.My.Resources.Resources.iconTCC_removebg_preview__1____Copia
        Me.PictureBox2.Location = New System.Drawing.Point(185, 137)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(384, 307)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 561)
        Me.Controls.Add(Me.PanelChildForm)
        Me.Controls.Add(Me.PanelSideMenu)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(950, 600)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.panelLogo.ResumeLayout(False)
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSideMenu.ResumeLayout(False)
        Me.PanelToolsSubmenu.ResumeLayout(False)
        Me.PanelPlaylistSubmenu.ResumeLayout(False)
        Me.PanelMediaSubmenu.ResumeLayout(False)
        Me.PanelChildForm.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents panelLogo As Panel
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents button5 As Button
    Private WithEvents btnCadPaciente As Button
    Private WithEvents btnCardapio As Button
    Private WithEvents btnCadastrarAlimento As Button
    Private WithEvents PanelSideMenu As Panel
    Private WithEvents btnExit As Button
    Private WithEvents btnHelp As Button
    Private WithEvents PanelToolsSubmenu As Panel
    Private WithEvents button10 As Button
    Private WithEvents button12 As Button
    Private WithEvents button13 As Button
    Private WithEvents btnTools As Button
    Private WithEvents btnEqualizer As Button
    Private WithEvents PanelPlaylistSubmenu As Panel
    Private WithEvents button1 As Button
    Private WithEvents btnPaciente As Button
    Private WithEvents btnConsCardápio As Button
    Private WithEvents button8 As Button
    Private WithEvents btnConsultar As Button
    Private WithEvents PanelMediaSubmenu As Panel
    Private WithEvents btnCadastrar As Button
    Friend WithEvents PanelChildForm As Panel
    Private WithEvents PictureBox2 As PictureBox
End Class
