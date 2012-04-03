using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace ShopClient.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        Model.ShopBackend shop;

        #region bindables
        public string LoginUser { get; set; }
        public string LoginPassword { get; set; }
        public string CurrentUser { get; set; }
        public ICommand LoginCommand { get; set; }
        public ICommand PurchaseCommand { get; set; }
        public ICommand LogoutCommand { get; set; }
        public Visibility LoginWindowVisible { get; set; }
        public Visibility LogoutButtonVisible { get; set; }
        public Visibility PurchaseVisible { get; set; }

        public MainViewModel()
        {
            shop = new Model.ShopBackend();
            SetDefaults();
        }

        private void SetDefaults()
        {
            LoginCommand = new ActionCommand { Command = () => Login() };
            PurchaseCommand = new ActionCommand { Command = () => Purchase() };
            LogoutCommand = new ActionCommand { Command = () => Logout() };
            CurrentUser = "-";
            LoginWindowVisible = Visibility.Visible;
            LogoutButtonVisible = Visibility.Collapsed;
            PurchaseVisible = Visibility.Collapsed;
        } 
        #endregion

        #region login
        private async void Login()
        {
            var login = await shop.Login(LoginUser, LoginPassword);
            if (login.Successful) LoginSuccessfull(login.Username);
            else MessageBox.Show("cannot login: unknown user", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void LoginSuccessfull(string user)
        {
            CurrentUser = user; PropertyChange("CurrentUser");
            LoginWindowVisible = Visibility.Collapsed; PropertyChange("LoginWindowVisible");
            LogoutButtonVisible = Visibility.Visible; PropertyChange("LogoutButtonVisible");
            PurchaseVisible = Visibility.Visible; PropertyChange("PurchaseVisible");
        } 
        #endregion

        #region purchase
        private async void Purchase()
        {
            var purchase = await shop.Purchase(LoginUser, "pc");
            if (string.IsNullOrEmpty(purchase.Error)) PurchaseSuccessfull(purchase.Item);
            else MessageBox.Show("cannot purchase: " + purchase.Error, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void PurchaseSuccessfull(string item)
        {
            MessageBox.Show("purchased: " + item);
        } 
        #endregion

        #region logout
        private async void Logout()
        {
            await shop.Logout(CurrentUser);
            LogoutSuccessfull();
        }

        private void LogoutSuccessfull()
        {
            CurrentUser = "-"; PropertyChange("CurrentUser");
            LoginWindowVisible = Visibility.Visible; PropertyChange("LoginWindowVisible");
            LogoutButtonVisible = Visibility.Collapsed; PropertyChange("LogoutButtonVisible");
            PurchaseVisible = Visibility.Collapsed; PropertyChange("PurchaseVisible");
        } 
        #endregion

        #region notifypropertychanged
        private void PropertyChange(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged; 
        #endregion
    }
}
