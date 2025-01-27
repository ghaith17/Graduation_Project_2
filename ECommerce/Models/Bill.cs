﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommerce.Models
{
    public class Bill
    {
        public Bill()
        {
        }
        private string id;
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        private string value;
        public string Value
        {
            get { return this.value; }
            set { this.value = value; }
        }
        private string status;
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }
        private DateTime billDate;
        public DateTime BillDate
        {
            get { return this.billDate; }
            set { this.billDate = value; }
        }
        public void generateBill(Order order)
        {
            double total = 0;
            foreach (var item in order.Items)
            {
                total += (item.Price * item.Quantity);
               
            }
            this.value = total.ToString();
            this.status = "shipped";
            this.billDate = DateTime.Now;
        }
    }

}
