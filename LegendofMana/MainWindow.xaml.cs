using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LegendofMana
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void MenuItemFileOpen_Click(object sender, RoutedEventArgs e)
		{
			FileOpen(false);
		}

		private void MenuItemFileForceOpen_Click(object sender, RoutedEventArgs e)
		{
			FileOpen(true);
		}

		private void MenuItemFileSave_Click(object sender, RoutedEventArgs e)
		{
			SaveData.Instance().Save();
		}

		private void FileOpen(bool force)
		{
			var dlg = new OpenFileDialog();
			dlg.Filter = "bin|*.bin";
			if (dlg.ShowDialog() == false) return;
			if (SaveData.Instance().Open(dlg.FileName, force) == false)
			{
				MessageBox.Show("CheckSum Error", "File Open", MessageBoxButton.OK, MessageBoxImage.Error);
				return;
			}
			DataContext = new ViewModel();
		}
	}
}
