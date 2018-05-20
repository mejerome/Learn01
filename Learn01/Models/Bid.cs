using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Learn01.Models
{
    public class Bid
    {
        public int ID { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FwdDate { get; set; }
        public string BankName { get; set; }
        public double FwdRate { get; set; }
        public decimal AmountBid { get; set; }
        public decimal CouponAmount { get; set; }
        public string BatchRef { get; set; }
    }
}