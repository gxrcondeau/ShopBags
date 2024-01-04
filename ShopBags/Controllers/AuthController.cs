using ShopBags.Services;
using ShopBags.Views;

namespace ShopBags.Controllers
{
    internal class AuthController
    {
        private readonly AuthView _view;
        private readonly UserService _userService;

        private StoreView _storeView;

        public AuthController(UserService userService, AuthView view, StoreView storeView)
        {
            _view = view;
            _userService = userService;
            _storeView = storeView;
            WireUpEvents();
        }

        private void WireUpEvents()
        {
            _view.Login += OnLogin;
            _view.Register += OnRegister;
        }

        private void OnLogin(object sender, EventArgs e)
        {
            string email = _view.Email;
            string password = _view.Password;

            bool isAuthenticated = _userService.AuthenticateUser(email, password);

            if (isAuthenticated)
            {
                _view.ShowInfo("Login successful!");
                _storeView.Show();
                _view.Close();
            }
            else
            {
                _view.ShowError("Invalid username or password.");
            }
        }

        private void OnRegister(object sender, EventArgs e)
        {
            string username = _view.Name;
            string password = _view.Password;
            string email = _view.Email;

            string isRegistered = _userService.RegisterUser(username, password, email);

            if (isRegistered == "Registration successfull!")
            {
                _view.ShowInfo(isRegistered);
                _view.ChangeAuthAction();
            }
            else
            {
                _view.ShowError(isRegistered);
            }
        }

    }
}
