namespace Syra.Models
{
    // Represents a resource and its assignation to an user
    // Used to update user resources
    public class AssignedResourceViewModel
    {
        public int Id { get; set; }
        public string nameResource { get; set; }
        public bool Assigned { get; set; }
    }
}