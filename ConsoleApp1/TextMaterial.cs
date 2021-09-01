using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task001
{
     class TextMaterial : TrainingMaterial 
    {
        private string _text;
        public string Text
        {
            get { return _text; }
            set { if ( value.Length > 0 && value.Length <= 10000 ) _text = value; }
        }
        public TextMaterial (string text, Guid unicId) : base(unicId)
        {
            Text = text;
        }

    }
}
