namespace WindowsFormsApp1
{
    partial class UpForm
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
            this.components = new System.ComponentModel.Container();
            this.Label_Ora = new System.Windows.Forms.Label();
            this.UpButton = new System.Windows.Forms.Button();
            this.Label_Ora_de_Afisat = new System.Windows.Forms.Label();
            this.Apl_Ceas = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Label_Ora
            // 
            this.Label_Ora.AutoSize = true;
            this.Label_Ora.Location = new System.Drawing.Point(90, 9);
            this.Label_Ora.Name = "Label_Ora";
            this.Label_Ora.Size = new System.Drawing.Size(111, 16);
            this.Label_Ora.TabIndex = 0;
            this.Label_Ora.Text = "Care este Ora?";
            // 
            // UpButton
            // 
            this.UpButton.Location = new System.Drawing.Point(107, 226);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(75, 23);
            this.UpButton.TabIndex = 1;
            this.UpButton.Text = "Close";
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // Label_Ora_de_Afisat
            // 
            this.Label_Ora_de_Afisat.AutoSize = true;
            this.Label_Ora_de_Afisat.Location = new System.Drawing.Point(104, 49);
            this.Label_Ora_de_Afisat.Name = "Label_Ora_de_Afisat";
            this.Label_Ora_de_Afisat.Size = new System.Drawing.Size(262, 16);
            this.Label_Ora_de_Afisat.TabIndex = 2;
            this.Label_Ora_de_Afisat.Text = "inloc de acest text ar trebui sa fie ora";
            this.Label_Ora_de_Afisat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Apl_Ceas
            // 
            this.Apl_Ceas.Enabled = true;
            this.Apl_Ceas.Interval = 1000;
            this.Apl_Ceas.Tick += new System.EventHandler(this.Apl_Ceas_Tick);
            // 
            // UpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(294, 261);
            this.Controls.Add(this.Label_Ora_de_Afisat);
            this.Controls.Add(this.UpButton);
            this.Controls.Add(this.Label_Ora);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UpForm";
            this.Text = "UpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Ora;
        private System.Windows.Forms.Button UpButton;
        private System.Windows.Forms.Label Label_Ora_de_Afisat;
        private System.Windows.Forms.Timer Apl_Ceas;
    }
}