using Assembly_BrowserLib;
using Browser.Model;
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
            _Types = _AsmData.GetAsmData(_Path);
        }
        private List<NamespaceInfo> _Types;
        private OpenFile _OpenCommand;
        private DataModel _AsmData = new DataModel();
        private string _Path;
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
                openFileDialog.Filter = ".Net assembly files (*.exe, *.dll) |*.exe;*.dll";
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
                Types = _AsmData.GetAsmData(_Path);
                OnPropertyChanged();
            }
        }

    }
}
