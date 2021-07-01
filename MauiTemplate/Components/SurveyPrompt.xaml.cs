using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;

namespace MauiTemplate.Components
{
    public partial class SurveyPrompt : ContentView
    {
        public SurveyPrompt()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty SurveyTitleProperty = BindableProperty.Create(
                "SurveyTitle",        // the name of the bindable property
                typeof(string),     // the bindable property type
                typeof(SurveyPrompt),   // the parent object type
                string.Empty);      // the default value for the property

        public string SurveyTitle
        {
            get => (string)GetValue(SurveyPrompt.SurveyTitleProperty);
            set => SetValue(SurveyPrompt.SurveyTitleProperty, value);
        }

        private async void SurveyTapped(object sender, System.EventArgs e)
        {
            await Browser.OpenAsync("https://www.dot.net");
        }
    }
}