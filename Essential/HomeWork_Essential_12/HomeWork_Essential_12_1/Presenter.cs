using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_12_1
{
	class Presenter
	{
        private Model _model = null;
        private Form1 _form = null;

        public Presenter(Form1 mainWindow) {
            _model = new Model();
            _form = mainWindow;
            _form.Tick += ChangeProgressBar_Tick;
        }

        void ChangeProgressBar_Tick(object sender, EventArgs e) {
            _form.ChangeProgressBar(_model);
        }

    }
}
