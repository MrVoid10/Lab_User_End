using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UpForm: Form
    {
        public UpForm()
        {
            InitializeComponent();
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Apl_Ceas_Tick(object sender, EventArgs e)
        {
            Label_Ora_de_Afisat.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
