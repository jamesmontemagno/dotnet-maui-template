using System;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace MauiTemplate.Pages
{
    public partial class CounterPage : ContentPage
    {

        public CounterPage()
        {
            InitializeComponent();
        }
    }

    public class CounterViewModel : BindableObject
    {

        ICommand clickedCommand;
        public ICommand ClickedCommand => clickedCommand ??= new Command(IncrementCount);

        private void IncrementCount()
        {
            Count++;
        }

        private int count = 0;
        public int Count
        {
            get => count;
            set
            {
                count = value;
                OnPropertyChanged();
            }
        }
    }
}
