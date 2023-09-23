using MegaSena.Atributos;
using System.ComponentModel.DataAnnotations;

namespace MegaSena.Models
{
    public class MegaSenaViewModel
    {
        [CustomStringLengthValidation(5, 255)]
        public string NomeDoJogador { get; set; }

        [CPFValidation]
        public string CPF{ get; set; }

        [Range(1, 60)]
        public int PrimeiroNumero { get; set; }
        [Range(1, 60)]
        public int SegundoNumero { get; set; }
        [Range(1, 60)]
        public int TerceiroNumero { get; set; }
        [Range(1, 60)]
        public int QuartoNumero { get; set; }
        [Range(1, 60)]
        public int QuintoNumero { get; set; }
        [Range(1, 60)]
        public int SextoNumero { get; set; }
        public DateTime DataJogo { get; set; }
    }
}
