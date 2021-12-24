using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendofMana
{
	internal class Item
	{
		public Weapon Weapon { get; private set; }
		public Armor Armor { get; private set; }

		public Item(uint address)
		{
			Weapon = new Weapon(address);
			Armor = new Armor(address);
		}
	}
}
