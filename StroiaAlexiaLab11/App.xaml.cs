using StroiaAlexiaLab11.Data;
using StroiaAlexiaLab11.Models;
namespace StroiaAlexiaLab11
{
    public partial class App : Application
    {
        public static ShoppingListDatabase Database { get; private set; }
        public App()
        {
            Database = new ShoppingListDatabase(new RestService());
            MainPage = new NavigationPage(new ListEntryPage());
        }
    }
}
