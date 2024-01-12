using LMS_VIKO_Nojus_Rascius_PI22A.Classes.Books_And_Journals_Interfaces;
using LMS_VIKO_Nojus_Rascius_PI22A.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LMS_VIKO_Nojus_Rascius_PI22A.Item_Manager
{
    public class ItemManager : IItemManager
    {
        private List<IPublishable> _availableItems = new List<IPublishable>();
        private List<IPublishable> _rentedItems = new List<IPublishable>();
        private List<IPublishable> _boughtItems = new List<IPublishable>();
        private List<IPublishable> _returnedItemsHistory = new List<IPublishable>();

        public bool RentItem(int itemId)
        {
            var item = _availableItems.FirstOrDefault(i => i.Id == itemId);
            if (item != null)
            {
                _availableItems.Remove(item);
                _rentedItems.Add(item);
                return true;
            }
            return false;
        }

        public bool ReturnItem(int itemId)
        {
            var item = _rentedItems.FirstOrDefault(i => i.Id == itemId);
            if (item != null)
            {
                _rentedItems.Remove(item);
                _availableItems.Add(item);
                _returnedItemsHistory.Add(item);
                return true;
            }
            return false;
        }

        public bool BuyItem(int itemId)
        {
            var item = _availableItems.FirstOrDefault(i => i.Id == itemId);
            if (item != null)
            {
                _availableItems.Remove(item);
                _boughtItems.Add(item);
                return true;
            }
            return false;
        }

        public List<IPublishable> GetAvailableItems() => _availableItems;
        public List<IPublishable> GetRentedItems() => _rentedItems;
        public List<IPublishable> GetBoughtItems() => _boughtItems;
        public List<IPublishable> GetReturnedItemsHistory() => _returnedItemsHistory;
    }

}
