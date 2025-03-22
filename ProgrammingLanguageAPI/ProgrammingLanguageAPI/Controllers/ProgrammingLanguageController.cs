using Microsoft.AspNetCore.Mvc;

namespace ProgrammingLanguageAPI.Controllers
{
    public class ProgrammingLanguageController : Controller
    {
        /* 
            1. feladat - api/programminglanguages
            Listázd ki az összes nyelv összes adatát json listaként
         */

        /*
            2. feladat - api/programminglanguages?name=Python
            Legyen egy végpont, ami név alapján vissza adja a megfelelő nyelv adatait
            Ha nincs az adatbázisban dobj vissza 400 Bad Requestet
         */

        /*
            3. feladat - api/programminglanguages?typeSystem=Static
            Legyen egy végpont ami típusrendszer alapján visszaadja az összes nyelvet amelyekre igaz
            Ha nincs az adatbázisban dobj vissza 400 Bad Requestet
         */

        /*
            4. feladat - api/programminglanguages/popular
            Legyen egy végpont ami a legnépszerűbb nyelvet adja vissza
         */

        /* 5. feladat - POST api/programminglanguages/insert/
            Lehessen beszúrni egy új nyelvet minden adatával, ha sikerült 201 (Created response)
            Ha nem, 400 bad request (Segítség: [FromBody] attribute a bemeneti paraméteren)

            Teszteld Postmannel! 
         */
    }
}
