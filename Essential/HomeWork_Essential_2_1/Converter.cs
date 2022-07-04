using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_2_1
{
	class Converter
	{
		private double _usd, _eur, _rub;

		public Converter(double usd, double eur, double rub) {
			_usd = usd;
			_eur = eur;
			_rub = rub;
		}

		public double CurrencyExchange(double sum, Currency currencyIn, Currency currencyOut) {
			if (currencyIn == Currency.UAN) {
				return ConvertFromUAN(sum, currencyOut);
			} else {
				if (currencyOut == Currency.UAN) {
					return ConvertToUAN(sum, currencyIn);
				}
				throw new ArgumentException($"Не верный тип {currencyOut} конвертации в гривну", nameof(currencyOut));
			}
		}

		private double ConvertFromUAN(double sum, Currency currencyOut) {
			if (currencyOut == Currency.EUR) {
				return sum / _eur;
			} else if (currencyOut == Currency.RUB) {
				return sum / _rub;
			} else if (currencyOut == Currency.USD) {
				return sum / _usd;
			} else {
				return sum;
			}
		}

		private double ConvertToUAN(double sum, Currency currencyIn) {
			if (currencyIn == Currency.EUR) {
				return sum * _eur;
			} else if (currencyIn == Currency.RUB) {
				return sum * _rub;
			} else if (currencyIn == Currency.USD) {
				return sum * _usd;
			} else {
				return sum;
			}
		}

	}
}
