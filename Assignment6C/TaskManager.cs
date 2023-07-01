using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6C
{
    internal class TaskManager
    {

        List<Task> taskList;

        #region CONSTRUCTORS
        public TaskManager()
        {
            taskList = new List<Task>();
        }

        /// <summary>
        /// retrieves a task from the taskList based on the given id. Checks if the index is valid by calling CheckIndex.
        /// </summary>
        /// <param name="id"></param>
        /// <returns> If valid return task at specified index. Otherwise, return null. </returns>
        public Task GetTask(int id)
        {
            if (CheckIndex(id))
            {
                return taskList[id];
            } else
            {
                return null;
            }
        }
        #endregion

        #region METHODS
        /// <summary>
        /// Adds a new task to the taskList. Checks if the task object is not null, indicating a valid task. If valid add to the taskList.
        /// </summary>
        /// <param name="time"></param>
        /// <param name="description"></param>
        /// <param name="priorityType"></param>
        /// <returns>Returns value ok wether the task was true or false.</returns>
        public bool AddTask(DateTime time, string description, PriorityType priorityType)
        {
            bool ok = true;

            Task task = new Task(time, description, priorityType);
            if (task != null)
            {
                taskList.Add(task);

            } else { ok = false; }
            return ok;
        }

        /// <summary>
        /// adds a new task to the taskList. Checks if provided task is not null, indicating a valid task. If valid add to the taskList.
        /// </summary>
        /// <param name="task"></param>
        /// <returns>Return ok indicating true or false. </returns>
        public bool AddTask(Task task) 
        {
            bool ok = true;

            if (task != null)
            {
                taskList.Add(task);

            } else
            {
                ok = false;
            }
            return ok;


        }

        /// <summary>
        /// Retrieves an array of strings containing the string representation of each task in the taskList. Iterates over each element in
        /// infoStrings. 
        /// </summary>
        /// <returns>Returns the infoStrings array containing the strings of the task.</returns>
        public string[] GetInfoStringsList()
        {
            //creates a local array of string element with a capacity = num of elemets in the tasklist
            string[] infoStrings = new string[taskList.Count];

            for (int i = 0; i < infoStrings.Length; i++)
            {
                infoStrings[i] = taskList[i].ToString();
            }
            return infoStrings;
        }

        /// <summary>
        /// Checks if given index is within range of taskList. 
        /// </summary>
        /// <param name="index"></param>
        /// <returns>If index is within range sets ok to true, if not false.</returns>
        public bool CheckIndex(int index)
        {
            bool ok = false;

            if ((index >= 0) && (index < taskList.Count))
            {
                ok = true;
            }
            return ok;
        }

        /// <summary>
        /// reads task data from a file.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns>returns the result of the file</returns>
        public bool ReadDataFromFile(string fileName)
        {
            FileManager fileManager = new FileManager();

            return fileManager.ReadTaskListFromFile(taskList, fileName);
        }

        /// <summary>
        /// Writes task data to a file.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns>Return the result of the file</returns>
        public bool WriteDataToFile(string fileName)
        {
            FileManager fileManager= new FileManager();
            return fileManager.SaveTaskListToFile(taskList, fileName);
        }

        #endregion
    }
}
