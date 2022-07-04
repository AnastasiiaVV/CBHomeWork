using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_12_2
{
	class Presenter
	{
		private MainWindow _mainWindow;
		private Model _model;
		private string _operator;


		public Presenter(MainWindow mainWindow) {
			_mainWindow = mainWindow;
			_model = new Model();
			_mainWindow.NumberKeyDown += _mainWindow_NumberKeyDown;
			_mainWindow.OperationKeyDown += _mainWindow_OperationKeyDown;
			_mainWindow.EnterKeyDown += _mainWindow_EnterKeyDown;
			_mainWindow.ClearKeyDown += _mainWindow_ClearKeyDown;
		}

		private void _mainWindow_ClearKeyDown() {
			_mainWindow.textBlock.Text = "";
		}

		private void _mainWindow_EnterKeyDown() {
			_mainWindow.textBlock.Text = _model.Result(_mainWindow.textBlock.Tag, _mainWindow.textBlock.Text, _operator);
		}

		private void _mainWindow_OperationKeyDown(string symbol) {
			_mainWindow.textBlock.Tag = _mainWindow.textBlock.Text;
			_mainWindow.textBlock.Text = "";
			_operator = symbol;
		}

		private void _mainWindow_NumberKeyDown(string symbol) {
			AddBlockText(symbol);

		}

		public void AddBlockText(string symbol) {
			_mainWindow.textBlock.Text = _mainWindow.textBlock.Text + symbol;
		}
	}
}
