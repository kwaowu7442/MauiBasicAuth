using MauiBasicAuth.DataAccess;

namespace MauiBasicAuth;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnLoginClicked(object sender, EventArgs e)
    {
        string username = txtUserId.Text;
        string password = txtPassword.Text;

        var userAuth = new UserAuthentication();
        bool isAuthenticated = userAuth.AuthenticateUser(username, password);

        if (isAuthenticated)
        {
            DisplayAlert("Success", "User authenticated successfully!", "OK");
        }
        else
        {
            DisplayAlert("Error", "Authentication failed.", "OK");
        }
    }
}