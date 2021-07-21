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
    public partial class AllLineDetails : Form
    {
        public AllLineDetails()
        {
            InitializeComponent();
        }
        private void AllLineDetails_Load(object sender, EventArgs e)
        {
            Repository repository = new Repository();
            grdvAllLineDetails.DataSource = repository.GetVehicleAssembleData();
        }
    }
}
