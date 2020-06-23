using FirstFloor.ModernUI.Windows.Controls;
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


namespace InstaBotWpfMui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ModernWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadAccounts();
        }


        private void LoadAccounts()
        {
            string cs = @"Data Source=" + AppDomain.CurrentDomain.BaseDirectory + @"\Storage\data.db;Version=3;New=False;Compress=True";
            SQLiteConnection cn = new SQLiteConnection(cs);
            cn.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter("select * from instagram_accounts", cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            foreach (DataRow drc in dt.Rows)
            {
                var c = new Model.InstagramAccount { Username = drc["username"] + "", Password = drc["password"] + "" };
                Vars.Globals.InstagramAccounts.Add(c);
            }

        }


    }
}
