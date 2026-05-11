using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MicrofinanceApp.Models
{
    public class Client
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string FullName { get; set; }

        [Required]
        [StringLength(30)]
        public string Phone { get; set; }

        [Browsable(false)]
        public virtual ICollection<Loan> Loans { get; set; }

        public Client()
        {
            Loans = new HashSet<Loan>();
        }

        public Client(string fullName, string phone) : this()
        {
            FullName = fullName;
            Phone = phone;
        }

        public override string ToString()
        {
            return FullName;
        }
    }
}
