using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using CretaceousPark.Models;

namespace CretaceousPark.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private CretaceousParkContext _db;
    public AnimalsController(CretaceousParkContext db)
    {
      _db = db;
    }

    //GET api/animals
    [HttpGet]
    public ActionResult<IEnumerable<Animal>> Get()
    {
      return _db.Animals.ToList();
    }

    //POST api/animals
    [HttpPost]
    public void Post([FromBody] Animal animal) //[Frombody] needed to put the details of a new animal in the body of a POST API call.
    {
      _db.Animals.Add(animal);
      _db.SaveChanges();
    }
  }
}