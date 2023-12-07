using System.Collections.Generic;

namespace Solid1
{
    //Який принцип S.O.L.I.D. порушено? Виправте!
    class Item
    {

    }
    class Order
    {
        private List<Item> itemList;

        internal List<Item> ItemList
        {
            get
            {
                return itemList;
            }

            set
            {
                itemList = value;
            }
        }

        public void AddItem(Item item) {/*...*/}
        public void DeleteItem(Item item) {/*...*/}

        class OrderCalculator
        {
            public void CalculateTotalSum(Order order) {/*...*/}
            public void GetItems(Order order) {/*...*/}
            public void GetItemCount(Order order) {/*...*/}
        }

        class OrderPrinter
        {
            public void PrintOrder(Order order) {/*...*/}
            public void ShowOrder(Order order) {/*...*/}
        }

        class OrderPersister
        {
            public void Load(Order order) {/*...*/}
            public void Save(Order order) {/*...*/}
            public void Update(Order order) {/*...*/}
            public void Delete(Order order) {/*...*/}
        }

        class Program
        {
            static void Main()
            {
            }
        }
    }
}


