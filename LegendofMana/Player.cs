using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendofMana
{
	internal class Player : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler? PropertyChanged;

		public String Name
		{
			get { return SaveData.Instance().ReadText(0x790, 30); }
			set
			{
				SaveData.Instance().WriteText(0x790, 30, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
			}
		}
	}
}
