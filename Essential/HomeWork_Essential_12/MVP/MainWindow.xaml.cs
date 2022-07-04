using System;
using System.Windows;

// View

namespace MVP
{    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        private event EventHandler _myEvent;

		public event EventHandler MyEvent {
			add { _myEvent += value; }
			remove { _myEvent -= value; }
		}

		private void button1_Click(object sender, RoutedEventArgs e)
        {
            _myEvent.Invoke(sender, e);
        }
    }
}
