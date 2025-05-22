using CovaDISAutoAPI.Domain.Data;
using CovaDISAutoAPI.Shared.DTO.Ritoverzicht;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovaDISAutoAPI.Application.Repositories
{
    public class RitoverzichtRepository
    {
        private readonly RitoverzichtContext ritoverzichtContext;

        // Test om 1 default object te hebben
        public RitoverzichtRepository(RitoverzichtContext ritoverzichtContext)
        {
            this.ritoverzichtContext = ritoverzichtContext;

        }

        public IEnumerable<RitoverzichtListItem> GeefAlleBoeken()
        {
            List<RitoverzichtListItem> returnRitoverzichten = new List<RitoverzichtListItem>();
            var ritoverzichtlijst = ritoverzichtContext.Ritoverzichten.Include(n => n.Chauffeur).Select(n => n);
            foreach (var item in ritoverzichtlijst)
            {
                returnRitoverzichten.Add(new RitoverzichtListItem()
                {
                    ID = item.ID,
                    Kilometerstand_voor = item.Kilometerstand_voor,
                    Chauffeur = item.Chauffeur.Naam,
                    Route = item.Route.beginAdres + " - " + item.Route.beginAdres
                });
            }
            return returnRitoverzichten;
        }
    }
}
