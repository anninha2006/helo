namespace helo;

public partial class MainPage
{
	const string Url = "https://api.hgbrasil.com/weather?woeid=455927&key=";
	results resposta;

	public MainPage()
	{
		InitializeComponent();
	}

	void TestaLayout()
	{
		resultado = new Results();
		resultado.Temp = 23;
		resultado.Description = "Tempo nublado";
		resultado.Currently = "dia";
		resultado.City = "Apucarana";

	}

	void PreencheTela()
	{
		labelTemperature.Text = resultado.Temp;
		labelDescricao.Text = resultado.Description;
	}
	void AtualizaTempo()
	{
		try
		{
			var httpcliente= new HttpClient();
			var response= await HttpCliente();
			if (response.IsSuccessStatusCode)
			{
				String Content= response.Content.ReadAsStringAsync()
				Resposta="JsonSerializer.Deserialize"<Resposta>(content);
			}
		}
		catch (Exception e){
			//Erro
		}
	}

}

