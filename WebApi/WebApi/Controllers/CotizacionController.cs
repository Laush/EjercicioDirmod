using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class CotizacionController : ApiController
    {
        Model[] values = new Model[] {

            new Model {id="dolar", source="USD", value=58.08},
           new Model  {id="real", source="BRL", value=14.12},
          new Model   {id="euro", source="EUR", value=64.09},
                };
        public IEnumerable<Model> GetAllMoneda()
        {
            return values;
        }

        public IHttpActionResult GetMoneda(string id)
        {
            var currency = values.FirstOrDefault((m) => m.id == id);
            if (currency != null)
            {
                return Ok(currency);
            }
            else
            {
                return NotFound();
            }

        }


    }
}

