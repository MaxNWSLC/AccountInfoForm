using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPage
{
    class ThemeClass
    {
        private string backColor;
        private string fontColor;
        private string textBoxBackColor;
        private string textBoxFontColor;
        private string buttonBackColor;
        private string buttonFontColor;

        public ThemeClass(string backColor, string fontColor, string textBoxBackColor, string textBoxFontColor, string buttonBackColor, string buttonFontColor)
        {
            this.backColor = backColor;
            this.fontColor = fontColor;
            this.textBoxBackColor = textBoxBackColor;
            this.textBoxFontColor = textBoxFontColor;
            this.buttonBackColor = buttonBackColor;
            this.buttonFontColor = buttonFontColor;
        }

        public string BackColor { get => backColor; set => backColor = value; }
        public string FontColor { get => fontColor; set => fontColor = value; }
        public string TextBoxBackColor { get => textBoxBackColor; set => textBoxBackColor = value; }
        public string TextBoxFontColor { get => textBoxFontColor; set => textBoxFontColor = value; }
        public string ButtonBackColor { get => buttonBackColor; set => buttonBackColor = value; }
        public string ButtonFontColor { get => buttonFontColor; set => buttonFontColor = value; }
    }
}
