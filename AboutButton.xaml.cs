namespace MauiFileRead;

public partial class AboutButton : ContentPage
{
	public AboutButton()
	{
		InitializeComponent();
	}

    private void ReadFile_Click(object sender, EventArgs e)
    {
        DisplayAlert("ReadFile", $"You made it to the Read File Method", "OK");

        
    } // end ReadFile
 }