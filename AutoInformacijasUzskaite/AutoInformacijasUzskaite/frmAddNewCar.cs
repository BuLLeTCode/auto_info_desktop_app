using System;
using System.Windows.Forms;

namespace AutoInformacijasUzskaite
{
    public partial class frmAddNewCar : Form
    {
        //Reference to main form
        MySQLManager dbManager;

        public frmAddNewCar()
        {
            InitializeComponent();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            //Create instance
            dbManager = new MySQLManager();
            dbManager.OpenDBConnection();
            if(dbManager.Insert(tbCarManufacture.Text, tbCarModel.Text, tbCarYear.Text))
            {
                MessageBox.Show("Jauna automašīna veiksmīgi pievienota!");
            }
            else
            {
                MessageBox.Show("Problēma pievienot jauno automašīnu");
            }
            //clear input fields
            tbCarManufacture.Clear();
            tbCarModel.Clear();
            tbCarYear.Clear();
            //Maybe at end - destroy instance?
            dbManager = null;
        }

        private void btnBackFrmAddNewCar_Click(object sender, EventArgs e)
        {
            //Close active form. :)
            this.Close();
        }
    }
}
