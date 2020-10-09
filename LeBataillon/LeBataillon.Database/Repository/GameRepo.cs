using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using LeBataillon.Database.Context;

using LeBataillon.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace LeBataillon.Database.Repository
{
    public interface IGameRepo
    {
        void Add(Game game);
        void Delete(int id);
        void Edit(Game game);
        List<Game> GetAll();
        Game GetById(int id);
    }

    public partial class GameRepo : IGameRepo
    {
        private readonly LeBataillonDbContext _context;
        public GameRepo(LeBataillonDbContext context)
        {
            _context = context;
        }

        public List<Game> GetAll()
        {
            return _context.games.ToList();
        }

        public Game GetById(int id)
        {
            return _context.games

                .FirstOrDefault(m => m.Id == id);
        }
        public void Add(Game game)
        {
            _context.Add(game);
            _context.SaveChanges();
        }

        public void Edit(Game game)
        {
            _context.Update(game);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var game = _context.games.Find(id);
            _context.games.Remove(game);
            _context.SaveChanges();
        }
    }
}