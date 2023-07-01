using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5C
{
    internal class Participant
    {
        //Instance variables
        private string firstName = string.Empty;
        private string lastName = string.Empty;

        //An object of the class Address
        private Address address;

        #region CONSTRUCTORS

        /// <summary>
        /// Default constructor with an instance of Address class
        /// </summary>
        public Participant()

        {
            address = new Address();
        }

        /// <summary>
        /// An overloaded constructor
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="adr"></param>
        public Participant (string firstName, string lastName, Address adr)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            address = adr;
            
        }

        /// <summary>
        /// Creates a new instance of the participants class by copying the values from another participant object called theOther. Copies
        /// the variables fields from theOther to the new Participant object. 
        /// </summary>
        /// <param name="theOther"></param>
       public Participant (Participant theOther)
        {
            this.firstName = theOther.firstName;
            this.lastName = theOther.lastName;
            address = theOther.address;

        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Allows getting and setting the Address object.
        /// </summary>
        public Address Address
        {
            get { return address; }
            set { address = value; }
        }

        /// <summary>
        /// Allows getting and setting the first name
        /// </summary>
        public string FirstName
        { get { return firstName; } set {  firstName = value; } }

        /// <summary>
        /// Allows getting and setting the last name
        /// </summary>
        public string LastName
        { get { return lastName; } set {  lastName = value; } }

        /// <summary>
        /// Returns the full name of the participant by concluding firstname and lastname together. 
        /// </summary>
        public string FullName
        {
            get { return firstName + " " + lastName; }
        }

        #endregion

        #region METHODS
        /// <summary>
        /// Overrides the ToString() method of the Object class and returns a string representation of the Participant object. 
        /// </summary>
        /// <returns>Fullname and address</returns>
        public override string ToString ()
        {
            string strOut = string.Format("{0, -20} {1}", FullName, address.ToString());
            return strOut;

        }

        /// <summary>
        /// Checks if the Participant object is valid. It calls the Validate() method of the Address object to validate the address and checks
        /// if the first name and last name are not null or empty. 
        /// </summary>
        /// <returns>Returns true if validation passes, otherwise false.</returns>
        public bool Validate()
        {
            bool addrOk = address.Validate();
            bool namesOK = (!string.IsNullOrEmpty(firstName)) && (!string.IsNullOrEmpty(lastName));
            return addrOk && namesOK;
        }

        #endregion
    }
}
