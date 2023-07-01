using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5C
{
    internal class EventManager
    {

        //Instancevariables
        private double costPerPerson;
        private double feePerPerson;
        private string title;

        ParticipantManager participantManager = new ParticipantManager();

        #region CONSTRUCTOR
        public EventManager()
        {
            participantManager = new ParticipantManager();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Returns an object of participantManager associated with the Event class. It allows access to the ParticipantManager instance. 
        /// </summary>
        public ParticipantManager Participants
        {
            get { return participantManager; } 
        }

        /// <summary>
        /// Allows getting and setting the title of the event. 
        /// </summary>
        public string Title
        { 
            get { return title; } 
            set
            {
                if (!string.IsNullOrEmpty(value))
                    title = value;
            }
        }

        /// <summary>
        /// allows getting and setting the cost per person for the event.
        /// </summary>
        public double CostPerPerson
        { 
            get { return costPerPerson; }
            set
            {

                if (value >= 0.0)
                costPerPerson = value;
            }
        }

        /// <summary>
        /// allows getting and setting the fee per person for the event. 
        /// </summary>
        public double FeePerPerson
        {
            get { return feePerPerson; }
            set
            {
                if (value >= 0.0)
                    feePerPerson = value;
            }
        }

        #endregion

        #region METHODS
        /// <summary>
        /// calculates and returns the total cost of the event by multiplying the number of particinapnts with the value of cost per person.
        /// </summary>
        /// <returns>Total cost value</returns>
        public double CalcTotalCost()
        {
            return Participants.Count * CostPerPerson;

        }

        /// <summary>
        /// calculates and returns the total fee of the event by multiplying the number of particinapnts with the value of fee per person.
        /// </summary>
        /// <returns>Total fee value</returns>
        public double CalcTotalFee()
        {
            return Participants.Count * feePerPerson;
        }

        #endregion
    }
}
