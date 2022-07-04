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

namespace HomeWork_Essential_12_2
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow() {
			InitializeComponent();
			new Presenter(this);
		}

		public delegate void NKeyDown(string symbol);

		private event NKeyDown _numberKeyDown;
		
		public event NKeyDown NumberKeyDown {
			add { _numberKeyDown += value; }
			remove { _numberKeyDown -= value; }

		}

		public delegate void CKeyDown();

		private event CKeyDown _clearKeyDown;

		public event CKeyDown ClearKeyDown {
			add { _clearKeyDown += value; }
			remove { _clearKeyDown -= value; }

		}



		public delegate void OKeyDown(string symbol);

		private event OKeyDown _operationKeyDown;

		public event OKeyDown OperationKeyDown {
			add { _operationKeyDown += value; }
			remove { _operationKeyDown -= value; }

		}

		public delegate void EKeyDown();

		private event EKeyDown _EnterKeyDown;

		public event EKeyDown EnterKeyDown {
			add { _EnterKeyDown += value; }
			remove { _EnterKeyDown -= value; }

		}

		private void Button_Click(object sender, RoutedEventArgs e) {
			_numberKeyDown.Invoke(((Button)sender).Content.ToString());
		}


		private void Button_Click_11(object sender, RoutedEventArgs e) {
			_operationKeyDown.Invoke(((Button)sender).Content.ToString());
		}

		private void Button_Click_12(object sender, RoutedEventArgs e) {
			_operationKeyDown.Invoke(((Button)sender).Content.ToString());
		}

		private void Button_Click_13(object sender, RoutedEventArgs e) {
			_operationKeyDown.Invoke(((Button)sender).Content.ToString());
		}

		private void Button_Click_14(object sender, RoutedEventArgs e) {
			_operationKeyDown.Invoke(((Button)sender).Content.ToString());
		}

		private void Button_Click_1(object sender, RoutedEventArgs e) {
			_EnterKeyDown.Invoke();
		}

		private void Button_Click_15(object sender, RoutedEventArgs e) {
			_clearKeyDown.Invoke();
		}
	}
}
