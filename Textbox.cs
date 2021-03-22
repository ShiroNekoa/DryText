using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textbox
{
    public class Textbox
    {
        public string Placeholder { get; set; }
        public string Name { get; set; }

        public Textbox(string text, string name)
        {
            Placeholder = text;
            Name = name;
        }
    }
}
