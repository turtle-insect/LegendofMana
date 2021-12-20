using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendofMana
{
	internal class ViewModel
	{
		public ObservableCollection<Charactor> Charactors { get; private set; } = new ObservableCollection<Charactor>();

		public ViewModel()
		{
			for (uint index = 0; index < 2; index++)
			{
				Charactors.Add(new Charactor(0x790 + index * 880));
			}
		}

		public uint Money
		{
			get { return SaveData.Instance().ReadNumber(0x1CC, 4); }
			set { Util.WriteNumber(0x1CC, 4, value, 0, 99999999); }
		}
	}
}
