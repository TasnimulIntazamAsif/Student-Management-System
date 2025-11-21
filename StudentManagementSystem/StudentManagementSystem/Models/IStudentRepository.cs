// IStudentRepository.cs
// Defines a contract for performing CRUD operations and search functionality on Student entities.
using System.Collections.Generic;
using System.Threading.Tasks;
namespace StudentManagementSystem.Models
{
    public interface IStudentRepository
    /// Retrieves all students from the data source.
    /// A collection of all students.</returns>
    {
        Task<IEnumerable<Student>> GetAllStudentsAsync();
        /// Retrieves a student by their unique ID
        Task<Student> GetStudentByIdAsync(int id);
        Task<Student> AddStudentAsync(Student student);
        /// Adds a new student to the data source.
        Task<Student> UpdateStudentAsync(Student student);
        // Updates an existing student's information.
        Task DeleteStudentAsync(int id);
        /// Deletes a student from the data source by ID.
        Task<IEnumerable<Student>> SearchStudentsAsync(string searchTerm);
        // Searches for students based on a search term.
    }
}
