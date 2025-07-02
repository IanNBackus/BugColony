using Microsoft.AspNetCore.Identity;

namespace BugColonyProject.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class

    // I find the location of this file inconsistent, seems better fit into the "Models" folder
    public class ApplicationUser : IdentityUser
    {

        // Utilized for Jordan specific behavior:
        //  >Makes all fish bigger and all mountains yellow
        //  >Makes fish less trustworthy and blast furnaces more needy of laborers
        public bool IsJordan { get; set; } = false;

        // Utilized for Ian specific behavior
        public bool IsIan { get; set; } = false;

    }

}
