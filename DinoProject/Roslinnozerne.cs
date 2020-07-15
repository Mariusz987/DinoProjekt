using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace DinoProject
{
    /// <summary>Klasa <c>Roslinozerne</c> dziedziczy po Dinozaur 
    /// i umożliwia utworzenie obiektu Roslinozerne.
    /// </summary>
    class Roslinnozerne : Dinozaur
    {

        /// <summary>Zmienna <c>plikiDetaleR</c> przechowuje ścieżke 
        ///  do plików tekstowych.</summary>
        static public List<string> plikDetaleR = Directory.GetFiles("D:/Projekty/DinoProject/DinoProject/text/detale/r").ToList<string>();
        static public List<string> plikOpisR = Directory.GetFiles("D:/Projekty/DinoProject/DinoProject/text/opis/r").ToList<string>();
        /// <summary>Konstruktor odziedziczony po  klasie Dinozaur,
        ///  inicjalizuje dane.</summary>
        public Roslinnozerne(string nazwa, string nazwanaukowa, string masa, string wzrost, string dlugosc, string rzad) : base
                            (nazwa, nazwanaukowa, masa, wzrost, dlugosc, rzad)
        { }
        
    }
}
