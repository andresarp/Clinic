using System;
using System.Collections.Generic;

namespace Clinica.Models
{
    public partial class Equipment
    {
        public int idEquipment { get; set; }
        public int assetNumber { get; set; }
        public string name { get; set; } = null!;
        public string serial { get; set; } = null!;
        public string description { get; set; } = null!;
        public DateTime datePurchase { get; set; }
        public int specialty { get; set; }
        public int consultingRoom { get; set; }
    }
}
