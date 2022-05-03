using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using System.Web;
using Webapitest.Models;
namespace Webapitest.Controllers
{
    public class WebApiController : ApiController
    {
        WebApi dt_api = new WebApi();
        WenContext db = new WenContext();
        // GET: api/WebApi

        public List<WebApi> Get()
        {

            var customers = db.WebApi.ToList();

            return customers.ToList();
        }

        //GET: api/WebApi/5
        public WebApi Get(int id)
        {
            var dt_sql = db.WebApi.Where(m => m.Id == id).FirstOrDefault();
            return dt_sql;
        }

        // POST: api/WebApi
        public int Post(string Name, string Phone, string Email, string Address)
        {
            int num = 0;
            try
            {
                WebApi dt_api = new WebApi();
                dt_api.Name = Name;
                dt_api.Phone = Phone;
                dt_api.Email = Email;
                dt_api.Address = Address;
                db.WebApi.Add(dt_api);
                num = db.SaveChanges();

            }
            catch (Exception ex)
            {
                num = 0;
            }
            return num;

        }

        // PUT: api/WebApi/5
        public int Put(int id, string Name, string Phone, string Email, string Address)
        {
            int num = 0;
            try
            {
                WebApi dt_api = new WebApi();
                var var_dt = db.WebApi.Where(m => m.Id == id).FirstOrDefault();
                var_dt.Name = Name;
                var_dt.Phone = Phone;
                var_dt.Email = Email;
                var_dt.Address = Address;
                num = db.SaveChanges();

            }
            catch (Exception ex)
            {
                num = 0;
            }
            return num;


        }

        // DELETE: api/WebApi/5
        public int Delete(int id)
        {
            int num = 0;
            try
            {
                WebApi dt = new WebApi();
                var var_dt = db.WebApi.Where(m => m.Id == id).FirstOrDefault();

            }
            catch (Exception ex)
            {
                num = 0;
            }
            return num;
        }
    }
}
