namespace AsincronoForm
{
    partial class Asincrono
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Asincrono));
            this.AccionUnobutton = new System.Windows.Forms.Button();
            this.AccionDosButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AccionUnobutton
            // 
            this.AccionUnobutton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.AccionUnobutton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AccionUnobutton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AccionUnobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccionUnobutton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.AccionUnobutton.Image = ((System.Drawing.Image)(resources.GetObject("AccionUnobutton.Image")));
            this.AccionUnobutton.Location = new System.Drawing.Point(86, 23);
            this.AccionUnobutton.Name = "AccionUnobutton";
            this.AccionUnobutton.Size = new System.Drawing.Size(114, 54);
            this.AccionUnobutton.TabIndex = 0;
            this.AccionUnobutton.Text = "Accion Uno";
            this.AccionUnobutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AccionUnobutton.UseVisualStyleBackColor = true;
            // 
            // AccionDosButton
            // 
            this.AccionDosButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.AccionDosButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AccionDosButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AccionDosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccionDosButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.AccionDosButton.Image = ((System.Drawing.Image)(resources.GetObject("AccionDosButton.Image")));
            this.AccionDosButton.Location = new System.Drawing.Point(311, 23);
            this.AccionDosButton.Name = "AccionDosButton";
            this.AccionDosButton.Size = new System.Drawing.Size(115, 54);
            this.AccionDosButton.TabIndex = 1;
            this.AccionDosButton.Text = "Accion Dos";
            this.AccionDosButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AccionDosButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Asincrono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 267);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AccionDosButton);
            this.Controls.Add(this.AccionUnobutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Asincrono";
            this.Text = "Prueba";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AccionUnobutton;
        private System.Windows.Forms.Button AccionDosButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}

