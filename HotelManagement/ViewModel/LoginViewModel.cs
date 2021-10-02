using HotelManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace HotelManagement.ViewModel
{
    class LoginViewModel : BaseViewModel
    {
        private string _errorMessage;
        public string ErrorMessage { get { return _errorMessage; } set { _errorMessage = value; OnPropertyChanged(); } }

        private string _username;
        public string Username { get { return _username; } set { _username = value; OnPropertyChanged(); } }

        private string _password;
        public string Password { get { return _password; } set { _password = value; OnPropertyChanged(); } }

        public ICommand CloseWindowCommand { get; set; }
        public ICommand PasswordChangedCommand { get; set; }
        public ICommand LoginCommand { get; set; }
        public ICommand RegisterCommand { get; set; }

        public LoginViewModel()
        {
            Username = "";
            Password = "";

            CloseWindowCommand = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                Application.Current.Shutdown();
            });

            PasswordChangedCommand = new RelayCommand<PasswordBox>((p) =>
            {
                return true;
            }, (p) =>
            {
                Password = p.Password;
            });

            LoginCommand = new RelayCommand<Window>((p) =>
            {
                return true;
            }, (p) =>
            {
                Login(p);
            });

            RegisterCommand = new RelayCommand<Window>((p) =>
            {
                return true;
            }, (p) =>
            {
                Register(p);
            });
        }

        void Login(Window p)
        {
            if (p == null)
                return;

            string encodePassword = MD5Hash(Base64Encode(Password));
            var accCount = DataProvider.Instance.DB.ACCOUNTs.Where(x => x.username == Username && x.password == encodePassword).Count();
            if (accCount > 0)
            {
                MessageBox.Show("login success");
            }
            else
            {
                ErrorMessage = "Invalid username or password";
            }    
        }

        void Register(Window p)
        {
            if (p == null)
                return;

            
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
    }
}
