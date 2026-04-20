using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrofinanceApp.Models
{
  
        [Serializable]
        public class Client
        {
            private int id;
            private string fullName;
            private string phone;

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

            public string Phone
            {
                get { return phone; }
                set { phone = value; }
            }

            public Client()
            {
            }

            public Client(int id, string fullName, string phone)
            {
                this.id = id;
                this.fullName = fullName;
                this.phone = phone;
            }

            public override string ToString()
            {
                return fullName;
            }
        }
}
