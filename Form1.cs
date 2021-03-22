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
        public Form1()
        {
            InitializeComponent();
        }
        
        private void OnClick(object sender, EventArgs e)
        {
            if (!Textbox.textBoxesInUI.Contains(ActiveControl))
            {
                Textbox.textBoxesInUI.Add(ActiveControl);
                Textbox.textBoxes.Add(new Textbox(ActiveControl.Text, ActiveControl.Name));
            }

            foreach (var textbox in Textbox.textBoxes)
            {
                if (ActiveControl.Text == textbox.Placeholder)
                {
                    ActiveControl.Text = string.Empty;
                }
            }
        }

        private void OnLeave(object sender, EventArgs e)
        {
            var obj = (BunifuMaterialTextbox)sender;
            foreach (var textbox in Textbox.textBoxes)
            {
                if (obj.Text == string.Empty && obj.Name == textbox.Name)
                {
                    obj.Text = textbox.Placeholder;
                }
            }
        }
    }
}
