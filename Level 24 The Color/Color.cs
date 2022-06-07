using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_24_The_Color
{
    internal class Color
    {
        private string _colorName;
        private int _red;
        private int _green;
        private int _blue;

        //General class constructor for use with custom colors that will be hardcoded into the main upon instantiation.
        public Color(string colorName, int red, int green, int blue)
        {

            _colorName = colorName;
            if (red <0 || red > 255 || green < 0 || green > 255 || blue < 0 || blue > 255 )
            {
                throw new Exception("Color is out of range. Values must not be more than 255");
            }
            _red = red;
            _green = green;
            _blue = blue;
        }

        //constructor for colors that will use the color-specific color methods. This will prevent the asisgnment of values. 
        public Color(string name)
        {
            _colorName=name;
        }

        public void WhiteConstructor() => new Color(_colorName = "White", _red = 255, _green = 255, _blue = 255);
        public void BlackConstructor() => new Color(_colorName = "Black", _red = 0, _green = 0, _blue = 0);
        public void RedConstructor() => new Color(_colorName = "Red", _red = 255, _green = 0, _blue = 0);
        public void OrangeConstructor() => new Color(_colorName = "Orange", _red = 255, _green = 165, _blue = 0);
        public void YellowConstructor() => new Color(_colorName = "Yellow", _red = 255, _green = 255, _blue = 0);
        public void GreenConstructor() => new Color(_colorName = "Green", _red = 0, _green = 128, _blue = 0);
        public void BlueConstructor() => new Color(_colorName = "Blue", _red = 0, _green = 0, _blue = 255);
        public void PurpleConstructor() => new Color(_colorName = "Purple", _red = 128, _green = 0, _blue = 128);

       
        public void OutputColorNameAndValues()
        {
            Console.WriteLine($"{_colorName} ({_red}, {_green}, {_blue})");
        }
    }
}
