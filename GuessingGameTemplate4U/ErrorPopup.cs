using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGameTemplate4U
{
    public partial class ErrorPopup : UserControl
    {
        public ErrorPopup()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {

            // f is the form that this control is on - ("this" is the current User Control) 

            Form f = this.FindForm();

            f.Controls.Remove(this);

            // Add the User Control to the Form 

        }
    }
}
