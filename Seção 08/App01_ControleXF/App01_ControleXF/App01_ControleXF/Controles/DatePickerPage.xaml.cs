using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ControleXF.Controles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DatePickerPage : ContentPage
	{
		public DatePickerPage ()
		{
			InitializeComponent ();
		}

        public void ActionDateSelected(object sender, DateChangedEventArgs args)
        {
            LblResultado.Text = args.OldDate.ToString("dd/MM/yyyy") + " > " + args.NewDate.ToString("dd/MM/yyyy");
        }

    }
}