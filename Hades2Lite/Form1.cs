using MaterialSkin.Controls;
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
using Hades2common;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Hades2Lite
{
    public partial class frm_Hades2Lite : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        public frm_Hades2Lite()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue700, MaterialSkin.Primary.Blue800, MaterialSkin.Primary.Amber100, MaterialSkin.Accent.Cyan700, MaterialSkin.TextShade.WHITE);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //-------------------Funkcje button click----------------------------------------------------------
        private async void btn_GetComputerDetails_Click(object sender, EventArgs e)
        {
            string computerName = tbx_pcName.Text.ToUpper();
            if (string.IsNullOrEmpty(computerName) | computerName == "PODAJ NAZWĘ LUB IP KOMPUTERA")
            {
                MessageBox.Show("Podaj nazwę komputera, lub jego adres IP.", "Informacja o błędzie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool active = await Task.Run(() => Hades2common.ToolBox.PingAndCheckDiskAsync(computerName));

            if (active)
            {
                try
                {
                    

                    tbx_snDetail.Text = "Pobieram dane...";
                    tbx_snDetail.Text = "Pobieram dane...";
                    tbx_macDetails.Text = "Pobieram dane...";
                    tbx_ipDetails.Text = "Pobieram dane...";
                    tbx_manufacturerDetails.Text = "Pobieram dane...";
                    tbx_modelDetails.Text = "Pobieram dane...";
                    tbx_versionDetails.Text = "Pobieram dane...";
                    tbx_buildDetails.Text = "Pobieram dane...";
                    tbx_architectureDetails.Text = "Pobieram dane...";

                    OperatingSystemDetails osDetails = new OperatingSystemDetails();
                    osDetails = Hades2common.ToolBox.GetOSInfo(computerName);
                    tbx_osDetailName.Text = osDetails.Name.ToString();

                    ComputerDetails computerDetails = new ComputerDetails();
                    computerDetails = Hades2common.ToolBox.GetComputerDetailsInfo(computerName);

                    tbx_snDetail.Text = computerDetails.SerialNumber.ToString();
                    tbx_macDetails.Text = computerDetails.MACAddress.ToString();
                    tbx_ipDetails.Text = computerDetails.IPAddress.ToString();

                    tbx_manufacturerDetails.Text = computerDetails.Manufacturer.ToString();
                    tbx_modelDetails.Text = computerDetails.Model.ToString();
                    tbx_versionDetails.Text = computerDetails.Version.ToString();
                    tbx_buildDetails.Text = computerDetails.OSBuild.ToString();
                    tbx_architectureDetails.Text = computerDetails.OSArchitecture.ToString();

                    tsb_remoteSCCM.Enabled = true;

                    //MessageBox.Show($"{osDetails.Name}\n{osDetails.OSArchitecture}\n{osDetails.BuildDisplay}\n{osDetails.BuildNumber}.{osDetails.UBRNumber}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Podczas pobierania danych wystapił błąd: " + ex.Message);
                    return;
                }

            }
            else
            {
                MessageBox.Show($"Komputer {computerName} jest niedostępny!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }


           
        }

        private void btn_pinglong_Click(object sender, EventArgs e)
        {
            string computerName = tbx_pcName.Text.ToUpper();
            if (string.IsNullOrEmpty(computerName) | computerName == "PODAJ NAZWĘ LUB IP KOMPUTERA")
            {
                MessageBox.Show("Podaj nazwę komputera, lub jego adres IP.", "Informacja o błędzie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Process process = new Process();
            process.StartInfo.FileName = @"C:\windows\system32\cmd.exe";
            process.StartInfo.Arguments = String.Join(" ", "/c", "ping", "-t", $"{computerName}");
            process.Start();


        }

        private async void btn_computerManagement_Click(object sender, EventArgs e)
        {
            string computerName = tbx_pcName.Text.ToUpper();
            if (string.IsNullOrEmpty(computerName) | computerName == "PODAJ NAZWĘ LUB IP KOMPUTERA")
            {
                MessageBox.Show("Podaj nazwę komputera, lub jego adres IP.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool active = await Task.Run(() => Hades2common.ToolBox.PingAndCheckDiskAsync(computerName));

            if (active)
            {

                bool openedSuccessfully = await Task.Run<bool>(() =>
                {
                    Process process = new Process();
                    process.StartInfo.FileName = @"C:\Windows\System32\compmgmt.msc";
                    process.StartInfo.Arguments = String.Join(" ", $@"/computer=\\{computerName}", "", "open", 1);
                    process.Start();
                    return true;
                });

                if (!openedSuccessfully)
                {
                    MessageBox.Show("Nie udało się otworzyć Zarządzania komputerem.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show($"Komputer {computerName} jest niedostępny!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btn_remoteCmd_Click(object sender, EventArgs e)
        {
            string computerName = tbx_pcName.Text.ToUpper();
            if (string.IsNullOrEmpty(computerName) | computerName == "PODAJ NAZWĘ LUB IP KOMPUTERA")
            {
                MessageBox.Show("Podaj nazwę komputera, lub jego adres IP.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool active = await Task.Run(() => Hades2common.ToolBox.PingAndCheckDiskAsync(computerName));

            if (active)
            {

                try
                {
                    if (File.Exists(@"D:\CI-OHD\HaDes2\Utils\psexec.exe"))
                    {
                        Process process = new Process();
                        process.StartInfo.FileName = @"D:\CI-OHD\HaDes2\Utils\psexec.exe";
                        process.StartInfo.Arguments = String.Join(" ", "-accepteula", $@"\\{computerName}", "cmd.exe");
                        process.Start();
                    }
                    else
                    {
                        Console.WriteLine("Plik psexec.exe nie istnieje w podanej ścieżce.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Wystąpił błąd podczas uruchamiania psexec: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show($"Komputer {computerName} jest niedostępny!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Error);
               // Main_common.LogOperation($"REMOTE_CMD_ACCESS: Brak możliwości uruchomienia Remote CMD, komputer jest niedostępny.", computerName, connectionString);
            }
        }

        private async void tsb_remoteSCCM_Click(object sender, EventArgs e)
        {
            string computerName = tbx_pcName.Text.ToUpper();
            if (string.IsNullOrEmpty(computerName) | computerName == "PODAJ NAZWĘ LUB IP KOMPUTERA")
            {
                MessageBox.Show("Podaj nazwę komputera, lub jego adres IP.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            bool active = await Task.Run(() => Hades2common.ToolBox.PingAndCheckDiskAsync(computerName));

            if (active)
            {
                bool success = await Hades2common.ToolBox.OpenRemoteAsync(computerName);
                if (success)
                {
                    //Main_common.LogOperation($"REMOTE_SCCM_CONNECTION: Połączenie Remote SCCM do komputera.", computerName, connectionString);
                }
            }
            else
            {
                MessageBox.Show($"Komputer {computerName} jest niedostępny!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Main_common.LogOperation($"REMOTE_SCCM_CONNECTION: Brak możliwości uruchomienia Remote SCCM, komputer jest niedostępny.", computerName, connectionString);
            }
        }

        private void btn_eraseData_Click(object sender, EventArgs e)
        {
            clearPCName();
        }



        private async void btn_shutdownPC_Click(object sender, EventArgs e)
        {
            string computerName = tbx_pcName.Text.ToUpper();
            if (string.IsNullOrEmpty(computerName) | computerName == "PODAJ NAZWĘ LUB IP KOMPUTERA")
            {
                MessageBox.Show("Podaj nazwę komputera, lub jego adres IP.", "Informacja o błędzie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool active = await Task.Run(() => Hades2common.ToolBox.PingAndCheckDiskAsync(computerName));
            if (active)
            {
                DialogResult result = MessageBox.Show($"Czy jesteś pewien, że chcesz wyłączyć komputer {computerName}?", "Potwierdzenie wyłaczenia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Process process = new Process();
                    process.StartInfo.FileName = "shutdown.exe";
                    process.StartInfo.Arguments = String.Join(" ", "/s", "/m", $@"\\{computerName}", "/t", "0");
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.CreateNoWindow = true;
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process.Start();
                    process.WaitForExit();

                    MessageBox.Show($"Polecenie wyłączenia zostało wysłane do komputera {computerName}.", "Zdalne wyłączenie komputera", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("Operacja została anulowana.", "Anulowano", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show($"Komputer {computerName} jest niedostępny!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //----------------------funkcje - inne---------------------------------------

        void clearPCName()
        {
            tbx_snDetail.Text = string.Empty;
            tbx_snDetail.Text = string.Empty;
            tbx_macDetails.Text = string.Empty;
            tbx_ipDetails.Text = string.Empty;
            tbx_manufacturerDetails.Text = string.Empty;
            tbx_modelDetails.Text = string.Empty;
            tbx_versionDetails.Text = string.Empty;
            tbx_buildDetails.Text = string.Empty;
            tbx_architectureDetails.Text = string.Empty;
            tbx_pcName.Text = string.Empty;
            tbx_pcName.Focus();
            tbx_pcName.SelectAll();
        }

        private async void btn_restartPC_Click(object sender, EventArgs e)
        {
            string computerName = tbx_pcName.Text.ToUpper();
            if (string.IsNullOrEmpty(computerName) | computerName == "PODAJ NAZWĘ LUB IP KOMPUTERA")
            {
                MessageBox.Show("Podaj nazwę komputera, lub jego adres IP.", "Informacja o błędzie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool active = await Task.Run(() => Hades2common.ToolBox.PingAndCheckDiskAsync(computerName));
            if (active)
            {
                DialogResult result = MessageBox.Show($"Czy jesteś pewien, że chcesz zrestartować komputer {computerName}?", "Potwierdzenie restartu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Process process = new Process();
                    process.StartInfo.FileName = "shutdown.exe";
                    process.StartInfo.Arguments = String.Join(" ", "/r", "/m", $@"\\{computerName}", "/t", "0");
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.CreateNoWindow = true;
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process.Start();
                    process.WaitForExit();

                    MessageBox.Show($"Polecenie restartu zostało wysłane do komputera {computerName}.", "Zdalny restart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("Operacja została anulowana.", "Anulowano", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show($"Komputer {computerName} jest niedostępny!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_refreshDNS_Click(object sender, EventArgs e)
        {
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = "ipconfig.exe";
                process.StartInfo.Arguments = "/flushdns";
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.Start();
                process.WaitForExit();

                Process pr = new Process();
                pr.StartInfo.FileName = "cmd.exe";
                pr.StartInfo.Arguments = @"/c ipconfig /registerdns";
                pr.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                pr.StartInfo.Verb = "runas";  // Uruchom jako administrator
                pr.Start();
                pr.WaitForExit();

                MessageBox.Show("Odświeżanie podręcznego DNS zostało zakończone.", "Odświeżanie DNS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd: " + ex.Message);
            }
        }

        private async void tsb_rdp_Click(object sender, EventArgs e)
        {
            string computerName = tbx_pcName.Text.ToUpper();
            if (string.IsNullOrEmpty(computerName) | computerName == "PODAJ NAZWĘ LUB IP KOMPUTERA")
            {
                MessageBox.Show("Podaj nazwę komputera, lub jego adres IP.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool active = await Task.Run(() => Hades2common.ToolBox.PingAndCheckDiskAsync(computerName));

            if (active)
            {
                bool openedSuccessfully = await Task.Run<bool>(() =>
                {
                    Process process = new Process();
                    process.StartInfo.FileName = @"C:\Windows\System32\mstsc.exe";
                    process.StartInfo.Arguments = String.Join(" ", $@"/v:{computerName}");
                    process.Start();
                    return true;
                });

                if (!openedSuccessfully) MessageBox.Show($"Nie udało się uruchomić zdalnego pulpitu.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show($"Komputer {computerName} jest niedostępny!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbx_pcName_TextChanged(object sender, EventArgs e)
        {
            // Sprawdź długość tekstu w TextBox1
            if (tbx_pcName.Text.Length >= 4)
            {
                btn_GetComputerData.Enabled = true;
            }
            else
            {
                btn_GetComputerData.Enabled = false;
            }
        }

        private void tbx_pcName_Leave(object sender, EventArgs e)
        {
            if (tbx_pcName.Text == "")
            {
                tbx_pcName.Text = "Podaj Nazwę lub IP komputera";
                tbx_pcName.ForeColor = Color.Gray;
            }
        }

        private void tbx_pcName_Enter(object sender, EventArgs e)
        {
            if (tbx_pcName.Text == "Podaj Nazwę lub IP komputera")
            {
                tbx_pcName.Text = "";
                tbx_pcName.ForeColor = Color.Black;
            }
        }
    }
}
