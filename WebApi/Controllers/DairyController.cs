using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AttributeRouting;
using AttributeRouting.Web.Http;
using BusinessEntities;
using BusinessServices;
using WebApi.ActionFilters;
using WebApi.Filters;

namespace WebApi.Controllers
{
    [AuthorizationRequired]
    [RoutePrefix("v1/Dairies/Dairy")]
    public class DairyController : ApiController
    {
        #region Private variable.

        private readonly IDairyServices _dairyServices;

        #endregion

        #region Public Constructor

        /// <summary>
        /// Public constructor to initialize dairy service instance
        /// </summary>
        public DairyController(IDairyServices dairyServices)
        {
            _dairyServices = dairyServices;
        }

        #endregion

        // GET api/dairy
        [GET("alldairies")]
        [GET("all")]
        public HttpResponseMessage Get()
        {
            var dairys = _dairyServices.GetAllDairys();
            var dairyEntities = dairys as List<DairyEntity> ?? dairys.ToList();
            if (dairyEntities.Any())
                return Request.CreateResponse(HttpStatusCode.OK, dairyEntities);
            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Dairies not found");
        }

        // GET api/dairy/5
        [GET("dairyid/{id?}")]
        [GET("particulardairy/{id?}")]
        [GET("mydairy/{id:range(1, 3)}")]
        public HttpResponseMessage Get(int id)
        {
            var dairy = _dairyServices.GetDairyById(id);
            if (dairy != null)
                return Request.CreateResponse(HttpStatusCode.OK, dairy);
            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No dairy found for this id");
        }

        // POST api/dairy
        [POST("Create")]
        [POST("Register")]
        public double Post([FromBody] DairyEntity dairyEntity)
        {
            return _dairyServices.CreateDairy(dairyEntity );
        }

        // PUT api/dairy/5
        [PUT("Update/dairyid/{id}")]
        [PUT("Modify/dairyid/{id}")]
        public bool Put(int id, [FromBody] DairyEntity dairyEntity)
        {
            if (id > 0)
            {
                return _dairyServices.UpdateDairy(id, dairyEntity);
            }
            return false;
        }

        // DELETE api/dairy/5
        [DELETE("remove/dairyid/{id}")]
        [DELETE("clear/dairyid/{id}")]
        [PUT("delete/dairyid/{id}")]
        public bool Delete(int id)
        {
            if (id > 0)
                return _dairyServices.DeleteDairy(id);
            return false;
        }
    }
}
