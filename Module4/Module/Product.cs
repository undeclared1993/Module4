using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4.Module
{
    public class Procuct
    {
        #region ctor
        public Procuct():this("")    { }
        public Procuct(String Pin):this(Pin,"")    { }
        public Procuct(String Pin, String Brend) : this(Pin, Brend, "")    { }
        public Procuct(String pin, String Brend, String Name)
        {
            this.Pin = Pin;
            this.Brend = Brend;
            this.Name = Name;
        }
        #endregion

        #region Properties
        public String Pin { get; set; }
        public String Brend { get; set; }
        public String Name { get; set; }
        public Boolean Analog { get; set; }
        public String ArtID { get; set; }

        private Double _Price;
        public Double Price
        {
            get { return _Price; }
            set
            {
                if (value > 0)
                    _Price = value;
                 else
                    _Price = 0;
             }
        }
        #endregion

        public static void ShowProduct(IList<Procuct> Procucts)
        {
            foreach (var item in Procucts)
            {
                string Info = string.Format("PIN: {0} NAME: {1} BREND:{2} PIN{3} ", item.Name, item.Brend + Convert.ToInt32(item.Pin));
                Console.WriteLine(Info);      
            }
        }
    }
}
