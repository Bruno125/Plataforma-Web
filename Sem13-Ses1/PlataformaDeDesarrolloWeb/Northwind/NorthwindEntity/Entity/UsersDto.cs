using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindEntity.Entity
{
    public class UsersDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }

    }
}
