namespace MauiHttpTest;

public partial class MainPage : ContentPage
{
	HttpClient client;

	public MainPage()
	{
		InitializeComponent();

		client = new HttpClient();
		client.BaseAddress = new Uri("https://www.bing.com");
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		CounterLabel.Text = "Searching...";

		string results = await client.GetStringAsync("search?q=maui");
		CounterLabel.Text = $"Length: {results.Length}";
	}
}

