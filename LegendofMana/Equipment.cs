using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendofMana
{
	internal class Equipment : INotifyPropertyChanged
	{
		protected readonly uint mAddress;
		public event PropertyChangedEventHandler? PropertyChanged;

		public Equipment(uint address)
		{
			mAddress = address;
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

		public uint Type
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 53, 1); }
			set
			{
				SaveData.Instance().WriteNumber(mAddress + 53, 1, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Type)));
			}
		}

		public uint Material
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 54, 1); }
			set
			{
				SaveData.Instance().WriteNumber(mAddress + 54, 1, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Material)));
			}
		}

		public Byte AttributeLevel1
		{
			get { return SaveData.Instance().ReadByte(mAddress + 56, true); }
			set
			{
				SaveData.Instance().WriteByte(mAddress + 56, true, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AttributeLevel1)));
			}
		}

		public Byte AttributeLevel2
		{
			get { return SaveData.Instance().ReadByte(mAddress + 56, false); }
			set
			{
				SaveData.Instance().WriteByte(mAddress + 56, false, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AttributeLevel2)));
			}
		}

		public Byte AttributeLevel3
		{
			get { return SaveData.Instance().ReadByte(mAddress + 57, true); }
			set
			{
				SaveData.Instance().WriteByte(mAddress + 57, true, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AttributeLevel3)));
			}
		}

		public Byte AttributeLevel4
		{
			get { return SaveData.Instance().ReadByte(mAddress + 57, false); }
			set
			{
				SaveData.Instance().WriteByte(mAddress + 57, false, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AttributeLevel4)));
			}
		}

		public Byte AttributeLevel5
		{
			get { return SaveData.Instance().ReadByte(mAddress + 58, true); }
			set
			{
				SaveData.Instance().WriteByte(mAddress + 58, true, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AttributeLevel5)));
			}
		}

		public Byte AttributeLevel6
		{
			get { return SaveData.Instance().ReadByte(mAddress + 58, false); }
			set
			{
				SaveData.Instance().WriteByte(mAddress + 58, false, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AttributeLevel6)));
			}
		}

		public Byte AttributeLevel7
		{
			get { return SaveData.Instance().ReadByte(mAddress + 59, true); }
			set
			{
				SaveData.Instance().WriteByte(mAddress + 59, true, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AttributeLevel7)));
			}
		}

		public Byte AttributeLevel8
		{
			get { return SaveData.Instance().ReadByte(mAddress + 59, false); }
			set
			{
				SaveData.Instance().WriteByte(mAddress + 59, false, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AttributeLevel8)));
			}
		}

		public Byte StatusLevel1
		{
			get { return SaveData.Instance().ReadByte(mAddress + 60, true); }
			set
			{
				SaveData.Instance().WriteByte(mAddress + 60, true, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(StatusLevel1)));
			}
		}

		public Byte StatusLevel2
		{
			get { return SaveData.Instance().ReadByte(mAddress + 60, false); }
			set
			{
				SaveData.Instance().WriteByte(mAddress + 60, false, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(StatusLevel2)));
			}
		}

		public Byte StatusLevel3
		{
			get { return SaveData.Instance().ReadByte(mAddress + 61, true); }
			set
			{
				SaveData.Instance().WriteByte(mAddress + 61, true, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(StatusLevel3)));
			}
		}

		public Byte StatusLevel4
		{
			get { return SaveData.Instance().ReadByte(mAddress + 61, false); }
			set
			{
				SaveData.Instance().WriteByte(mAddress + 61, false, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(StatusLevel4)));
			}
		}

		public Byte StatusLevel5
		{
			get { return SaveData.Instance().ReadByte(mAddress + 62, true); }
			set
			{
				SaveData.Instance().WriteByte(mAddress + 62, true, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(StatusLevel5)));
			}
		}

		public Byte StatusLevel6
		{
			get { return SaveData.Instance().ReadByte(mAddress + 62, false); }
			set
			{
				SaveData.Instance().WriteByte(mAddress + 62, false, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(StatusLevel6)));
			}
		}

		public Byte StatusLevel7
		{
			get { return SaveData.Instance().ReadByte(mAddress + 63, true); }
			set
			{
				SaveData.Instance().WriteByte(mAddress + 63, true, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(StatusLevel7)));
			}
		}

		public Byte StatusLevel8
		{
			get { return SaveData.Instance().ReadByte(mAddress + 63, false); }
			set
			{
				SaveData.Instance().WriteByte(mAddress + 63, false, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(StatusLevel8)));
			}
		}

		public uint SecretPower1
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 64, 1); }
			set
			{
				SaveData.Instance().WriteNumber(mAddress + 64, 1, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SecretPower1)));
			}
		}

		public uint SecretPower2
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 65, 1); }
			set
			{
				SaveData.Instance().WriteNumber(mAddress + 65, 1, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SecretPower2)));
			}
		}

		public uint SecretPower3
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 66, 1); }
			set
			{
				SaveData.Instance().WriteNumber(mAddress + 66, 1, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SecretPower3)));
			}
		}
	}
}
