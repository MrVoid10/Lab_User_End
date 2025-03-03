#nullable disable
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Laborator1
{
    public partial class Form1 : Form
    {
        private Label TitleLabel;
        private Label nLabel;
        private TextBox nTextBox;
        private Button ApasaButton;
        private TextBox RezultatTextBox;

        public Form1()
        {
            // Setări pentru fereastră
            this.Name = "Form1";
            this.BackColor = Color.Aquamarine;
            this.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            this.ForeColor = Color.Navy;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new Size(500, 400);
            this.Text = "Afișarea numerelor mai mici ca un n dat";

            // Label: TitleLabel
            TitleLabel = new Label();
            TitleLabel.Name = "TitleLabel";
            TitleLabel.BorderStyle = BorderStyle.Fixed3D;
            TitleLabel.Location = new Point(25, 70);
            TitleLabel.Size = new Size(175, 25);
            TitleLabel.TabIndex = 1;
            TitleLabel.Text = "Dați valoarea lui n";
            this.Controls.Add(TitleLabel);

            // Label: nLabel
            nLabel = new Label();
            nLabel.Name = "nLabel";
            nLabel.BorderStyle = BorderStyle.Fixed3D;
            nLabel.Location = new Point((this.ClientSize.Width - nLabel.Width -(225/2))  / 2, 30);
            nLabel.Size = new Size(225, 30);
            nLabel.Text = "Introduceți valoarea lui n";
            this.Controls.Add(nLabel);

            // TextBox: nTextBox
            nTextBox = new TextBox();
            nTextBox.Name = "nTextBox";
            nTextBox.Location = new Point(220, 70);
            nTextBox.Size = new Size(50, 20);
            this.Controls.Add(nTextBox);

            // Button: ApasaButton
            ApasaButton = new Button();
            ApasaButton.Name = "ApasaButton";
            ApasaButton.Location = new Point(50, 105);
            ApasaButton.Size = new Size(90, 30);
            ApasaButton.Text = "Apasă";
            ApasaButton.Click += new EventHandler(ApasaButton_Click);
            this.Controls.Add(ApasaButton);

            // TextBox: RezultatTextBox
            RezultatTextBox = new TextBox();
            RezultatTextBox.Name = "RezultatTextBox";
            RezultatTextBox.Location = new Point(20, 140);
            RezultatTextBox.ScrollBars = ScrollBars.Both;
            RezultatTextBox.Size = new Size(370, 180);
            RezultatTextBox.Multiline = true;
            this.Controls.Add(RezultatTextBox);
        }

        private void ApasaButton_Click(object sender, EventArgs e)
        {
            RezultatTextBox.Clear();
            if (int.TryParse(nTextBox.Text, out int n))
            {
                for (int i = 0; i < n; i++)
                {
                    RezultatTextBox.AppendText(i + " ");
                }
            }
            else
            {
                MessageBox.Show("Introduceți un număr valid!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}