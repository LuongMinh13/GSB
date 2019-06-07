using projetGSB.classeMetier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projetGSB.pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListerRegion : ContentPage
	{
		public ListerRegion ()
		{
			InitializeComponent ();
            LstRegion();
		}

        public async void LstRegion()
        {
            lvRegion.ItemsSource = await App.GstWS.ListRegion();
        }

        private async void BtnRetour_ClickedAsync(object sender, EventArgs e)
        {
            MainPage page = new MainPage();
            await Navigation.PushModalAsync(page);
        }

        private async void LvRegion_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            classeMetier.Region laregionselectione = (lvRegion.SelectedItem as classeMetier.Region);
            ModifierRegions page = new ModifierRegions(laregionselectione);
            await Navigation.PushModalAsync(page);
        }
    }
}