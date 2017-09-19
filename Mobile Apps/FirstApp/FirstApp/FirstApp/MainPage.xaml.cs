using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace FirstApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_OnClicked(object sender, EventArgs e)
        {
            string text = ClickMeButton.Text;
            MainLabel.Text = "Hello " + text;
        }
    }
    
}
