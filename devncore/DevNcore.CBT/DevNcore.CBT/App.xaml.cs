namespace DevNcore.CBT;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        App.Current.UserAppTheme = AppTheme.Light;

        if (DeviceInfo.Idiom == DeviceIdiom.Phone)
        {
            Shell.Current.CurrentItem = PhoneTabs;
        }   
    }
}
