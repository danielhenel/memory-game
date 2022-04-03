using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    class Style
    {
        static System.Drawing.Color backgroundColor = System.Drawing.SystemColors.Info;
        static System.Drawing.Color buttonColor = System.Drawing.SystemColors.MenuHighlight;
        static System.Drawing.Font buttonFont = new System.Drawing.Font("MV Boli", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        static System.Drawing.Font labelFont = new System.Drawing.Font("MV Boli", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        public static System.Drawing.Color getBackgroundColor()
        {
            return backgroundColor;
        } 

        public static System.Drawing.Color getButtonColor()
        {
            return buttonColor;
        }

        public static System.Drawing.Font getButtonFont()
        {
            return buttonFont;
        }
    }
}
