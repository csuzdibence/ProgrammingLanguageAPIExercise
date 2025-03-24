using Microsoft.AspNetCore.Mvc;
using ProgrammingLanguage.Data;
using System.Linq;

namespace ProgrammingLanguageAPI.Controllers
{
    [Route("api/programminglanguages")]
    public class ProgrammingLanguageController : Controller
    {
        private readonly ProgrammingLanguageDbContext dbContext;
        public ProgrammingLanguageController(ProgrammingLanguageDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        /* 
            1. feladat - api/programminglanguages
            Listázd ki az összes nyelv összes adatát json listaként
         */
        // api/programminglanguages
        [HttpGet]
        public IActionResult GetProgrammingLanguages()
        {
            return Ok(dbContext.ProgrammingLanguages);
        }

        /*
            2. feladat - api/programminglanguages/name/{Python}
            Legyen egy végpont, ami név alapján vissza adja a megfelelő nyelv adatait
            Ha nincs az adatbázisban dobj vissza 400 Bad Requestet
         */
        // api/programminglanguages/name
        [HttpGet("name/{name}")]
        public IActionResult GetProgrammingLangaugesByTypeName(string name)
        {
            var foundLanguage = dbContext.ProgrammingLanguages.FirstOrDefault(x => x.Name == name);
            if (foundLanguage == null)
            {
                return BadRequest();
            }
            return Ok(foundLanguage);
        }

        /*
            3. feladat - api/programminglanguages/typeSystem/{Static}
            Legyen egy végpont ami típusrendszer alapján visszaadja az összes nyelvet amelyekre igaz
            Ha nincs az adatbázisban dobj vissza 400 Bad Requestet
         */
        // url: api/programminglanguages/typeSystem
        [HttpGet("typeSystem/{typeSystem}")]
        public IActionResult GetProgrammingLangaugesByTypeSystem(string typeSystem)
        {
            // SELECT * FROM ProgrammingLanuages WHERE TypeSystem = "NincsBenne"
            var languagesByTypeSystem = dbContext.ProgrammingLanguages.Where(x => x.TypeSystem == typeSystem);
            if (languagesByTypeSystem.Count() == 0)
            {
                return BadRequest();
            }
            return Ok(languagesByTypeSystem);
        }

        /*
            4. feladat - api/programminglanguages/popular
            Legyen egy végpont ami a legnépszerűbb nyelvet adja vissza
         */
        [HttpGet("popular")]
        public IActionResult MostPopularLanguage()
        {
            double maxValue = dbContext.ProgrammingLanguages.Max(x => x.UsagePercentage);
            return Ok(dbContext.ProgrammingLanguages.FirstOrDefault(x => x.UsagePercentage == maxValue));
        }

        /* 5. feladat - POST api/programminglanguages/insert/
            Lehessen beszúrni egy új nyelvet minden adatával, ha sikerült 201 (Created response)
            Ha nem, 400 bad request (Segítség: [FromBody] attribute a bemeneti paraméteren)

            Teszteld Postmannel! 
         */

        [HttpPost("insert")]
        public IActionResult Insert([FromBody] ProgrammingLanguage.Data.ProgrammingLanguage programmingLanguage)
        {
            try
            {
                dbContext.ProgrammingLanguages.Add(programmingLanguage);
                dbContext.SaveChanges();
                return Created("Insert", programmingLanguage);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
