using D424.Data;
using D424.Views;

namespace D424;

public partial class App : Application
{
    private readonly AppDatabase _database;

    public App(AppDatabase database)
    {
        InitializeComponent();
        _database = database;
        //_database.SeedDataAsync().Wait();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new NavigationPage(new TermListPage(_database)));
    }
}