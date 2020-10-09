using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using LeBataillon.Database.Context;

using LeBataillon.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace LeBataillon.Database.Repository
{
    public interface IPlayerRepo
    {

        List<Player> GetAll();
        Player GetById(int id);
        void Add(Player Player);
        void Edit(Player Player);
        void Delete(int id);


    }


    public partial class PlayerRepo : IPlayerRepo
    {
        LeBataillonDbContext _context;
        public PlayerRepo(LeBataillonDbContext context)
        {
            this._context = context;
        }

        public List<Player> GetAll()
        {
            return _context.players.ToList();
        }

        public Player GetById(int id)
        {
            return _context.players

                .FirstOrDefault(m => m.Id == id);
        }
        public void Add(Player Player)
        {
            _context.Add(Player);
            _context.SaveChanges();
        }
        public void Edit(Player Player)
        {
            _context.Update(Player);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var Player = _context.players.Find(id);
            _context.players.Remove(Player);
            _context.SaveChanges();
        }
    }


}