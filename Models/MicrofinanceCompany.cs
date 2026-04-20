using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrofinanceApp.Models
{
    [Serializable]
    public class MicrofinanceCompany
    {
        private string companyName;
        private List<Client> clients;
        private List<Manager> managers;
        private List<Loan> loans;

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        public List<Client> Clients
        {
            get { return clients; }
            set { clients = value; }
        }

        public List<Manager> Managers
        {
            get { return managers; }
            set { managers = value; }
        }

        public List<Loan> Loans
        {
            get { return loans; }
            set { loans = value; }
        }

        public MicrofinanceCompany()
        {
            clients = new List<Client>();
            managers = new List<Manager>();
            loans = new List<Loan>();
        }

        public void AddClient(Client client)
        {
            clients.Add(client);
        }

        public void AddManager(Manager manager)
        {
            managers.Add(manager);
        }

        public void AddLoan(Loan loan)
        {
            loans.Add(loan);
        }
    }
}
