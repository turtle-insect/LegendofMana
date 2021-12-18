using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendofMana
{
	internal class ViewModel
	{
		public Player Player { get; private set; } = new Player();

		public uint Money
		{
			get { return SaveData.Instance().ReadNumber(0x1CC, 4); }
			set { Util.WriteNumber(0x1CC, 4, value, 0, 99999999); }
		}
	}
}
