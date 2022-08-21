using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace U21429792_HW04.ViewModels
{
    public class Help
    {
        private string _FirstName;
        private string _LastName;
        private string _HelpArea;

        public Help(string name, string surname, string area)
        {
            _FirstName = name;
            _LastName = surname;
            _HelpArea = area;
        }

        public string Name
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }
        public string Surname
        {
            get { return _LastName; }
            set { _LastName = value; }
        }
        public string Area
        {
            get { return _HelpArea; }
            set { _HelpArea = value; }
        }
    }
}