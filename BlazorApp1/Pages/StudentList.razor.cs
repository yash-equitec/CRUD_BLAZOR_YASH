using BlazorApp1.Models;
using System.Linq;

namespace BlazorApp1.Pages
{
    public partial class StudentList
    {
        List<StudentViewResult> students = new List<StudentViewResult>();
        List<GetStudentSkillsResult> skills = new List<GetStudentSkillsResult>();  
        public Dictionary<int,string> result = new Dictionary<int,string>();    
        protected override async Task OnInitializedAsync()
        {
            try
            {
                students = await StudentService.GetStudentDataAsync();
                skills = await StudentService.Skills();
                foreach (var student in skills) 
                {
                    var user = skills
                        .Where(student => student.StudentId == student.StudentId)
                        .Select(student => student.SkillsName);
                    result[student.StudentId] = string.Join(", ", user);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching data: {ex.Message}");
            }
        }
    }
}
