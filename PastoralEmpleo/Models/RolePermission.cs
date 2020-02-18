namespace PastoralEmpleo.Models
{
    public class RolePermission
    {
        public int Idrole { get; set; }
        public Role Role { get; set; }
        public int Idpermission { get; set; }
        public Permission Permission { get; set; }
    }
}
