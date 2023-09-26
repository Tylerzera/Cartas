using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[Route("api/[controller]")]
[ApiController]
public class CartasController : ControllerBase
{
    private static List<CartaDoPapaiNoel> cartas = new List<CartaDoPapaiNoel>();

    [HttpPost]
    public IActionResult Post([FromBody] CartaDoPapaiNoel carta)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        if (carta.IdadeDaCrianca >= 15)
        {
            return BadRequest("Apenas crianças com menos de 15 anos podem enviar cartas.");
        }

        cartas.Add(carta);
        carta.Id = cartas.Count; 

        return CreatedAtAction(nameof(Get), new { id = carta.Id }, carta);
    }

    [HttpGet]
    public IEnumerable<CartaDoPapaiNoel> Get()
    {
        return cartas;
    }
}
