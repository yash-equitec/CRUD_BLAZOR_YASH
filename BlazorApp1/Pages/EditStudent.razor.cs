using BlazorApp1.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Pages
{
    public partial class EditStudent
    {
        private StudentViewResult student;

        [Parameter]
        public int StudentId { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {

                student = await StudentService.GetStudentAsync(StudentId);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error fetching student data: {ex.Message}");
            }
        }

        private async Task UpdateStudent()
        {
            try
            {

                int result = await StudentService.StudentUpdateAsync(
                    student.Student_ID,
                    student.Student_Name,
                    student.Student_DOB,
                    student.Student_Age,
                    student.Student_Gender,
                    student.Student_Mobile,
                    student.Student_Address,
                    student.IsDeleted);

                if (result > 0)
                {

                    NavigationManager.NavigateTo("/studentlist");
                }
                else
                {

                    Console.WriteLine("Update failed");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating student: {ex.Message}");
            }
        }
    }
}
