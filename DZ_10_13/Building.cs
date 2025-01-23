using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_10_13
{
    public class Building
    {
        private string address;
        private int floors;
        private int numberOfApartments;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public int Floors
        {
            get { return floors; }
            set { floors = value; }
        }

        public int NumberOfApartments
        {
            get { return numberOfApartments; }
            set { numberOfApartments = value; }
        }

        public Building() { }

        public Building(string address, int floors, int numberOfApartments)
        {
            this.address = address;
            this.floors = floors;
            this.numberOfApartments = numberOfApartments;
        }
    }
}
