// StudentService.cs
using BlazorApp1.Models;

public class StudentService
{
    private readonly StudentDBContext _dbContext;

    public StudentService(StudentDBContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<StudentViewResult>> GetStudentDataAsync()
    {
        List<StudentViewResult> students = await _dbContext.Procedures.StudentViewAsync();

        // Format the date part only for each student
        foreach (var student in students)
        {
            student.Student_DOB = student.Student_DOB.Date;
        }
        try
        {
            return await _dbContext.Procedures.StudentViewAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error fetching student data: {ex.Message}");
            throw;
        }
    }


    public async Task<int> AddStudentAsync(string studentName, DateTime? studentDOB, int? studentAge, string studentGender, int? studentMobile, string studentAddress)
    {
        try
        {

            int result = await _dbContext.Procedures.StudentAddAsync(studentName, studentDOB, studentAge, studentGender, studentMobile, studentAddress, false);


            return result;
        }
        catch (Exception ex)
        {

            Console.WriteLine($"Error adding new student: {ex.Message}");
            return -1;
        }
    }

    public virtual async Task<int> StudentUpdateAsync(int? Student_ID, string Student_Name, DateTime? Student_DOB, int? Student_Age, string Student_Gender, int? Student_Mobile, string Student_Address, bool? IsDeleted, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
    {
        try
        {
            var result = await _dbContext.Procedures.StudentUpdateAsync(Student_ID, Student_Name, Student_DOB, Student_Age, Student_Gender, Student_Mobile, Student_Address, IsDeleted);
            return result;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error updating student: {ex.Message}");
            return -1;
        }
    }


    public async Task<StudentViewResult> GetStudentAsync(int studentId)
    {
        try
        {
            var students = await _dbContext.Procedures.StudentViewAsync();
            return students.FirstOrDefault(student => student.Student_ID == studentId);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error getting student: {ex.Message}");
            return null;
        }
    }

    public async Task<int> DeleteStudentAsync(int studentId)
    {
        try
        {

            int result = await _dbContext.Procedures.StudentDeleteAsync(studentId);


            return result;
        }
        catch (Exception ex)
        {

            Console.WriteLine($"Error deleting student: {ex.Message}");
            return -1;
        }
    }
}
