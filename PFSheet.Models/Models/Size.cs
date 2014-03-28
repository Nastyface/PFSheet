using PFSheet.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFSheet.Models.Models
{
    public class Size 
    {
        public int SizeID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int SizeModifier { get; set; }
        public int SpecialSizeModifier { get; set; }
        public int SizeModifierToFly { get; set; }
        public int SizeModifierToStealth { get; set; }
        public string Space { get; set; }
        public string NaturalReach { get; set; }
        public string TypicalHeightLength { get; set; }
        public string TypicalWeight { get; set; }
    }
}
