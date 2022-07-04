using System;
using System.Collections.Generic;
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
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Collections.Generic;
using System.Linq;


namespace _2
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow() {
			InitializeComponent();

		}

		private void Button_Click(object sender, RoutedEventArgs e) {
			using (Table_context db = new Table_context()) {
				AddUsers(db);
				List<MyTable> users = db.MyTables.ToList();
				data.ItemsSource = users;
			}
		}

		public void AddUsers(Table_context db) {
			MyTable user = new MyTable() { Name = "Ivan", PhoneNumber = "809900000" };
			MyTable user1 = new MyTable() { Name = "Petro", PhoneNumber = "806600000" };
			db.Add(user);
			db.Add(user1);
			db.SaveChanges();

		}
	}
}
