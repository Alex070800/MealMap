using MealMap.Context;
using MealMap.Dto.Response;

namespace MealMap.Service
{
    public class ComponentService
    {
        public List<GetProductResponse> Get()
        {
            using (MealMapContext context = new MealMapContext())
            {
                return context.Products.Select(o => new GetProductResponse() { Id = o.Id, Name = o.Name }).ToList();
            }

        }
    }
}
