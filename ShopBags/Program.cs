using ShopBags.Controllers;
using ShopBags.Helpers;
using ShopBags.Services;
using ShopBags.Sessions;
using ShopBags.Views;

namespace ShopBags
{
    internal static class Program
    {
        public static AuthView authView { get; set; }
        public static StoreView storeView { get; set; }

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            BootstrapHelper.Execute();

            UserService user = new UserService();
            UserSession.Instance.SetUserData(0, "", "", false, false); // You can set default values or leave them empty

            authView = new AuthView();
            storeView = new StoreView();

            AuthController authController = new AuthController(user, authView, storeView);
            StoreController storeController = new StoreController(storeView, user);

            authView.Show();

            Application.Run();
        }
    }
}