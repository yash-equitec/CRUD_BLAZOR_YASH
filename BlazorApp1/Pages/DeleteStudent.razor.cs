using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Pages
{
    public partial class DeleteStudent
    {
        [Parameter]
        public int studentId { get; set; }

        private async Task DeleteStudentAsync()
        {
            try
            {
                int result = await StudentService.DeleteStudentAsync(studentId);

                if (result > 0)
                {
                    NavigationManager.NavigateTo("/studentlist");
                }
                else
                {
                    // Handle failure scenario
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting student: {ex.Message}");
            }
        }
    }
}
