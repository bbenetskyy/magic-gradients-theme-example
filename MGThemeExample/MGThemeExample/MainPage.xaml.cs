using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MGThemeExample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
            Application.Current.RequestedThemeChanged += (s, a) =>
            {
                GradientView.StyleClass = new[]
                {
                    a.RequestedTheme == OSAppTheme.Light
                        ? "lightGradient"
                        : "darkGradient"
                };
            };
        }
    }
}