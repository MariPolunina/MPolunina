//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _2LAB_3VAR
{
    using System;
    using System.Collections.Generic;
    
    public partial class TableHero
    {
        public string Nick { get; set; }
        public string Class { get; set; }
        public int Force { get; set; }
        public int Intelligence { get; set; }
        public int Adroitness { get; set; }
        public int Luck { get; set; }
        public TableHero(string nick, string _class,int force, int intel, int adr, int luck )
        {
            Nick = nick;
            Class = _class;
            Force = force;
            Intelligence = intel;
            Adroitness = adr;
            Luck = luck;
        }
    }
}
