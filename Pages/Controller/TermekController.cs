using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace logindlm.Pages.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class TermekController : ControllerBase
    {
        [HttpGet]

        public IActionResult TermekInfo()
        {
            List<TermekInfo> Termek = new List<TermekInfo>
            {
                new TermekInfo
                {
                    Cikkszam = "MM007950007020",
                    Termeknev = "Digitális terhelő villa 12V",
                    Leiras = "BAT508 Digitális akkumulátor terhelő villa 12V, 200-1000CCA, Digital battery load tester BAT508",
                    Ar = "10.490 Ft",
                    CreateAt = "2024-11-05T13:57:55.667"
                },
                new TermekInfo
                {
                    Cikkszam = "WURT59200010",
                    Termeknev = "WÜRTEMBERG 55Ah J+ akkumulátor",
                    Leiras = "12V 55AH akkumulátor Indító áramerősség: 480A méret: 242x175x190 mm",
                    Ar = "22.500 Ft",
                    CreateAt = "2024-11-05T13:57:55.667"
                },
                new TermekInfo
                {
                    Cikkszam = "OE4889777HU",
                    Termeknev = "Astra G KÜLSŐ HÉJ TÁVIRÁNYÍTÓH",
                    Leiras = "",
                    Ar = "2.211 Ft",
                    CreateAt = "2024-11-05T13:57:55.667"
                },

                new TermekInfo
                {
                    Cikkszam = "MO000033",
                    Termeknev = "Alvázvédő bitumenes flakon 1L",
                    Leiras = "Alvázvédő bitumenes fekete csavaros flakonban 1 L Nagyon jó hatású rozsdavédő szer",
                    Ar = "2.690 Ft",
                    CreateAt = "2024-11-05T13:57:55.667"
                },

                new TermekInfo
                {
                    Cikkszam = "ITA3080005IT",
                    Termeknev = "Gumiszerelő paszta - fehér 5kg",
                    Leiras = "",Ar = "4.290 Ft",
                    CreateAt = "2024-11-05T13:57:55.667"
                },
                new TermekInfo
                {
                    Cikkszam = "0189911070",
                    Termeknev = "C70 Akkumulátor töltő 10A",
                    Leiras = "Bosch C70 akkumulátor töltő Ólom-sav, EFB, AGM, GEL, VRLA akkumulátorokhoz.",
                    Ar = "41.990 Ft",
                    CreateAt = "2024-11-05T13:57:55.667"
                },
                new TermekInfo
                {
                    Cikkszam = "OSR64210NL",
                    Termeknev = "H7 12V 55W NBR. LASER izzó",
                    Leiras = "NIGHT BREAKER LASER izzó +150% fényerő H7, 12V, 55W, Foglalat:PX26D",
                    Ar = "4.390 Ft",
                    CreateAt = "2024-11-05T13:57:55.667"
                }
            };
            return new JsonResult(Termek);
        }
    }
}

