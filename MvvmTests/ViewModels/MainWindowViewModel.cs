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
    public class MainWindowViewModel : INotifyPropertyChanged
    {
		readonly SettingsModel model = Settings.Load();
		public event PropertyChangedEventHandler PropertyChanged;

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

		protected void OnPropertyChanged(params string[] propertyName) 
		{
			if (PropertyChanged != null) 
			{
				foreach (string s in propertyName)
				{
					PropertyChanged(this, new PropertyChangedEventArgs(s));
				}
			}
		}

		public void Save() 
		{
			
			Settings.Save(model);
		}

	}
}

