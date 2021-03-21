using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
namespace textbox
{
    public partial class Form1 : Form
    {
        #region Variable to compare this is going to be used for logic
        public string name = "Name";
        public string Adress = "Adress";
        public string Email = "Email";
        public string cp = "Cp No.";
        
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void OnClick(object sender, EventArgs e)
        {

            #region Empty the textbox
            BunifuMaterialTextbox obj = (BunifuMaterialTextbox)sender;
            if (obj.Text == name || obj.Text == Adress || obj.Text == Email || obj.Text == cp)
            {
                obj.Text = string.Empty;
            }
            #endregion


        }

        private void OnLeave(object sender, EventArgs e)
        {
            #region TextBox Logic
             BunifuMaterialTextbox obj = (BunifuMaterialTextbox)sender;
            //checking the textbox if it is empty and giving the if statement a condition where we are selecting textbox name to mark and modify it
            if (obj.Text == string.Empty && obj.Name == "txt1")
            {
                obj.Text = name;
            }
            else if (obj.Text == string.Empty && obj.Name == "txt2")
            {
                obj.Text = Email;
            }
            else if (obj.Text == string.Empty && obj.Name == "txt3")
            {
                obj.Text = Adress;
            }
            else if (obj.Text == string.Empty && obj.Name == "txt4")
            {
                obj.Text = cp;
            }
            #endregion



        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
        }
    }       
}
