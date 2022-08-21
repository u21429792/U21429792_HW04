using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace U21429792_HW04.ViewModels
{
    public class VolunteerViewModel : Help
    {
        private string _VolunteerDays;

        public VolunteerViewModel(string name, string surname, string area, string days) : base(name, surname, area)
        {
            _VolunteerDays = days;
        }

        public string Days
        {
            get { return _VolunteerDays; }
            set { _VolunteerDays = value; }
        }
    }
}