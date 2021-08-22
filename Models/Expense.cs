using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HomeApp.Models
{
    public class Expense
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string ConsumptionMethod { get; set; }
        public int Amount { get; set; } //金額
        public int Installment { get; set; }//分期
        public int Consumer { get; set; }//消費人
        
    }
}