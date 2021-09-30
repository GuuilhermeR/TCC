
namespace TCC2.Telas
{
    partial class frmTemplatesAnamnese
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTemplatesAnamnese));
            this.rtxtAnamnese = new MvtWindowsForms.RitchTextBoxWithToolBar();
            this.txtNomeTemplate = new MaterialSkin.Controls.MaterialTextBox();
            this.btnSalvarAnamnese = new System.Windows.Forms.Button();
            this.cbxTempSalvo = new MaterialSkin.Controls.MaterialComboBox();
            this.cbxExibirSalvos = new MaterialSkin.Controls.MaterialCheckbox();
            this.SuspendLayout();
            // 
            // rtxtAnamnese
            // 
            this.rtxtAnamnese.AcceptsTab = false;
            this.rtxtAnamnese.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtAnamnese.AutoWordSelection = true;
            this.rtxtAnamnese.DetectURLs = true;
            this.rtxtAnamnese.Location = new System.Drawing.Point(6, 134);
            this.rtxtAnamnese.Name = "rtxtAnamnese";
            this.rtxtAnamnese.PlainText = "";
            this.rtxtAnamnese.ReadOnly = false;
            // 
            // 
            // 
            this.rtxtAnamnese.RichTextBox.AutoWordSelection = true;
            this.rtxtAnamnese.RichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtAnamnese.RichTextBox.Location = new System.Drawing.Point(0, 48);
            this.rtxtAnamnese.RichTextBox.Name = "rtb1";
            this.rtxtAnamnese.RichTextBox.Size = new System.Drawing.Size(1200, 598);
            this.rtxtAnamnese.RichTextBox.TabIndex = 1;
            this.rtxtAnamnese.ShowBold = true;
            this.rtxtAnamnese.ShowCenterJustify = true;
            this.rtxtAnamnese.ShowColors = true;
            this.rtxtAnamnese.ShowCopy = true;
            this.rtxtAnamnese.ShowCut = true;
            this.rtxtAnamnese.ShowFont = true;
            this.rtxtAnamnese.ShowFontSize = true;
            this.rtxtAnamnese.ShowItalic = true;
            this.rtxtAnamnese.ShowLeftJustify = true;
            this.rtxtAnamnese.ShowOpen = true;
            this.rtxtAnamnese.ShowPaste = true;
            this.rtxtAnamnese.ShowRedo = true;
            this.rtxtAnamnese.ShowRightJustify = true;
            this.rtxtAnamnese.ShowSave = true;
            this.rtxtAnamnese.ShowStamp = false;
            this.rtxtAnamnese.ShowStrikeout = true;
            this.rtxtAnamnese.ShowToolBarText = false;
            this.rtxtAnamnese.ShowUnderline = true;
            this.rtxtAnamnese.ShowUndo = true;
            this.rtxtAnamnese.Size = new System.Drawing.Size(1200, 646);
            this.rtxtAnamnese.StampAction = MvtWindowsForms.StampActions.EditedBy;
            this.rtxtAnamnese.StampColor = System.Drawing.Color.Blue;
            this.rtxtAnamnese.TabIndex = 3;
            // 
            // 
            // 
            this.rtxtAnamnese.Toolbar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.rtxtAnamnese.Toolbar.ButtonSize = new System.Drawing.Size(16, 16);
            this.rtxtAnamnese.Toolbar.Divider = false;
            this.rtxtAnamnese.Toolbar.DropDownArrows = true;
            this.rtxtAnamnese.Toolbar.Location = new System.Drawing.Point(0, 0);
            this.rtxtAnamnese.Toolbar.Name = "tb1";
            this.rtxtAnamnese.Toolbar.ShowToolTips = true;
            this.rtxtAnamnese.Toolbar.Size = new System.Drawing.Size(1200, 48);
            this.rtxtAnamnese.Toolbar.TabIndex = 0;
            // 
            // txtNomeTemplate
            // 
            this.txtNomeTemplate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeTemplate.Depth = 0;
            this.txtNomeTemplate.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNomeTemplate.Hint = "Template";
            this.txtNomeTemplate.LeadingIcon = null;
            this.txtNomeTemplate.Location = new System.Drawing.Point(6, 78);
            this.txtNomeTemplate.MaxLength = 50;
            this.txtNomeTemplate.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNomeTemplate.Multiline = false;
            this.txtNomeTemplate.Name = "txtNomeTemplate";
            this.txtNomeTemplate.Size = new System.Drawing.Size(317, 50);
            this.txtNomeTemplate.TabIndex = 4;
            this.txtNomeTemplate.Text = "";
            this.txtNomeTemplate.TrailingIcon = null;
            // 
            // btnSalvarAnamnese
            // 
            this.btnSalvarAnamnese.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarAnamnese.AutoSize = true;
            this.btnSalvarAnamnese.Image = global::TCC2.Properties.Resources.mvtSaveGreen_16;
            this.btnSalvarAnamnese.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarAnamnese.Location = new System.Drawing.Point(1091, 786);
            this.btnSalvarAnamnese.Name = "btnSalvarAnamnese";
            this.btnSalvarAnamnese.Size = new System.Drawing.Size(115, 35);
            this.btnSalvarAnamnese.TabIndex = 5;
            this.btnSalvarAnamnese.Text = "Salvar";
            this.btnSalvarAnamnese.UseVisualStyleBackColor = true;
            this.btnSalvarAnamnese.Click += new System.EventHandler(this.btnSalvarAnamnese_Click);
            // 
            // cbxTempSalvo
            // 
            this.cbxTempSalvo.AutoResize = false;
            this.cbxTempSalvo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxTempSalvo.Depth = 0;
            this.cbxTempSalvo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxTempSalvo.DropDownHeight = 174;
            this.cbxTempSalvo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTempSalvo.DropDownWidth = 121;
            this.cbxTempSalvo.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxTempSalvo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxTempSalvo.FormattingEnabled = true;
            this.cbxTempSalvo.Hint = "Templates Salvos";
            this.cbxTempSalvo.IntegralHeight = false;
            this.cbxTempSalvo.ItemHeight = 43;
            this.cbxTempSalvo.Location = new System.Drawing.Point(6, 79);
            this.cbxTempSalvo.MaxDropDownItems = 4;
            this.cbxTempSalvo.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxTempSalvo.Name = "cbxTempSalvo";
            this.cbxTempSalvo.Size = new System.Drawing.Size(317, 49);
            this.cbxTempSalvo.StartIndex = 0;
            this.cbxTempSalvo.TabIndex = 323;
            this.cbxTempSalvo.Visible = false;
            this.cbxTempSalvo.SelectedIndexChanged += new System.EventHandler(this.cbxTempSalvo_SelectedIndexChanged);
            // 
            // cbxExibirSalvos
            // 
            this.cbxExibirSalvos.AutoSize = true;
            this.cbxExibirSalvos.Depth = 0;
            this.cbxExibirSalvos.Location = new System.Drawing.Point(326, 84);
            this.cbxExibirSalvos.Margin = new System.Windows.Forms.Padding(0);
            this.cbxExibirSalvos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbxExibirSalvos.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbxExibirSalvos.Name = "cbxExibirSalvos";
            this.cbxExibirSalvos.Ripple = true;
            this.cbxExibirSalvos.Size = new System.Drawing.Size(183, 37);
            this.cbxExibirSalvos.TabIndex = 324;
            this.cbxExibirSalvos.Text = "Exibir Apenas Salvos";
            this.cbxExibirSalvos.UseVisualStyleBackColor = true;
            this.cbxExibirSalvos.CheckedChanged += new System.EventHandler(this.cbxExibirSalvos_CheckedChanged);
            // 
            // frmTemplatesAnamnese
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 827);
            this.Controls.Add(this.cbxExibirSalvos);
            this.Controls.Add(this.cbxTempSalvo);
            this.Controls.Add(this.btnSalvarAnamnese);
            this.Controls.Add(this.txtNomeTemplate);
            this.Controls.Add(this.rtxtAnamnese);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTemplatesAnamnese";
            this.Text = "Configuração Template Anamnese";
            this.Load += new System.EventHandler(this.frmTemplatesAnamnese_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MvtWindowsForms.RitchTextBoxWithToolBar rtxtAnamnese;
        private MaterialSkin.Controls.MaterialTextBox txtNomeTemplate;
        internal System.Windows.Forms.Button btnSalvarAnamnese;
        private MaterialSkin.Controls.MaterialComboBox cbxTempSalvo;
        private MaterialSkin.Controls.MaterialCheckbox cbxExibirSalvos;
    }
}