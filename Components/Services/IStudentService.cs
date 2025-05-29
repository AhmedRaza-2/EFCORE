using EFCORE.Models;

public interface IStudentService
{
    Task<List<Student>> GetAllStudentsAsync();
    Task<Student?> GetStudentByIdAsync(int studentId);
    Task CreateStudentAsync(Student newStudent);
    Task ModifyStudentAsync(Student updatedStudent);
    Task RemoveStudentAsync(int studentId);
}
