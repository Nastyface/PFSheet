using PFSheet.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFSheet.DAL.MSSQL
{
    internal partial class Race : IRace
    {
        public int RaceID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int BaseSpeed { get; set; }
        public IList<IBonusStat> StatBonuses { get; set; }
        public IList<IBonusSkill> SkillBonuses { get; set; }
        public IList<ILanguage> RaceLanguages { get; set; }
        public ISize Size { get; set; }
    }
}
