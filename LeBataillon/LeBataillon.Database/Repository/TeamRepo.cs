using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using LeBataillon.Database.Context;

using LeBataillon.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace LeBataillon.Database.Repository
{
    public interface ITeamRepo
    {
        void Add(Team Team);
        void Delete(int id);
        void Edit(Team Team);
        List<Team> GetAll();
        Team GetById(int id);
    }

    public partial class TeamRepo : ITeamRepo
    {
        private readonly LeBataillonDbContext _context;
        public TeamRepo(LeBataillonDbContext context)
        {
            _context = context;
        }

        public List<Team> GetAll()
        {
            return _context.teams.ToList();
        }

        public Team GetById(int id)
        {
            return _context.teams

                .FirstOrDefault(m => m.Id == id);
        }
        public void Add(Team Team)
        {
            _context.Add(Team);
            _context.SaveChanges();
        }
        public void Edit(Team Team)
        {
            _context.Update(Team);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var Team = _context.teams.Find(id);
            _context.teams.Remove(Team);
            _context.SaveChanges();
        }
    }

}