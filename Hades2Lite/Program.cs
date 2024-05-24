using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices.AccountManagement;

namespace Hades2Lite
{
    internal static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new frm_Hades2Lite());

            if (CheckUserGroupMembership())
            {
                Application.Run(new frm_Hades2Lite());
            }
            else
            {
                MessageBox.Show("Brak uprawnień.\nNie jesteś członkiem grupy GG_HADES2_CHRO1.\nPoproś swojego bezpośredniego przełożonego o nadanie uprawnień do grupy i spróbuj ponownie.", "Sprawdzenie uprawnień", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private static bool CheckUserGroupMembership()
        {
            try
            {
                // Pobierz aktualnie zalogowanego użytkownika
                WindowsIdentity currentUser = WindowsIdentity.GetCurrent();
                string userName = currentUser.Name.Split('\\')[1];

                // Ustawienia domeny i kontenerów
                string domainName = "ZUS";
                string userContainer = "OU=Uzytkownicy,OU=CentrumInformatyki,DC=ZUS,DC=AD";
                string groupContainer = "OU=Uzytkownicy,OU=Chrzanow,DC=ZUS,DC=AD";
                string groupName = "GG_HADES2_CHRO1";

                // Połącz z kontenerem użytkowników
                using (PrincipalContext userContext = new PrincipalContext(ContextType.Domain, domainName, userContainer))
                {
                    // Znajdź użytkownika
                    UserPrincipal user = UserPrincipal.FindByIdentity(userContext, userName);

                    if (user != null)
                    {
                        // Połącz z kontenerem grupy
                        using (PrincipalContext groupContext = new PrincipalContext(ContextType.Domain, domainName, groupContainer))
                        {
                            // Znajdź grupę
                            GroupPrincipal group = GroupPrincipal.FindByIdentity(groupContext, groupName);
                            if (group != null && user.IsMemberOf(group))
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

    }
}
