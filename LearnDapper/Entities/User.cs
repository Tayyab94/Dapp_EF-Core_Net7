using LearnDapper.Entities.Common;
using LearnDapper.Entities.ValueObjects;
using System.Net;

namespace LearnDapper.Entities
{

    public class User : Entity
    {
        public string Name { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public Address? Address { get; set; }

        private List<Post> _posts = new();
        public ICollection<Post> Posts => _posts;
    }
}
