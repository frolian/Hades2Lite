using Hades2common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hades2Lite
{
    public partial class ComputersListsForm : Form
    {
        public const string listsDirPath = @"D:\CI-OHD\Hades2\listyPC"; //katalog w kóry przechowywane są listy
        public List<String> pcLists = new List<String>();
        public ComputersListsForm()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComputersListsForm_Load(object sender, EventArgs e)
        {
            try
            {
                pcLists.Clear();
                pcLists = ToolBox.GetListyPc(listsDirPath);
                foreach (String list in pcLists)
                {
                    listyPC_dataGridView.Rows.Add(list);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Podczas odczytu usług wystapił błąd: " + ex.Message);
                return;
            }

        }

        private void listyPC_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //kodowanie plików list w UTF-8
            if (e.RowIndex >= 0 && e.RowIndex < listyPC_dataGridView.Rows.Count)
            {
                try
                {
                    string selectedFileName = listyPC_dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString() + ".csv";
                    string selectedFilePath = Path.Combine(listsDirPath, selectedFileName);

                    DataTable pcList = ToolBox.GetListPcContent(selectedFilePath);
                    lista_dataGridView.DataSource = pcList;
                    lista_dataGridView.Columns[0].HeaderText = "Nazwa Komputera";
                    lista_dataGridView.Columns[1].HeaderText = "Opis Komputera";
                    lista_dataGridView.Columns[0].Width = 150;
                    lista_dataGridView.Columns[1].Width = 320;
                    lista_dataGridView.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    lista_dataGridView.Sort(lista_dataGridView.Columns["pcName"], System.ComponentModel.ListSortDirection.Ascending);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Podczas odczytu usług wystapił błąd: " + ex.Message);
                    return;
                }

            }


        }
    }
}
