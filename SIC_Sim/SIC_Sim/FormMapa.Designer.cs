namespace SIC_Sim
{
    partial class FormMapa
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
            this.mapaDeMemoria = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openRegDialog = new System.Windows.Forms.OpenFileDialog();
            this.lbDirCarga = new System.Windows.Forms.Label();
            this.lbTamProg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mapaDeMemoria)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mapaDeMemoria
            // 
            this.mapaDeMemoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapaDeMemoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mapaDeMemoria.Location = new System.Drawing.Point(18, 71);
            this.mapaDeMemoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mapaDeMemoria.Name = "mapaDeMemoria";
            this.mapaDeMemoria.Size = new System.Drawing.Size(790, 354);
            this.mapaDeMemoria.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(826, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(55, 18);
            this.archivoToolStripMenuItem.Text = "Archivo";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // openRegDialog
            // 
            this.openRegDialog.Filter = "SIC OBJ | *.sobj";
            this.openRegDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openRegDialog_FileOk);
            // 
            // lbDirCarga
            // 
            this.lbDirCarga.AutoSize = true;
            this.lbDirCarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDirCarga.Location = new System.Drawing.Point(14, 36);
            this.lbDirCarga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDirCarga.Name = "lbDirCarga";
            this.lbDirCarga.Size = new System.Drawing.Size(149, 20);
            this.lbDirCarga.TabIndex = 2;
            this.lbDirCarga.Text = "Dirección de carga: ";
            // 
            // lbTamProg
            // 
            this.lbTamProg.AutoSize = true;
            this.lbTamProg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTamProg.Location = new System.Drawing.Point(280, 36);
            this.lbTamProg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTamProg.Name = "lbTamProg";
            this.lbTamProg.Size = new System.Drawing.Size(169, 20);
            this.lbTamProg.TabIndex = 3;
            this.lbTamProg.Text = "Tamaño de programa: ";
            // 
            // FormMapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 439);
            this.Controls.Add(this.lbTamProg);
            this.Controls.Add(this.lbDirCarga);
            this.Controls.Add(this.mapaDeMemoria);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMapa";
            this.Text = "FormMapa";
            this.Load += new System.EventHandler(this.FormMapa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mapaDeMemoria)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView mapaDeMemoria;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openRegDialog;
        private System.Windows.Forms.Label lbDirCarga;
        private System.Windows.Forms.Label lbTamProg;
    }
}