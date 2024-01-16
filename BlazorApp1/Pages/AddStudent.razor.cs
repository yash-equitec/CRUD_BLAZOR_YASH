using BlazorApp1.Models;

namespace BlazorApp1.Pages
{
    public partial class AddStudent
    {
        StudentViewResult newStudent = new StudentViewResult();

        private async Task AddNewStudent()
        {
            try
            {
                int newStudentId = await StudentService.AddStudentAsync(newStudent.Student_Name, newStudent.Student_DOB, newStudent.Student_Age, newStudent.Student_Gender, newStudent.Student_Mobile, newStudent.Student_Address);

                NavigationManager.NavigateTo("/studentlist");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding new student: {ex.Message}");
            }
        }
    }
}
