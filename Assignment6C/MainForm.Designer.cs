namespace Assignment6C
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblDateNTime = new Label();
            lblTodo = new Label();
            dateTimePicker = new DateTimePicker();
            lblPriority = new Label();
            cmbPrioritylist = new ComboBox();
            txtTodo = new TextBox();
            btnAdd = new Button();
            grpTodolist = new GroupBox();
            lblDescription = new Label();
            lblPriorityInLst = new Label();
            lblHour = new Label();
            lblDate = new Label();
            lstTodo = new ListBox();
            lblTimer = new Label();
            toolTip = new ToolTip(components);
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1 = new MenuStrip();
            fIleToolStripMenuItem = new ToolStripMenuItem();
            newCtrlNToolStripMenuItem = new ToolStripMenuItem();
            openDataFileToolStripMenuItem = new ToolStripMenuItem();
            saveDataFileToolStripMenuItem = new ToolStripMenuItem();
            exitAltF4ToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            grpTodolist.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblDateNTime
            // 
            lblDateNTime.AutoSize = true;
            lblDateNTime.Location = new Point(26, 39);
            lblDateNTime.Name = "lblDateNTime";
            lblDateNTime.Size = new Size(81, 15);
            lblDateNTime.TabIndex = 0;
            lblDateNTime.Text = "Date and time";
            // 
            // lblTodo
            // 
            lblTodo.AutoSize = true;
            lblTodo.Location = new Point(26, 73);
            lblTodo.Name = "lblTodo";
            lblTodo.Size = new Size(36, 15);
            lblTodo.TabIndex = 1;
            lblTodo.Text = "To do";
            lblTodo.Click += lblTodo_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(182, 31);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(265, 23);
            dateTimePicker.TabIndex = 2;
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Location = new Point(471, 39);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(45, 15);
            lblPriority.TabIndex = 3;
            lblPriority.Text = "Priority";
            // 
            // cmbPrioritylist
            // 
            cmbPrioritylist.FormattingEnabled = true;
            cmbPrioritylist.Location = new Point(541, 31);
            cmbPrioritylist.Name = "cmbPrioritylist";
            cmbPrioritylist.Size = new Size(121, 23);
            cmbPrioritylist.TabIndex = 4;
            // 
            // txtTodo
            // 
            txtTodo.Location = new Point(107, 70);
            txtTodo.Name = "txtTodo";
            txtTodo.Size = new Size(555, 23);
            txtTodo.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.ForeColor = Color.Green;
            btnAdd.Location = new Point(310, 113);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(137, 30);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // grpTodolist
            // 
            grpTodolist.Controls.Add(lblDescription);
            grpTodolist.Controls.Add(lblPriorityInLst);
            grpTodolist.Controls.Add(lblHour);
            grpTodolist.Controls.Add(lblDate);
            grpTodolist.Controls.Add(lstTodo);
            grpTodolist.ForeColor = Color.FromArgb(0, 192, 0);
            grpTodolist.Location = new Point(12, 171);
            grpTodolist.Name = "grpTodolist";
            grpTodolist.Size = new Size(776, 267);
            grpTodolist.TabIndex = 7;
            grpTodolist.TabStop = false;
            grpTodolist.Text = "To Do";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.ForeColor = Color.Black;
            lblDescription.Location = new Point(400, 24);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Description";
            // 
            // lblPriorityInLst
            // 
            lblPriorityInLst.AutoSize = true;
            lblPriorityInLst.ForeColor = Color.Black;
            lblPriorityInLst.Location = new Point(224, 25);
            lblPriorityInLst.Name = "lblPriorityInLst";
            lblPriorityInLst.Size = new Size(45, 15);
            lblPriorityInLst.TabIndex = 1;
            lblPriorityInLst.Text = "Priority";
            // 
            // lblHour
            // 
            lblHour.AutoSize = true;
            lblHour.ForeColor = Color.Black;
            lblHour.Location = new Point(160, 25);
            lblHour.Name = "lblHour";
            lblHour.Size = new Size(34, 15);
            lblHour.TabIndex = 1;
            lblHour.Text = "Hour";
            lblHour.Click += lblHour_Click;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.ForeColor = Color.Black;
            lblDate.Location = new Point(24, 25);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(31, 15);
            lblDate.TabIndex = 1;
            lblDate.Text = "Date";
            // 
            // lstTodo
            // 
            lstTodo.FormattingEnabled = true;
            lstTodo.ItemHeight = 15;
            lstTodo.Location = new Point(14, 42);
            lstTodo.Name = "lstTodo";
            lstTodo.Size = new Size(744, 214);
            lstTodo.TabIndex = 0;
            // 
            // lblTimer
            // 
            lblTimer.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblTimer.ForeColor = Color.LightSeaGreen;
            lblTimer.Location = new Point(722, 441);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(66, 28);
            lblTimer.TabIndex = 8;
            lblTimer.Text = "Timer";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(224, 224, 224);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fIleToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            fIleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newCtrlNToolStripMenuItem, openDataFileToolStripMenuItem, saveDataFileToolStripMenuItem, exitAltF4ToolStripMenuItem });
            fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            fIleToolStripMenuItem.Size = new Size(37, 20);
            fIleToolStripMenuItem.Text = "File";
            // 
            // newCtrlNToolStripMenuItem
            // 
            newCtrlNToolStripMenuItem.Name = "newCtrlNToolStripMenuItem";
            newCtrlNToolStripMenuItem.Size = new Size(203, 22);
            newCtrlNToolStripMenuItem.Text = "New                       Ctrl+N";
            newCtrlNToolStripMenuItem.Click += newCtrlNToolStripMenuItem_Click;
            // 
            // openDataFileToolStripMenuItem
            // 
            openDataFileToolStripMenuItem.Name = "openDataFileToolStripMenuItem";
            openDataFileToolStripMenuItem.Size = new Size(203, 22);
            openDataFileToolStripMenuItem.Text = "Open data file";
            openDataFileToolStripMenuItem.Click += openDataFileToolStripMenuItem_Click;
            // 
            // saveDataFileToolStripMenuItem
            // 
            saveDataFileToolStripMenuItem.Name = "saveDataFileToolStripMenuItem";
            saveDataFileToolStripMenuItem.Size = new Size(203, 22);
            saveDataFileToolStripMenuItem.Text = "Save data file";
            saveDataFileToolStripMenuItem.Click += saveDataFileToolStripMenuItem_Click;
            // 
            // exitAltF4ToolStripMenuItem
            // 
            exitAltF4ToolStripMenuItem.Name = "exitAltF4ToolStripMenuItem";
            exitAltF4ToolStripMenuItem.Size = new Size(203, 22);
            exitAltF4ToolStripMenuItem.Text = "Exit                         Alt+F4";
            exitAltF4ToolStripMenuItem.Click += exitAltF4ToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(116, 22);
            aboutToolStripMenuItem.Text = "About...";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 474);
            Controls.Add(lblTimer);
            Controls.Add(grpTodolist);
            Controls.Add(btnAdd);
            Controls.Add(txtTodo);
            Controls.Add(cmbPrioritylist);
            Controls.Add(lblPriority);
            Controls.Add(dateTimePicker);
            Controls.Add(lblTodo);
            Controls.Add(lblDateNTime);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            grpTodolist.ResumeLayout(false);
            grpTodolist.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDateNTime;
        private Label lblTodo;
        private DateTimePicker dateTimePicker;
        private Label lblPriority;
        private ComboBox cmbPrioritylist;
        private TextBox txtTodo;
        private Button btnAdd;
        private GroupBox grpTodolist;
        private ListBox lstTodo;
        private Label lblDate;
        private Label lblHour;
        private Label lblPriorityInLst;
        private Label lblDescription;
        private Label lblTimer;
        private ToolTip toolTip;
        private System.Windows.Forms.Timer timer1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fIleToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private ToolStripMenuItem newCtrlNToolStripMenuItem;
        private ToolStripMenuItem openDataFileToolStripMenuItem;
        private ToolStripMenuItem saveDataFileToolStripMenuItem;
        private ToolStripMenuItem exitAltF4ToolStripMenuItem;
    }
}