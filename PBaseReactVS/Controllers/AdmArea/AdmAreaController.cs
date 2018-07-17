using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PBaseReactVS.Models;
using System.ServiceModel;
namespace PBaseReactVS.Controllers
{
    public class AdmAreaController : Controller
    {

        AdmAreaDataLayer objarea = new AdmAreaDataLayer();

        [HttpGet]

        [Route("api/Area/Index")]

        public IEnumerable<AdmArea> Index()

        {

            return objarea.GetAllAreas();

        }

        [HttpPost]

        [Route("api/Area/Create")]

        public int Create(AdmArea area)

        {

            return objarea.AddArea(area);

        }
        [HttpGet]


        [Route("api/Area/Details/{id}")]

        public AdmArea Details(int id)

        {

            return objarea.GetAreaData(id);

        }

        [HttpPut]

        [Route("api/Area/Edit")]

        public int Edit(AdmArea employee)

        {

            return objarea.UpdateArea(employee);

        }

        [HttpDelete]

        [Route("api/Area/Delete/{id}")]

        public int Delete(int id)

        {
            return objarea.DeleteArea(id);
        }
        
       [HttpGet]


        [Route("api/Area/Probar")]

        public string   Probar()

        { 

            return  "ssss";

        }

         [HttpGet]
        [Route("api/Area/ProbarServicio")]
        public async Task<string> ProbarAsync()
        {

            

            ServiceReference1.ServiceClient clientechido = new ServiceReference1.ServiceClient();
            string s = await clientechido.ObtenerCatalogosPagoTarjetaAsync();
            return s.ToString();

        }
    }
}
