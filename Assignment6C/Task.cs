using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6C
{
    internal class Task
    {

        private DateTime date;
        private string description = string.Empty;
        private PriorityType priority;


        #region CONSTRUCTORS

        /// <summary>
        /// Default constructor
        /// </summary>
        public Task()
        {
            //Setting default priority type
            priority = PriorityType.Normal;
        }

        /// <summary>
        /// overloaded constructor with three parameters
        /// </summary>
        /// <param name="taskDate"></param>
        /// <param name="description"></param>
        /// <param name="priority"></param>
        public Task (DateTime taskDate, string description, PriorityType priority)
        {
            this.date = taskDate;
            this.description = description;
            this.priority = priority;
        }

        /// <summary>
        /// an overload constructor with only one parameter. 
        /// </summary>
        /// <param name="taskDate"></param>
        
        public Task(DateTime taskDate) { this.date = taskDate; }

        #endregion


        #region PROPERTIES
        /// <summary>
        /// Getters and setters for our variables.
        /// </summary>
        public DateTime DateAndTime
        { get { return date; } set {  date = value; } }

        public PriorityType Priority
        { get { return priority; } set {  priority = value; } }

        public string Description
        { 
            get { return description; } 
            set 
            {
                if(!string.IsNullOrEmpty(value))
                {
                    description = value;
                }
            } 
        }
        #endregion

        #region METHODS
        
        /// <summary>
        /// Gets the Priority string that is chosen.
        /// </summary>
        /// <returns>The priority value without _ and a space betweeo instead. </returns>
        public string GetPriorityString()
        {
            string strOut = Enum.GetName(typeof(PriorityType), priority);
            strOut = strOut.Replace("_", " ");
            return strOut;
        }

        /// <summary>
        /// Get the time String the GUI
        /// </summary>
        /// <returns>Timestamp</returns>
        private string GetTimeString()
        {
            string time = string.Format("{0}:{1}", date.Hour.ToString("00"), date.Minute.ToString("00"));
            return time;
        }

        /// <summary>
        /// Just the layout for the ToString method when shown in the GUI
        /// </summary>
        /// <returns>Values for listbox</returns>
        public override string ToString()
        {
            string strOut = $"{date.ToLongDateString()} {GetTimeString(),25} {" ",10}" + 
                            $"{GetPriorityString(),-16} {description,38}";
            return strOut;
        }

        #endregion
    }
}
