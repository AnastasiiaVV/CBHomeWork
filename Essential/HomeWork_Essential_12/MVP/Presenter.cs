using System;

// Presenter

namespace MVP
{
    class Presenter
    {
        private Model _model = null;
        private MainWindow _mainWindow = null;

        public Presenter(MainWindow mainWindow)
        {
            _model = new Model();
            _mainWindow = mainWindow;
            _mainWindow.MyEvent += MainWindow_MyEvent;
        }

        void MainWindow_MyEvent(object sender, EventArgs e) {
            _mainWindow.textBox1.Text = _model.Logic(_mainWindow.textBox1.Text);
        }

    }
}
