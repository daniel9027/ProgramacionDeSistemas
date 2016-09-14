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
            this.label1 = new System.Windows.Forms.Label();
            this.inputEquation = new System.Windows.Forms.TextBox();
            this.Resultado = new System.Windows.Forms.Label();
            this.outputEquation = new System.Windows.Forms.TextBox();
            this.readEquation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadena de entrada";
            // 
            // inputEquation
            // 
            this.inputEquation.Location = new System.Drawing.Point(16, 30);
            this.inputEquation.Name = "inputEquation";
            this.inputEquation.Size = new System.Drawing.Size(382, 20);
            this.inputEquation.TabIndex = 1;
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Location = new System.Drawing.Point(16, 57);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(55, 13);
            this.Resultado.TabIndex = 2;
            this.Resultado.Text = "Resultado";
            // 
            // outputEquation
            // 
            this.outputEquation.Location = new System.Drawing.Point(19, 74);
            this.outputEquation.Name = "outputEquation";
            this.outputEquation.Size = new System.Drawing.Size(379, 20);
            this.outputEquation.TabIndex = 3;
            // 
            // readEquation
            // 
            this.readEquation.BackColor = System.Drawing.SystemColors.HighlightText;
            this.readEquation.Location = new System.Drawing.Point(19, 101);
            this.readEquation.Name = "readEquation";
            this.readEquation.Size = new System.Drawing.Size(75, 36);
            this.readEquation.TabIndex = 4;
            this.readEquation.Text = "button1";
            this.readEquation.UseVisualStyleBackColor = false;
            this.readEquation.Click += new System.EventHandler(this.readEquation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 153);
            this.Controls.Add(this.readEquation);
            this.Controls.Add(this.outputEquation);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.inputEquation);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "SIC Simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputEquation;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.TextBox outputEquation;
        private System.Windows.Forms.Button readEquation;
    }
}

