using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Location.API.Model
{
    public class Follow
    {
        public Follow()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public User Follower { get; set; }
        public User Followed { get; set; }
        public bool Status { get; set; }
    }
}
