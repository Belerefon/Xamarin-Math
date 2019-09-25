using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


//  Λατινικά            -> 1
//  Βιολογία Γ.Π.       -> 2
//  Μαθηματικά Προσ/μού -> 3
//  Βιολογία Πορσ/μού   -> 4
//  Α.Ο.Θ.              -> 5


namespace CrazyMathematicianApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page3 : ContentPage
	{
		public Page3 ()
		{
            InitializeComponent();

            switch (App._omadaProsanatolismou)
            {
                case 1:
                    button1.Text = "Λατινικα";
                    button2.Text = "Βιολογια Γ.Π.";
                    break;
                case 2:
                    button1.Text = "Μαθηματικα Προσ/μου";
                    button2.Text = "Βιολογια Προσ/μου";
                    break;
                case 3:
                    button1.Text = "Βιολογια Γ.Π.";
                    button2.Text = "Α.Ο.Θ.";
                    break;
            };
        }

        private void Button1(object sender, EventArgs e)
        {
            switch (App._omadaProsanatolismou)
            {
                case 1:
                    App._mathimaEpilogis = 1;
                    break;
                case 2:
                    App._mathimaEpilogis = 3;
                    break;
                case 3:
                    App._mathimaEpilogis = 2;
                    break;
            };
            Navigation.PushAsync(new Page4());
        }

        private void Button2(object sender, EventArgs e)
        {
            switch (App._omadaProsanatolismou)
            {
                case 1:
                    App._mathimaEpilogis = 2;
                    break;
                case 2:
                    App._mathimaEpilogis = 4;
                    break;
                case 3:
                    App._mathimaEpilogis = 5;
                    break;
            };
            Navigation.PushAsync(new Page4());
        }

    }
}