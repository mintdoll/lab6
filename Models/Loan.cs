using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrofinanceApp.Models
{
    [Serializable]
    public class Loan
    {
        private int id;
        private decimal amount;
        private double interestRate;
        private DateTime issueDate;
        private DateTime dueDate;
        private string comment;
        private Client client;
        private Manager manager;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public double InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
        }

        public DateTime IssueDate
        {
            get { return issueDate; }
            set { issueDate = value; }
        }

        public DateTime DueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        public Client Client
        {
            get { return client; }
            set { client = value; }
        }

        public Manager Manager
        {
            get { return manager; }
            set { manager = value; }
        }

        public string ManagerName
        {
            get { return manager != null ? manager.FullName : string.Empty; }
        }

        public Loan()
        {
        }

        public Loan(int id, decimal amount, double interestRate, DateTime issueDate,
            DateTime dueDate, string comment, Client client, Manager manager)
        {
            this.id = id;
            this.amount = amount;
            this.interestRate = interestRate;
            this.issueDate = issueDate;
            this.dueDate = dueDate;
            this.comment = comment;
            this.client = client;
            this.manager = manager;
        }

        public decimal CalculateTotalAmount()
        {
            return amount + (amount * (decimal)interestRate / 100);
        }
        public decimal TotalAmount
        {
            get { return CalculateTotalAmount(); }
        }

    }
}
