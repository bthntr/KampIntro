﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention isimlendirme tekniği
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi! :" + urun.Adi);

        }

        public void Ekle2(string UrunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi! : " + UrunAdi);
        }
        
    }
}