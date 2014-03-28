using PFSheet.DAL.DTO;

namespace PFSheet.BL.Models
{
    public class Race 
    {
        public int RaceID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Race(IRace dalRace)
        {
            RaceID = dalRace.RaceID;
            Name = dalRace.Name;
            Description = dalRace.Description;
        }
        
    }
}
