namespace WindowsFormsApp1
{
    partial class PupForm
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
            this.PopButton = new System.Windows.Forms.Button();
            this.Label_data = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // PopButton
            // 
            this.PopButton.AutoSize = true;
            this.PopButton.Location = new System.Drawing.Point(118, 217);
            this.PopButton.Name = "PopButton";
            this.PopButton.Size = new System.Drawing.Size(75, 26);
            this.PopButton.TabIndex = 0;
            this.PopButton.Text = "Next";
            this.PopButton.UseVisualStyleBackColor = true;
            this.PopButton.Click += new System.EventHandler(this.PopButton_Click);
            // 
            // Label_data
            // 
            this.Label_data.AutoSize = true;
            this.Label_data.Location = new System.Drawing.Point(95, 9);
            this.Label_data.Name = "Label_data";
            this.Label_data.Size = new System.Drawing.Size(117, 16);
            this.Label_data.TabIndex = 1;
            this.Label_data.Text = "Care este data?";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.Location = new System.Drawing.Point(40, 34);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // PupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(313, 272);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.Label_data);
            this.Controls.Add(this.PopButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PupForm";
            this.Text = "Pop Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PopButton;
        private System.Windows.Forms.Label Label_data;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}

