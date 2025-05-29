using EFCORE.Data;
using EFCORE.Models;
using Microsoft.EntityFrameworkCore;
public class StudentService : IStudentService
{
    private readonly AppDbContext _dbContext;
    public StudentService(AppDbContext dbContext)
    {     _dbContext = dbContext;}

    public async Task<List<Student>> GetAllStudentsAsync()        => await _dbContext.Students.ToListAsync();

    public async Task<Student?> GetStudentByIdAsync(int studentId) => await _dbContext.Students.FindAsync(studentId);

    public async Task CreateStudentAsync(Student newStudent)
    {   _dbContext.Students.Add(newStudent);
        await _dbContext.SaveChangesAsync();}

    public async Task ModifyStudentAsync(Student updatedStudent)
    {_dbContext.Students.Update(updatedStudent);
     await _dbContext.SaveChangesAsync();  }

    public async Task RemoveStudentAsync(int studentId)
    {var existingStudent = await _dbContext.Students.FindAsync(studentId);
        if (existingStudent != null)   {
            _dbContext.Students.Remove(existingStudent);
            await _dbContext.SaveChangesAsync();}}}
