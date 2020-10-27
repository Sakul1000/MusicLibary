using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicLibary;

namespace RadioRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicController : ControllerBase
    {
        // Data
        private static List<Music> _data = new List<Music>()
        {
            new Music(1, "king crimson", "Mike", 2030, 1995),
            new Music(2, "beach boys", "bob", 2050, 1994),
            new Music(3, "battles", "nick", 2000, 1990),
            new Music(4, "The best", "Fred", 2000, 1600),
            new Music(5, "Going", "Peter", 2010, 1890),
        };

        // GET: api/Music
        [HttpGet]
        //200 betyder det er gennenført. 404 betyder at serven den kan ikke finde hvad client leder efter.
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public IEnumerable<Music> Get()
        {
            return _data;
        }

        /// <summary>
        /// henter id fra klassen
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: api/Music/5
        [HttpGet]
        [Route("id/{id}")]
        public Music GetId(int id)
        {
            return _data.Find(i => i.Id == id);
        }

        [HttpGet]
        [Route("duration/{duration}")]
        public Music GetDur(int duration)
        {
            return _data.Find(j => j.Duration == duration);
        }

        [HttpGet]
        [Route("publication/{publication}")]
        public Music GetPub(int publication)
        {
            return _data.Find(h => h.Publication == publication);
        }


        /// <summary>
        /// henter en shoppingliste ud fra hvad jeg søger efter.  
        /// </summary>
        /// <param name="substring"></param>
        /// <returns></returns>
        [HttpGet]
        [Route ("Artis/{substring}")]
        public IEnumerable<Music> GetArtist(string substring)
        {
            return _data.FindAll(p => p.Artis.Contains(substring));
        }

        [HttpGet]
        [Route("Titel/{substring}")]
        public IEnumerable<Music> GetTitel(string substring)
        {
            return _data.FindAll(h => h.Titel.Contains(substring));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        // POST: api/Music
        [HttpPost]
        public void Post([FromBody] Music value)
        {
            _data.Add(value);
        }

        // PUT: api/Music/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Music value)
        {
            Music music = GetId(id);
            if (music != null)
            {
                music.Id = value.Id;
                music.Titel = value.Titel;
                music.Artis = value.Artis;
                music.Duration = value.Duration;
                music.Publication = value.Publication;
            }

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Music music = GetId(id);
            _data.Remove(music);
        }
    }
}
