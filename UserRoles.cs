namespace C_FinallPROJECT.Models
{
    // Tabla puente que une Users con Roles (relación many-to-many)
    public class UserRoles
    {
        // Llave foránea hacia Users
        public int UserID { get; set; }

        // Navegación hacia la entidad Users
        public Users User { get; set; } = null!;

        // Llave foránea hacia Roles
        public int RoleID { get; set; }

        // Navegación hacia la entidad Roles
        public Roles Role { get; set; } = null!;
    }
}
