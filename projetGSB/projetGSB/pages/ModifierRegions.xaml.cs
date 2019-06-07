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
	public partial class ModifierRegions : ContentPage
	{
        classeMetier.Region uneRegion = new classeMetier.Region();
		public ModifierRegions (classeMetier.Region LaRegion)
		{
            uneRegion = LaRegion;
			InitializeComponent ();
            LstRegion(LaRegion);
		}

        public void LstRegion(classeMetier.Region LaRegions)
        {
            nomregion.Text = LaRegions.REG_NOM;
            codesecteur.Text = LaRegions.SEC_CODE;
            coderegion.Text = LaRegions.REG_CODE;
        }

        private async void BtnRetour_ClickedAsync(object sender, EventArgs e)
        {
            ListerRegion page = new ListerRegion();
            await Navigation.PushModalAsync(page);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await App.GstWS.modifierRegion(coderegion.Text, codesecteur.Text, nomregion.Text);
            ListerRegion page = new ListerRegion();
            //MainPage page = new MainPage();
            await Navigation.PushModalAsync(page);
        }
    }
}