using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MicrofinanceApp.Models
{
    public class Loan
    {
        public int Id { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public decimal InterestRate { get; set; }

        [Required]
        public DateTime IssueDate { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        [StringLength(500)]
        public string Comment { get; set; }

        [Required]
        public int ClientId { get; set; }

        [Browsable(false)]
        public virtual Client Client { get; set; }

        [Required]
        public int ManagerId { get; set; }

        [Browsable(false)]
        public virtual Manager Manager { get; set; }

        [NotMapped]
        public string ManagerName
        {
            get { return Manager != null ? Manager.FullName : string.Empty; }
        }

        [NotMapped]
        public decimal TotalAmount
        {
            get { return CalculateTotalAmount(); }
        }
        public Loan()
        {
        }

        public Loan(decimal amount, decimal interestRate, DateTime issueDate, DateTime dueDate, string comment, Client client, Manager manager)
        {
            Amount = amount;
            InterestRate = interestRate;
            IssueDate = issueDate;
            DueDate = dueDate;
            Comment = comment;
            Client = client;
            Manager = manager;

            if (client != null)
            {
                ClientId = client.Id;
            }

            if (manager != null)
            {
                ManagerId = manager.Id;
            }
        }


        public decimal CalculateTotalAmount()
        {
            return Amount + (Amount * InterestRate / 100m);
        }
    }
}

