using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maasBodrosuHesaplama

{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sskPrimiİsciPayi=0, issizlikSigortasiİscininPayi=0, gelirVergisininMatrahi=0, gelirVergisiMiktari=0, damgaVergisiMiktarı=0, kesintilerinToplami=0, netUcret=0, brutUcret=0;
            Console.Write("brüt ücreti giriniz : ");
            brutUcret=Convert.ToDouble(Console.ReadLine());
            sskPrimiİsciPayi = (brutUcret * 14)/100;
            issizlikSigortasiİscininPayi = (brutUcret * 1)/100;
            gelirVergisininMatrahi = (brutUcret - (sskPrimiİsciPayi + issizlikSigortasiİscininPayi));
            gelirVergisiMiktari = (gelirVergisininMatrahi * 15) / 100;
            damgaVergisiMiktarı = (brutUcret * 759) / 100000;
            kesintilerinToplami = (sskPrimiİsciPayi + issizlikSigortasiİscininPayi + gelirVergisiMiktari + damgaVergisiMiktarı);
            netUcret = brutUcret - kesintilerinToplami;
            Console.WriteLine("ssk primi işçi payı : {0}", sskPrimiİsciPayi);
            Console.WriteLine("işsizlik sigorta işçinin parası : {0}", issizlikSigortasiİscininPayi);
            Console.WriteLine("gelir vergisinin matrahı : {0} ", gelirVergisininMatrahi);
            Console.WriteLine("damga vergisi miktarı : {0} ", damgaVergisiMiktarı);
            Console.WriteLine("kesintilerin toplamı : {0}", kesintilerinToplami);
            Console.WriteLine("net ücret : {0}", netUcret);
            Console.ReadKey();




        }
    }
}
