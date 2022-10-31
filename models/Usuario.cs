

using System.ComponentModel.DataAnnotations;

namespace UsuariosApi.Models{


    public class Usuarios{

        [Key]
        public int id { get; set; }

        public string email { get; set; }

        public string  password { get; set; }
    }
}