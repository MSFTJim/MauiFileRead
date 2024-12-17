namespace MauiFileRead;

public partial class AboutButton : ContentPage
{
	public AboutButton()
	{
		InitializeComponent();
	}

    private async void ReadFile_Click(object sender, EventArgs e)
    {
        //DisplayAlert("ReadFile", $"You made it to the Read File Method", "OK");

        string filePath = "AboutAssets.txt";

        BuildDateLabel2.Text = await ReadTextFileAsync(filePath);



    } // end ReadFile

    public async Task<string> ReadTextFileAsync(string filePath)
    {
        using Stream fileStream = await FileSystem.Current.OpenAppPackageFileAsync(filePath);
        using StreamReader reader = new StreamReader(fileStream);

        return await reader.ReadToEndAsync();
    }
}