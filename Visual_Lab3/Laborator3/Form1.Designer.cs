namespace Laborator3
{
    partial class testRdBtnForm
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
            this.typeGroup = new System.Windows.Forms.GroupBox();
            this.RetCancelBtn = new System.Windows.Forms.RadioButton();
            this.YesNoRdBtn = new System.Windows.Forms.RadioButton();
            this.YesNoCancelRdBtn = new System.Windows.Forms.RadioButton();
            this.AbRetIgRdBtn = new System.Windows.Forms.RadioButton();
            this.OkCancelRdBtn = new System.Windows.Forms.RadioButton();
            this.OkRdBtn = new System.Windows.Forms.RadioButton();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.iconGroup = new System.Windows.Forms.GroupBox();
            this.QuestRdBtn = new System.Windows.Forms.RadioButton();
            this.InfoRdBtn = new System.Windows.Forms.RadioButton();
            this.ExclamRdBtn = new System.Windows.Forms.RadioButton();
            this.ErrorRdBtn = new System.Windows.Forms.RadioButton();
            this.DisplayBtn = new System.Windows.Forms.Button();
            this.DisplayLabel = new System.Windows.Forms.Label();
            this.typeGroup.SuspendLayout();
            this.iconGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // typeGroup
            // 
            this.typeGroup.Controls.Add(this.RetCancelBtn);
            this.typeGroup.Controls.Add(this.YesNoRdBtn);
            this.typeGroup.Controls.Add(this.YesNoCancelRdBtn);
            this.typeGroup.Controls.Add(this.AbRetIgRdBtn);
            this.typeGroup.Controls.Add(this.OkCancelRdBtn);
            this.typeGroup.Controls.Add(this.OkRdBtn);
            this.typeGroup.Location = new System.Drawing.Point(12, 30);
            this.typeGroup.Name = "typeGroup";
            this.typeGroup.Size = new System.Drawing.Size(131, 203);
            this.typeGroup.TabIndex = 0;
            this.typeGroup.TabStop = false;
            this.typeGroup.Text = "Button Type";
            this.typeGroup.Enter += new System.EventHandler(this.typeGroup_Enter);
            // 
            // RetCancelBtn
            // 
            this.RetCancelBtn.AutoSize = true;
            this.RetCancelBtn.Location = new System.Drawing.Point(9, 160);
            this.RetCancelBtn.Name = "RetCancelBtn";
            this.RetCancelBtn.Size = new System.Drawing.Size(83, 17);
            this.RetCancelBtn.TabIndex = 6;
            this.RetCancelBtn.TabStop = true;
            this.RetCancelBtn.Text = "RetryCancel";
            this.RetCancelBtn.UseVisualStyleBackColor = true;
            this.RetCancelBtn.CheckedChanged += new System.EventHandler(this.buttonType_CheckedChanged);
            // 
            // YesNoRdBtn
            // 
            this.YesNoRdBtn.AutoSize = true;
            this.YesNoRdBtn.Location = new System.Drawing.Point(9, 137);
            this.YesNoRdBtn.Name = "YesNoRdBtn";
            this.YesNoRdBtn.Size = new System.Drawing.Size(57, 17);
            this.YesNoRdBtn.TabIndex = 5;
            this.YesNoRdBtn.TabStop = true;
            this.YesNoRdBtn.Text = "YesNo";
            this.YesNoRdBtn.UseVisualStyleBackColor = true;
            this.YesNoRdBtn.CheckedChanged += new System.EventHandler(this.buttonType_CheckedChanged);
            // 
            // YesNoCancelRdBtn
            // 
            this.YesNoCancelRdBtn.AutoSize = true;
            this.YesNoCancelRdBtn.Location = new System.Drawing.Point(9, 114);
            this.YesNoCancelRdBtn.Name = "YesNoCancelRdBtn";
            this.YesNoCancelRdBtn.Size = new System.Drawing.Size(90, 17);
            this.YesNoCancelRdBtn.TabIndex = 4;
            this.YesNoCancelRdBtn.TabStop = true;
            this.YesNoCancelRdBtn.Text = "YesNoCancel";
            this.YesNoCancelRdBtn.UseVisualStyleBackColor = true;
            this.YesNoCancelRdBtn.CheckedChanged += new System.EventHandler(this.buttonType_CheckedChanged);
            // 
            // AbRetIgRdBtn
            // 
            this.AbRetIgRdBtn.AutoSize = true;
            this.AbRetIgRdBtn.Location = new System.Drawing.Point(9, 91);
            this.AbRetIgRdBtn.Name = "AbRetIgRdBtn";
            this.AbRetIgRdBtn.Size = new System.Drawing.Size(105, 17);
            this.AbRetIgRdBtn.TabIndex = 3;
            this.AbRetIgRdBtn.TabStop = true;
            this.AbRetIgRdBtn.Text = "AbortRetryIgnore";
            this.AbRetIgRdBtn.UseVisualStyleBackColor = true;
            this.AbRetIgRdBtn.CheckedChanged += new System.EventHandler(this.buttonType_CheckedChanged);
            // 
            // OkCancelRdBtn
            // 
            this.OkCancelRdBtn.AutoSize = true;
            this.OkCancelRdBtn.Location = new System.Drawing.Point(9, 68);
            this.OkCancelRdBtn.Name = "OkCancelRdBtn";
            this.OkCancelRdBtn.Size = new System.Drawing.Size(73, 17);
            this.OkCancelRdBtn.TabIndex = 2;
            this.OkCancelRdBtn.TabStop = true;
            this.OkCancelRdBtn.Text = "OKCancel";
            this.OkCancelRdBtn.UseVisualStyleBackColor = true;
            this.OkCancelRdBtn.CheckedChanged += new System.EventHandler(this.buttonType_CheckedChanged);
            // 
            // OkRdBtn
            // 
            this.OkRdBtn.AutoSize = true;
            this.OkRdBtn.Location = new System.Drawing.Point(9, 45);
            this.OkRdBtn.Name = "OkRdBtn";
            this.OkRdBtn.Size = new System.Drawing.Size(40, 17);
            this.OkRdBtn.TabIndex = 1;
            this.OkRdBtn.TabStop = true;
            this.OkRdBtn.Text = "OK";
            this.OkRdBtn.UseVisualStyleBackColor = true;
            this.OkRdBtn.CheckedChanged += new System.EventHandler(this.buttonType_CheckedChanged);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(20, 9);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(262, 13);
            this.InfoLabel.TabIndex = 0;
            this.InfoLabel.Text = "– Alegeți tipul de MessageBox pe care doriti sa-l Afisati";
            // 
            // iconGroup
            // 
            this.iconGroup.Controls.Add(this.QuestRdBtn);
            this.iconGroup.Controls.Add(this.InfoRdBtn);
            this.iconGroup.Controls.Add(this.ExclamRdBtn);
            this.iconGroup.Controls.Add(this.ErrorRdBtn);
            this.iconGroup.Location = new System.Drawing.Point(160, 30);
            this.iconGroup.Name = "iconGroup";
            this.iconGroup.Size = new System.Drawing.Size(122, 203);
            this.iconGroup.TabIndex = 1;
            this.iconGroup.TabStop = false;
            this.iconGroup.Text = "Icon Type";
            this.iconGroup.Enter += new System.EventHandler(this.iconGroup_Enter);
            // 
            // QuestRdBtn
            // 
            this.QuestRdBtn.AutoSize = true;
            this.QuestRdBtn.Location = new System.Drawing.Point(25, 129);
            this.QuestRdBtn.Name = "QuestRdBtn";
            this.QuestRdBtn.Size = new System.Drawing.Size(67, 17);
            this.QuestRdBtn.TabIndex = 4;
            this.QuestRdBtn.TabStop = true;
            this.QuestRdBtn.Text = "Question";
            this.QuestRdBtn.UseVisualStyleBackColor = true;
            this.QuestRdBtn.CheckedChanged += new System.EventHandler(this.iconType_CheckedChanged);
            // 
            // InfoRdBtn
            // 
            this.InfoRdBtn.AutoSize = true;
            this.InfoRdBtn.Location = new System.Drawing.Point(25, 106);
            this.InfoRdBtn.Name = "InfoRdBtn";
            this.InfoRdBtn.Size = new System.Drawing.Size(77, 17);
            this.InfoRdBtn.TabIndex = 3;
            this.InfoRdBtn.TabStop = true;
            this.InfoRdBtn.Text = "Information";
            this.InfoRdBtn.UseVisualStyleBackColor = true;
            this.InfoRdBtn.CheckedChanged += new System.EventHandler(this.iconType_CheckedChanged);
            // 
            // ExclamRdBtn
            // 
            this.ExclamRdBtn.AutoSize = true;
            this.ExclamRdBtn.Location = new System.Drawing.Point(25, 83);
            this.ExclamRdBtn.Name = "ExclamRdBtn";
            this.ExclamRdBtn.Size = new System.Drawing.Size(82, 17);
            this.ExclamRdBtn.TabIndex = 2;
            this.ExclamRdBtn.TabStop = true;
            this.ExclamRdBtn.Text = "Exclamation";
            this.ExclamRdBtn.UseVisualStyleBackColor = true;
            this.ExclamRdBtn.CheckedChanged += new System.EventHandler(this.iconType_CheckedChanged);
            // 
            // ErrorRdBtn
            // 
            this.ErrorRdBtn.AutoSize = true;
            this.ErrorRdBtn.Location = new System.Drawing.Point(25, 60);
            this.ErrorRdBtn.Name = "ErrorRdBtn";
            this.ErrorRdBtn.Size = new System.Drawing.Size(47, 17);
            this.ErrorRdBtn.TabIndex = 1;
            this.ErrorRdBtn.TabStop = true;
            this.ErrorRdBtn.Text = "Error";
            this.ErrorRdBtn.UseVisualStyleBackColor = true;
            this.ErrorRdBtn.CheckedChanged += new System.EventHandler(this.iconType_CheckedChanged);
            // 
            // DisplayBtn
            // 
            this.DisplayBtn.Location = new System.Drawing.Point(132, 244);
            this.DisplayBtn.Name = "DisplayBtn";
            this.DisplayBtn.Size = new System.Drawing.Size(150, 30);
            this.DisplayBtn.TabIndex = 5;
            this.DisplayBtn.Text = "Afiseaza";
            this.DisplayBtn.UseVisualStyleBackColor = true;
            this.DisplayBtn.Click += new System.EventHandler(this.DisplayBtn_Click);
            // 
            // DisplayLabel
            // 
            this.DisplayLabel.AutoSize = true;
            this.DisplayLabel.Location = new System.Drawing.Point(51, 253);
            this.DisplayLabel.Name = "DisplayLabel";
            this.DisplayLabel.Size = new System.Drawing.Size(17, 13);
            this.DisplayLabel.TabIndex = 0;
            this.DisplayLabel.Text = "\"\"";
            this.DisplayLabel.Click += new System.EventHandler(this.DisplayLabel_Click);
            // 
            // testRdBtnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(310, 286);
            this.Controls.Add(this.DisplayBtn);
            this.Controls.Add(this.iconGroup);
            this.Controls.Add(this.typeGroup);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.DisplayLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "testRdBtnForm";
            this.Text = "Test RadioButtons";
            this.typeGroup.ResumeLayout(false);
            this.typeGroup.PerformLayout();
            this.iconGroup.ResumeLayout(false);
            this.iconGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox typeGroup;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.RadioButton OkRdBtn;
        private System.Windows.Forms.RadioButton OkCancelRdBtn;
        private System.Windows.Forms.RadioButton AbRetIgRdBtn;
        private System.Windows.Forms.RadioButton YesNoCancelRdBtn;
        private System.Windows.Forms.RadioButton YesNoRdBtn;
        private System.Windows.Forms.RadioButton RetCancelBtn;
        private System.Windows.Forms.GroupBox iconGroup;
        private System.Windows.Forms.RadioButton ErrorRdBtn;
        private System.Windows.Forms.RadioButton InfoRdBtn;
        private System.Windows.Forms.RadioButton ExclamRdBtn;
        private System.Windows.Forms.RadioButton QuestRdBtn;
        private System.Windows.Forms.Button DisplayBtn;
        private System.Windows.Forms.Label DisplayLabel;
    }
}

