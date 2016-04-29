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
    public partial class frmAddNewService : Form
    {
        MySQLManager dbManager;

        public frmAddNewService()
        {
            InitializeComponent();
            AddFewServiceTypes();
            AddUserCars();
        }

        private void AddFewServiceTypes()
        {
            cbServiceType.Items.Add("Ellas maina");
            cbServiceType.Items.Add("Zobsiksnas maina");
            cbServiceType.Items.Add("Remonts");
            cbServiceType.Items.Add("Cits");
        }

        private void AddUserCars()
        {
            dbManager = new MySQLManager();
            cbUserCar.DataSource = dbManager.SelectUserCars();
        }

        private void btnNewServiceBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            
            string[] carServiceInfo = new string[] { cbServiceType.SelectedItem.ToString(), dateTimePicker1.Value.ToShortDateString(), numericUpDown1.Value.ToString(), tbServiceComments.Text};

            if(dbManager.Insert(cbUserCar.SelectedItem.ToString(), carServiceInfo))
            {
                MessageBox.Show("Apkope pievienota!");
            }
            else
            {
                MessageBox.Show("Apkopes pievienošanā radusies kļūda");
            }
        }
    }
}
