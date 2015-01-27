﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace EDRoutePlanner
{
	public partial class DefaultsForm : Form
	{
		MainScreen mainScreen;

		public DefaultsForm(MainScreen mainScreen)
		{
			this.mainScreen = mainScreen;
			InitializeComponent();
			UpdateDisplay();
		}

		public void UpdateDisplay()
		{
			tbCommodityData.Text = mainScreen.defaults.pathCommodityData;
			tbStationData.Text = mainScreen.defaults.pathStationData;
			cbTypeStation.SelectedIndex = (int)mainScreen.defaults.typeStationData;
			if(!Enum.IsDefined(typeof(DataSourceType), mainScreen.defaults.typeStationData)) {
				cbTypeStation.SelectedIndex = 0;
			}
		}

		private void btnBrowseCommodity_Click(object sender, EventArgs e)
		{
			tbCommodityData.Text = openFile(tbCommodityData.Text);
		}

		private void buttonBrowseStation_Click(object sender, EventArgs e)
		{
			tbStationData.Text = openFile(tbStationData.Text);
		}

		private void btnReload_Click(object sender, EventArgs e)
		{
			mainScreen.loadDefaults();
			UpdateDisplay();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			mainScreen.defaults.pathCommodityData = tbCommodityData.Text;
			mainScreen.defaults.pathStationData = tbStationData.Text;
			mainScreen.defaults.typeStationData = (DataSourceType)cbTypeStation.SelectedIndex;
			if (!Enum.IsDefined(typeof(DataSourceType), mainScreen.defaults.typeStationData))
			{
				mainScreen.defaults.typeStationData = DataSourceType.RegulatedNoise;
			}
			mainScreen.saveDefaults();
			mainScreen.forceReloadData();
			mainScreen.updateDisplay();
			this.DialogResult = DialogResult.OK;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}

		private string openFile(string previous)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			try
			{
				ofd.FileName = previous;
				ofd.InitialDirectory = new FileInfo(previous).Directory.FullName;
			}
			catch (ArgumentException) { }
			catch (PathTooLongException) { }
			catch (NotSupportedException) { }
			if (ofd.ShowDialog(this) == DialogResult.OK)
			{
				return ofd.FileName;
			}
			else
			{
				return previous;
			}
		}
	}
}
