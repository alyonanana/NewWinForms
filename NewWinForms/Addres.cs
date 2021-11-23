using System;
using System.Collections.Generic;
using System.Text;

namespace NewWinForms
{
    class Addres
    {
        private string country;
        private string city;
        private string street;
        

        public Addres(string country,string city,string street)
        {

            this.city = city;
            this.street = street;
            this.country= country;
        }
        public string City { get { return city; } set { city = value; } }
        public string Street { get { return street; } set { street = value; } }
        public string Country { get { return country; } set { country = value; } }
       
        public string AddresToString()
        {
            return (country + " "+city+" " + street + " " );
        }
    }
}
