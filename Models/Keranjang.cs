using System;
using System.Collections.Generic;

namespace KalaRintikTea.Models
{
    public class Keranjang
    {
        public int IdKeranjang { get; set; }
        public int IdUser { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<ItemKeranjang> Items { get; set; } = new List<ItemKeranjang>();

        public Keranjang() { }
    }
}
