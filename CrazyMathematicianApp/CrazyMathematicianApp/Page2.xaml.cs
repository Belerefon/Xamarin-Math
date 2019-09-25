using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


//  ΑΝΘΡΩΠΙΣΤΙΚΩΝ ΣΠΟΥΔΩΝ               -> 1
//  ΘΕΤΙΚΩΝ ΣΠΟΥΔΩΝ                     -> 2
//  ΣΠΟΥΔΩΝ ΟΙΚΟΝΟΜΙΑΣ ΚΑΙ ΠΛΗΡΟΦΟΡΙΚΗΣ -> 3


namespace CrazyMathematicianApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentPage
	{
		public Page2 ()
		{
			InitializeComponent ();
		}

        private void Button_1(object sender, EventArgs e)
        {
            App._omadaProsanatolismou = 1;
            Navigation.PushAsync(new Page3());
        }

        private void Button_2(object sender, EventArgs e)
        {
            App._omadaProsanatolismou = 2;
            Navigation.PushAsync(new Page3());           
        }

        private void Button_3(object sender, EventArgs e)
        {
            App._omadaProsanatolismou = 3;
            Navigation.PushAsync(new Page3());           
        }
    }
}