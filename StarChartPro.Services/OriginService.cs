using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarChartPro.Models;
using StarChartPro.Data;
using StarChartPro.Models.OriginModels;

namespace StarChartPro.Services
{
    public class OriginService
    {
        private readonly Guid _userId;
        private readonly int originId;
        //private int originId;
        //private readonly int listId;

        public OriginService(Guid userId) //, int OriginId)
        {
            _userId = userId;
            //listId = OriginId;

            return ;
        }

        public bool CreateOrigin(OriginCreate model)
        {
            var entity =
                new Origin()
                {
                    OriginId = model.OriginId,
                    OriginName = model.OriginName,
                    OriginDesc = model.OriginDesc,
                    Latitude = (decimal)model.Latitude,
                    Longitude = (decimal)model.Longitude,
                    OriginGalaxy = model.OriginGalaxy,
                    CreatedUtc = DateTimeOffset.Now
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Origins.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<OriginListItem> ListOrigin() 
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.Origins
                    .Where(e => e.OriginId == originId)
                        .Select
                            (
                                e =>
                                    new OriginListItem
                                    {
                                        OriginId = e.OriginId,
                                        OriginName = e.OriginName,
                                        OriginDesc = e.OriginDesc,
                                        OriginGalaxy = e.OriginGalaxy,
                                        Latitude = (float)e.Latitude,
                                        Longitude = (float)e.Longitude,
                                        CreatedUtc = e.CreatedUtc
                                    }
                        );

                return query.ToArray();
            }
        }

        public bool EditOrigin(OriginEdit model) 
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Origins
                            .Single
                                (e => e.OriginId == model.OriginId && e.OriginId == originId);
                
                    entity.OriginId = model.OriginId;
                    entity.OriginName = model.OriginName;
                    entity.OriginDesc = model.OriginDesc;
                    entity.OriginGalaxy = model.OriginGalaxy;
                    entity.Latitude = (decimal)model.Latitude;
                    entity.Longitude = (decimal)model.Longitude;
                    entity.CreatedUtc = model.CreatedUtc;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteOrigin(OriginDelete model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx
                    .Origins
                        .Single
                            (e => e.OriginId == model.OriginId && e.OriginId == originId);
                ctx.Origins.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
