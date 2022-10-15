using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Login
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void LogedInPage(object sender, EventArgs e)
        {
            string user = User.Text;
            string password = Password.Text;
            if ((user == "hector.murillo") && (password == "admin"))
            {
                await Navigation.PushAsync(new LogedIn());
            } else {
                await DisplayAlert("Usuario no valido","Usuario o contraseña incorrectos","Aceptar");
            }
        }

        private async void FPasswordPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FPassword()); 
        }
    }
}
