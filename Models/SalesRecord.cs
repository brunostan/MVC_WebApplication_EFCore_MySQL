using MVC_WebApplication.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace MVC_WebApplication.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; } = DateTime.Now;

        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Amount { get; set; }
        public SaleStatus Status { get; set; } = SaleStatus.PENDING;
        public Seller? Seller { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
