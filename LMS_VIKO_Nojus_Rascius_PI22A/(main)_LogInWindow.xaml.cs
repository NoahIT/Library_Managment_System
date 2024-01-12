using LMS_VIKO_Nojus_Rascius_PI22A.Item_Manager;
using LMS_VIKO_Nojus_Rascius_PI22A.Models;
using LMS_VIKO_Nojus_Rascius_PI22A.User_Manager;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LMS_VIKO_Nojus_Rascius_PI22A  
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly User_Manager.IUserManager _userManager;
        private readonly IItemManager _itemManager;

        public MainWindow() : this(new UserManager(), new ItemManager())
        {
        }
        public MainWindow(User_Manager.IUserManager userManager, IItemManager itemManager)
        {
            InitializeComponent();
            _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
            _itemManager = itemManager ?? throw new ArgumentNullException(nameof(itemManager));
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void ClearTextBoxes()
        {
            UsernameTbx.Clear();
            PasswordPsb.Clear();
        }
        private void TextBlockLogIn_MouseUp(object sender, MouseButtonEventArgs e)
        {
            RegisterWindow registerWindow = new RegisterWindow(_userManager,_itemManager);
            this.Close();
            registerWindow.Show();
        }
        private void LogInBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var username = UsernameTbx.Text;
                var password = PasswordPsb.Password;
                var userExists = _userManager.CheckUserExists(username, password);
                //var itemsExists = _itemManager.GetAvailableItems();

                if (userExists)
                {
                    HomeWindow homeWindow = new HomeWindow(_userManager, _itemManager);
                    this.Close();
                    homeWindow.Show();
                }
                else
                {
                    ClearTextBoxes();
                    MessageBox.Show("User not found.");
                }
            }
            catch (Exception err)
            {

                throw(err);
            }
        }
    }
}
