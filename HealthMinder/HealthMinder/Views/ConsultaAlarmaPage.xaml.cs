using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HealthMinder.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ConsultaAlarmaPage : ContentPage
	{
		public ConsultaAlarmaPage()
		{
			InitializeComponent();
		}

		public ConsultaAlarmaPage(List<RegistrosPage.MedicationRecord> alarms)
		{
			InitializeComponent();
			alarmsListView.ItemsSource = alarms;
		}
	}
}