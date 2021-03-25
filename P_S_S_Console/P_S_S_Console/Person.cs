using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_S_S_Console
{
    abstract class Person
    {
        string name, surname, phone;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Phone { get => phone; set => phone = value; }

        public abstract void Regiter();

        public abstract override string ToString();

    }
}
