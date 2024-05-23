using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Hades2Lite
{
    public partial class frm_AppAudit : Form

    {

        public string ComputerName { get; set; }

        public frm_AppAudit()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            string computerName = ComputerName.Trim();
            string filePath = @"C:\CSI\verify.txt"; 

            dgv_mismatch.Rows.Clear();

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split(';');
                    if (parts.Length == 3)
                    {
                        string filePathOnComputer = parts[0];
                        string expectedVersion = parts[1];
                        string appName = parts[2];

                        string actualVersion = GetFileVersion(filePathOnComputer, computerName);
                        if (actualVersion != "Plik nie istnieje" && !actualVersion.StartsWith("Błąd"))
                        {
                            bool isVersionMatch = expectedVersion == actualVersion;
                            if (!isVersionMatch) // Dodaj wiersz tylko jeśli wersje są niezgodne
                            {
                                string fileName = Path.GetFileName(filePathOnComputer); // Pobranie nazwy pliku
                                dgv_mismatch.Rows.Add(appName, fileName, actualVersion, expectedVersion, "Tak");
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Plik nie istnieje.");
            }
        }


        public string GetFileVersion(string filePath, string computerName)
        {
            try
            {
                string fullPath = Path.Combine(@"\\", computerName, filePath.TrimStart('\\'));
                if (File.Exists(fullPath))
                {
                    FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(fullPath);
                    return versionInfo.ProductVersion.Replace(".", string.Empty);
                }
                else
                {
                    return "Plik nie istnieje";
                }
            }
            catch (Exception ex)
            {
                return $"Błąd: {ex.Message}";
            }
        }
    }
}
