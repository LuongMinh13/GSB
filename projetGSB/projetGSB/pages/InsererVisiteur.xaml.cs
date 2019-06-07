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
	public partial class InsererVisiteur : ContentPage
	{
		public InsererVisiteur ()
		{
			InitializeComponent ();
            time.Time = DateTime.Now.TimeOfDay;
		}

        private async void BtnRetour_ClickedAsync(object sender, EventArgs e)
        {
            AccueilVisiteur page = new AccueilVisiteur();
            await Navigation.PushModalAsync(page);

        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {

        }

        private void LstRegion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}