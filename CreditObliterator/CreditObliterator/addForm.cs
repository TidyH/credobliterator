using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditObliterator
{
    public partial class addForm : Form
    {
        public addForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            try
            {
                //Form1.newCardName = newCardNameTextBox.Text;
                mainPage.newCardName = newCardNameTextBox.Text;
                mainPage.newCardRate = double.Parse(newCardRateTextBox.Text);
                mainPage.newCardPrincipal = double.Parse(newCardPrincipalTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}
