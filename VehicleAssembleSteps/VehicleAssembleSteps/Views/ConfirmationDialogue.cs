using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleAssembleSteps.Views
{
    public partial class ConfirmationDialogue : Form
    {
        private VehicleAssembleModel vehicleAssembleModel;
        public ConfirmationDialogue(VehicleAssembleModel vehicleAssembleModel)
        {
            InitializeComponent();
            LoadControls(vehicleAssembleModel);
            this.vehicleAssembleModel = vehicleAssembleModel;
        }
        /// <summary>
        /// Loads the controls
        /// </summary>
        /// <param name="vehicleAssemble">adding vehicleAssemble</param>
        private void LoadControls(VehicleAssembleModel vehicleAssemble)
        {
            lblAssemblyProcess.Text = vehicleAssemble.AssemblyProcess;
            lblTirePressure.Text = vehicleAssemble.TirePressure.ToString();
            lblVehicleProjectCode.Text = vehicleAssemble.VehicleProjectCode;
            lblVariant.Text = vehicleAssemble.Variant;
            lblRegion.Text = vehicleAssemble.Region;
            lblTransmissionType.Text = vehicleAssemble.TransmissionType;
            lblColorCode.Text = vehicleAssemble.ColorCode;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Repository repository = new Repository();
            repository.AddVehicleAssemble(vehicleAssembleModel);
            ConfirmationMessage msg = new ConfirmationMessage(vehicleAssembleModel);
            msg.ShowDialog();
            this.Close();
        }
    }
}
