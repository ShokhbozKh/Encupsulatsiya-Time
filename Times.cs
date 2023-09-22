using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Time
    {
        //Quyidagi 3ta field'larga ega bo’lgan
        //Time klassini encapsulation prinsipi asosida yarating: soat, minut, va sekund.
        //“soat:minut:sekund” (Masalan: 01:25:08)
        //formatdagi vaqtni qaytaruvchi metod yarating.
        private int _soat;
        private int _minut;
        private int _sekund;

        public int Soat
        {
            get { return _soat; }
            set 
            { 
                if(value >= 0 && value <= 25)
                _soat = value;
                else
                {
                    Console.WriteLine("soatda xatolik bor");
                }
            }
        }
        public int Minut
        {
            get { return _minut; }
            set 
            {
                if (value >= 0 && value <= 60)
                    _minut = value;
                else
                {
                    Console.WriteLine("minutda xatolik bor");
                }
                 
            }
        }
        public int Sekund
        {
            get { return _sekund; }
            set 
            {
                if (value >= 0 && value <= 60)
                    _sekund = value;
                else
                {
                    Console.WriteLine("secundda xatolik bor");
                }
                 
            }
        }
        public void DesplayInfo()
        {
            Console.WriteLine($"{_soat}:{_minut}:{_sekund}");
        }

    }
}
