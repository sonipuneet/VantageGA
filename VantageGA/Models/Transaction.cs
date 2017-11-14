using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VantageGA.Models
{
    public class Transaction
    {
        public string TransactionType{ get; set; }
        [Required(ErrorMessage = "Transaction Type is Required.")]

        public string InvoiceNumber { get; set; }
        [Required(ErrorMessage = "Please provide the Invoice Number", AllowEmptyStrings = false)]
        public string TransactionTotal { get; set; }
        [Required(ErrorMessage = "Please provide the Transaction Total", AllowEmptyStrings = false)]
    }

    public enum TransactionType
    {
        PrePay,
        PostPay,
        PayAtThePump,LoyaltyOutPayIn(LOPI)
    }
}