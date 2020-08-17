using System;
using System.Collections.Generic;
using System.Linq;

namespace Hike.Models
{
    public interface ITrailRepository
    {
         IEnumerable<Trail> Trails {get; set;}
         List<Trail> AddTrails(List<Trail> trailList);
         Trail GetTrail(int id);
    }
}