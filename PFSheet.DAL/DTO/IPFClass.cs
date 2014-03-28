using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFSheet.DAL.DTO
{
    public interface IPFClass
    {
        int PFClassID { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        IList<IPFClassLevelStats> StatsByLevel { get; set; }
        IList<ISkill> ClassSkills { get; set; }
    }
}
