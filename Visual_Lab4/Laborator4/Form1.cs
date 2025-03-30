using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Laborator4
{
    public partial class MenuForm: Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
            //se va deschide aplicația NotePad
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox1.Clear();//se va șterge textul introdus în TextBox
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox1.Clear(); //sterge textul afisat in caseta
            TextBox1.Visible = false; //caseta redevine invizibila
        }

        private void formatTextBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            boldToolStripMenuItem.Checked = boldToolStripMenuItem.Checked;
            TextBox1.Font = new Font(TextBox1.Font.FontFamily, 14,
            TextBox1.Font.Style ^ FontStyle.Bold);
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            italicToolStripMenuItem.Checked = italicToolStripMenuItem.Checked;
            TextBox1.Font = new Font(TextBox1.Font.FontFamily, 14,
            TextBox1.Font.Style ^ FontStyle.Italic);
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            displayLabel.ForeColor = Color.Red;
            redItem.Checked = true;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            displayLabel.ForeColor = Color.Blue;
            redItem.Checked = true;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            displayLabel.ForeColor = Color.Green;
            redItem.Checked = true;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            displayLabel.ForeColor = Color.Black;
            redItem.Checked = true;
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox1.Paste();
        }

        private void colorToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void redToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClearColor();
            TextBox1.ForeColor = Color.Red;
            blackItem.Checked = true;
        }

        private void greebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            TextBox1.ForeColor = Color.Green;
            blackItem.Checked = true;
        }

        private void blueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClearColor();
            TextBox1.ForeColor = Color.Blue;
            blackItem.Checked = true;

        }

        private void blackToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClearColor();
            TextBox1.ForeColor = Color.Black;
            blackItem.Checked = true;

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void formatLabelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exemplu de utilizare a meniurilor","Informatii", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timesItem_Click(object sender, EventArgs e)
        {
            displayLabel.Font = new Font("Times New Roman", 14,displayLabel.Font.Style);
            timesItem.Checked = true;
        }

        private void courierItem_Click(object sender, EventArgs e)
        {
            displayLabel.Font = new Font("Courier", 14, displayLabel.Font.Style);
            timesItem.Checked = true;
        }

        private void comicItem_Click(object sender, EventArgs e)
        {
            displayLabel.Font = new Font("Comic San Serif", 14,displayLabel.Font.Style);
            timesItem.Checked = true;
        }

        private void boldItem_Click(object sender, EventArgs e)
        {
            boldItem.Checked = !boldItem.Checked;
            displayLabel.Font = new Font(displayLabel.Font.FontFamily, 14,displayLabel.Font.Style ^ FontStyle.Bold);
        }

        private void italicItem_Click(object sender, EventArgs e)
        {
            italicItem.Checked = !italicItem.Checked;
            displayLabel.Font = new Font(displayLabel.Font.FontFamily, 14,displayLabel.Font.Style ^ FontStyle.Italic);
        }

        private void regularItem_Click(object sender, EventArgs e)
        {
            regularItem.Checked = regularItem.Checked;
            displayLabel.Font = new Font(displayLabel.Font.FontFamily, 14,displayLabel.Font.Style ^ FontStyle.Regular);
        }

        private void ClearColor()
        {
            blackItem.Checked = false;
            blueItem.Checked = false;
            redItem.Checked = false;
            greenItem.Checked = false;
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
