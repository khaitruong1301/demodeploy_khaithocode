using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using demokhaithocode.Models;
//using demokhaithocode.Models;

namespace demokhaithocode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class productController (StoreContext _db): ControllerBase
    {
   

        [HttpGet("get-all-product")]
        public async Task<IActionResult> getAllProduct()
        {
          

            return Ok(_db.Products);
        }

    }
}