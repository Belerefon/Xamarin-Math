using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CrazyMathematicianApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page4 : ContentPage
	{

        double sintelestisA = 0;
        double sintelestisB = 0;

        public Page4 ()
		{
			InitializeComponent ();

            switch (App._omadaProsanatolismou)
            {
                case 1:
                    switch (App._mathimaEpilogis)
                    {
                        case 1:
                            label1.Text = "Αρχαία";
                            label2.Text = "Ιστορία";
                            label3.Text = "Λατινικά";
                            label4.Text = "Ν.Γλώσσα";
                            sintelestisA = 1.3;
                            sintelestisB = 0.7;
                            break;
                        case 2:
                            label1.Text = "Βιολογία Γ.Π.";
                            label2.Text = "Ν.Γλώσσα";
                            label3.Text = "Αρχαία";
                            label4.Text = "Ιστορία";
                            sintelestisA = 0.9;
                            sintelestisB = 0.4;
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                    }
                    break;
                case 2:
                    switch (App._mathimaEpilogis)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            label1.Text = "Μαθηματικά Προσ/μου";
                            label2.Text = "Φυσική";
                            label3.Text = "Χημεία";
                            label4.Text = "Ν.Γλώσσα";
                            sintelestisA = 1.3;
                            sintelestisB = 0.7;
                            break;
                        case 4:
                            label1.Text = "Βιολογία Προσ/μου";
                            label2.Text = "Χημεία";
                            label3.Text = "Φυσική";
                            label4.Text = "Ν.Γλώσσσα";
                            sintelestisA = 1.3;
                            sintelestisB = 0.7;
                            break;
                        case 5:
                            break;
                    }
                    break;
                case 3:
                    switch (App._mathimaEpilogis)
                    {
                        case 1:
                            break;
                        case 2:
                            label1.Text = "Βιολογία Γ.Π.";
                            label2.Text = "Ν.Γλώσσα";
                            label3.Text = "Μαθηματικά";
                            label4.Text = "Α.Ε.Π.Π.";
                            sintelestisA = 0.9;
                            sintelestisB = 0.4;
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            label1.Text = "Μαθηματικά";
                            label2.Text = "Α.Ο.Θ.";
                            label3.Text = "Ν.Γλώσσα";
                            label4.Text = "Α.Ε.Π.Π.";
                            sintelestisA = 1.3;
                            sintelestisB = 0.7;
                            break;
                    }
                    break;
            }
        }

        private void ButtonCalculate(object sender, EventArgs e)
        {

            double results;
            double A = Convert.ToDouble(entry1.Text);
            double B = Convert.ToDouble(entry2.Text);
            double C = Convert.ToDouble(entry3.Text);
            double D = Convert.ToDouble(entry4.Text);

            if (A < 0 || A > 20 || B < 0 || B > 20 || C < 0 || C > 20 || D < 0 || D > 20)
                DisplayAlert("Error", "Invalid Number.", "OK");
            else
            {
                results = ((A + B + C + D) * 2 + (A * sintelestisA) + (B * sintelestisB)) * 100;
                labelApotelesma.Text = Convert.ToString(results);
            }
            
            
        }
    }
}