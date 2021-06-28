using System;
using Microsoft.Maui.Controls;

namespace MauiTemplate.Pages
{
    public partial class CounterPage : ContentPage
    {
        public CounterPage()
        {
            InitializeComponent();
        }

        int count = 0;
        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;
            CounterLabel.Text = $"Current count: {count}";
        }
    }
}
