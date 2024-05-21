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
using Microsoft.Win32;


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

        private void EnableButtons()
        {
            tsb_remoteSCCM.Enabled = true;
            tsb_rdp.Enabled = true;
            btn_computerManagement.Enabled = true;
            btn_remoteCmd.Enabled = true;
            btn_shutdownPC.Enabled = true;
            btn_restartPC.Enabled = true;
        }

        private void DisableButtons()
        {
            tsb_remoteSCCM.Enabled = false;
            tsb_rdp.Enabled = false;
            btn_computerManagement.Enabled = false;
            btn_remoteCmd.Enabled = false;
            btn_shutdownPC.Enabled = false;
            btn_restartPC.Enabled = false;
        }

        //-------------------Funkcje button click----------------------------------------------------------
        private async void btn_GetComputerDetails_Click(object sender, EventArgs e)
        {
            string computerName = tbx_pcName.Text.ToUpper();
            string recoveryPhrase = null;

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

                    string userName = UserDetails.LookForUser(computerName);


                    Hades2common.UserInfo ADUserData = new Hades2common.UserInfo();
                    ADUserData = UserDetails.GetADUserInfo(userName);
                    ADUserData.Status = UserDetails.getUserComputerStatus(computerName);

                    


                    tbx_phoneDetails.Text = ADUserData.LoginAD.ToString();
                    tbx_cellPhoneDetails.Text = ADUserData.OfficePhone.ToString();
                    tbx_emailDetails.Text = ADUserData.Email.ToString();
                    tbx_departmentDetails.Text = ADUserData.Department.ToString();
                    tbx_ksiCodeDetails.Text = ADUserData.KSIcode.ToString();
                    tbx_unitDetails.Text = ADUserData.State.ToString();

                    tbx_snDetail.Text = computerDetails.SerialNumber.ToString();
                    tbx_macDetails.Text = computerDetails.MACAddress.ToString();
                    tbx_ipDetails.Text = computerDetails.IPAddress.ToString();

                    tbx_manufacturerDetails.Text = computerDetails.Manufacturer.ToString();
                    tbx_modelDetails.Text = computerDetails.Model.ToString();
                    tbx_versionDetails.Text = computerDetails.Version.ToString();
                    tbx_buildDetails.Text = computerDetails.OSBuild.ToString();
                    tbx_architectureDetails.Text = computerDetails.OSArchitecture.ToString();

                    tsb_remoteSCCM.Enabled = true;
                    tsb_rdp.Enabled = true;
                    btn_computerManagement.Enabled = true;
                    btn_remoteCmd.Enabled = true;
                    btn_shutdownPC.Enabled = true;
                    btn_restartPC.Enabled = true;

                    recoveryPhrase = Hades2common.ToolBox.GetBitlockerRecoveryInfo(computerName);

                    tbx_bitlockerDetails.Text = recoveryPhrase;

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
            DisableButtons();
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
                btn_pinglong.Enabled = true;
            }
            else
            {
                btn_GetComputerData.Enabled = false;
                btn_pinglong.Enabled = false;
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

        private void tsb_c__Click(object sender, EventArgs e)
        {
         
            string computerName = tbx_pcName.Text.ToUpper();
            if (string.IsNullOrEmpty(computerName) | computerName == "PODAJ NAZWĘ LUB IP KOMPUTERA")
            {
                MessageBox.Show("Podaj nazwę komputera, lub jego adres IP.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Hades2common.ToolBox.OpenUNCAsync(computerName, "C$");
            
        }

        private void tsb_autostart_Click(object sender, EventArgs e)
        {

            string computerName = tbx_pcName.Text.ToUpper();
            if (string.IsNullOrEmpty(computerName) | computerName == "PODAJ NAZWĘ LUB IP KOMPUTERA")
            {
                MessageBox.Show("Podaj nazwę komputera, lub jego adres IP.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Hades2common.ToolBox.OpenUNCAsync(computerName, @"C$\ProgramData\Microsoft\Windows\Start Menu\Programs\Startup");

        }

        private void tsb_listManagement_Click(object sender, EventArgs e)
        {
            try
            {
                ComputersListsForm computerList = new ComputersListsForm();
                computerList.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Podczas odczytu usług wystapił błąd: " + ex.Message);
                return;
            }
        }

        private async void tsb_services_Click(object sender, EventArgs e)
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
                ServicesForm services = new ServicesForm(computerName);
                services.Text = $"Manager usług - komputer {computerName}";
                services.ShowDialog();
            }
            else
            {
                MessageBox.Show($"Komputer {computerName} jest niedostępny!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tsb_profileRefresh_Click(object sender, EventArgs e)
        {
            // Ścieżka do skryptu PowerShell
            string scriptPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "scripts", "profil.ps1");
            string computerName = tbx_pcName.Text.ToUpper();

            // Sprawdzenie, czy skrypt istnieje
            if (System.IO.File.Exists(scriptPath))
            {
                try
                {
                    // Uruchomienie skryptu PowerShell
                    ProcessStartInfo startInfo = new ProcessStartInfo()
                    {
                        FileName = "powershell.exe",
                        Arguments = $"-NoProfile -ExecutionPolicy Bypass -File \"{scriptPath}\" {computerName}",
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        UseShellExecute = false,
                        CreateNoWindow = false
                    };

                    using (Process process = new Process())
                    {
                        process.StartInfo = startInfo;
                        process.Start();
                        process.WaitForExit();

                        // Odczytanie wyników
                        string output = process.StandardOutput.ReadToEnd();
                        string error = process.StandardError.ReadToEnd();

                        // Wyświetlenie wyników w MessageBox
                        if (string.IsNullOrEmpty(error))
                        {
                            MessageBox.Show("Script executed successfully:\n" + output);
                        }
                        else
                        {
                            MessageBox.Show("Script error:\n" + error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Script not found: " + scriptPath);
            }
        }

        private void tsb_wol_Click(object sender, EventArgs e)
        {
            // Ścieżka do skryptu PowerShell
            string scriptPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "scripts", "WOL.ps1");
            string sccmServer = "SCM11-ADMCE.ZUS.AD";
            string sccmCollection = "Chrzanow - Windows Workstation";
            string computerName = tbx_pcName.Text.ToUpper();

            // Sprawdzenie, czy skrypt istnieje
            if (System.IO.File.Exists(scriptPath))
            {
                try
                {
                    // Uruchomienie skryptu PowerShell
                    ProcessStartInfo startInfo = new ProcessStartInfo()
                    {
                        FileName = "powershell.exe",
                        Arguments = $"-NoProfile -ExecutionPolicy Bypass -File \"{scriptPath}\" {sccmServer} {sccmCollection} {computerName}",
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        UseShellExecute = false,
                        CreateNoWindow = false
                    };

                    using (Process process = new Process())
                    {
                        process.StartInfo = startInfo;
                        process.Start();
                        process.WaitForExit();

                        // Odczytanie wyników
                        string output = process.StandardOutput.ReadToEnd();
                        string error = process.StandardError.ReadToEnd();

                        // Wyświetlenie wyników w MessageBox
                        if (string.IsNullOrEmpty(error))
                        {
                            MessageBox.Show("Script executed successfully:\n" + output);
                        }
                        else
                        {
                            MessageBox.Show("Script error:\n" + error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Script not found: " + scriptPath);
            }
        }

        private void tsb_installer_Click(object sender, EventArgs e)
        {
            // Ścieżka do skryptu PowerShell
            string scriptPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "scripts", "installKSIAPP.ps1");
            string sfsServer = "SFS01-OSCI1";
            string computerName = tbx_pcName.Text.ToUpper();

            // Sprawdzenie, czy skrypt istnieje
            if (System.IO.File.Exists(scriptPath))
            {
                try
                {
                    // Uruchomienie skryptu PowerShell
                    ProcessStartInfo startInfo = new ProcessStartInfo()
                    {
                        FileName = "powershell.exe",
                        Arguments = $"-NoProfile -ExecutionPolicy Bypass -File \"{scriptPath}\" {computerName} {sfsServer}",
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        UseShellExecute = false,
                        CreateNoWindow = false
                    };

                    using (Process process = new Process())
                    {
                        process.StartInfo = startInfo;
                        process.Start();
                        process.WaitForExit();

                        // Odczytanie wyników
                        string output = process.StandardOutput.ReadToEnd();
                        string error = process.StandardError.ReadToEnd();

                        // Wyświetlenie wyników w MessageBox
                        if (string.IsNullOrEmpty(error))
                        {
                            MessageBox.Show("Script executed successfully:\n" + output);
                        }
                        else
                        {
                            MessageBox.Show("Script error:\n" + error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Script not found: " + scriptPath);
            }
        }

        private void tsb_officeAudit_Click(object sender, EventArgs e)
        {
            // Ścieżka do skryptu PowerShell
            string scriptPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "scripts", "OfficeAudit.ps1");
            string sfsServer = "SFS01-OSCI1";
            string computerName = tbx_pcName.Text.ToUpper();

            // Sprawdzenie, czy skrypt istnieje
            if (System.IO.File.Exists(scriptPath))
            {
                try
                {
                    // Uruchomienie skryptu PowerShell
                    ProcessStartInfo startInfo = new ProcessStartInfo()
                    {
                        FileName = "powershell.exe",
                        Arguments = $"-NoProfile -ExecutionPolicy Bypass -File \"{scriptPath}\" {computerName}",
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        UseShellExecute = false,
                        CreateNoWindow = false
                    };

                    using (Process process = new Process())
                    {
                        process.StartInfo = startInfo;
                        process.Start();
                        process.WaitForExit();

                        // Odczytanie wyników
                        string output = process.StandardOutput.ReadToEnd();
                        string error = process.StandardError.ReadToEnd();

                        // Wyświetlenie wyników w MessageBox
                        if (string.IsNullOrEmpty(error))
                        {
                            MessageBox.Show("Script executed successfully:\n" + output);
                        }
                        else
                        {
                            MessageBox.Show("Script error:\n" + error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Script not found: " + scriptPath);
            }
        }

        private void tsb_usersPrinter_Click(object sender, EventArgs e)
        {
            string computerName = tbx_pcName.Text.ToUpper();
            if (string.IsNullOrEmpty(computerName) | computerName == "PODAJ NAZWĘ LUB IP KOMPUTERA")
            {
                MessageBox.Show("Podaj nazwę komputera, lub jego adres IP.", "Informacja o błędzie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string outputPath = @".\userPrinters.txt";

            // get the logged-in user of the specified computer
            var computerSystem = new System.Management.ManagementObject($"Win32_ComputerSystem.Name='{computerName}'");
            string userName = Hades2common.UserDetails.LookForUser(computerName);

            string userProfilePrinters = $"Komputer: {computerName}\r\nZalogowany użytkownik: {userName}\r\n\r\nDrukarki sieciowe zainstalowane na profilu użytkownika:";

            // get that user's AD object
            var adObj = new System.Security.Principal.NTAccount(userName);

            // get the SID for the user's AD Object 
            var strSID = adObj.Translate(typeof(System.Security.Principal.SecurityIdentifier)).ToString();

            var rootKey = $@"{strSID}\Printers\Connections";

            try
            {
                using (var registry = RegistryKey.OpenRemoteBaseKey(RegistryHive.Users, computerName))
                {
                    foreach (var subKeyName in registry.OpenSubKey(rootKey).GetSubKeyNames())
                    {
                        // This is really the list of printers
                        userProfilePrinters += $"\r\n{subKeyName}";
                    }

                    userProfilePrinters = userProfilePrinters.Replace(',', '\\');

                    // get a handle to the "USERS" hive on the computer
                    using (var reg = RegistryKey.OpenRemoteBaseKey(RegistryHive.Users, computerName))
                    {
                        using (var regKey = reg.OpenSubKey($@"{strSID}\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Windows"))
                        {
                            // read the new value from the Registry for verification
                            var regValue = regKey.GetValue("Device").ToString();

                            // remove value from comma to the end of the string
                            regValue = regValue.TrimEnd().Split(',')[0];

                            userProfilePrinters += $"\r\n\r\nDrukarka domyślna:\r\n{regValue}";

                            File.WriteAllText(outputPath, userProfilePrinters);

                            try
                            {
                                // Uruchamia przeglądarkę z określonym adresem URL
                                Process.Start(new ProcessStartInfo
                                {
                                    FileName = outputPath,
                                    UseShellExecute = true
                                });
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Wystąpił błąd podczas otwierania przeglądarki: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }



                        }
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine($"Registry - access denied {rootKey}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btn_itTeren_Click(object sender, EventArgs e)
        {
            Hades2common.URL.OpenUrl("http://it.zus.ad/teren");
        }
    }
}
