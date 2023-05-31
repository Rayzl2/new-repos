using AvaloniaUI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaUI.ViewModels
{
    public class ColorViewModel
    {
        public ColorViewModel(IEnumerable<ColorProfile> items) =>
            Items = new ObservableCollection<ColorProfile>(items);


        public ObservableCollection<ColorProfile> Items { get; }
    }
}
