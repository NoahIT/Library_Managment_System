using LMS_VIKO_Nojus_Rascius_PI22A.Classes.Books_And_Journals_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_VIKO_Nojus_Rascius_PI22A.Item_Manager
{
    public interface IItemManager
    {
        bool RentItem(int itemId);
        bool ReturnItem(int itemId);
        bool BuyItem(int itemId);
        List<IPublishable> GetAvailableItems();
        List<IPublishable> GetRentedItems();
        List<IPublishable> GetBoughtItems();
        List<IPublishable> GetReturnedItemsHistory();
    }
}
