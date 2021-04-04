
namespace CadConsultaForms
{
    partial class frmConsulta
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
            this.lblCodIni = new System.Windows.Forms.Label();
            this.txtCodInicial = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.gvConsulta = new System.Windows.Forms.DataGridView();
            this.lblInserir = new System.Windows.Forms.LinkLabel();
            this.lblCodFin = new System.Windows.Forms.Label();
            this.txtCodFinal = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.gbCodigo = new System.Windows.Forms.GroupBox();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvConsulta)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbCodigo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodIni
            // 
            this.lblCodIni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodIni.AutoSize = true;
            this.lblCodIni.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCodIni.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblCodIni.Location = new System.Drawing.Point(53, 19);
            this.lblCodIni.Name = "lblCodIni";
            this.lblCodIni.Size = new System.Drawing.Size(50, 19);
            this.lblCodIni.TabIndex = 0;
            this.lblCodIni.Text = "Inicial: ";
            this.lblCodIni.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtCodInicial
            // 
            this.txtCodInicial.Location = new System.Drawing.Point(109, 15);
            this.txtCodInicial.Name = "txtCodInicial";
            this.txtCodInicial.Size = new System.Drawing.Size(90, 23);
            this.txtCodInicial.TabIndex = 1;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.AutoEllipsis = true;
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.Location = new System.Drawing.Point(329, 103);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(84, 24);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // pnlGrid
            // 
            this.pnlGrid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlGrid.Controls.Add(this.gvConsulta);
            this.pnlGrid.Controls.Add(this.lblInserir);
            this.pnlGrid.Location = new System.Drawing.Point(33, 176);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(732, 255);
            this.pnlGrid.TabIndex = 3;
            this.pnlGrid.Visible = false;
            // 
            // gvConsulta
            // 
            this.gvConsulta.AllowUserToAddRows = false;
            this.gvConsulta.AllowUserToDeleteRows = false;
            this.gvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvConsulta.Location = new System.Drawing.Point(18, 11);
            this.gvConsulta.Name = "gvConsulta";
            this.gvConsulta.ReadOnly = true;
            this.gvConsulta.RowTemplate.Height = 25;
            this.gvConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvConsulta.Size = new System.Drawing.Size(694, 216);
            this.gvConsulta.TabIndex = 0;
            this.gvConsulta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvConsulta_CellDoubleClick);
            // 
            // lblInserir
            // 
            this.lblInserir.AutoSize = true;
            this.lblInserir.Location = new System.Drawing.Point(18, 230);
            this.lblInserir.Name = "lblInserir";
            this.lblInserir.Size = new System.Drawing.Size(117, 15);
            this.lblInserir.TabIndex = 4;
            this.lblInserir.TabStop = true;
            this.lblInserir.Text = "Inserir novo cadastro";
            this.lblInserir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblInserir_LinkClicked);
            // 
            // lblCodFin
            // 
            this.lblCodFin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodFin.AutoSize = true;
            this.lblCodFin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCodFin.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblCodFin.Location = new System.Drawing.Point(59, 48);
            this.lblCodFin.Name = "lblCodFin";
            this.lblCodFin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCodFin.Size = new System.Drawing.Size(40, 19);
            this.lblCodFin.TabIndex = 5;
            this.lblCodFin.Text = "Final:";
            this.lblCodFin.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtCodFinal
            // 
            this.txtCodFinal.Location = new System.Drawing.Point(109, 44);
            this.txtCodFinal.Name = "txtCodFinal";
            this.txtCodFinal.Size = new System.Drawing.Size(90, 23);
            this.txtCodFinal.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblConsulta);
            this.panel1.Controls.Add(this.btnFiltrar);
            this.panel1.Controls.Add(this.gbCodigo);
            this.panel1.Location = new System.Drawing.Point(33, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 158);
            this.panel1.TabIndex = 6;
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConsulta.Location = new System.Drawing.Point(289, 13);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(171, 21);
            this.lblConsulta.TabIndex = 8;
            this.lblConsulta.Text = "Consulta de Cadastro";
            // 
            // gbCodigo
            // 
            this.gbCodigo.Controls.Add(this.lblCodFin);
            this.gbCodigo.Controls.Add(this.txtCodFinal);
            this.gbCodigo.Controls.Add(this.lblCodIni);
            this.gbCodigo.Controls.Add(this.txtCodInicial);
            this.gbCodigo.Location = new System.Drawing.Point(18, 48);
            this.gbCodigo.Name = "gbCodigo";
            this.gbCodigo.Size = new System.Drawing.Size(261, 79);
            this.gbCodigo.TabIndex = 7;
            this.gbCodigo.TabStop = false;
            this.gbCodigo.Text = "Código";
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(809, 453);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.panel1);
            this.Name = "frmConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtro";
            this.pnlGrid.ResumeLayout(false);
            this.pnlGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvConsulta)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbCodigo.ResumeLayout(false);
            this.gbCodigo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCodIni;
        private System.Windows.Forms.TextBox txtCodInicial;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView gvConsulta;
        private System.Windows.Forms.LinkLabel lblInserir;
        private System.Windows.Forms.Label lblCodFin;
        private System.Windows.Forms.TextBox txtCodFinal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.GroupBox gbCodigo;
    }
}