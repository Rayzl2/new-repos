using Avalonia;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System;
using System.Reactive.Linq;
using Avalonia.Controls.Metadata;
using Avalonia.Controls.Presenters;
using Avalonia.Controls.Primitives;
using Avalonia.Controls;
using AvaloniaUI.Services;
using System.Globalization;
using Avalonia.Media;
using SkiaSharp;

namespace AvaloniaUI.Views
{
  

    public partial class CustomUserWindowProfile : UserControl
        {
        public CustomUserWindowProfile()
        {
            InitializeComponent();
        }
        private Point _startMousePosition;
        private Point _startElementPosition;

        private void MyElement_PointerPressed(object sender, PointerPressedEventArgs e)
        {
            var myElement = (Button)sender;
            _startMousePosition = e.GetPosition(myElement.Parent);
            _startElementPosition = new Point(Canvas.GetLeft(myElement), Canvas.GetTop(myElement));

            //myElement.VALU = e.Pointer;
        }
        private void HorizontalScrollBar_ValueChanged(object sender, double e)
        {
            var myElement = (ScrollViewer)sender;
            double delta = e * (myElement.MaxWidth - myElement.Width);

            Canvas.SetLeft(myElement, _startElementPosition.X + delta);
        }
        public void ButtonClick(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            string colorcode = new GetColor().yourHex();
            int argb = Int32.Parse(colorcode.Replace("#", ""), NumberStyles.HexNumber);
            button.Background = colorcode;
        } 


    }
}
