using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentContext.Domain.Entities
{
    public class BoletoPayment : Payment
    {
    public BoletoPayment(string barCode, string boletoNumber, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer, string document, string address, string email) 
    : base( paidDate, expireDate, total, totalPaid, payer, document, address, email)
    {
      BarCode = barCode;
      BoletoNumber = boletoNumber;
    }

    public string BarCode { get; set; }
        public string BoletoNumber { get; set; }
    }
}