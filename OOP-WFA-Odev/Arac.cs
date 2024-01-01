using OOP_WFA_Odev.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_WFA_Odev
{
    public class Arac
    {
        private int _modelYili;
        private int _motorGucu;


        public string AracTuru { get; set; }
        public string KasaTipi { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string SanzimanTuru { get; set; }
        public string YakitTuru { get; set; }
        public Color Renk { get; set; }
        public Image Resim { get; set; }
        public bool GarantiliMi { get; set; }
        public int ModelYili
        {
            get { return _modelYili; }
            set
            {
                if (value < 2005)
                {
                    throw new Exception("2005 yılından küçük araç işlem görmemektedir.");
                }
                else if (value > DateTime.Now.Year)
                {
                    throw new Exception($"{DateTime.Now.Year} yılından büyük araç işlem görmemektedir.");
                }
                else
                {
                    _modelYili = value;
                }
            }
        }
        public int MotorGucu
        {
            get { return _motorGucu; }
            set
            {
                if (value < 1000)
                {
                    throw new Exception("Motor Gücü en az 1000 olabilir.");
                }
                else
                {
                    _motorGucu = value;
                }
            }
        }


        public override string ToString()
        {
            return $"{Marka} {Model} {AracTuru} {YakitTuru}";
        }
    }
}
