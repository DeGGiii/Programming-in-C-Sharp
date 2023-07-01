using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5C
{
    internal class ParticipantManager
    {
        //Instansvariabler

        private List<Participant> participants; //List of participants


        #region CONSTRUCTOR
        /// <summary>
        /// Constructor that initalize a new instance of the class Partyicipants and creates an empty list
        /// </summary>
        public ParticipantManager() 
        { 
            participants = new List<Participant>();
        }
        #endregion

        #region METHODS TO VALIDATE PARTICPANTS

        /// <summary>
        /// This method returns the participants at the specified index in the list. 
        /// </summary>
        /// <param name="index"></param>
        /// <returns>Return the participant</returns>
        public Participant GetParticipantAt(int index)
        {
            if (index < 0 || index >= participants.Count)
            {
                return null;            
            }

            return participants[index];
        }

        /// <summary>
        /// Method that returns the number of participants in the list.
        /// </summary>
        public int Count 
        {
            get { return participants.Count; }
        }

        /// <summary>
        /// This method method created a new participant object with the given parameters and add it to the list of participants.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="address"></param>
        /// <returns>Returns true</returns>
        public bool AddParticipant (string firstName, string lastName, Address address)
        {
            Participant participant = new Participant(firstName, lastName, address);
            participants.Add(participant);
            return true;
        }

        /// <summary>
        /// This method adds the specified participant object to the list of participants if it's not already present. 
        /// </summary>
        /// <param name="participant"></param>
        /// <returns>returns bool value true.</returns>
        public bool AddParticipant(Participant participant)
        {
            if (!participants.Contains(participant))
            {
                participants.Add(participant);
            }
            return true;
        }

        /// <summary>
        /// Changes the specified participant with the index to the given participantIn object. 
        /// </summary>
        /// <param name="participantIn"></param>
        /// <param name="index"></param>
        /// <returns>Returns true if the participant was changed or removed, otherwise false</returns>
        public bool ChangeParticipantAt(Participant participantIn, int index)
        {
            bool ok = false;
            if ((participantIn == null) && (CheckIndex(index)))
                {
                participants[index] = participantIn;
            } else
            {
                ok = true;
            }

            return ok;
        }

        /// <summary>
        /// Private helper method that checks if the given index is valid. Within the range of the list.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private bool CheckIndex(int index)
        {
            return (index <  participants.Count && index >= 0);
        }

        /// <summary>
        /// Removes the participants at specified index from the list if the index is valid.
        /// </summary>
        /// <param name="index"></param>
        /// <returns>True if participant is deleted, otherwise false</returns>
        public bool DeleteParticipantAt(int index)
        {
            if (CheckIndex(index))
            {
                participants.RemoveAt(index);

            }
            else
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Iterates over the participants and calls the ToString() method on each participant to get its string representation. 
        /// </summary>
        /// <returns>An array of strings containing the string representation of each participant in the list.</returns>
        public string[] GetParticipantsInfo()
        {
            string[] strInfoStrings = new string[participants.Count];

            int i = 0;

            foreach (Participant participant in participants)
            {
                strInfoStrings[i++] = participant.ToString();
            }

            return strInfoStrings;
        }

        #endregion
    }
}
