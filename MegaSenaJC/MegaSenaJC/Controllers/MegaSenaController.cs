using MegaSena.AutoMapperConfiguration;
using MegaSena.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MegaSena.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MegaSenaController : ControllerBase
    {
        string lugar = @".\Data\EstatisticasDoJogo.json";
       
        [HttpPost]
        public IActionResult RegistroDoJogo([FromBody]MegaSenaViewModel megaSena)
        {
            Directory.CreateDirectory(caminho.Substring(0, caminho.LastIndexOf('\\')+1));
            string jsonRead = System.IO.File.ReadAllText(caminho);
            var pegarNumeros = JsonConvert.DeserializeObject<IEnumerable<Entities.MegaSena>>(jsonRead);
            List<Entities.MegaSena> lista = pegarNumeros.ToList();
            Entities.MegaSena newMegaSena = AutoMapperConfig.Map.Map<Entities.MegaSena>(megaSena);
            newMegaSena.atualizarData();
            lista.Add(newMegaSena);
            string json = JsonConvert.SerializeObject(lista);
            System.IO.File.WriteAllText(caminho, json);
            return Ok();
        }

        [HttpGet]
        public IEnumerable<MegaSenaViewModel> ObterNumeros()
        {
            string json = System.IO.File.ReadAllText(caminho);
            IEnumerable<Entities.MegaSena> pegarNumeros = JsonConvert.DeserializeObject<IEnumerable<Entities.MegaSena>>(json);
            return AutoMapperConfig.Map.Map<IEnumerable<MegaSenaViewModel>>(pegarNumeros);
        }

    }
}
