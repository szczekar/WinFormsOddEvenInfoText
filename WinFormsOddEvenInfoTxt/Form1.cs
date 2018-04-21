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

namespace WinFormsOddEvenInfoTxt
{
    public partial class OddEvenInfoText : Form
    {
        public OddEvenInfoText()
        {
            InitializeComponent();
        }

        private void buttonTxtInfo_Click(object sender, EventArgs e)
        {
             int inputUserNumber = Convert.ToInt32(inputNumber.Text);
             StreamWriter file;
              

            try
            {

                file = new StreamWriter(@"info.txt");

                if (inputUserNumber % 2 == 0)
                {

                    file.WriteLine("Number " + inputUserNumber + " is even !");

                }
                else
                {
                    file.WriteLine("Number " + inputUserNumber + " is odd !");

                }

                MessageBox.Show("File is saved.");
                file.Close();

            }
            catch(Exception)
            {
                MessageBox.Show("File was not created !");
            }
              
        }
    }
}
