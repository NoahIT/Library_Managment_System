using Google.Protobuf.WellKnownTypes;
using LMS_VIKO_Nojus_Rascius_PI22A.Item_Manager;
using LMS_VIKO_Nojus_Rascius_PI22A.Models;
using LMS_VIKO_Nojus_Rascius_PI22A.User_Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LMS_VIKO_Nojus_Rascius_PI22A
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        private readonly IUserManager _userManager;
        private readonly IItemManager _itemManager;

        public RegisterWindow(IUserManager userManager, IItemManager itemManager)
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
            _itemManager = itemManager ?? throw new ArgumentNullException(nameof(itemManager));
        }

        private void clearTextBoxes()
        {
            RUsernameTbx.Clear();
            RPasswordPsb.Clear();
            RFirstNameTbx.Clear();
            RLastNameTbx.Clear();
        }
        private void endRegistration()
        {
            var app = (App)Application.Current;
            MainWindow logInWindow = new MainWindow(_userManager,_itemManager);
            this.Close();
            logInWindow.Show();
        }

        private bool RegisterUserValidation(string username, string password, string firstName, string lastName)
        {
            if (_userManager.RegisterUser(username, password, firstName, lastName))
            {
                clearTextBoxes();
                endRegistration();
                return true;
            }
            else
            {
                MessageBox.Show("User with this username already exists, please try again", "Failed registration");
                clearTextBoxes();
                return false;
            }
        }
        private void TextBlockRegister_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MainWindow logInView = new MainWindow(_userManager,_itemManager);
            this.Close();
            logInView.Show();
        }
        private void RegisterBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(RUsernameTbx.Text) ||
                string.IsNullOrEmpty(RPasswordPsb.Password) ||
                string.IsNullOrEmpty(RFirstNameTbx.Text) ||
                string.IsNullOrEmpty(RLastNameTbx.Text))
                {
                    clearTextBoxes();
                    MessageBox.Show("Please fill all of the boxes");
                }
                else
                {
                    RegisterUserValidation(
                        RUsernameTbx.Text,
                        RPasswordPsb.Password,
                        RFirstNameTbx.Text,
                        RLastNameTbx.Text);
                }
            }
            catch (Exception err)
            {
                throw(err);
            }
        }
    }
}
