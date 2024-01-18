using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Pages
{
    public partial class RestoreStudent
    {
        [Parameter]
        public int studentId { get; set; }

        private async Task RestoreStudentAsync()
        {
            try
            {
                int result = await StudentService.RestoreStudentAsync(studentId);

                if (result > 0)
                {
                    NavigationManager.NavigateTo("/studentlist");
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting student: {ex.Message}");
            }
        }
    }
}
