using System.Collections.Generic;

namespace App.ViewModels
{
    public class DepartmentViewModel
    {
        public string DepartmentName { get; set; } = string.Empty;
        public List<string> StudentNamesOver25 { get; set; } = new List<string>();
        public string DepartmentState { get; set; } = string.Empty; // "Main" / "Branch"
    }
}
