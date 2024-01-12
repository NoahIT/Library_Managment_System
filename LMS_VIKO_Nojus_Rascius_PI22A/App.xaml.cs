using LMS_VIKO_Nojus_Rascius_PI22A.Generators;
using LMS_VIKO_Nojus_Rascius_PI22A.Item_Manager;
using LMS_VIKO_Nojus_Rascius_PI22A.Models;
using LMS_VIKO_Nojus_Rascius_PI22A.User_Manager;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace LMS_VIKO_Nojus_Rascius_PI22A
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private User_Manager.IUserManager _userManager = new UserManager();
        private IItemManager _itemManager = new ItemManager();

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MainWindow mainWindow = new MainWindow(_userManager, _itemManager);
            mainWindow.Show();
        }
    }
}
