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
    public partial class ConfirmationMessage : Form
    {
        public ConfirmationMessage(VehicleAssembleModel vehicleAssemble)
        {
            InitializeComponent();
            LoadControls(vehicleAssemble);
        }
        /// <summary>
        /// Loads the controls data
        /// </summary>
        /// <param name="vehicleAssemble">Adding vehicleAssemble</param>
        private void LoadControls(VehicleAssembleModel vehicleAssemble)
        {
            lblAssembleProcess.Text = vehicleAssemble.VehicleProjectCode;
            lblTirePressure.Text = vehicleAssemble.TirePressure.ToString();
            lblVehicleColor.Text = vehicleAssemble.ColorCode;
        }
        private void btnConfirmation_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
