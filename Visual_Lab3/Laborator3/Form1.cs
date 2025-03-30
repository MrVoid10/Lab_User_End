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

namespace Laborator3
{
    public partial class testRdBtnForm: Form
    {
        private MessageBoxButtons buttonType = MessageBoxButtons.OK; // Pentru tipul butoanelor
        private MessageBoxIcon iconType = MessageBoxIcon.Error; // Pentru tipul iconului

        public testRdBtnForm()
        {
            InitializeComponent();
        }

        private void DisplayLabel_Click(object sender, EventArgs e)
        {

        }

        private void typeGroup_Enter(object sender, EventArgs e)
        {

        }

        private void iconGroup_Enter(object sender, EventArgs e)
        {

        }

        private void buttonType_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == OkRdBtn)
                buttonType = MessageBoxButtons.OK;
            else if (sender == OkCancelRdBtn)
                buttonType = MessageBoxButtons.OKCancel;
            else if (sender == AbRetIgRdBtn)
                buttonType = MessageBoxButtons.AbortRetryIgnore;
            else if (sender == YesNoCancelRdBtn)
                buttonType = MessageBoxButtons.YesNoCancel;
            else if (sender == YesNoRdBtn)
                buttonType = MessageBoxButtons.YesNo;
            else buttonType = MessageBoxButtons.RetryCancel;
        }

        private void iconType_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == ErrorRdBtn)
                iconType = MessageBoxIcon.Error;
            else if (sender == ExclamRdBtn)
                iconType = MessageBoxIcon.Exclamation;
            else if (sender == InfoRdBtn)
                iconType = MessageBoxIcon.Information;
            else iconType = MessageBoxIcon.Question;
        }

        private void DisplayBtn_Click(object sender, EventArgs e)
        {
            DialogResult resut = MessageBox.Show("Acesta este obiceiul tau MessageBox.", "CustomMessageBox", buttonType, iconType, 0, 0);
            switch (resut)
            {
                case DialogResult.OK:
                    DisplayLabel.Text = " Ok a fostapăsat.";break;
                case DialogResult.Cancel:
                    DisplayLabel.Text = " Cancel a fost apăsat."; break;
                case DialogResult.Abort:
                    DisplayLabel.Text = " Abort a fost apăsat."; break;
                case DialogResult.Retry:
                    DisplayLabel.Text = " Retry a fost apăsat."; break;
                case DialogResult.Ignore:
                    DisplayLabel.Text = " Ignore a fost apăsat."; break;
                case DialogResult.Yes:
                    DisplayLabel.Text = " Yes a fost apăsat."; break;
                case DialogResult.No:
                    DisplayLabel.Text = " NO a fostapăsat."; break; 
            } 
        }
    }
}
