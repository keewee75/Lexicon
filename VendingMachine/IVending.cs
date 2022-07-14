using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public interface IVending
    {
        // Purchase, to buy a product.
        void Purchase();

        // ShowAll. show all products.
        int ShowAll();

        // InsertMoney, add money to the pool.
        int InsertMoney();

        // EndTransaction, returns money left in appropriate amount of change.
        void EndTransaction();
    }
}
