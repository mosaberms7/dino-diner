using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Collections.Specialized;
using System.ComponentModel;
using DinoDiner.Menu;
using System.Windows;


namespace DinoDiner.Menu
{

        /// <summary>
        /// create  an order instance 
        /// </summar
  public class Order: INotifyPropertyChanged
  {

        /// <summary>
        /// represent the items added to the order
        /// </summary>
        private List<IOrderItem> items { get; set; } = new List<IOrderItem>();

        public IOrderItem[] Items
        {
            get { return items.ToArray(); }
        }

        public double SubtotalCost
            {
                get
                {
                    double cost = 0;
                    foreach (IOrderItem i in Items)
                    {
                        cost += i.Price;
                    }
                if (cost > 0)
                    return cost;
                else return 0;
                }
            }

            /// <summary>
            ///  the current sales tax rate.
            /// </summary>
            public double SalesTaxRate {
            get
            {
                return .01;
            }
            set
            {

            }
        }

            /// <summary>
            /// the sales tax cost of the order
            /// and SubtotalCost together.
            /// </summary>
            public double SalesTaxCost
            {
                get
                {
                return SalesTaxRate * SubtotalCost;
                }
            }

            /// <summary>
            ///  the total cost of the order after the tax 
            /// </summary>
            public double TotalCost
        {
            get
            {
                return SubtotalCost + SalesTaxCost;
            }
        }



        public Order()
        {
            
        }

        public void addItems(IOrderItem item)
        {
           // item.PropertyChanged += OnCollectionChanged;
            items.Add(item);
            item.PropertyChanged += OnPropertyChanged;
            OnCollectionChanged();
        }

       

            public bool removeItems(IOrderItem item)
            {
            bool removed = items.Remove(item);
            if (removed)
            {
                OnCollectionChanged();

            }
            return removed;
            }
        private void OnPropertyChanged(object sender,PropertyChangedEventArgs args)
        {

            OnCollectionChanged();
        }

        protected void OnCollectionChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

       
        public event PropertyChangedEventHandler PropertyChanged;

    }
}

