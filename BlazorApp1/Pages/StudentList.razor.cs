using BlazorApp1.Models;
using System.Linq;
namespace BlazorApp1.Pages
{
    public partial class StudentList
    {
        List<StudentViewResult> students = new List<StudentViewResult>();
        List<GetStudentSkillsResult> skills = new List<GetStudentSkillsResult>();
        public Dictionary<int, string> result = new Dictionary<int, string>();
        protected override async Task OnInitializedAsync()
        {
            try
            {
                students = await StudentService.GetStudentDataAsync();
                foreach (var student in students)
                {
                    skills = await StudentService.Skills(student.Student_ID);
                    var userSkills = skills.Select(skill => skill.SkillsName);
                    result[student.Student_ID] = string.Join(", ", userSkills);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching data: {ex.Message}");
            }
        }
    }
}
