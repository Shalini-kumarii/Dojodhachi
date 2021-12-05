
using Microsoft.AspNetCore.Mvc;

using Dojodhachi.Models;
namespace DojoController.Controllers     //be sure to use your own project's namespace!
{
    public class DojoController : Controller   //remember inheritance??
    {
        [HttpGet("")]      // Both lines can be written in one line
        public ViewResult Index()
        {
            // var model = new Dojo();
            //     model.Location = "Bellevue";
           // return View(model);
           return View();
        }

        [HttpPost]
        [Route("result")]
        public IActionResult Result(Dojo fromForm)
        {
            // return View("result",result);
            if (ModelState.IsValid)
          {
        //         var msg = result.Location + " selected";
        // return RedirectToAction("Result", new { message = msg });
                // do somethng!  maybe insert into db?  then we will redirect
               // return View("Result");
                return View(fromForm);
            }
            
                // Oh no!  We need to return a ViewResponse to preserve the ModelState, and the errors it now contains!
                return View("Index");
        
        }
        [HttpGet("result")]

        public ViewResult Result()

        {

            return View();

        }
    }
}

