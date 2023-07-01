using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5C
{
    internal class Address
    {
        //instansvariabler & input fields
        private string city;
        private Countries country;
        private string zipCode;
        private string street;

        #region CONSTRUCTORS
        public Address() 
        {
        
        }

        public Address(string city, Countries country, string zipCode, string street)
        {
            this.city = city;
            this.country = country;
            this.zipCode = zipCode;
            this.street = street;
        }

        public Address(string street, string zip, string city)
        {
            this.street = street;
            this.zipCode= zip;
            this.city = city;
        }

        public Address (Address theOther)
        {
            this.street= theOther.street;
            this.zipCode= theOther.zipCode;
            this.city= theOther.city;
            this.country= theOther.country;
        }

        #endregion

        #region PROPERTIES

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public string City
        {
            get { return city; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    city = value;

            }
        }

        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }

        public Countries Country
        {
            get { return country; }
            set { country = value; }

        }

        #endregion

        #region METHODS
        /// <summary>
        /// Formatting text into several lines
        /// </summary>
        /// <returns></returns>
        public string GetAdressLabel()

        {
            string strOut = street + Environment.NewLine;
            strOut = strOut + zipCode + " " + city;
            return strOut;
        }

        /// <summary>
        /// Deletes the underscore from the country names in the enum.
        /// </summary>
        /// <returns>Country names without the underscore. </returns>
        public string GetCountryString()
        {
            string strCountry = country.ToString();
            strCountry = strCountry.Replace("_", " ");
            return strCountry;
        }

        /// <summary>
        /// Overrides the ToString method to return a string made of the address detailed information formated in one line
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string strOut = string.Format("{0, -25} {1, -8} {2, -10} {3} ", street, zipCode, city, GetCountryString());
            return strOut;
        }

        /// <summary>
        /// Validates if the choice of country is not chosen.
        /// </summary>
        /// <returns>return a true or false statement</returns>
        public bool Validate()
        {
           bool ok = !string.IsNullOrEmpty(city);
           return ok;
        }
        #endregion
    }
}
