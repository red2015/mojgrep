using System;

namespace mojgrep.CommandStuff.ColorStuff
{
    class ColorConsoleFactory
    {
        public static ConsoleColor GetColor(ColorStatus colorStatus)
        {
            switch (colorStatus)
            {
                case ColorStatus.Colored:
                    return ConsoleColor.Red;
                case ColorStatus.NotColored:
                    return Console.ForegroundColor;
                default:
                    throw new ArgumentOutOfRangeException(nameof(colorStatus), colorStatus, null);
            }
        }
    }
}
