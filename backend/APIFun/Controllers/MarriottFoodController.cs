using APIFun.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIFun.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MarriottFoodController : ControllerBase
    {
        private iFoodRepository _foodRepository;
        public MarriottFoodController(iFoodRepository temp) {
            _foodRepository = temp;
        }

        [HttpGet]
        public IEnumerable<MarriottFood> Get()
        {
            var foodData = _foodRepository.Foods.ToArray();

            return foodData;
        }
    }
}
