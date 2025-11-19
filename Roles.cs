namespace C_FinallPROJECT.Models
{
    // Tabla que representa los distintos roles del sistema (Admin, Cliente, etc.)
    public class Roles
    {
        // Llave primaria del rol
        public int RoleID { get; set; }

        // Nombre del rol (ej. “Admin”, “Guest”, “Manager”)
        public string RoleName { get; set; } = null!;

        // Relación con la tabla puente UserRoles
        public List<UserRoles>? UserRole { get; set; }
    }
}
