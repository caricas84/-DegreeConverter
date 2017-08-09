using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace _DegreeConverter
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ConvertButton.Clicked += ConvertButton_Clicked;
        }
            private void ConvertButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DegreeEntry.Text))
            {
                DisplayAlert("Error", "You must enter a value in degree.", "Accept");
                return;
            }

            var degree = decimal.Parse(DegreeEntry.Text);

            var fahrenheit = (degree * 1.8M) + 32;
            
            FahrenheitEntry.Text = string.Format("{0:N2}", fahrenheit);
        }
    }
}
