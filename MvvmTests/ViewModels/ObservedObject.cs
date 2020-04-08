using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmTests.ViewModels
{
    public class ObservedObject : INotifyPropertyChanged
    {
		public event PropertyChangedEventHandler PropertyChanged;
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
	}
}
