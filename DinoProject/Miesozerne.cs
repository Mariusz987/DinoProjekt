using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoProject
{
    /// <summary>Klasa <c>Miesozerne</c> dziedziczy po Dinozaur 
    /// i umożliwia utworzenie obiektu Miesozerne.
    /// </summary>
    class Miesozerne : Dinozaur 
    {
        /// <summary>Zmienna <c>plikiDetaleM</c> przechowuje ścieżke 
        ///  do plików tekstowych.</summary>
        static public List<string> plikDetaleM = Directory.GetFiles("D:/Projekty/DinoProject/DinoProject/text/detale/m").ToList<string>();
        static public List<string> plikOpisM = Directory.GetFiles("D:/Projekty/DinoProject/DinoProject/text/opis/m").ToList<string>();
        /// <summary>Konstruktor odziedziczony po  klasie Dinozaur,
        ///  inicjalizuje dane.</summary>
        public Miesozerne(string nazwa, string nazwanaukowa, string masa, string wzrost, string dlugosc, string rzad) : base
                         (nazwa, nazwanaukowa, masa, wzrost, dlugosc, rzad)
        { }
    }
}
