using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendofMana
{
	internal class Armor : INotifyPropertyChanged
	{
		private readonly uint mAddress;
		public event PropertyChangedEventHandler? PropertyChanged;
		public Equipment Equipment { get; private set; }

		public Armor(uint address)
		{
			mAddress = address;
			Equipment = new Equipment(address);
		}

		public uint Hit
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 68, 2); }
			set
			{
				SaveData.Instance().WriteNumber(mAddress + 68, 2, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Hit)));
			}
		}

		public uint Cut
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 70, 2); }
			set
			{
				SaveData.Instance().WriteNumber(mAddress + 70, 2, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Cut)));
			}
		}

		public uint Thrust
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 72, 2); }
			set
			{
				SaveData.Instance().WriteNumber(mAddress + 72, 2, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Thrust)));
			}
		}

		public uint Magic
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 74, 2); }
			set
			{
				SaveData.Instance().WriteNumber(mAddress + 74, 2, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Magic)));
			}
		}

		public bool StatusResistance1
		{
			get { return SaveData.Instance().ReadBit(mAddress + 76, 0); }
			set
			{
				SaveData.Instance().WriteBit(mAddress + 76, 0, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(StatusResistance1)));
			}
		}

		public bool StatusResistance2
		{
			get { return SaveData.Instance().ReadBit(mAddress + 76, 1); }
			set
			{
				SaveData.Instance().WriteBit(mAddress + 76, 1, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(StatusResistance2)));
			}
		}

		public bool StatusResistance3
		{
			get { return SaveData.Instance().ReadBit(mAddress + 76, 2); }
			set
			{
				SaveData.Instance().WriteBit(mAddress + 76, 2, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(StatusResistance3)));
			}
		}

		public bool StatusResistance4
		{
			get { return SaveData.Instance().ReadBit(mAddress + 76, 3); }
			set
			{
				SaveData.Instance().WriteBit(mAddress + 76, 3, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(StatusResistance4)));
			}
		}

		public bool StatusResistance5
		{
			get { return SaveData.Instance().ReadBit(mAddress + 76, 4); }
			set
			{
				SaveData.Instance().WriteBit(mAddress + 76, 4, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(StatusResistance5)));
			}
		}

		public bool StatusResistance6
		{
			get { return SaveData.Instance().ReadBit(mAddress + 76, 5); }
			set
			{
				SaveData.Instance().WriteBit(mAddress + 76, 5, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(StatusResistance6)));
			}
		}

		public bool StatusResistance7
		{
			get { return SaveData.Instance().ReadBit(mAddress + 76, 6); }
			set
			{
				SaveData.Instance().WriteBit(mAddress + 76, 6, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(StatusResistance7)));
			}
		}

		public bool StatusResistance8
		{
			get { return SaveData.Instance().ReadBit(mAddress + 76, 7); }
			set
			{
				SaveData.Instance().WriteBit(mAddress + 76, 7, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(StatusResistance8)));
			}
		}

		public bool AttributeResistance1
		{
			get { return SaveData.Instance().ReadBit(mAddress + 77, 0); }
			set
			{
				SaveData.Instance().WriteBit(mAddress + 77, 0, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AttributeResistance1)));
			}
		}

		public bool AttributeResistance2
		{
			get { return SaveData.Instance().ReadBit(mAddress + 77, 1); }
			set
			{
				SaveData.Instance().WriteBit(mAddress + 77, 1, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AttributeResistance2)));
			}
		}

		public bool AttributeResistance3
		{
			get { return SaveData.Instance().ReadBit(mAddress + 77, 2); }
			set
			{
				SaveData.Instance().WriteBit(mAddress + 77, 2, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AttributeResistance3)));
			}
		}

		public bool AttributeResistance4
		{
			get { return SaveData.Instance().ReadBit(mAddress + 77, 3); }
			set
			{
				SaveData.Instance().WriteBit(mAddress + 77, 3, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AttributeResistance4)));
			}
		}

		public bool AttributeResistance5
		{
			get { return SaveData.Instance().ReadBit(mAddress + 77, 4); }
			set
			{
				SaveData.Instance().WriteBit(mAddress + 77, 4, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AttributeResistance5)));
			}
		}

		public bool AttributeResistance6
		{
			get { return SaveData.Instance().ReadBit(mAddress + 77, 5); }
			set
			{
				SaveData.Instance().WriteBit(mAddress + 77, 5, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AttributeResistance6)));
			}
		}

		public bool AttributeResistance7
		{
			get { return SaveData.Instance().ReadBit(mAddress + 77, 6); }
			set
			{
				SaveData.Instance().WriteBit(mAddress + 77, 6, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AttributeResistance7)));
			}
		}

		public bool AttributeResistance8
		{
			get { return SaveData.Instance().ReadBit(mAddress + 77, 7); }
			set
			{
				SaveData.Instance().WriteBit(mAddress + 77, 7, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AttributeResistance8)));
			}
		}
	}
}
