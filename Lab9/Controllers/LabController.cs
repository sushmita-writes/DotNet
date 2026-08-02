using Microsoft.AspNetCore.Mvc;

namespace Lab9.Controllers
{
    public class LabController : Controller
    {
        [Route("ContentResult-interface")] // this is attribute
        public ContentResult ContentPage()
        {
            return Content("ContentResult Interface to return content.");
        }

        [Route("JsonResult-interface")]
        public IActionResult JsonPage()
        {
            var data = new { Name = "Sushmita", Id = 62, Occupation = "Student" };
            return Json(data);
        }

        [Route("PartialViewResult-interface")]
        public IActionResult PartialViewPage()
        {
            return PartialView("~/Views/Lab/Sushmita.cshtml");
        }

        [Route("FileResult-interface")]
        public IActionResult FilePage()
        {
            return File("~/files/dotnetCoverPage.pdf", "application/pdf", "CP.pdf");
        }

        public IActionResult Sushmita()
        {
            return View();
        }

    }
}
