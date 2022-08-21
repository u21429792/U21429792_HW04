using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace U21429792_HW04.ViewModels
{
    public class DonatorViewModel : Help
    {
        private string _DonateAmount;

        public DonatorViewModel(string name, string surname, string area, string amount) : base(name, surname, area)
        {
            _DonateAmount = amount;
        }

        public string Amount
        {
            get { return _DonateAmount; }
            set { _DonateAmount = value; }
        }
    }
}