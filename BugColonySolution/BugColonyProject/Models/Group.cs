using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BugColonyProject.Data;

namespace BugColonyProject.Models
{
    //represents a given bug group (called a "colony" within the UI)
    public class Group
    {

        //unique identifier for each group (required by entityframrework)
        public int Id { get; set; }

        //group name
        [Required]
        public string Name { get; set; }

        //group bio/description
        public string Description { get; set; }

        //alliance the group belongs to (walkers, scuttlers, or flyers)
        [EnumDataTypeAttribute(typeof(BugAlliance))]
        [Required]
        public BugAlliance Alliance { get; set; }


        //a list of references to the bugs (users) that belong to this group
        public List<ApplicationUser> GroupMembers { get; set; }

        //a list of mappable activities belonging to this group
        //public List<IMappable> Mappables { get; set; }

    }
}
