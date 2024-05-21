using Hades2common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hades2Lite
{
    public partial class ServicesForm : Form
    {
        private string pcName;
        private DataTable servicesTable = new DataTable();

        public ServicesForm(string computerName)
        {
            pcName = computerName;
            InitializeComponent();
        }





        private async void ServicesForm_Load(object sender, EventArgs e)
        {
            servicesTable = await ToolBox.GetServicesFromComputerAsync(pcName);
            dataGridView_services.DataSource = servicesTable;

            dataGridView_services.Columns[0].HeaderText = "Nazwa usługi";
            dataGridView_services.Columns[1].HeaderText = "Stan";
            dataGridView_services.Columns[2].HeaderText = "Opis usługi";
            dataGridView_services.Columns[0].Width = 200;
            dataGridView_services.Columns[1].Width = 120;
            dataGridView_services.Columns[2].Width = 500;
            dataGridView_services.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_services.Sort(dataGridView_services.Columns["serviceName"], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_servicename_filter_TextChanged(object sender, EventArgs e)
        {
            servicesTable.DefaultView.RowFilter = string.Format("serviceName like '%" + textBox_servicename_filter.Text + "%'");
        }

        private void textBox_status_filter_TextChanged(object sender, EventArgs e)
        {
            servicesTable.DefaultView.RowFilter = string.Format("stan like '%" + textBox_status_filter.Text + "%'");
        }

        private void textBox_displayName_filter_TextChanged(object sender, EventArgs e)
        {
            servicesTable.DefaultView.RowFilter = string.Format("displayName like '%" + textBox_displayName_filter.Text + "%'");
        }

        private void textBox_servicename_filter_Enter(object sender, EventArgs e)
        {
            textBox_servicename_filter.Text = "";
            textBox_status_filter.Text = "";
            textBox_displayName_filter.Text = "";
        }

        private void textBox_status_filter_Enter(object sender, EventArgs e)
        {
            textBox_servicename_filter.Text = "";
            textBox_status_filter.Text = "";
            textBox_displayName_filter.Text = "";
        }

        private void textBox_displayName_filter_Enter(object sender, EventArgs e)
        {
            textBox_servicename_filter.Text = "";
            textBox_status_filter.Text = "";
            textBox_displayName_filter.Text = "";
        }

        private async void button_start_service_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView_services.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView_services.SelectedRows[0];
                    object cellValue = selectedRow.Cells["serviceName"].Value;

                    if (cellValue != null)
                    {
                        selectedRow.Cells["stan"].Value = "Uruchamianie...";
                        bool result = await ToolBox.ManageRemoteServiceAsync(pcName, (string)cellValue, "start");
                        string serviceStatus = await ToolBox.GetServiceStateAsync((string)cellValue, pcName);
                        selectedRow.Cells["stan"].Value = serviceStatus;
                    }
                    else
                    {
                        MessageBox.Show("Komórka jest pusta.");
                    }
                }
                else
                {
                    MessageBox.Show("Nie zaznaczono żadnego wiersza.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystapił błąd: " + ex.Message);
                return;
            }


        }

        private async void button_stop_service_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView_services.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView_services.SelectedRows[0];
                    object cellValue = selectedRow.Cells["serviceName"].Value;

                    if (cellValue != null)
                    {
                        selectedRow.Cells["stan"].Value = "Zatrzymywanie...";
                        bool result = await ToolBox.ManageRemoteServiceAsync(pcName, (string)cellValue, "stop");
                        string serviceStatus = await ToolBox.GetServiceStateAsync((string)cellValue, pcName);
                        selectedRow.Cells["stan"].Value = serviceStatus;
                    }
                    else
                    {
                        MessageBox.Show("Komórka jest pusta.");
                    }
                }
                else
                {
                    MessageBox.Show("Nie zaznaczono żadnego wiersza.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystapił błąd: " + ex.Message);
                return;
            }
        }

        private void button_restart_service_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem_start_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem_stop_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem_restart_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelcenter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void contextMenuStrip_services_Opening(object sender, CancelEventArgs e)
        {

        }

        private void paneltop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox_szukaj_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_services_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panelbottom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_restart_Click(object sender, EventArgs e)
        {

        }
    }
}
