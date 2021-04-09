using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstApp
{
    [ApiController]
    public class SecretsController: ControllerBase
    {

        private readonly IConfiguration _configuration;

        public SecretsController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [Route("api/secret")]
        public string GetSecret()
        {
            return _configuration.GetValue<string>("secret");
        }

    }
}
