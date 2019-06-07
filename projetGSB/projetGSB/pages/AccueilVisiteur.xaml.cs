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
	public partial class AccueilVisiteur : ContentPage
	{
		public AccueilVisiteur ()
		{
			InitializeComponent ();
		}

        private async void BtnInsererVisiteur_ClickedAsync(object sender, EventArgs e)
        {
            InsererVisiteur page = new InsererVisiteur();
            await Navigation.PushModalAsync(page);
        }

        private async void BtnListerVisiteur_ClickedAsync(object sender, EventArgs e)
        {
            ListerVisiteur page = new ListerVisiteur();
            await Navigation.PushModalAsync(page);
        }

        private async void BtnModifierVisiteur_ClickedAsync(object sender, EventArgs e)
        {
            ModifierVisiteur page = new ModifierVisiteur();
            await Navigation.PushModalAsync(page);
        }

        private async void BtnRetour_ClickedAsync(object sender, EventArgs e)
        {
            MainPage page = new MainPage ();
            await Navigation.PushModalAsync(page);
        }
    }
}