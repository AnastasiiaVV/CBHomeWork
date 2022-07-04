using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_4_2
{
	class PlayerFactory
	{
		public static IPlayable GetPlayable() {
			return new Player();
		}

		public static IRecodable GetRecodable() {
			return new Player();
		}

	}
}
