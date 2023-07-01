using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Assignment5C
{
    public partial class MainForm : Form
    {
        EventManager eventManager;
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        public void InitializeGUI()
        {
            cmbCountry.Items.AddRange(Enum.GetNames(typeof(Countries)));
            cmbCountry.SelectedIndex = (int)Countries.Sverige;

            ClearTextBoxes(grpNewEvent);
            ClearTextBoxes(grpParticipants);

            //Clear output controls
            txtNbrOfParticipants.Text = "0";
            txtTotalCost.Text = "0.00";
            txtTotalFees.Text = "0.00";
            txtSurplusDeficit.Text = "0.00";
            lstParticipants.Items.Clear();

            //disable the participant groupbox at start
            grpParticipants.Enabled = false;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblParticipants_Click(object sender, EventArgs e)
        {

        }

        private void lblNbrOfParticipants_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// An eventhandler for the button Create Event when clicked. It clears the text boxes withing grpParticipants group box and clears the items
        /// in the lstParticipants list bx and class the CreateEvent() method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(grpParticipants);
            lstParticipants.Items.Clear();
            CreateEvent();
        }

        /// <summary>
        /// Clears the text in all of the text boxes within the specified groupbox. 
        /// </summary>
        /// <param name="groupBox"></param>
        private void ClearTextBoxes(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
            }
        }

        /// <summary>
        /// creates a new EventManager instance, sets the title of the event and updates the GUI. Checks the cost and fee amounts entered by 
        /// calling both ReadCostPerParticipants and ReadFeePerParticipants. 
        /// </summary>
        private void CreateEvent()
        {
            eventManager = new EventManager();

            if (string.IsNullOrEmpty(txtEventTitle.Text))
            {
                txtEventTitle.Text = "Untitled Event";
            }

            eventManager.Title = txtEventTitle.Text + " By Jagtej Sidhu";
            this.Text = eventManager.Title;

            bool costAmountOk = ReadCostPerParticipants();
            bool feeAmountOK = ReadFeePerParticipants();

            if (costAmountOk && feeAmountOK)
            {
                grpParticipants.Enabled = true; //turns group box participants on
                UpdateGUI();
            }

        }

        /// <summary>
        /// Reads the cost per participant from the txtCostPerParticipant text box in the GUI. Parses the value to a double and checks if 
        /// it's a valid non-negative value. 
        /// </summary>
        /// <returns></returns>
        private bool ReadCostPerParticipants()
        {
            double amount = 0.0;
            bool ok = true;

            if ((double.TryParse(txtCostPerParticipant.Text, out amount)) && (amount >= 0.0))
            {
                eventManager.CostPerPerson = amount;
            }
            else
            {
                MessageBox.Show("Invalid cost amount. Please try again!");
                ok = false;
            }
            return ok;
        }

        /// <summary>
        /// Reads the fee per participant from the txtFeePerParticipant text box in the GUI. Parses the value to a double and checks if 
        /// it's a valid non-negative value. 
        /// </summary>
        /// <returns></returns>
        private bool ReadFeePerParticipants()
        {
            double amount = 0.0;
            bool ok = true;

            if ((double.TryParse(txtFeePerParticipant.Text, out amount)) && (amount >= 0.0))
            {
                eventManager.CostPerPerson = amount;
            }
            else
            {
                MessageBox.Show("Invalid cost amount. Please try again!");
                ok = false;
            }
            return ok;
        }

        /// <summary>
        /// Clears the listBox and adds participants to the ListBox with the AddRange Method.
        /// </summary>

        private void UpdateGUI()
        {
            string[] strInfo = eventManager.Participants.GetParticipantsInfo();

            if (strInfo != null)
            {
                lstParticipants.Items.Clear();
                lstParticipants.Items.AddRange(strInfo);
                txtNbrOfParticipants.Text = lstParticipants.Items.Count.ToString();
            }

            //calls the methods from EventManger class
            double totalCost = eventManager.CalcTotalCost();
            txtTotalCost.Text = totalCost.ToString("0.00");
            txtNbrOfParticipants.Text = lstParticipants.Items.Count.ToString();

            double totalFee = eventManager.CalcTotalFee();
            txtTotalFees.Text = totalFee.ToString("0.00");
            txtSurplusDeficit.Text = (totalFee - totalCost).ToString("0.00");
        }

        /// <summary>
        /// Eventhandler for the button Add when clicked. If the input is valid it clears the textboxes and updates the gui and adds the
        /// the participants with calling the readInput method. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Participant participant = new Participant();
            if (ReadInput(ref participant))
            {
                ClearTextBoxes(grpParticipants);
                UpdateGUI();
            }
        }

        /// <summary>
        /// reads the input data from the user for a participant and validates it. If the input is valid, it adds the participant to the
        /// event manager's participant list. 
        /// </summary>
        /// <param name="participant"></param>
        /// <returns>a boolean that indicates whether the data is valid or not.</returns>
        private bool ReadInput(ref Participant participant)
        {
            bool ok = ReadParticipantData(ref participant);

            if (ok)
            {
                eventManager.Participants.AddParticipant(participant);
            }
            else
            {
                MessageBox.Show("First name, last name and city are required inputs");
            }
            return ok;
        }

        /// <summary>
        /// reads the participants data from the input fields and populates the corresponding properties of the participant object. 
        /// Reads and validates the address by calling the ReadAddress method. 
        /// </summary>
        /// <param name="participant"></param>
        /// <returns>a boolean that indicates whether the data is valid or not.</returns>
        private bool ReadParticipantData(ref Participant participant)
        {
            participant.FirstName = txtFirstName.Text;
            participant.LastName = txtLastName.Text;

            Address address = ReadAdress();

            participant.Address = address;

            bool ok = address.Validate();
            return ok;
        }

        /// <summary>
        /// Reads the address data from the input fields and creates a new Address object with the entered values. 
        /// </summary>
        /// <returns>The populated Address object.</returns>
        private Address ReadAdress()
        {
            Address address = new Address();

            address.Street = txtStreet.Text;
            address.City = txtCity.Text;
            address.ZipCode = txtZipCode.Text;

            address.Country = (Countries)cmbCountry.SelectedIndex;

            return address;
        }

        /// <summary>
        /// an event handler for the SelectedIndexChanged event of the list box. It retrieves the index of the selected item in the list box.
        /// If a valid index is selected it retrieves the corresponding participant from the event manager and updates the text boxes with the 
        /// participants information. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstParticipants_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstParticipants.SelectedIndex;

            if (index >= 0)
            {
                Participant participant = eventManager.Participants.GetParticipantAt(index);

                txtFirstName.Text = participant.FirstName;
                txtLastName.Text = participant.LastName;
                txtStreet.Text = participant.Address.Street;
                txtCity.Text = participant.Address.City;
                txtZipCode.Text = participant.Address.ZipCode;

                cmbCountry.SelectedIndex = (int)participant.Address.Country;
            }
        }

        /// <summary>
        /// Checks the index of the value the user has clicked. If it matches the new participant is added to the list instead of the older one.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChange_Click(object sender, EventArgs e)
        {
            int index = IsListBoxItemSelected();

            if (index < 0)
            {
                return;
            }

            Participant particpant = eventManager.Participants.GetParticipantAt(index);

            if (ReadParticipantData(ref particpant))
            {
                eventManager.Participants.ChangeParticipantAt(particpant, index);
                UpdateGUI();
            }
        }

        /// <summary>
        /// Checks the index of value by user and deletes is from the list box. Updates GUI. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = IsListBoxItemSelected();
            if (index < 0)
            {
                return;
            }

            eventManager.Participants.DeleteParticipantAt(index);
            UpdateGUI();
        }

        /// <summary>
        /// Method to check if a participant is selected in the list box. Change and Delete button use this method. 
        /// </summary>
        /// <returns>The index value of selected participant</returns>
        private int IsListBoxItemSelected()
        {
            int index = lstParticipants.SelectedIndex;

            if (lstParticipants.SelectedIndex != -1)
            {
                string selecteditem = lstParticipants.SelectedItem.ToString();
                MessageBox.Show("Selected item: " + selecteditem);
            }
            else
            {
                MessageBox.Show("No item selected.");
            }

            return index;
        }
    }
}