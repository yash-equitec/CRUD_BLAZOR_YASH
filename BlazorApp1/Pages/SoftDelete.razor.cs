using BlazorApp1.Models;

namespace BlazorApp1.Pages
{
    public partial class SoftDelete
    {
        List<SoftDeleteResult> students = new List<SoftDeleteResult>();
        protected override async Task OnInitializedAsync()
        {
            try
            {
                students = await StudentService.SoftDeleteAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching data: {ex.Message}");
            }
        }
        private void RestoreStudent(int studentId)
        {
            NavigationManager.NavigateTo($"/restorestudent/{studentId}");
        }
    }
}
