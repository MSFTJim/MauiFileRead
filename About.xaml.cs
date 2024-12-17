namespace MauiFileRead;

public partial class About : ContentPage
{
	public About()
	{
		InitializeComponent();

        string filePath = "AboutAssets.txt";

        BuildDateLabel.Text = ReadTextFileAsync(filePath).Result;

        //await LoadMauiAsset();

    }

    public async Task<string> ReadTextFileAsync(string filePath)
    {
        using Stream fileStream = await FileSystem.Current.OpenAppPackageFileAsync(filePath);
        using StreamReader reader = new StreamReader(fileStream);

        return await reader.ReadToEndAsync();
    }

    async Task LoadMauiAsset()
    {
        using var stream = await FileSystem.OpenAppPackageFileAsync("AboutAssets.txt");
        using var reader = new StreamReader(stream);

        var contents = reader.ReadToEnd();
    }
}