using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textbox
{
    public class Textbox
    {
        public string Placeholder { get; set; }
        public string Name { get; set; }
        public static List<Textbox> textBoxes = new List<Textbox>();
        public static ArrayList textBoxesInUI = new ArrayList();

        public Textbox(string text, string name)
        {
            this.Placeholder = text;
            this.Name = name;
        }
    }
}
