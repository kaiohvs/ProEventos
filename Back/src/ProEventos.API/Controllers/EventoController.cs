using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{

private readonly DataContext _context;
public EventoController(DataContext context){
    _context = context;
}

 

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
       return _context.Eventos;
    }
    [HttpGet("{id}")]
    public Evento GetById(int id)
    {
       return _context.Eventos.FirstOrDefault(evento => evento.EventoId == id);
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
