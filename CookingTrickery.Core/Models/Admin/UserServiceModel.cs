namespace CookingTrickery.Core.Models.Admin
{
    public class UserServiceModel
    {
        public string UserId { get; init; } = null!;

        public string UserName { get; set; } = null!;

        public string? Email { get; init; } = null;

        public string FullName { get; init; } = null!;

    }
}
