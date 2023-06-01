using AvaloniaUI.Services;
using System.Collections.Generic;
using System;
using AvaloniaUI.ViewModels;
using System.Collections.ObjectModel;
using AvaloniaUI.Models;
using Avalonia.Controls;


namespace AvaloniaUI.ViewModels
{
    class MainWindowViewModel : ViewModelBase
    {
        public string VARIABLE
        {
            get => "1";
            set => this.VARIABLE = value;
        }
        public MainWindowViewModel(Database db)
        {
            List = new ColorViewModel(db.GetItems());
        }


        public void AddBlock()
        {

        }



        public ColorViewModel List { get; }


    }
}