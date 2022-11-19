using BusinessLayer;
using DataAccessLayer;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    internal class Cashier
    {
        public static void PrintReceipt(List<BaseClothing> clothes, DateTime currentDate)
        {
            JacketContext jacketContext = new JacketContext();
            ShirtContext shirtContext = new ShirtContext();
            TrousersContext trousersContext = new TrousersContext();
            ShoesContext shoesContext = new ShoesContext();

            clothes = new List<BaseClothing>();
            clothes.AddRange(jacketContext.GetAll());
            clothes.AddRange(shirtContext.GetAll());
            clothes.AddRange(trousersContext.GetAll());
            clothes.AddRange(shoesContext.GetAll());

            //print stuff
        }
    }
}
