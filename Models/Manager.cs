using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MicrofinanceApp.Models
{
    public class Manager
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string FullName { get; set; }

        [Required]
        [StringLength(100)]
        public string Department { get; set; }

        [Browsable(false)]
        public virtual ICollection<Loan> Loans { get; set; }

        public Manager()
        {
            Loans = new HashSet<Loan>();
        }

        public Manager(string fullName, string department) : this()
        {
            FullName = fullName;
            Department = department;
        }

        public override string ToString()
        {
            return FullName;
        }
    }
}

