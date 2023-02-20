using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vertigo_Hash.Helpers;

namespace Vertigo_Hash.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HashController : ControllerBase
    {
        // POST: api/Hash
        [HttpPost]
        public long Post([FromBody] string value)
        {
            long hash = CustomHash.Hash(value);

            return hash;
        }
    }
}
