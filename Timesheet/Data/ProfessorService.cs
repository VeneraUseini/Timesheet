using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timesheet.Model;

namespace Timesheet.Data
{
    public class ProfessorService
    {
        TimesheetDbContext _context;
        public ProfessorService(TimesheetDbContext context)
        {
            _context = context;
        }

        public async Task<List<Professor>> GetProfessorsAsync()
        {
            return await _context.Professors.ToListAsync();
        }

        public async Task<Professor> GetProfessorByIdAsync(string id)
        {
            return await _context.Professors.FindAsync(id);
        }

        public async Task<Professor> InsertProfessorAsync(Professor professor)
        {
            _context.Professors.Add(professor);
            await _context.SaveChangesAsync();

            return professor;
        }

        public async Task<Professor> UpdateProfessorAsync(string id, Professor p)
        {
            var professor = await _context.Professors.FindAsync(id);

            if (professor == null)
                return null;

            professor.FirstName = p.FirstName;
            professor.LastName = p.LastName;
            professor.Faculty = p.Faculty;
            professor.Email = p.Email;

            _context.Professors.Update(professor);
            await _context.SaveChangesAsync();

            return professor;
        }

        public async Task<Professor> DeleteProfessorAsync(string id)
        {
            var professor = await _context.Professors.FindAsync(id);

            if (professor == null)
                return null;

            _context.Professors.Remove(professor);
            await _context.SaveChangesAsync();

            return professor;
        }

        private bool ProfessorExists(string id)
        {
            return _context.Professors.Any(e => e.ProfessorId == id);
        }
    }
}
