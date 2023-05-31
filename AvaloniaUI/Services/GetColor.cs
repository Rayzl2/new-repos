using System;

namespace AvaloniaUI.Services
{
    public class GetColor
    {
        public string yourHex()
        {
            var random = new Random();
            var color = String.Format("#{0:X6}", random.Next(0x1000000));
            return color;
        }
    }
}
