namespace SIC_Sim
{
    partial class Form1
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
<<<<<<< HEAD
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.léxicoSintácticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeContainer = new System.Windows.Forms.SplitContainer();
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeContainer)).BeginInit();
            this.codeContainer.Panel1.SuspendLayout();
            this.codeContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.mainContainer.Panel2.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.analizarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.guardarComoToolStripMenuItem.Text = "Guardar como";
            // 
            // analizarToolStripMenuItem
            // 
            this.analizarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.léxicoSintácticoToolStripMenuItem});
            this.analizarToolStripMenuItem.Name = "analizarToolStripMenuItem";
            this.analizarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.analizarToolStripMenuItem.Text = "Analizar";
            // 
            // léxicoSintácticoToolStripMenuItem
            // 
            this.léxicoSintácticoToolStripMenuItem.Name = "léxicoSintácticoToolStripMenuItem";
            this.léxicoSintácticoToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.léxicoSintácticoToolStripMenuItem.Text = "Léxico / Sintáctico";
            this.léxicoSintácticoToolStripMenuItem.Click += new System.EventHandler(this.AnalizarGramatica);
            // 
            // codeContainer
            // 
            this.codeContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codeContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.codeContainer.IsSplitterFixed = true;
            this.codeContainer.Location = new System.Drawing.Point(0, 0);
            this.codeContainer.Name = "codeContainer";
            this.codeContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // codeContainer.Panel1
            // 
            this.codeContainer.Panel1.Controls.Add(this.inputTextBox);
            // 
            // codeContainer.Panel2
            // 
            this.codeContainer.Panel2.BackColor = System.Drawing.Color.White;
            this.codeContainer.Size = new System.Drawing.Size(505, 428);
            this.codeContainer.SplitterDistance = 321;
            this.codeContainer.TabIndex = 0;
            // 
            // mainContainer
            // 
            this.mainContainer.BackColor = System.Drawing.Color.White;
            this.mainContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.mainContainer.ForeColor = System.Drawing.Color.White;
            this.mainContainer.IsSplitterFixed = true;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Name = "mainContainer";
            // 
            // mainContainer.Panel1
            // 
            this.mainContainer.Panel1.ForeColor = System.Drawing.Color.White;
            // 
            // mainContainer.Panel2
            // 
            this.mainContainer.Panel2.Controls.Add(this.codeContainer);
            this.mainContainer.Size = new System.Drawing.Size(684, 428);
            this.mainContainer.SplitterDistance = 175;
            this.mainContainer.TabIndex = 6;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputTextBox.Location = new System.Drawing.Point(3, 26);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(497, 290);
            this.inputTextBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 428);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.mainContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SIC Simulator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.codeContainer.Panel1.ResumeLayout(false);
            this.codeContainer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeContainer)).EndInit();
            this.codeContainer.ResumeLayout(false);
            this.mainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

=======
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeContainer = new System.Windows.Forms.SplitContainer();
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.code = new System.Windows.Forms.RichTextBox();
            this.analiza = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeContainer)).BeginInit();
            this.codeContainer.Panel1.SuspendLayout();
            this.codeContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.mainContainer.Panel1.SuspendLayout();
            this.mainContainer.Panel2.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.guardarComoToolStripMenuItem.Text = "Guardar como";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
            // 
            // codeContainer
            // 
            this.codeContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codeContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.codeContainer.IsSplitterFixed = true;
            this.codeContainer.Location = new System.Drawing.Point(0, 0);
            this.codeContainer.Name = "codeContainer";
            this.codeContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // codeContainer.Panel1
            // 
            this.codeContainer.Panel1.Controls.Add(this.resultado);
            // 
            // codeContainer.Panel2
            // 
            this.codeContainer.Panel2.BackColor = System.Drawing.Color.White;
            this.codeContainer.Size = new System.Drawing.Size(505, 404);
            this.codeContainer.SplitterDistance = 297;
            this.codeContainer.TabIndex = 0;
            // 
            // mainContainer
            // 
            this.mainContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.mainContainer.IsSplitterFixed = true;
            this.mainContainer.Location = new System.Drawing.Point(0, 24);
            this.mainContainer.Name = "mainContainer";
            // 
            // mainContainer.Panel1
            // 
            this.mainContainer.Panel1.Controls.Add(this.analiza);
            this.mainContainer.Panel1.Controls.Add(this.code);
            this.mainContainer.Panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            // 
            // mainContainer.Panel2
            // 
            this.mainContainer.Panel2.Controls.Add(this.codeContainer);
            this.mainContainer.Size = new System.Drawing.Size(684, 404);
            this.mainContainer.SplitterDistance = 175;
            this.mainContainer.TabIndex = 6;
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(3, 3);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(169, 301);
            this.code.TabIndex = 0;
            this.code.Text = "";
            // 
            // analiza
            // 
            this.analiza.Location = new System.Drawing.Point(12, 311);
            this.analiza.Name = "analiza";
            this.analiza.Size = new System.Drawing.Size(75, 23);
            this.analiza.TabIndex = 1;
            this.analiza.Text = "Analiza";
            this.analiza.UseVisualStyleBackColor = true;
            this.analiza.Click += new System.EventHandler(this.analiza_Click);
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(-1, -1);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(313, 293);
            this.resultado.TabIndex = 0;
            this.resultado.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 428);
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SIC Simulator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.codeContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.codeContainer)).EndInit();
            this.codeContainer.ResumeLayout(false);
            this.mainContainer.Panel1.ResumeLayout(false);
            this.mainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

>>>>>>> origin/master
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.SplitContainer codeContainer;
<<<<<<< HEAD
        private System.Windows.Forms.SplitContainer mainContainer;
        private System.Windows.Forms.ToolStripMenuItem léxicoSintácticoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analizarToolStripMenuItem;
        private System.Windows.Forms.TextBox inputTextBox;
=======
        private System.Windows.Forms.SplitContainer mainContainer;
        private System.Windows.Forms.RichTextBox code;
        private System.Windows.Forms.Button analiza;
        private System.Windows.Forms.RichTextBox resultado;
>>>>>>> origin/master
    }
}

