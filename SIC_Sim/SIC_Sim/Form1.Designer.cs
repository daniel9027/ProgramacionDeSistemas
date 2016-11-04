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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AnalisisMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabSimMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeContainer = new System.Windows.Forms.SplitContainer();
            this.CodObjTextBox = new System.Windows.Forms.TextBox();
            this.direcciones = new System.Windows.Forms.TextBox();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.StdTreeView = new System.Windows.Forms.TreeView();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.btnClose = new System.Windows.Forms.Button();
            this.maximizeWindow = new System.Windows.Forms.Button();
            this.minimizeWindow = new System.Windows.Forms.Button();
            this.windowTitle = new System.Windows.Forms.Label();
            this.mapaDeMemoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeContainer)).BeginInit();
            this.codeContainer.Panel1.SuspendLayout();
            this.codeContainer.Panel2.SuspendLayout();
            this.codeContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.mainContainer.Panel1.SuspendLayout();
            this.mainContainer.Panel2.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.analizarToolStripMenuItem,
            this.tabSimMenuItem,
            this.resultadoToolStripMenuItem,
            this.mapaDeMemoriaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 21);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(593, 29);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem});
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 25);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.NewFileClick);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.OpenFileClick);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.SaveFileClick);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.guardarComoToolStripMenuItem.Text = "Guardar como";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.SaveFileAsClick);
            // 
            // analizarToolStripMenuItem
            // 
            this.analizarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AnalisisMenuItem});
            this.analizarToolStripMenuItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.analizarToolStripMenuItem.Name = "analizarToolStripMenuItem";
            this.analizarToolStripMenuItem.Size = new System.Drawing.Size(61, 25);
            this.analizarToolStripMenuItem.Text = "Analizar";
            // 
            // AnalisisMenuItem
            // 
            this.AnalisisMenuItem.Enabled = false;
            this.AnalisisMenuItem.Name = "AnalisisMenuItem";
            this.AnalisisMenuItem.Size = new System.Drawing.Size(170, 22);
            this.AnalisisMenuItem.Text = "Léxico / Sintáctico";
            this.AnalisisMenuItem.Click += new System.EventHandler(this.AnalizarGramatica);
            // 
            // tabSimMenuItem
            // 
            this.tabSimMenuItem.Enabled = false;
            this.tabSimMenuItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tabSimMenuItem.Name = "tabSimMenuItem";
            this.tabSimMenuItem.Size = new System.Drawing.Size(60, 25);
            this.tabSimMenuItem.Text = "TABSIM";
            this.tabSimMenuItem.Click += new System.EventHandler(this.TabSimClick);
            // 
            // resultadoToolStripMenuItem
            // 
            this.resultadoToolStripMenuItem.Name = "resultadoToolStripMenuItem";
            this.resultadoToolStripMenuItem.Size = new System.Drawing.Size(71, 25);
            this.resultadoToolStripMenuItem.Text = "Resultado";
            this.resultadoToolStripMenuItem.Click += new System.EventHandler(this.resultadoToolStripMenuItem_Click);
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
            this.codeContainer.Panel1.AutoScroll = true;
            this.codeContainer.Panel1.Controls.Add(this.CodObjTextBox);
            this.codeContainer.Panel1.Controls.Add(this.direcciones);
            this.codeContainer.Panel1.Controls.Add(this.inputTextBox);
            // 
            // codeContainer.Panel2
            // 
            this.codeContainer.Panel2.BackColor = System.Drawing.Color.White;
            this.codeContainer.Panel2.Controls.Add(this.outputTextBox);
            this.codeContainer.Size = new System.Drawing.Size(739, 427);
            this.codeContainer.SplitterDistance = 317;
            this.codeContainer.TabIndex = 0;
            // 
            // CodObjTextBox
            // 
            this.CodObjTextBox.AcceptsTab = true;
            this.CodObjTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CodObjTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CodObjTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CodObjTextBox.Location = new System.Drawing.Point(612, -1);
            this.CodObjTextBox.Multiline = true;
            this.CodObjTextBox.Name = "CodObjTextBox";
            this.CodObjTextBox.ReadOnly = true;
            this.CodObjTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CodObjTextBox.Size = new System.Drawing.Size(125, 315);
            this.CodObjTextBox.TabIndex = 6;
            // 
            // direcciones
            // 
            this.direcciones.AcceptsTab = true;
            this.direcciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.direcciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.direcciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.direcciones.Location = new System.Drawing.Point(0, 0);
            this.direcciones.Multiline = true;
            this.direcciones.Name = "direcciones";
            this.direcciones.ReadOnly = true;
            this.direcciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.direcciones.Size = new System.Drawing.Size(90, 315);
            this.direcciones.TabIndex = 4;
            // 
            // inputTextBox
            // 
            this.inputTextBox.AcceptsTab = true;
            this.inputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.inputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputTextBox.Enabled = false;
            this.inputTextBox.Location = new System.Drawing.Point(90, 0);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputTextBox.Size = new System.Drawing.Size(522, 315);
            this.inputTextBox.TabIndex = 5;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputTextBox.Location = new System.Drawing.Point(3, 3);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTextBox.Size = new System.Drawing.Size(732, 98);
            this.outputTextBox.TabIndex = 0;
            // 
            // mainContainer
            // 
            this.mainContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainContainer.BackColor = System.Drawing.Color.White;
            this.mainContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.mainContainer.ForeColor = System.Drawing.Color.White;
            this.mainContainer.IsSplitterFixed = true;
            this.mainContainer.Location = new System.Drawing.Point(1, 52);
            this.mainContainer.Name = "mainContainer";
            // 
            // mainContainer.Panel1
            // 
            this.mainContainer.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.mainContainer.Panel1.Controls.Add(this.StdTreeView);
            this.mainContainer.Panel1.ForeColor = System.Drawing.Color.White;
            // 
            // mainContainer.Panel2
            // 
            this.mainContainer.Panel2.Controls.Add(this.codeContainer);
            this.mainContainer.Size = new System.Drawing.Size(918, 427);
            this.mainContainer.SplitterDistance = 175;
            this.mainContainer.TabIndex = 6;
            // 
            // StdTreeView
            // 
            this.StdTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StdTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StdTreeView.Location = new System.Drawing.Point(3, 3);
            this.StdTreeView.Name = "StdTreeView";
            this.StdTreeView.Size = new System.Drawing.Size(167, 419);
            this.StdTreeView.TabIndex = 0;
            this.StdTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.StdTreeView_NodeMouseClick);
            // 
            // openFile
            // 
            this.openFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openFile_FileOk);
            // 
            // saveFile
            // 
            this.saveFile.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFile_FileOk);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.Location = new System.Drawing.Point(883, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.closeWindow_Click);
            // 
            // maximizeWindow
            // 
            this.maximizeWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeWindow.FlatAppearance.BorderSize = 0;
            this.maximizeWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximizeWindow.ForeColor = System.Drawing.Color.DodgerBlue;
            this.maximizeWindow.Location = new System.Drawing.Point(845, 2);
            this.maximizeWindow.Name = "maximizeWindow";
            this.maximizeWindow.Size = new System.Drawing.Size(35, 35);
            this.maximizeWindow.TabIndex = 8;
            this.maximizeWindow.Text = "[ ]";
            this.maximizeWindow.UseVisualStyleBackColor = true;
            this.maximizeWindow.Click += new System.EventHandler(this.maximizeWindow_Click);
            // 
            // minimizeWindow
            // 
            this.minimizeWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeWindow.FlatAppearance.BorderSize = 0;
            this.minimizeWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeWindow.ForeColor = System.Drawing.Color.DodgerBlue;
            this.minimizeWindow.Location = new System.Drawing.Point(806, 2);
            this.minimizeWindow.Name = "minimizeWindow";
            this.minimizeWindow.Size = new System.Drawing.Size(35, 35);
            this.minimizeWindow.TabIndex = 9;
            this.minimizeWindow.Text = "_";
            this.minimizeWindow.UseVisualStyleBackColor = true;
            this.minimizeWindow.Click += new System.EventHandler(this.minimizeWindow_Click);
            // 
            // windowTitle
            // 
            this.windowTitle.AutoSize = true;
            this.windowTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.windowTitle.Location = new System.Drawing.Point(410, 10);
            this.windowTitle.Name = "windowTitle";
            this.windowTitle.Size = new System.Drawing.Size(92, 17);
            this.windowTitle.TabIndex = 10;
            this.windowTitle.Text = "SIC Simulator";
            // 
            // mapaDeMemoriaToolStripMenuItem
            // 
            this.mapaDeMemoriaToolStripMenuItem.Name = "mapaDeMemoriaToolStripMenuItem";
            this.mapaDeMemoriaToolStripMenuItem.Size = new System.Drawing.Size(116, 25);
            this.mapaDeMemoriaToolStripMenuItem.Text = "Mapa de Memoria";
            this.mapaDeMemoriaToolStripMenuItem.Click += new System.EventHandler(this.mapaDeMemoriaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(920, 480);
            this.Controls.Add(this.windowTitle);
            this.Controls.Add(this.minimizeWindow);
            this.Controls.Add(this.maximizeWindow);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.mainContainer);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIC Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.codeContainer.Panel1.ResumeLayout(false);
            this.codeContainer.Panel1.PerformLayout();
            this.codeContainer.Panel2.ResumeLayout(false);
            this.codeContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeContainer)).EndInit();
            this.codeContainer.ResumeLayout(false);
            this.mainContainer.Panel1.ResumeLayout(false);
            this.mainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.SplitContainer codeContainer;
        private System.Windows.Forms.SplitContainer mainContainer;
        private System.Windows.Forms.ToolStripMenuItem AnalisisMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analizarToolStripMenuItem;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.ToolStripMenuItem tabSimMenuItem;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.TreeView StdTreeView;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button maximizeWindow;
        private System.Windows.Forms.Button minimizeWindow;
        private System.Windows.Forms.Label windowTitle;
        private System.Windows.Forms.TextBox direcciones;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox CodObjTextBox;
        private System.Windows.Forms.ToolStripMenuItem resultadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapaDeMemoriaToolStripMenuItem;
    }
}

