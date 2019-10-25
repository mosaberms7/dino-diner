using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{

        /// <summary>
        /// create  an order instance 
        /// </summary>
        public class Order: INotifyPropertyChanged
        {

        /// <summary>
        /// represent the items added to the order
        /// </summary>
        private ObservableCollection<IOrderItem> items;

        public IOrderItem[] Items {
            get { return Items.ToArray(); }
            set { }
        }
            /// <summary>
            /// Gets the total price by summing the price of all order items.
            /// if the cost value negative will return  0 .
            /// </summary>
            public double SubtotalCost
            {
                get
                {
                    double cost = 0;
                    foreach (IOrderItem i in items)
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
                return SalesTaxRate;
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

        public event PropertyChangedEventHandler PropertyChanged;

        public Order()
        {
            items = new ObservableCollection<IOrderItem>();
            items.CollectionChanged += Items_CollectionChanged;
        }
        public void addItems(IOrderItem item)
        {
            item.propertyChanged += OnCollectionChanged;
            items.add(item);
            OnCollectionChanged(this, new EventArgs());

        }
        public void removeItems(IOrderItem item)
        {
            item.propertyChanged += OnCollectionChanged;
            items.add(item);
            OnCollectionChanged(this, new EventArgs());

        }

        private void Items_CollectionChanged(object sender,EventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));

        }
    }
    }

