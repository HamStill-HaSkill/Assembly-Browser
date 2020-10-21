using System;
using System.Collections.Generic;
using System.Text;

namespace Assembly_BrowserLib
{
    public class TypeInfo
    {
        public string Name {get; set;}
        // Это и метод, и поле, и свойсто, и конструктор, и элементаль, и мурлок, и тотем. 
        public List<string> MethodsFieldsPropertiesConstucters { get; } = new List<string>(); 
    }
}
