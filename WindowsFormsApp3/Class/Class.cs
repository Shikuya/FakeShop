using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Class
{
    public class ComboBoxItem
    {
        public String Name { get; set; }
        public String No { get; set; }


        public ComboBoxItem(String name, String no)
        {
            Name = name;
            No = no;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

public class ComboBoxItem_Band
{
    String BandName { get; set; }
    String BandNo { get; set; }

    public ComboBoxItem_Band(String bandName, String bandNo)
    {
        BandName = bandName;
        BandNo = bandNo;
    }

    public override string ToString()
    {
        return BandName;
    }
}