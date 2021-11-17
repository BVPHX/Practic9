using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic9
{
    public class Abonents
    {
        public struct Abonent
        {
            public int PhoneNumber;
            public string Name;
            public string Address;
            public Abonent(int phoneNumber, string name, string address)
            {
                PhoneNumber = phoneNumber;
                Name = name;
                Address = address;
            }

        }
    }
}
