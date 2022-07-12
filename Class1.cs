using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billeteras2
{
    public class Billetera
    {
        public int billetesDe10 { get; set; }
        public int billetesDe20 { get; set; }
        public int billetesDe50 { get; set; }
        public int billetesDe100 { get; set; }
        public int billetesDe200 { get; set; }
        public int billetesDe500 { get; set; }
        public int billetesDe1000 { get; set; }

        public int Total()
        {
            int impTotal;

            impTotal = ((billetesDe10 * 10) + (billetesDe20 * 20) + (billetesDe50 * 50) + (billetesDe100 * 100) + (billetesDe200 * 200) + (billetesDe500 * 500) + (billetesDe1000 * 1000));
            return impTotal;
        }

        public Billetera Combinar(Billetera billetera)
        {
            Billetera nuevaBilletera = new Billetera();
            nuevaBilletera.billetesDe10 = this.billetesDe10 + billetera.billetesDe10;
            nuevaBilletera.billetesDe20 = this.billetesDe20 + billetera.billetesDe20;
            nuevaBilletera.billetesDe50 = this.billetesDe50 + billetera.billetesDe50;
            nuevaBilletera.billetesDe100 = this.billetesDe100 + billetera.billetesDe100;
            nuevaBilletera.billetesDe200 = this.billetesDe200 + billetera.billetesDe200;
            nuevaBilletera.billetesDe500 = this.billetesDe500 + billetera.billetesDe500;
            nuevaBilletera.billetesDe1000 = this.billetesDe1000 + billetera.billetesDe1000;
     
            return nuevaBilletera;
           
        }
       
       public void vaciar()
       {
            billetesDe10 = 0;
            billetesDe20 = 0;
            billetesDe50 = 0;
            billetesDe100 = 0;
            billetesDe200 = 0;
            billetesDe500 = 0;
            billetesDe1000 = 0;
       }
    }
}

