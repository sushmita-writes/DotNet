/*
        TASK 1: Add Controller
                Right Click on Controllers folder > Add > Controller 
                > MVC Controller - Empty > Name it as xyzController
        */
// TASK 2: Add a new Action Method
/*
TASK 3: Add a new View for the Action Method
        Right click on Action Method > Add View
        Select 'Razor View' and click Add
        Keep these views in Student Folder

        OR copy a view from Home folder and paste it in the Student folder

        Write html codes in the .cshtml view files

        Acess these pages using URL eg: localhost:7083/Student/List
*/
/*
TASK 4: Change Layout
        Goto Views Folder > Shared folder > _Layout.cshtml
        Add new view pages link to Navigation
        make these changes to attributes of <a> tag:
                asp-controller="Student" asp-action="Info"

        Make other changes as you wish
 */
/*
TASK 5: Use different layout for specific pages
        Copy _Layout.cshtml and paste it in Student folder (rename)

        Write C# code in .cshtml files within @{ }:
                Layout = "_LayoutStudent.cshtml"; 
 */
/*
TASK 6: Place static files in wwwroot folder
        eg: images, video, css, js files
 */

using Microsoft.AspNetCore.Mvc;

namespace Labx.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            return View();
        }
        public IActionResult Info()
        {
            
            return View();
        }
    }
}
