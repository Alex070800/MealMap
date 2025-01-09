using MealMap.Context;
using MealMap.Dto.Response;

namespace MealMap.Service
{
    public class MealTypeService
    {

        public List<GetMealTypesResponse> Get()
        {
            using (MealMapContext context = new MealMapContext())
            {
                return context.MealTypes.Select(o => new GetMealTypesResponse() { Id = o.Id, Name = o.Name, Order = o.Order }).ToList();
            }

        }
    }
}
