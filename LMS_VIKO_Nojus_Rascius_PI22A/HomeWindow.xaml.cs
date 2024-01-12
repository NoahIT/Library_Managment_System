using LMS_VIKO_Nojus_Rascius_PI22A.Classes.Books_And_Journals_Interfaces;
using LMS_VIKO_Nojus_Rascius_PI22A.Generators;
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
    /// Interaction logic for HomeWindow.xaml
    /// </summary>
    public partial class HomeWindow : Window
    {
        private IUserManager _userManager;

        private ItemManager _itemManager;
        private IUserManager userManager;
        private IItemManager itemManager;

        public HomeWindow(IUserManager userManager, ItemManager itemManager)
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
            _itemManager = itemManager;
        }

        public HomeWindow(IUserManager userManager, IItemManager itemManager)
        {
            this.userManager = userManager;
            this.itemManager = itemManager;
        }

        //Issiregistroujam
        private void LogOutBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow logInView = new MainWindow(_userManager, _itemManager);
            this.Close();
            logInView.Show();
        }

        //Funkcionalumo mygtuku logika ka po ko atidaro
        private void Rent_Click(object sender, RoutedEventArgs e)
        {
            int itemId = GetSelectedItemId();
            if (_itemManager.RentItem(itemId))
            {
                MessageBox.Show("Item rented successfully.");
                BookDg.ItemsSource = _itemManager.GetAvailableItems().OfType<Book>().ToList();
            }
            else
            {
                MessageBox.Show("Failed to rent item.");
            }
        }
        private void ReturnBook_Click(object sender, RoutedEventArgs e)
        {
            int itemId = GetSelectedItemId();
            if (_itemManager.ReturnItem(itemId))
            {
                MessageBox.Show("Item returned successfully.");
                BookDg.ItemsSource = _itemManager.GetAvailableItems().OfType<Book>().ToList();
            }
            else
            {
                MessageBox.Show("Failed to return item.");
            }
        }
        private void BuyBookBtn_Click(object sender, RoutedEventArgs e)
        {
            int itemId = GetSelectedItemId();
            if (_itemManager.BuyItem(itemId))
            {
                MessageBox.Show("Item bought successfully.");
                BookDg.ItemsSource = _itemManager.GetAvailableItems().OfType<Book>().ToList();
            }
            else
            {
                MessageBox.Show("Failed to buy item.");
            }
        }
        
        private void ViewJournals_Click(object sender, RoutedEventArgs e)
        {
            BookDg.ItemsSource = _itemManager.GetAvailableItems().OfType<Journal>().ToList();
        }
        private void ViewBooks_Click(object sender, RoutedEventArgs e)
        {
            BookDg.ItemsSource = _itemManager.GetAvailableItems().OfType<Book>().ToList();
        }

        private int GetSelectedItemId()
        {
            var selectedItem = (IPublishable)BookDg.SelectedItem;
            return selectedItem?.Id ?? -1;
        }
    }
}
