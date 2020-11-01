<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenuPrincipal
    Inherits MvtWindowsForms.MvtForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuPrincipal))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnConsultarAlimentos = New System.Windows.Forms.Button()
        Me.btnCadastrarAlimento = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCadastroCardapio = New System.Windows.Forms.Button()
        Me.btnCadastrarPaciente = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Chartreuse
        Me.Panel1.Controls.Add(Me.btnCadastrarPaciente)
        Me.Panel1.Controls.Add(Me.btnConsultarAlimentos)
        Me.Panel1.Controls.Add(Me.btnCadastrarAlimento)
        Me.Panel1.Controls.Add(Me.btnCadastroCardapio)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(234, 544)
        Me.Panel1.TabIndex = 5
        '
        'btnConsultarAlimentos
        '
        Me.btnConsultarAlimentos.BackColor = System.Drawing.Color.Chartreuse
        Me.btnConsultarAlimentos.FlatAppearance.BorderSize = 0
        Me.btnConsultarAlimentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultarAlimentos.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultarAlimentos.ForeColor = System.Drawing.Color.Black
        Me.btnConsultarAlimentos.Location = New System.Drawing.Point(12, 283)
        Me.btnConsultarAlimentos.Name = "btnConsultarAlimentos"
        Me.btnConsultarAlimentos.Size = New System.Drawing.Size(208, 41)
        Me.btnConsultarAlimentos.TabIndex = 3
        Me.btnConsultarAlimentos.Text = "Consultar Alimentos"
        Me.btnConsultarAlimentos.UseVisualStyleBackColor = False
        '
        'btnCadastrarAlimento
        '
        Me.btnCadastrarAlimento.BackColor = System.Drawing.Color.Chartreuse
        Me.btnCadastrarAlimento.FlatAppearance.BorderSize = 0
        Me.btnCadastrarAlimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarAlimento.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadastrarAlimento.ForeColor = System.Drawing.Color.Black
        Me.btnCadastrarAlimento.Location = New System.Drawing.Point(12, 142)
        Me.btnCadastrarAlimento.Name = "btnCadastrarAlimento"
        Me.btnCadastrarAlimento.Size = New System.Drawing.Size(208, 41)
        Me.btnCadastrarAlimento.TabIndex = 2
        Me.btnCadastrarAlimento.Text = "Cadastrar Alimento"
        Me.btnCadastrarAlimento.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ProjetoTCC.My.Resources.Resources._5_Icon_Branco
        Me.PictureBox2.Location = New System.Drawing.Point(58, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(110, 109)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(281, 136)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnCadastroCardapio
        '
        Me.btnCadastroCardapio.BackColor = System.Drawing.Color.Chartreuse
        Me.btnCadastroCardapio.FlatAppearance.BorderSize = 0
        Me.btnCadastroCardapio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastroCardapio.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadastroCardapio.ForeColor = System.Drawing.Color.Black
        Me.btnCadastroCardapio.Location = New System.Drawing.Point(12, 236)
        Me.btnCadastroCardapio.Name = "btnCadastroCardapio"
        Me.btnCadastroCardapio.Size = New System.Drawing.Size(208, 41)
        Me.btnCadastroCardapio.TabIndex = 4
        Me.btnCadastroCardapio.Text = "Cardápio"
        Me.btnCadastroCardapio.UseVisualStyleBackColor = False
        '
        'btnCadastrarPaciente
        '
        Me.btnCadastrarPaciente.BackColor = System.Drawing.Color.Chartreuse
        Me.btnCadastrarPaciente.FlatAppearance.BorderSize = 0
        Me.btnCadastrarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarPaciente.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadastrarPaciente.ForeColor = System.Drawing.Color.Black
        Me.btnCadastrarPaciente.Location = New System.Drawing.Point(12, 189)
        Me.btnCadastrarPaciente.Name = "btnCadastrarPaciente"
        Me.btnCadastrarPaciente.Size = New System.Drawing.Size(208, 41)
        Me.btnCadastrarPaciente.TabIndex = 5
        Me.btnCadastrarPaciente.Text = "Cadastro de Paciente"
        Me.btnCadastrarPaciente.UseVisualStyleBackColor = False
        '
        'frmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(856, 544)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMenuPrincipal"
        Me.Text = "Menu Principal"
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCadastrarAlimento As Button
    Friend WithEvents btnConsultarAlimentos As Button
    Friend WithEvents btnCadastrarPaciente As Button
    Friend WithEvents btnCadastroCardapio As Button
End Class
