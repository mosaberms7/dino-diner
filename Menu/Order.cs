using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DinoDiner.Menu
{

        /// <summary>
        /// create  an order instance 
        /// </summary>
        public class Order
        {

        /// <summary>
        /// represent the items added to the order
        /// </summary>
        public ObservableCollection<IOrderItem> Items = new ObservableCollection<IOrderItem>();

            /// <summary>
            /// Gets the total price by summing the price of all order items.
            /// if the cost value negative will return  0 .
            /// </summary>
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
            public double SalesTaxRate { get; protected set; }

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


        

        }
    }

