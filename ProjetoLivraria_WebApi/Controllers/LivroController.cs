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
using ProjetoLivraria_WebApi.Models;
using System.Web.Http.OData;
using System.Web.Http.OData.Query;


namespace ProjetoLivraria_WebApi.Controllers
{
    public class LivroController : ApiController
    {
        private DBModel db = new DBModel();

        // GET: api/Livro
        [EnableQuery(AllowedQueryOptions = AllowedQueryOptions.Filter | AllowedQueryOptions.OrderBy | AllowedQueryOptions.Select)]
        public IQueryable<LIVRO> GetLivros()
        {
            return db.Livros;
        }

        // GET: api/Livro/5
        [ResponseType(typeof(LIVRO))]
        public IHttpActionResult GetLivro(int id)
        {
            LIVRO livro = db.Livros.Find(id);
            if (livro == null)
            {
                return NotFound();
            }

            return Ok(livro);
        }

        // PUT: api/Livro/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutLivro(int id, LIVRO livro)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            if (id != livro.Id)
            {
                return BadRequest();
            }

            db.Entry(livro).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LivroExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Livro
        [ResponseType(typeof(LIVRO))]
        public IHttpActionResult PostLivro(LIVRO livro)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            db.Livros.Add(livro);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = livro.Id }, livro);
        }

        // DELETE: api/Livro/5
        [ResponseType(typeof(LIVRO))]
        public IHttpActionResult DeleteLivro(int id)
        {
            LIVRO livro = db.Livros.Find(id);
            if (livro == null)
            {
                return NotFound();
            }

            db.Livros.Remove(livro);
            db.SaveChanges();

            return Ok(livro);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LivroExists(int id)
        {
            return db.Livros.Count(e => e.Id == id) > 0;
        }
    }
}