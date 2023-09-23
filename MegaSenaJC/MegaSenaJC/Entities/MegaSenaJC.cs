using MegaSena.Atributos;
using System.ComponentModel.DataAnnotations;

namespace MegaSena.Entities
{
    public class MegaSena
    {
        public string NomeDoJogador { get; set; }
        public string CPF { get; set; }
        public int PrimeiroNumero { get; set; }
        public int SegundoNumero { get; set; }
        public int TerceiroNumero { get; set; }
        public int QuartoNumero { get; set; }
        public int QuintoNumero { get; set; }
        public int SextoNumero { get; set; }
        public DateTime DataJogo { get; set; }

        public bool NumerosValidos()
        {
            if (PrimeiroNumero == SegundoNumero || PrimeiroNumero == TerceiroNumero || PrimeiroNumero == QuartoNumero || PrimeiroNumero == QuintoNumero || PrimeiroNumero == SextoNumero ||
                SegundoNumero == TerceiroNumero || SegundoNumero == QuartoNumero || SegundoNumero == QuintoNumero || SegundoNumero == SextoNumero ||
                TerceiroNumero == QuartoNumero || TerceiroNumero == QuintoNumero || TerceiroNumero == SextoNumero ||
                QuartoNumero == QuintoNumero || QuartoNumero == SextoNumero ||
                QuintoNumero == SextoNumero)
                return false;
              return true;

        }
        public void atualizarData()
        {
            DataJogo = DateTime.Now;
        }
    }
}
