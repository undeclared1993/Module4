using Module4.Module;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4
{
    class Program
    {
        static List<String[]> getData(string Args)
        {
            List<String[]> Rows = new List<String[]>();

            foreach (string row in Args.Replace("},", "}").Split('}'))
            {
                foreach (var item in row.Split(','))
                {
                    string[] Parsing = item.Replace("{\"", "").Replace("\"", "").Split(':');
                    Rows.Add(Parsing);
                }
            }
            return Rows;
        }
        static void Main(string[] args)
        {
            #region DATA
            String DATA =
                "{\"PIN\":\"2288\",\"BRAND\":\"NGK\",\"NAME\":\"свеча зажигания!\\ BMW E30/E36/E46/E39/E34/E32, Opel Astra/Omega 1.6-4.0 82-98\",\"ARTID\":\"21943\",\"PARNR\":\"0000000000\",\"KEYZAK\":\"MOV0000075\",\"RVALUE\":\">20\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"VENSL\":\"98.0\",\"PRICE\":\"135.50\",\"WAERS\":\"RUB\",\"DLVDT\":\"20170602181500\",\"ANALOG\":\"\",\"MSG\":null,\"PriceTenge\":0,\"PriceRub\":0.0,\"ArtificialPrice\":null,\"ShowArtificialByDefault\":false,\"SupplierId\":0,\"Delivery\":null,\"DeliveryEx\":0,\"DeliveryGu\":0,\"Vkorg\":null,\"Kunnr\":null}," +
                "{\"PIN\":\"2288\",\"BRAND\":\"NGK\",\"NAME\":\"свеча зажигания!\\ BMW E30/E36/E46/E39/E34/E32, Opel Astra/Omega 1.6-4.0 82-98\",\"ARTID\":\"21943\",\"PARNR\":\"0000000000\",\"KEYZAK\":\"MOV0000086\",\"RVALUE\":\">20\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"VENSL\":\"98.0\",\"PRICE\":\"142.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20170601181500\",\"ANALOG\":\"\",\"MSG\":null,\"PriceTenge\":0,\"PriceRub\":0.0,\"ArtificialPrice\":null,\"ShowArtificialByDefault\":false,\"SupplierId\":0,\"Delivery\":null,\"DeliveryEx\":0,\"DeliveryGu\":0,\"Vkorg\":null,\"Kunnr\":null}," +
                "{\"PIN\":\"2288\",\"BRAND\":\"NGK\",\"NAME\":\"свеча зажигания!\\ BMW E30/E36/E46/E39/E34/E32, Opel Astra/Omega 1.6-4.0 82-98\",\"ARTID\":\"21943\",\"PARNR\":\"0000000000\",\"KEYZAK\":\"MOV0000073\",\"RVALUE\":\">20\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"VENSL\":\"100.0\",\"PRICE\":\"138.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20170529181500\",\"ANALOG\":\"\",\"MSG\":null,\"PriceTenge\":0,\"PriceRub\":0.0,\"ArtificialPrice\":null,\"ShowArtificialByDefault\":false,\"SupplierId\":0,\"Delivery\":null,\"DeliveryEx\":0,\"DeliveryGu\":0,\"Vkorg\":null,\"Kunnr\":null},";
            #endregion

            Random rand = new Random();

            IList<Procuct> Procucts = new List<Procuct>();

            foreach (string[] item in getData(DATA))
            {

                Procuct Product = new Procuct();   
                switch (item[0])
                {
                    case "PIN":
                        Product.Pin = item[1];
                        break;
                    case "BRAND": Product.Brend = item[1];
                        break;
                    case "NAME": Product.Name = item[1];
                        break;
                    default:
                        break;
                }
                Procucts.Add(Product);
            }

            Procuct.ShowProduct(Procucts);
            Console.WriteLine();
        }
    }
}
