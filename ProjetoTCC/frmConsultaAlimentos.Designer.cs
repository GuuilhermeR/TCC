using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ProjetoTCC
{
    [DesignerGenerated()]
    public partial class frmConsultaAlimentos : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaAlimentos));
            _dtgConsultaAlimentos = new DataGridView();
            _dtgConsultaAlimentos.CellEndEdit += new DataGridViewCellEventHandler(dtgConsultaAlimentos_CellEndEdit);
            _dtgConsultaAlimentos.CellBeginEdit += new DataGridViewCellCancelEventHandler(dtgConsultaAlimentos_CellBeginEdit);
            lblAlimento = new Label();
            txtAlimento = new TextBox();
            _btnRecalcular = new Button();
            _btnRecalcular.Click += new EventHandler(btnRecalcular_Click_1);
            btnProcurarAlimento = new Button();
            _btnConsultar = new Button();
            _btnConsultar.Click += new EventHandler(btnConsultar_Click_1);
            ((System.ComponentModel.ISupportInitialize)_dtgConsultaAlimentos).BeginInit();
            SuspendLayout();
            // 
            // dtgConsultaAlimentos
            // 
            _dtgConsultaAlimentos.BackgroundColor = SystemColors.Control;
            _dtgConsultaAlimentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _dtgConsultaAlimentos.GridColor = SystemColors.Control;
            _dtgConsultaAlimentos.Location = new Point(12, 80);
            _dtgConsultaAlimentos.Name = "_dtgConsultaAlimentos";
            _dtgConsultaAlimentos.Size = new Size(838, 394);
            _dtgConsultaAlimentos.TabIndex = 0;
            // 
            // lblAlimento
            // 
            lblAlimento.AutoSize = true;
            lblAlimento.Location = new Point(12, 20);
            lblAlimento.Name = "lblAlimento";
            lblAlimento.Size = new Size(50, 13);
            lblAlimento.TabIndex = 2;
            lblAlimento.Text = "Alimento:";
            // 
            // txtAlimento
            // 
            txtAlimento.Location = new Point(68, 17);
            txtAlimento.Name = "txtAlimento";
            txtAlimento.Size = new Size(262, 20);
            txtAlimento.TabIndex = 3;
            // 
            // btnRecalcular
            // 
            _btnRecalcular.Location = new Point(746, 480);
            _btnRecalcular.Name = "_btnRecalcular";
            _btnRecalcular.Size = new Size(104, 31);
            _btnRecalcular.TabIndex = 1;
            _btnRecalcular.Text = "Recalcular";
            _btnRecalcular.UseVisualStyleBackColor = true;
            // 
            // btnProcurarAlimento
            // 
            btnProcurarAlimento.Image = My.Resources.Resources.consultar;
            btnProcurarAlimento.Location = new Point(336, 15);
            btnProcurarAlimento.Name = "btnProcurarAlimento";
            btnProcurarAlimento.Size = new Size(30, 23);
            btnProcurarAlimento.TabIndex = 25;
            btnProcurarAlimento.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            _btnConsultar.Image = My.Resources.Resources.consultar1;
            _btnConsultar.ImageAlign = ContentAlignment.MiddleLeft;
            _btnConsultar.Location = new Point(746, 43);
            _btnConsultar.Name = "_btnConsultar";
            _btnConsultar.Size = new Size(104, 31);
            _btnConsultar.TabIndex = 4;
            _btnConsultar.Text = "Consultar";
            _btnConsultar.UseVisualStyleBackColor = true;
            // 
            // frmConsultaAlimentos
            // 
            ClientSize = new Size(862, 523);
            Controls.Add(btnProcurarAlimento);
            Controls.Add(_btnConsultar);
            Controls.Add(txtAlimento);
            Controls.Add(lblAlimento);
            Controls.Add(_btnRecalcular);
            Controls.Add(_dtgConsultaAlimentos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmConsultaAlimentos";
            Text = "Consulta Alimentos";
            ((System.ComponentModel.ISupportInitialize)_dtgConsultaAlimentos).EndInit();
            Load += new EventHandler(frmConsultaMedidasCaseiras_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView _dtgConsultaAlimentos;

        internal DataGridView dtgConsultaAlimentos
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dtgConsultaAlimentos;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dtgConsultaAlimentos != null)
                {
                    _dtgConsultaAlimentos.CellEndEdit -= dtgConsultaAlimentos_CellEndEdit;
                    _dtgConsultaAlimentos.CellBeginEdit -= dtgConsultaAlimentos_CellBeginEdit;
                }

                _dtgConsultaAlimentos = value;
                if (_dtgConsultaAlimentos != null)
                {
                    _dtgConsultaAlimentos.CellEndEdit += dtgConsultaAlimentos_CellEndEdit;
                    _dtgConsultaAlimentos.CellBeginEdit += dtgConsultaAlimentos_CellBeginEdit;
                }
            }
        }

        private Button _btnRecalcular;

        internal Button btnRecalcular
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnRecalcular;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnRecalcular != null)
                {
                    _btnRecalcular.Click -= btnRecalcular_Click_1;
                }

                _btnRecalcular = value;
                if (_btnRecalcular != null)
                {
                    _btnRecalcular.Click += btnRecalcular_Click_1;
                }
            }
        }

        internal Label lblAlimento;
        internal TextBox txtAlimento;
        private Button _btnConsultar;

        internal Button btnConsultar
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnConsultar;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnConsultar != null)
                {
                    _btnConsultar.Click -= btnConsultar_Click_1;
                }

                _btnConsultar = value;
                if (_btnConsultar != null)
                {
                    _btnConsultar.Click += btnConsultar_Click_1;
                }
            }
        }

        internal Button btnProcurarAlimento;
    }
}