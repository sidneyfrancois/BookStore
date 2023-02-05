using BookStore.Context;
using BookStore.Domain;
using BookStore.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BookStore.Repositories
{
    public class AutorRepository : IAutorRepository
    {
        private readonly BookStoreDataContext _db;

        public AutorRepository(BookStoreDataContext context)
        {
            _db = context;
        }

        public bool Create(Autor autor)
        {
            try
            {
                _db.Autores.Add(autor);
                _db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }


        }

        public bool Update(Autor autor)
        {
            try
            {
                // compare memory entity with entity in db
                _db.Entry<Autor>(autor).State = EntityState.Modified;   
                _db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Delete(int id)
        {
            var autor = _db.Autores.Find(id);
            _db.Autores.Remove(autor);
            _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public List<Autor> Get()
        {
            return _db.Autores.ToList();
        }

        public Autor Get(int id)
        {
            return _db.Autores.Find(id);
        }

        public List<Autor> GetByName(string name)
        {
            return _db.Autores
                .Where(x => x.Nome.Contains(name))
                .ToList();
        }

    }
}