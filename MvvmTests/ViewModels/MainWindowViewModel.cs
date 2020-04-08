using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmTests.Models;

namespace MvvmTests.ViewModels
{
    public class MainWindowViewModel : ObservedObject
    {
		readonly SettingsModel model = Settings.Load();
		public string X
		{
			get { return model.X; }
			set 
			{ 
				model.X = value; OnPropertyChanged("X"); 
			}
		}
		public string Y
		{
			get { return model.Y; }
			set 
			{ 
				model.Y = value; OnPropertyChanged("Y"); 
			}
		}
		public string Z
		{
			get { return model.Z; }
			set 
			{
				model.Z = value; OnPropertyChanged("Z"); 
			}
		}
		public int Number
		{
			get { return model.Number; }
			set
			{
				model.Number = value; OnPropertyChanged("Number");
			}
		}
		public void Save() 
		{	
			Settings.Save(model);
		}
	}
}

