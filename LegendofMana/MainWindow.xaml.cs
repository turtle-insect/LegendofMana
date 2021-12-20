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

		private void Window_PreviewDragOver(object sender, DragEventArgs e)
		{
			e.Handled = e.Data.GetDataPresent(DataFormats.FileDrop);
		}

		private void Window_Drop(object sender, DragEventArgs e)
		{
			String[] files = e.Data.GetData(DataFormats.FileDrop) as String[];
			if (files == null) return;

			FileOpen(files[0], false);
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

		private void ButtonEquipmentType_Click(object sender, RoutedEventArgs e)
		{
			var equipment = (sender as Button)?.DataContext as Equipment;
			if (equipment == null) return;

			equipment.Type = EquipmentChoiceID(equipment.Type, ChoiceWindow.eType.eType);
		}

		private void ButtonEquipmentMaterial_Click(object sender, RoutedEventArgs e)
		{
			var equipment = (sender as Button)?.DataContext as Equipment;
			if (equipment == null) return;

			equipment.Material = EquipmentChoiceID(equipment.Material, ChoiceWindow.eType.eMaterial);
		}

		private void ButtonEquipmentSecretPower1_Click(object sender, RoutedEventArgs e)
		{
			var equipment = (sender as Button)?.DataContext as Equipment;
			if (equipment == null) return;

			equipment.SecretPower1 = EquipmentChoiceID(equipment.SecretPower1, ChoiceWindow.eType.eSecretPower);
		}

		private void ButtonEquipmentSecretPower2_Click(object sender, RoutedEventArgs e)
		{
			var equipment = (sender as Button)?.DataContext as Equipment;
			if (equipment == null) return;

			equipment.SecretPower2 = EquipmentChoiceID(equipment.SecretPower2, ChoiceWindow.eType.eSecretPower);
		}

		private void ButtonEquipmentSecretPower3_Click(object sender, RoutedEventArgs e)
		{
			var equipment = (sender as Button)?.DataContext as Equipment;
			if (equipment == null) return;

			equipment.SecretPower3 = EquipmentChoiceID(equipment.SecretPower3, ChoiceWindow.eType.eSecretPower);
		}

		private void ButtonWeaponTechnique1_Click(object sender, RoutedEventArgs e)
		{
			var weapon = (sender as Button)?.DataContext as Weapon;
			if (weapon == null) return;

			weapon.Technique1 = EquipmentChoiceID(weapon.Technique1, ChoiceWindow.eType.eTechnique);
		}

		private void ButtonWeaponTechnique2_Click(object sender, RoutedEventArgs e)
		{
			var weapon = (sender as Button)?.DataContext as Weapon;
			if (weapon == null) return;

			weapon.Technique2 = EquipmentChoiceID(weapon.Technique2, ChoiceWindow.eType.eTechnique);
		}

		private void ButtonWeaponTechnique3_Click(object sender, RoutedEventArgs e)
		{
			var weapon = (sender as Button)?.DataContext as Weapon;
			if (weapon == null) return;

			weapon.Technique3 = EquipmentChoiceID(weapon.Technique3, ChoiceWindow.eType.eTechnique);
		}

		private void FileOpen(bool force)
		{
			var dlg = new OpenFileDialog();
			dlg.Filter = "bin|*.bin";
			if (dlg.ShowDialog() == false) return;
			FileOpen(dlg.FileName, force);
		}

		private void FileOpen(String filename, bool force)
		{
			if (SaveData.Instance().Open(filename, force) == false)
			{
				MessageBox.Show("CheckSum Error", "File Open", MessageBoxButton.OK, MessageBoxImage.Error);
				return;
			}
			DataContext = new ViewModel();
		}

		private uint EquipmentChoiceID(uint ID, ChoiceWindow.eType type)
		{
			var dlg = new ChoiceWindow();
			dlg.ID = ID;
			dlg.Type = type;
			dlg.ShowDialog();

			return dlg.ID;
		}
	}
}
