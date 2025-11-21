using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Context;
namespace StudentManagementSystem.Models{
    public class StudentRepository : IStudentRepository
    /// Concrete implementation of IStudentRepository using Entity Framework Core.
    {
        private readonly AppDBContext _context;
        public StudentRepository(AppDBContext context)
        /// Constructor that injects the application database context.

        {
            _context = context;
        }
        public async Task<IEnumerable<Student>> GetAllStudentsAsync()
        // Retrieves all student records from the database.
        {
            return await _context.Students.ToListAsync();
        }
        public async Task<Student> GetStudentByIdAsync(int id)
        // Retrieves a student by their ID.
        {
            return await _context.Students.FindAsync(id);
        }
        public async Task<Student> AddStudentAsync(Student student)
        // Adds a new student to the database.
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
            return student;
        }
        public async Task<Student> UpdateStudentAsync(Student student)
        // Updates an existing student record.
        {
            _context.Entry(student).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return student;
        }
        public async Task DeleteStudentAsync(int id) { 
        // Deletes a student by their ID.
            var student = await _context.Students.FindAsync(id);
            if (student != null)
            {
                _context.Students.Remove(student);
                await _context.SaveChangesAsync();
            } }
        public async Task<IEnumerable<Student>> SearchStudentsAsync(string searchTerm)
        // Searches for students whose names contain the given search term.
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return await GetAllStudentsAsync();

            return await _context.Students
                .Where(s => s.Name.Contains(searchTerm))
                .ToListAsync();
        }
    }
}
