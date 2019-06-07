using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace projetGSB
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void BtnAccRegions_ClickedAsync(object sender, EventArgs e)
        {
            pages.ListerRegion page = new pages.ListerRegion();
            await Navigation.PushModalAsync(page);
        }

        private async void BtnAccVisiteurs_ClickedAsync(object sender, EventArgs e)
        {
            pages.AccueilVisiteur page = new pages.AccueilVisiteur();
            await Navigation.PushModalAsync(page);
        }
    }
}
