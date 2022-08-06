using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using CreateApi.EDM;

namespace CreateApi.Controllers
{
    public class DefaultController : ApiController
    {
        private CompanyEntities db = new CompanyEntities();

        public DefaultController()
        {
            db.Configuration.ProxyCreationEnabled = false;
        }

        // GET: api/Default
        public IQueryable<tblemployee> Gettblemployees()
        {
            return db.tblemployees;
        }

        // GET: api/Default/5
        [ResponseType(typeof(tblemployee))]
        public IHttpActionResult Gettblemployee(int id)
        {
            tblemployee tblemployee = db.tblemployees.Find(id);
            if (tblemployee == null)
            {
                return NotFound();
            }

            return Ok(tblemployee);
        }

        // PUT: api/Default/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Puttblemployee(int id, tblemployee tblemployee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblemployee.emp_id)
            {
                return BadRequest();
            }

            db.Entry(tblemployee).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblemployeeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = tblemployee.emp_id }, tblemployee);
        }

        // POST: api/Default
        [ResponseType(typeof(tblemployee))]
        public IHttpActionResult Posttblemployee(tblemployee tblemployee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tblemployees.Add(tblemployee);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tblemployee.emp_id }, tblemployee);
        }

        // DELETE: api/Default/5
        [ResponseType(typeof(tblemployee))]
        public IHttpActionResult Deletetblemployee(int id)
        {
            tblemployee tblemployee = db.tblemployees.Find(id);
            if (tblemployee == null)
            {
                return NotFound();
            }

            db.tblemployees.Remove(tblemployee);
            db.SaveChanges();

            return Ok(tblemployee);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblemployeeExists(int id)
        {
            return db.tblemployees.Count(e => e.emp_id == id) > 0;
        }
    }
}