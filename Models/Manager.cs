using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrofinanceApp.Models
{
    [Serializable]
    public class Manager
    {
        private int id;
        private string fullName;
        private string department;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public Manager()
        {
        }

        public Manager(int id, string fullName, string department)
        {
            this.id = id;
            this.fullName = fullName;
            this.department = department;
        }

        public override string ToString()
        {
            return fullName;
        }
    }
}
