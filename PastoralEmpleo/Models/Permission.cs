using System.Collections.Generic;

namespace PastoralEmpleo.Models
{
    public partial class Permission
    {
        public Permission()
        {
            RolePermission = new HashSet<RolePermission>();
        }

        public int Idpermission { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public ICollection<RolePermission> RolePermission { get; set; }
    }
}
