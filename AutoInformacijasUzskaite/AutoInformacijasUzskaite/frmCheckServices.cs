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
    public partial class frmCheckServices : Form
    {
        MySQLManager dbManager;
        private string selectedItemName = "";

        public frmCheckServices()
        {
            InitializeComponent();
            dbManager = new MySQLManager();
            SetUserAvaibleCars();
        }

        private void SetUserAvaibleCars()
        {
            cbChooseCar.DataSource = dbManager.SelectUserCars(); 
        }

        private void cbChooseCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayServiceInfoForCar(cbChooseCar.SelectedItem.ToString());
        }

        private void DisplayServiceInfoForCar(string carInfo)
        {
            Console.WriteLine("Change index: " + carInfo);
            string[] carInfoParts = carInfo.Split(' ');
            List<string> specificCarInfo = dbManager.SelectCarServices(carInfoParts[0], carInfoParts[1], carInfoParts[2]);
            //MessageBox.Show("FIRST SERVICE" + specificCarInfo[0][0].ToString());

            foreach (var service in specificCarInfo)
            {
                string[] specificServiceInfo = service.Split('|');
                ListViewItem item = new ListViewItem(specificServiceInfo[0]);
                item.SubItems.Add(specificServiceInfo[1]);
                item.SubItems.Add(specificServiceInfo[2]);
                item.SubItems.Add(specificServiceInfo[3]);
                lvCarServices.Items.Add(item);
            }
        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem service in lvCarServices.Items)
            {
                if(service.Checked)
                {
                    Console.WriteLine("Tika nodzests: " + service.SubItems[1].Text + " " + service.SubItems[2].Text);

                    //First try to delete from DB and then, if succesfull delete from ListView
                    if(dbManager.DeleteService(cbChooseCar.SelectedItem.ToString(), service.SubItems[0].Text, service.SubItems[1].Text, service.SubItems[2].Text))
                    {
                        service.Remove();
                        MessageBox.Show("Apkopes dzēšana veiksmīga!");
                    }
                    else
                    {
                        MessageBox.Show("Apkopes dzēšanas procesā ir notikusi kļūda");
                    }
                }
            }
        }

        private void btnCheckServicesBack_Click(object sender, EventArgs e)
        {
            dbManager = null;
            this.Close();//Close this form.
        }
    }
}
