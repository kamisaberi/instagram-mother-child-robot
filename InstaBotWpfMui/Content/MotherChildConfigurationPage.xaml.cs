using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InstaBotWpfMui.Content
{
    /// <summary>
    /// Interaction logic for MotherChildConfigurationPage.xaml
    /// </summary>
    public partial class MotherChildConfigurationPage : UserControl
    {
        public MotherChildConfigurationPage()
        {
            InitializeComponent();

            foreach(Model.InstagramAccount ia in Vars.Globals.InstagramAccounts)
            {
                cmbSelectMotherAccount.Items.Add(ia.Username);
            }

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

            string selected = cmbSelectMotherAccount.SelectedItem + "";
            foreach(Model.InstagramAccount ia in Vars.Globals.InstagramAccounts)
            {
                if(ia.Username == selected)
                {
                    ia.Mother = 1;
                }
                else
                {
                    ia.Mother = 0;
                }
            }

            string cs = @"Data Source=" + AppDomain.CurrentDomain.BaseDirectory + @"\Storage\data.db;Version=3;New=False;Compress=True";
            SQLiteConnection cn = new SQLiteConnection(cs);
            cn.Open();
            var cm = new SQLiteCommand(cn);
            cm.CommandText = string.Format("UPDATE instagram_accounts SET mother=0 ");
            cm.ExecuteNonQuery();

            cm.CommandText = string.Format("UPDATE instagram_accounts SET mother=1 WHERE username='{0}'", selected);
            cm.ExecuteNonQuery();


        }
    }
}
