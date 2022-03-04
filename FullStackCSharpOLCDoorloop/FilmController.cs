using DatabaseLaag;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FullStackCSharpOLCDoorloop
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private DatabaseContext _dc;
        public FilmController(DatabaseContext dc) {
            _dc = dc;
        }


        // GET: api/<FilmController>
        [HttpGet]
        public IEnumerable<Film> Get()
        {
            Film f = new Film();
            f.Titel = "The matrix";
            f.Jaar = 2002;
            f.Hoofdacteur = "johan";
           
            _dc.Add(f);
            _dc.SaveChanges();
            return _dc.films;
        }

        // GET api/<FilmController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<FilmController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<FilmController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FilmController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
