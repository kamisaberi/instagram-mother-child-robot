using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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
    /// Interaction logic for InstagramAccounts.xaml
    /// </summary>

    public partial class InstagramAccounts : UserControl
    {

        public InstagramAccounts()
        {
            InitializeComponent();
            ObservableCollection<Model.InstagramAccount> custdata = Vars.Globals.InstagramAccounts;
            grdAccounts.DataContext = custdata;

        }


        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

            string cs= @"Data Source=" + AppDomain.CurrentDomain.BaseDirectory + @"\Storage\data.db;Version=3;New=False;Compress=True";
            SQLiteConnection cn = new SQLiteConnection(cs);
            cn.Open();
            var cm = new SQLiteCommand(cn);
            cm.CommandText = string.Format( "INSERT INTO instagram_accounts(username, password) VALUES('{0}','{1}')" , txtPassword.Text , txtPassword.Text);
            cm.ExecuteNonQuery();
            var c = new Model.InstagramAccount { Username = txtUsername.Text + "", Password = txtPassword.Text+ "" };
            Vars.Globals.InstagramAccounts.Add(c);
            grdAccounts.DataContext = Vars.Globals.InstagramAccounts;

        }
    }
}
