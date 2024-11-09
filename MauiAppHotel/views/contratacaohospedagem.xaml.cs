namespace MauiAppHotel.views;

public partial class contratacaohospedagem : ContentPage
{
	App PropriedadesApp;
	public contratacaohospedagem()
	{
		InitializeComponent();

		PropriedadesApp = (App)Application.Current;

		pck_Quarto.ItemsSource = PropriedadesApp.lista_quartos;

		dtpck_checkin.MinimumDate = DateTime.Now;
		dtpck_checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

		dtpck_checkout.MinimumDate = dtpck_checkin.Date.AddDays(1);
		dtpck_checkout.MaximumDate = dtpck_checkin.Date.AddMonths(6);
	}
	private void ButtonClicled1(object sender, EventArgs e)
	{
		try
		{
			Navigation.PushAsync(new sobre());
		}
		catch (Exception ex)
		{
			DisplayAlert("Ops", ex.Message, "Ok");
		}
	}

	private void ButtonClicled2(object sender, EventArgs e)
	{
		try
		{
			Navigation.PushAsync(new hospedagemcontratada());
		}
		catch (Exception ex)
		{
			DisplayAlert("Ops", ex.Message, "Ok");
		}
	}

    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
		DatePicker elemento = sender as DatePicker;

		DateTime data_selecionada_checkin = elemento.Date;
		dtpck_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
		dtpck_checkout.MaximumDate = data_selecionada_checkin.AddMonths(6);
    }
}
