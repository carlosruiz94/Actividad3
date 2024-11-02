using System.ComponentModel.DataAnnotations;

namespace ISNP001724_ISNP010424_ISNP142324_Bloque3.Models
{
    public class pelicula
    {
        [Key]
        public int idPelicula { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Sinopsis { get; set; }
        public string Duración { get; set; }
        public string Clasificación { get; set; }
    }
}
