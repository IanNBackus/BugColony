namespace BugColonyProject.Models.GroupsAndUsers
{
    //this join class generally represents an invite sent to a user to join a group,
    // used to store the useful data about the membership like if they're an admin
    public class GroupInvite
    {

        public string ApplicationUserId { get; set; } // foreign key to ApplicationUser

        public int GroupId { get; set; } // foreign key to Group

    }
}
