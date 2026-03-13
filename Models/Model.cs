using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuSistemi.Models
{
    public class HesaplamaModel { 
        public int Sayi1 { get; set; }
        public int Sayi2 { get; set; }

        public int Topla() {
            return Sayi1 + Sayi2;
        }
    }
} 
