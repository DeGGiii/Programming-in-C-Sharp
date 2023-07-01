namespace Assignment6C
{
    public partial class MainForm : Form
    {
        TaskManager taskManager;

        private string fileName = Application.StartupPath + "\\Tasks.txt";
        public MainForm()
        {
            InitializeComponent();

            InitializeGUI();
        }

        private void InitializeGUI()
        {
            this.Text = "ToDo Reminder by Jagtej Sidhu";

            taskManager = new TaskManager();

            //connects the enum class with the GUI. Able to choose from the Enum class in the Priority List.
            cmbPrioritylist.Items.Clear();
            cmbPrioritylist.Items.AddRange(Enum.GetNames(typeof(PriorityType)));
            cmbPrioritylist.SelectedIndex = (int)PriorityType.Normal;

            lstTodo.Items.Clear();
            lblTimer.Text = string.Empty;
            timer1.Start();

            txtTodo.Text = "";

            //Changes the Format for the date time picker.
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "yyyy-MM-dd   HH:mm";

            toolTip.ShowAlways = true;

            toolTip.SetToolTip(dateTimePicker, "Click to open calender for date, write in time here.");
            toolTip.SetToolTip(cmbPrioritylist, "Select the priority");

            string tips = "TO CHANGE: Select an item first!" + Environment.NewLine;
            tips += "Make your chnages in the input controls," + Environment.NewLine;

            toolTip.SetToolTip(lstTodo, tips);

            string descriptionTips = "Write your sins here!";
            toolTip.SetToolTip(txtTodo, descriptionTips);

            openDataFileToolStripMenuItem.Enabled = true;
            saveDataFileToolStripMenuItem.Enabled = true;

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("HH:mm");
        }

        private void exitAltF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Think twice", MessageBoxButtons.OKCancel);

            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void lblTodo_Click(object sender, EventArgs e)
        {

        }

        private void openDataFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string errMessage = "Something went wrong when opening the file!";

            bool ok = taskManager.ReadDataFromFile(fileName);
            if (!ok)
            {
                MessageBox.Show(errMessage);
            }
            else
            {
                UpdateGUI();
            }
        }

        private void UpdateGUI()
        {
            lstTodo.Items.Clear();
            string[] infoStrings = taskManager.GetInfoStringsList();
            if (infoStrings != null && infoStrings.Length > 0)
            {
                lstTodo.Items.AddRange(infoStrings);
            }
        }

        private void saveDataFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string errMessage = "Something went wrong while saving data to file";

            bool ok = taskManager.WriteDataToFile(fileName);
            {
                if (!ok)
                {
                    MessageBox.Show(errMessage);
                }
                else
                {
                    MessageBox.Show("Data saved to file: " + Environment.NewLine + fileName);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Task task = ReadInput();
            if (taskManager.AddTask(task))
            {
                UpdateGUI();
            }
        }

        private Task ReadInput()
        {
            Task task = new Task();

            if (string.IsNullOrEmpty(txtTodo.Text))
            {
                MessageBox.Show("No subject? Write something please!");
                return null;
            }

            task.Description = txtTodo.Text;
            task.DateAndTime = dateTimePicker.Value;
            task.Priority = (PriorityType)cmbPrioritylist.SelectedIndex;

            return task;
        }

        private void newCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeGUI();
        }

        private void lblHour_Click(object sender, EventArgs e)
        {

        }
    }
}