using System.Collections.Generic;


namespace PastoralEmpleo.Models
{
    public partial class Role
    {
        public Role()
        {
            User = new HashSet<User>();
            RolePermission = new HashSet<RolePermission>();
        }

        public int Idrole { get; set; }
        public string Name { get; set; }

        public ICollection<User> User { get; set; }
        public ICollection<RolePermission> RolePermission { get; set; }
    }
}
