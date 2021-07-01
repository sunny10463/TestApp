using App.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();

            VM main = new VM();
            main.List.Add(new Models.Model() { A = "1", B = 3.5, C = 0.5, D = 1000 });
            main.List.Add(new Models.Model() { A = "2", B = 2.5, C = 0.4, D = 1000 });
            main.List.Add(new Models.Model() { A = "3", B = 1.5, C = 0.3, D = 1000 });

            grid.ItemsSource = main.List;
        }
    }
}