namespace BugColonyProject.Models.GroupsAndUsers
{
    //this join class generally represents a membership of a user in a group,
    // used to store the useful data about the membership like if they're an admin
    public class GroupMembership
    {

        public string ApplicationUserId { get; set; } // foreign key to ApplicationUser

        public int GroupId { get; set; } // foreign key to Group

        public bool IsAdmin { get; set; } // true if the user is an admin of the group

    }
}
