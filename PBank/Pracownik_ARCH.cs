//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PBank
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pracownik_ARCH
    {
        public int ID { get; set; }
        public string Imię { get; set; }
        public string Nazwisko { get; set; }
        public string Pesel { get; set; }
        public string Stanowisko { get; set; }
        public int Nr_Komputera { get; set; }
        public Nullable<int> Przełożony { get; set; }
        public double Pensja { get; set; }
        public string login { get; set; }
        public string haslo { get; set; }
        public Nullable<System.DateTime> data_zwolnienia { get; set; }
    }
}
