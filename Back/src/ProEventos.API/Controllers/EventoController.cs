using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{

public EventoController(){}

   public IEnumerable<Evento> _evento = new Evento[]{
       new Evento(){
            EventoId = 1,
            Tema = "Angular 11 e .NET 5",
            Local = "São Paulo",
            Lote = "1° Lote",
            QtdPessoas = 250,
            DataEvento = DateTime.Now.AddDays(2).ToString(),
            ImagemUrl = "Foto.png"
       },
       new Evento(){
            EventoId = 2,
            Tema = "Angular e suas novidades",
            Local = "Belo Horizonte",
            Lote = "2° Lote",
            QtdPessoas = 350,
            DataEvento = DateTime.Now.AddDays(3).ToString(),
            ImagemUrl = "Foto1.png"
       }
   };

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
       return _evento;
    }
    [HttpGet("{id}")]
    public IEnumerable<Evento> GetById(int id)
    {
       return _evento.Where(evento => evento.EventoId == id);
    }


    [HttpPost]
    public string post()
    {
        return "Exemplo de post";
    }
      [HttpPut("{id}")]
    public string put(int id)
    {
        return $"Exemplo de put com ID = {id}";
    }
    [HttpDelete("{id}")]
    public string Delete(int id)
    {
        return $"Exemplo de post de ID = {id}";
    }
     
}
