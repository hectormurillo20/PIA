using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FPassword : ContentPage
    {
        public FPassword()
        {
            InitializeComponent();
            webVideo.Source = "https://www.youtube.com/embed/dQw4w9WgXcQ";
        }
    }
}