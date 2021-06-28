using System;
using Microsoft.Maui.Controls;

namespace MauiTemplate.Pages
{
    public partial class FetchDataPage : ContentPage
    {
        public FetchDataPage()
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
