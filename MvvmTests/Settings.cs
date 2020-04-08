using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmTests.Models;

namespace MvvmTests
{
    public static class Settings
    {
        public static SettingsModel Load()
        {
            Trace.WriteLine("Settings Load");
            Properties.Settings settings = Properties.Settings.Default;
            return new SettingsModel()
            {
                X = settings.X,
                Y = settings.Y,
                Z = settings.Z
            };
        }
        public static void Save(SettingsModel model)     
        {
            Trace.WriteLine("Settings Save");
            Properties.Settings settings = Properties.Settings.Default;

            settings.X = model.X;
            settings.Y = model.Y;
            settings.Z = model.Z;
            settings.Number = model.Number;
            settings.Save();
        }
    }
}



