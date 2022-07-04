using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_16_1
{
	class Block
	{
		public int Field1 { get; set; }
		public int Field2 { get; set; }
		public int Field3 { get; set; }
		public int Field4 { get; set; }

		public Block(int field1, int field2, int field3, int field4) {
			Field1 = field1;
			Field2 = field2;
			Field3 = field3;
			Field4 = field4;
		}

		public override string ToString() {
			return $"1 - {Field1}, 2 - {Field2}, 3 - {Field3}, 4 - {Field4}";
		}

		public override bool Equals(object obj) {
			Block block = obj as Block;
			if (block.Field1 == this.Field1 && block.Field2 == this.Field2 && block.Field3 == this.Field3 && block.Field4 == this.Field4) {
				return true;
			} else {
				return false;
			}
		}

	}
}
