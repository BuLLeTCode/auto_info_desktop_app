using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoInformacijasUzskaite
{
    public partial class frmMain : Form
    {
        
        public frmMain()
        {
            InitializeComponent();
            SetDate();//After inicializing components, set date
        }

        private void SetDate()
        {
            lblDateTimeFrmMain.Text = DateTime.Today.ToShortDateString();
        }

        private void btnNewCarFrmMain_Click(object sender, EventArgs e)
        {
            frmAddNewCar newCar = new frmAddNewCar();
            newCar.ShowDialog();
        }

        private void btnShowServicesFrmMain_Click(object sender, EventArgs e)
        {
            frmCheckServices carService = new frmCheckServices();
            carService.ShowDialog();
        }

        private void btnAddNewServiceFrmMain_Click(object sender, EventArgs e)
        {
            frmAddNewService newService = new frmAddNewService();
            newService.ShowDialog();
        }
    }
}
