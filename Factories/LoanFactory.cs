using MicrofinanceApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrofinanceApp.Factories
{
    public class LoanFactory
    {
        public Loan CreateLoan(int id, decimal amount, double interestRate,
            DateTime issueDate, DateTime dueDate, string comment,
            Client client, Manager manager)
        {
            return new Loan(id, amount, interestRate, issueDate, dueDate, comment, client, manager);
        }
    }
}
