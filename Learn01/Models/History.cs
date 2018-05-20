using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Learn01.Models
{
    public class History
    {
        public int HistoryID { get; set; }
        public int BidID { get; set; }
        public string BankName { get; set; }
        public DateTime FwdDate { get; set; }
        public double FwdRate { get; set; }
        public decimal AmountBid { get; set; }
        public decimal AmountWon { get; set; }
        public decimal CouponAmount { get; set; }
        public string BatchRef { get; set; }

        public Bid Bid { get; set; }
    }
}