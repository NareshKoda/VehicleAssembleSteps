using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using VehicleAssembleSteps.Views;
using System.IO;

namespace VehicleAssembleSteps
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            getColorCodes();
        }
        public static List<VehicleAssembleModel> listOfVehicleAssembleModels = new List<VehicleAssembleModel>();
        /// <summary>
        /// Gets the color codes
        /// </summary>
        private void getColorCodes()
        {
            ArrayList ColorList = new ArrayList();
            Type colorType = typeof(System.Drawing.Color);
            PropertyInfo[] propInfoList = colorType.GetProperties(BindingFlags.Static |
                                          BindingFlags.DeclaredOnly | BindingFlags.Public);
            foreach (PropertyInfo c in propInfoList)
            {
                this.cmbColor.Items.Add(c.Name);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            VehicleAssembleModel vehicleAssemble = new VehicleAssembleModel();
            vehicleAssemble.VehicleProjectCode = txtVehicleProjCode.Text;
            if(!string.IsNullOrEmpty(txtTirePressure.Text))
                vehicleAssemble.TirePressure = Convert.ToInt32(txtTirePressure.Text);
            vehicleAssemble.AssemblyProcess = rtxtAssemblyProcess.Text;

            if (rbDomestic.Checked)
                vehicleAssemble.Variant = rbDomestic.Text;
            if (rbExport.Checked)
                vehicleAssemble.Variant = rbExport.Text;

            GetTransmissionType(vehicleAssemble);
            GetRegionData(vehicleAssemble);

            vehicleAssemble.ColorCode = cmbColor.SelectedItem.ToString();

            ConfirmationDialogue s = new ConfirmationDialogue(vehicleAssemble);
            s.ShowDialog();
        }

       

        /// <summary>
        /// Get the transmission type
        /// </summary>
        /// <param name="vehicleAssemble">Selected vehicleAssemble</param>
        private void GetTransmissionType(VehicleAssembleModel vehicleAssemble)
        {
            if (rbAMT.Checked)
                vehicleAssemble.TransmissionType = rbAMT.Text;
            if (rbMT.Checked)
                vehicleAssemble.TransmissionType = rbMT.Text;
            if (rbAT.Checked)
                vehicleAssemble.TransmissionType = rbAT.Text;
            if (rbIMT.Checked)
                vehicleAssemble.TransmissionType = rbIMT.Text;

        }
        /// <summary>
        /// Gets the Region code data
        /// </summry>
        /// <param name="vehicleAssemble">Selected vehicleAssemble</param>
        private void GetRegionData(VehicleAssembleModel vehicleAssemble)
        {
            if (chkBoxNorth.Checked)
                vehicleAssemble.Region = chkBoxNorth.Text;
            if (chkBoxMWest.Checked)
                vehicleAssemble.Region = chkBoxMWest.Text;
            if (chkBoxWest.Checked)
                vehicleAssemble.Region = chkBoxWest.Text;
            if (chkBoxSouth.Checked)
                vehicleAssemble.Region = chkBoxSouth.Text;
        }

        private void btnDisplaAllLines_Click(object sender, EventArgs e)
        {
            AllLineDetails all = new AllLineDetails();
            all.ShowDialog();
        }

        private void txtVehicleProjCode_Leave(object sender, EventArgs e)
        {
            ValidateSubmitButton();
        }
        private void rtxtAssemblyProcess_Leave(object sender, EventArgs e)
        {
            ValidateSubmitButton();
        }
        private void cmbColor_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidateSubmitButton();
        }
        /// <summary>
        /// Validating the Submit button
        /// </summary>
        private void ValidateSubmitButton()
        {
            if (!string.IsNullOrEmpty(txtVehicleProjCode.Text) && !string.IsNullOrEmpty(rtxtAssemblyProcess.Text) && !string.IsNullOrEmpty(cmbColor.Text))
                btnSubmit.Enabled = true;
            else
                btnSubmit.Enabled = false;
        }

        private void txtTirePressure_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;

            if (e.Handled)
                MessageBox.Show("Please enter numbers only", "ALert", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void chkBoxMWest_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxChanged(chkBoxMWest.Text);
        }
        private void chkBoxNorth_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxChanged(chkBoxNorth.Text);
        }

        private void chkBoxSouth_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxChanged(chkBoxSouth.Text);
        }

        private void chkBoxWest_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxChanged(chkBoxWest.Text);
        }
      
        /// <summary>
        /// Checking the check boxes
        /// </summary>
        /// <param name="checkBoxName">selected CheckBox</param>
        private void CheckBoxChanged(string checkBoxName)
        {
            switch (checkBoxName)
            {
                case "Mid West":
                    chkBoxNorth.Checked = false;
                    chkBoxSouth.Checked = false;
                    chkBoxWest.Checked = false;
                    break;
                case "North East":
                    chkBoxMWest.Checked = false;
                    chkBoxSouth.Checked = false;
                    chkBoxWest.Checked = false;
                    break;
                case "South":
                    chkBoxNorth.Checked = false;
                    chkBoxMWest.Checked = false;
                    chkBoxWest.Checked = false;
                    break;
                case "West":
                    chkBoxNorth.Checked = false;
                    chkBoxSouth.Checked = false;
                    chkBoxMWest.Checked = false;
                    break;
                default:
                    break;
            }
        }

       
    }
}
