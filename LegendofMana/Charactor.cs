using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendofMana
{
	internal class Charactor : INotifyPropertyChanged
	{
		private readonly uint mAddress;
		public event PropertyChangedEventHandler? PropertyChanged;
		public Weapon Weapon { get; private set; }
		public ObservableCollection<Armor> Armors { get; private set; } = new ObservableCollection<Armor>();

		public Charactor(uint address)
		{
			mAddress = address;
			Weapon = new Weapon(address + 0x70);
			for (uint index = 0; index < 3; index++)
			{
				Armors.Add(new Armor(address + 0xD0 + index * 0x60));
			}
		}

		public String Name
		{
			get { return SaveData.Instance().ReadText(mAddress, 30); }
			set
			{
				SaveData.Instance().WriteText(mAddress, 30, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
			}
		}
	}
}
