using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    class OrderDetails
    {
        public OrderDetails()
        {
            this.Itemname = null;
            this.Count = 0;
            this.Cost = 0;
        }

        public OrderDetails(string itemname,int count,float cost)
        {
            this.itemname = itemname;
            this.cost = cost;
            this.count = count;
        }

        private string itemname;
        public string Itemname
        { get; 
          set; }

        private int count;
        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                if (value < 0) throw new Exception("数不应小于0");
            }
        }

        private float cost;
        public float Cost
        {
            get;
            set;
        }
    }


}
