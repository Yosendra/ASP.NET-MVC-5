using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Dtos;

namespace Vidly.Controllers.Api
{
    public class RentalsController : ApiController
    {
        [HttpPost]
        public IHttpActionResult CreateRental(RentalDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
