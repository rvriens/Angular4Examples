using Angular4Examples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Angular4Examples.Controllers
{
    public class HeroesController : ApiController
    {
        public static List<Hero> heroes = new List<Hero>()
        {
            new Hero() { Id = 0, Name = "Zero"},
            new Hero() { Id = 11, Name = "Mr. Nice"},
            new Hero() { Id = 12, Name = "Narco"},
            new Hero() { Id = 13, Name = "Bombasto"},
            new Hero() { Id = 14, Name = "Celeritas"},
            new Hero() { Id = 15, Name = "Magneta"},
            new Hero() { Id = 16, Name = "RubberMan"},
            new Hero() { Id = 17, Name = "Dynama"},
            new Hero() { Id = 18, Name = "Dr IQ"},
            new Hero() { Id = 19, Name = "Magma"},
            new Hero() { Id = 20, Name = "Tornado"}
        };

        // GET: api/Heroes
        public IEnumerable<Hero> Get()
        {
            return heroes;
        }

        // GET: api/Heroes/5
        public Hero Get(int id)
        {
            return (from q in heroes where q.Id == id select q).FirstOrDefault();
        }

        // POST: api/Heroes
        public IHttpActionResult Post([FromBody]Hero hero)
        {
            int maxid = heroes.Any() ? heroes.Max(q => q.Id) : 1;
            hero.Id = maxid;
            heroes.Add(hero);
            return Ok(hero);
        }

        // PUT: api/Heroes/5
        public IHttpActionResult Put(int id, [FromBody]Hero value)
        {
            Hero hero = Get(id);
            if (hero != null)
            {
                hero.Name = value.Name;
                return Ok(hero);
            }
            return NotFound();
        }

        // DELETE: api/Heroes/5
        public IHttpActionResult Delete(int id)
        {
            Hero hero = Get(id);
            if (hero != null)
            {
                heroes.Remove(hero);
                return Ok(hero);
            }
            return NotFound();
        }
    }
}
