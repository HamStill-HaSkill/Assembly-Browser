using Assembly_BrowserLib;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Browser.ViewModel
{
    class DataViewModel : ViewModelBase
    {
        public DataViewModel()
        {
            //string path = @"C:\Users\Xiaomi\source\repos\Faker\Faker\bin\Debug\netcoreapp3.1\Faker.dll";
            _Types = new AssemblyBrowser().GetAssemblyInfo(_Path);
        }
        private List<NamespaceInfo> _Types;
        private OpenFile _OpenCommand;
        private String _Path;
        public List<NamespaceInfo> Types
        {
            get { return _Types; }
            set
            {
                _Types = value;
                OnPropertyChanged();
            }
        }
        public OpenFile OpenCommand
        {
            
            get 
            {
                var openFileDialog = new OpenFileDialog();
                return _OpenCommand ??
                  (_OpenCommand = new OpenFile(obj =>
                  {
                      openFileDialog.ShowDialog();
                      Path = openFileDialog.FileName;

                  }));
            }
        }
        public string Path
        {
            get { return _Path; }
            set
            {
                _Path = value;
                Types = new AssemblyBrowser().GetAssemblyInfo(_Path);
                OnPropertyChanged();
            }
        }

    }
}
