namespace AspNetCoreMvcMovie.Controllers
{
	using Microsoft.AspNetCore.Mvc;

	public class HelloWorldController : Controller
	{
		public string Index()
		{
			return "This is my default action...";
		}

		public ActionResult Welcome(string name, int numTimes)
		{
			ViewData["Message"] = "Hello " + name;
			ViewData["NumTimes"] = numTimes;
			return View();
		}
	}
}