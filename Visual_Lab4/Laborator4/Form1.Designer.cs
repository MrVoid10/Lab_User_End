namespace Laborator4
{
    partial class MenuForm
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
            this.displayLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatTextBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.colorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.greebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.blackToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editTextBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timesItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courierItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comicItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boldItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italicItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regularItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true;
            this.displayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLabel.Location = new System.Drawing.Point(24, 34);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(355, 16);
            this.displayLabel.TabIndex = 0;
            this.displayLabel.Text = "Utilizați meniul Format ca sa schimbati aspectul acestui text";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileItem,
            this.editTextBoxToolStripMenuItem,
            this.formatItem,
            this.aboutItem,
            this.exitItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileItem
            // 
            this.fileItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.formatTextBoxToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileItem.Name = "fileItem";
            this.fileItem.Size = new System.Drawing.Size(39, 20);
            this.fileItem.Text = "File";
            this.fileItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.clearToolStripMenuItem.Text = "Clear TextBox";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // formatTextBoxToolStripMenuItem
            // 
            this.formatTextBoxToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boldToolStripMenuItem,
            this.italicToolStripMenuItem,
            this.toolStripSeparator1,
            this.colorToolStripMenuItem1});
            this.formatTextBoxToolStripMenuItem.Name = "formatTextBoxToolStripMenuItem";
            this.formatTextBoxToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.formatTextBoxToolStripMenuItem.Text = "Format TextBox";
            this.formatTextBoxToolStripMenuItem.Click += new System.EventHandler(this.formatTextBoxToolStripMenuItem_Click);
            // 
            // boldToolStripMenuItem
            // 
            this.boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            this.boldToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.boldToolStripMenuItem.Text = "Bold";
            this.boldToolStripMenuItem.Click += new System.EventHandler(this.boldToolStripMenuItem_Click);
            // 
            // italicToolStripMenuItem
            // 
            this.italicToolStripMenuItem.Name = "italicToolStripMenuItem";
            this.italicToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.italicToolStripMenuItem.Text = "Italic";
            this.italicToolStripMenuItem.Click += new System.EventHandler(this.italicToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(104, 6);
            // 
            // colorToolStripMenuItem1
            // 
            this.colorToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem1,
            this.greebToolStripMenuItem,
            this.blueToolStripMenuItem1,
            this.blackToolStripMenuItem1});
            this.colorToolStripMenuItem1.Name = "colorToolStripMenuItem1";
            this.colorToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.colorToolStripMenuItem1.Text = "Color";
            this.colorToolStripMenuItem1.Click += new System.EventHandler(this.colorToolStripMenuItem1_Click);
            // 
            // redToolStripMenuItem1
            // 
            this.redToolStripMenuItem1.Name = "redToolStripMenuItem1";
            this.redToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.redToolStripMenuItem1.Text = "Red";
            this.redToolStripMenuItem1.Click += new System.EventHandler(this.redToolStripMenuItem1_Click);
            // 
            // greebToolStripMenuItem
            // 
            this.greebToolStripMenuItem.Name = "greebToolStripMenuItem";
            this.greebToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.greebToolStripMenuItem.Text = "Green";
            this.greebToolStripMenuItem.Click += new System.EventHandler(this.greebToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem1
            // 
            this.blueToolStripMenuItem1.Name = "blueToolStripMenuItem1";
            this.blueToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.blueToolStripMenuItem1.Text = "Blue";
            this.blueToolStripMenuItem1.Click += new System.EventHandler(this.blueToolStripMenuItem1_Click);
            // 
            // blackToolStripMenuItem1
            // 
            this.blackToolStripMenuItem1.Name = "blackToolStripMenuItem1";
            this.blackToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.blackToolStripMenuItem1.Text = "Black";
            this.blackToolStripMenuItem1.Click += new System.EventHandler(this.blackToolStripMenuItem1_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // editTextBoxToolStripMenuItem
            // 
            this.editTextBoxToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editTextBoxToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editTextBoxToolStripMenuItem.Name = "editTextBoxToolStripMenuItem";
            this.editTextBoxToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.editTextBoxToolStripMenuItem.Text = "Edit TextBox";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // formatItem
            // 
            this.formatItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorItem,
            this.fontItem,
            this.toolStripSeparator2});
            this.formatItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formatItem.Name = "formatItem";
            this.formatItem.Size = new System.Drawing.Size(102, 20);
            this.formatItem.Text = "Format Label";
            this.formatItem.Click += new System.EventHandler(this.formatLabelToolStripMenuItem_Click);
            // 
            // colorItem
            // 
            this.colorItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redItem,
            this.blueItem,
            this.greenItem,
            this.blackItem});
            this.colorItem.Name = "colorItem";
            this.colorItem.Size = new System.Drawing.Size(107, 22);
            this.colorItem.Text = "Color";
            // 
            // redItem
            // 
            this.redItem.Name = "redItem";
            this.redItem.Size = new System.Drawing.Size(112, 22);
            this.redItem.Text = "Red";
            this.redItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // blueItem
            // 
            this.blueItem.Name = "blueItem";
            this.blueItem.Size = new System.Drawing.Size(112, 22);
            this.blueItem.Text = "Blue";
            this.blueItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // greenItem
            // 
            this.greenItem.Name = "greenItem";
            this.greenItem.Size = new System.Drawing.Size(112, 22);
            this.greenItem.Text = "Green";
            this.greenItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // blackItem
            // 
            this.blackItem.Name = "blackItem";
            this.blackItem.Size = new System.Drawing.Size(112, 22);
            this.blackItem.Text = "Black";
            this.blackItem.Click += new System.EventHandler(this.blackToolStripMenuItem_Click);
            // 
            // fontItem
            // 
            this.fontItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timesItem,
            this.courierItem,
            this.comicItem,
            this.toolStripSeparator3,
            this.boldItem,
            this.italicItem,
            this.regularItem});
            this.fontItem.Name = "fontItem";
            this.fontItem.Size = new System.Drawing.Size(180, 22);
            this.fontItem.Text = "Font";
            // 
            // timesItem
            // 
            this.timesItem.Name = "timesItem";
            this.timesItem.Size = new System.Drawing.Size(189, 22);
            this.timesItem.Text = "Times New Roman";
            this.timesItem.Click += new System.EventHandler(this.timesItem_Click);
            // 
            // courierItem
            // 
            this.courierItem.Name = "courierItem";
            this.courierItem.Size = new System.Drawing.Size(189, 22);
            this.courierItem.Text = "Courier";
            this.courierItem.Click += new System.EventHandler(this.courierItem_Click);
            // 
            // comicItem
            // 
            this.comicItem.Name = "comicItem";
            this.comicItem.Size = new System.Drawing.Size(189, 22);
            this.comicItem.Text = "Comic San Serif";
            this.comicItem.Click += new System.EventHandler(this.comicItem_Click);
            // 
            // boldItem
            // 
            this.boldItem.Name = "boldItem";
            this.boldItem.Size = new System.Drawing.Size(189, 22);
            this.boldItem.Text = "Bold";
            this.boldItem.Click += new System.EventHandler(this.boldItem_Click);
            // 
            // italicItem
            // 
            this.italicItem.Name = "italicItem";
            this.italicItem.Size = new System.Drawing.Size(189, 22);
            this.italicItem.Text = "Italic";
            this.italicItem.Click += new System.EventHandler(this.italicItem_Click);
            // 
            // regularItem
            // 
            this.regularItem.Name = "regularItem";
            this.regularItem.Size = new System.Drawing.Size(189, 22);
            this.regularItem.Text = "Regular";
            this.regularItem.Click += new System.EventHandler(this.regularItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(104, 6);
            // 
            // aboutItem
            // 
            this.aboutItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutItem.Name = "aboutItem";
            this.aboutItem.Size = new System.Drawing.Size(59, 20);
            this.aboutItem.Text = "About";
            this.aboutItem.Click += new System.EventHandler(this.aboutItem_Click);
            // 
            // exitItem
            // 
            this.exitItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitItem.Name = "exitItem";
            this.exitItem.Size = new System.Drawing.Size(42, 20);
            this.exitItem.Text = "Exit";
            this.exitItem.Click += new System.EventHandler(this.exitItem_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(52, 73);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(272, 22);
            this.TextBox1.TabIndex = 2;
            this.TextBox1.Text = "TextBox de manupulat exemplu";
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(186, 6);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuForm";
            this.Text = "Utilizare meniuri";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatTextBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem italicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editTextBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatItem;
        private System.Windows.Forms.ToolStripMenuItem colorItem;
        private System.Windows.Forms.ToolStripMenuItem redItem;
        private System.Windows.Forms.ToolStripMenuItem blueItem;
        private System.Windows.Forms.ToolStripMenuItem greenItem;
        private System.Windows.Forms.ToolStripMenuItem blackItem;
        private System.Windows.Forms.ToolStripMenuItem fontItem;
        private System.Windows.Forms.ToolStripMenuItem timesItem;
        private System.Windows.Forms.ToolStripMenuItem courierItem;
        private System.Windows.Forms.ToolStripMenuItem comicItem;
        private System.Windows.Forms.ToolStripMenuItem boldItem;
        private System.Windows.Forms.ToolStripMenuItem italicItem;
        private System.Windows.Forms.ToolStripMenuItem regularItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem greebToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem aboutItem;
        private System.Windows.Forms.ToolStripMenuItem exitItem;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

