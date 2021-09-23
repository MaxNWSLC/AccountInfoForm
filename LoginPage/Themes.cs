using System;

namespace LoginPage
{
    public class Themes
    {
        static readonly ThemeClass Default =new("Control", "ControlText", "Window", "WindowText", "Control", "Black");
        static readonly ThemeClass Dark =   new("Black", "WhiteSmoke", "Gainsboro", "WindowText", "Black", "WhiteSmoke");
        static readonly ThemeClass Light =  new("White", "DimGray", "White", "Black", "White", "DimGray");
        static readonly ThemeClass Orange = new("LightSalmon", "Maroon", "WhiteSmoke", "OrangeRed", "LightSalmon", "Maroon");
        static readonly ThemeClass Blue =   new("SteelBlue", "White", "WhiteSmoke", "RoyalBlue", "SteelBlue", "White");


        readonly ThemeClass[] themesArray = new ThemeClass[] { Default, Dark, Light, Orange, Blue };

        internal ThemeClass[] ThemesArray => themesArray;
    }
}