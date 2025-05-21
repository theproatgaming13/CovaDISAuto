using CovaDISAutoAPI.Application.Repositories;
using CovaDISAutoAPI.Shared.DTO.Ritoverzicht;
using Microsoft.AspNetCore.Mvc;

namespace CovaDISAutoAPI.API.Controllers
{
    public class RitoverzichtController
    {
        private readonly RitoverzichtRepository ritoverzichtRepository;

        public RitoverzichtController(RitoverzichtRepository ritoverzichtRepository)
        {
            this.ritoverzichtRepository = ritoverzichtRepository;
        }

        [HttpGet]
        [Route("geefRitoverzichten")]
        public ActionResult<IEnumerable<RitoverzichtListItem>> GeefAlleBoeken()
        {
            return Ok(ritoverzichtRepository.GeefAlleRitoverzichten());
        }
    }
}
