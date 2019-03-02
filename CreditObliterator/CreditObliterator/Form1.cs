using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CreditObliterator
{
    

    public partial class mainPage : Form
    {

        //new Card variables need access between forms

        public static string newCardName;
        public static double newCardRate;
        public static double newCardPrincipal;

        public mainPage()
        {
            InitializeComponent();
        }

        private void doubleButton_Click(object sender, EventArgs e)
        {
           
        }

        private void trippleButton_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addCardButton_Click(object sender, EventArgs e)
        {
            //new form for additional information
            addForm f2 = new addForm();
            f2.ShowDialog();

            //create radio box
            RadioButton rdo = new RadioButton();
            rdo.Name = newCardName+"RadioButton";
            rdo.Text = newCardName;
            cardGroupBox.Controls.Add(rdo);

            //Creates variables attached to radiobutton

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //create
        }
    }
}
