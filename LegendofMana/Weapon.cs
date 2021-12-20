using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendofMana
{
	internal class Weapon : INotifyPropertyChanged
	{
		private readonly uint mAddress;
		public event PropertyChangedEventHandler? PropertyChanged;
		public Equipment Equipment { get; private set; }

		public Weapon(uint address)
		{
			mAddress = address;
			Equipment = new Equipment(address);
		}

		public uint Offense
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 68, 2); }
			set
			{
				SaveData.Instance().WriteNumber(mAddress + 68, 2, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Offense)));
			}
		}

		public uint Technique1
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 72, 1); }
			set
			{
				SaveData.Instance().WriteNumber(mAddress + 72, 1, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Technique1)));
			}
		}

		public uint Technique2
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 73, 1); }
			set
			{
				SaveData.Instance().WriteNumber(mAddress + 73, 1, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Technique2)));
			}
		}

		public uint Technique3
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 74, 1); }
			set
			{
				SaveData.Instance().WriteNumber(mAddress + 74, 1, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Technique3)));
			}
		}

		public bool EnchantmentAttribute1
		{
			get { return SaveData.Instance().ReadBit(mAddress + 76, 0); }
			set
			{
				SaveData.Instance().WriteBit(mAddress + 76, 0, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(EnchantmentAttribute1)));
			}
		}

		public bool EnchantmentAttribute2
		{
			get { return SaveData.Instance().ReadBit(mAddress + 76, 1); }
			set
			{
				SaveData.Instance().WriteBit(mAddress + 76, 1, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(EnchantmentAttribute2)));
			}
		}

		public bool EnchantmentAttribute3
		{
			get { return SaveData.Instance().ReadBit(mAddress + 76, 2); }
			set
			{
				SaveData.Instance().WriteBit(mAddress + 76, 2, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(EnchantmentAttribute3)));
			}
		}

		public bool EnchantmentAttribute4
		{
			get { return SaveData.Instance().ReadBit(mAddress + 76, 3); }
			set
			{
				SaveData.Instance().WriteBit(mAddress + 76, 3, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(EnchantmentAttribute4)));
			}
		}

		public bool EnchantmentAttribute5
		{
			get { return SaveData.Instance().ReadBit(mAddress + 76, 4); }
			set
			{
				SaveData.Instance().WriteBit(mAddress + 76, 4, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(EnchantmentAttribute5)));
			}
		}

		public bool EnchantmentAttribute6
		{
			get { return SaveData.Instance().ReadBit(mAddress + 76, 5); }
			set
			{
				SaveData.Instance().WriteBit(mAddress + 76, 5, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(EnchantmentAttribute6)));
			}
		}

		public bool EnchantmentAttribute7
		{
			get { return SaveData.Instance().ReadBit(mAddress + 76, 6); }
			set
			{
				SaveData.Instance().WriteBit(mAddress + 76, 6, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(EnchantmentAttribute7)));
			}
		}

		public bool EnchantmentAttribute8
		{
			get { return SaveData.Instance().ReadBit(mAddress + 76, 7); }
			set
			{
				SaveData.Instance().WriteBit(mAddress + 76, 7, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(EnchantmentAttribute8)));
			}
		}
	}
}
