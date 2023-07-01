using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Assignment6C
{
    internal class FileManager
    {
        private const string fileVersionToken = "ToDoRe_21";

        private const double fileVersionNbr = 1.0;

        #region METHODS
        /// <summary>
        /// saves a list of tasks to a file by writing the task info using StreamWriter. 
        /// </summary>
        /// <param name="taskList"></param>
        /// <param name="fileName"></param>
        /// <returns>Boolean value indicating success or failure (true or false)</returns>
        public bool SaveTaskListToFile(List<Task> taskList, string fileName)
        {
            bool ok = true;

            StreamWriter writer = null;

            try
            {
                writer = new StreamWriter(fileName);
                writer.WriteLine(fileVersionToken);
                writer.WriteLine(fileVersionNbr);
                writer.WriteLine(taskList.Count);

                for (int i = 0; i < taskList.Count; i++)
                {
                    writer.WriteLine(taskList[i].Description);
                    writer.WriteLine(taskList[i].Priority.ToString());
                    writer.WriteLine(taskList[i].DateAndTime.Year);
                    writer.WriteLine(taskList[i].DateAndTime.Month);
                    writer.WriteLine(taskList[i].DateAndTime.Day);
                    writer.WriteLine(taskList[i].DateAndTime.Hour);
                    writer.WriteLine(taskList[i].DateAndTime.Minute);
                    writer.WriteLine(taskList[i].DateAndTime.Second);
                }
            }
            catch (Exception ex)
            {
                ok = false;
            } finally
            {
                if (writer != null)
                    writer.Close();
            }

            return ok;
        }

        /// <summary>
        /// read a list of tasks from a file by reading the task info using StreamReader. 
        /// </summary>
        /// <param name="taskList"></param>
        /// <param name="fileName"></param>
        /// <returns>Boolean value indicating success or failure (true or false)</returns>
        public bool ReadTaskListFromFile(List<Task> taskList, string fileName)
        {
            bool ok = true;
            StreamReader reader = null;

            try
            {
                //Clear the contnts of taskList
                if(taskList != null)
                {
                    taskList.Clear();
                } else
                {
                    taskList = new List<Task>();

                }

                reader = new StreamReader(fileName);

                //Makes sure that its the correct file
                string versionTest = reader.ReadLine();
                //Checks if it is the correct version
                double version = double.Parse(reader.ReadLine());

                if((version == fileVersionNbr) && (versionTest == fileVersionToken))
                {
                    int count = int.Parse(reader.ReadLine());
                    for (int i = 0; i < count; i++)
                    {
                        Task task = new Task();
                        task.Description = reader.ReadLine();
                        task.Priority = (PriorityType)Enum.Parse(typeof(PriorityType), reader.ReadLine());

                        //Readonlys
                        int year = 0;
                        int month = 0;
                        int day = 0;

                        int hour = 0;
                        int minute = 0;
                        int second = 0;

                        year = int.Parse(reader.ReadLine());
                        month = int.Parse(reader.ReadLine());
                        day = int.Parse(reader.ReadLine());
                        hour = int.Parse(reader.ReadLine());
                        minute = int.Parse(reader.ReadLine());
                        second = int.Parse(reader.ReadLine());

                        task.DateAndTime = new DateTime(year, month, day, hour, minute, second);

                        taskList.Add(task);
                    }
                }

            } catch 
            
            {
               ok = false;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }


            return ok;
        }
        #endregion

    }
}
