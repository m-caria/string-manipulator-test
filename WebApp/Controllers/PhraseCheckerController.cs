using Microsoft.AspNetCore.Mvc;
using StringManipulator.Models.Phrase;

namespace StringManipulator.Controllers;

public partial class PhraseCheckerController : Controller
{
    public IActionResult Index(PhraseModel model)
    {
        TempData.TryGetValue("largestWord", out object? largestWord);
        ViewData.Add("largestWord", (string?)largestWord);

        return View(model);
    }

    [HttpPost]
    public IActionResult GetLargestWord(CheckLargestWordPhraseModel model)
    {
        TempData.Add("largestWord", model.GetPhraseWord());

        return RedirectToAction("Index", model);
    }
}