using BlazorApp1.Models;

namespace BlazorApp1.Pages
{
    public partial class StudentList
    {
        List<StudentViewResult> students = new List<StudentViewResult>();

        protected override async Task OnInitializedAsync()
        {
            try
            {
                students = await StudentService.GetStudentDataAsync();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching data: {ex.Message}");
            }
        }
    }
}
