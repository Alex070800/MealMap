using MealMap.Context;
using MealMap.Dto.Response;

namespace MealMap.Service
{
    public class UnitService
    {
        public List<GetUnitsResponse> Get()
        {
            using (MealMapContext context = new MealMapContext())
            {
                return context.Units.Select(o => new GetUnitsResponse() { Id = o.Id, Name = o.Name }).ToList();
            }

        }
    }
}
