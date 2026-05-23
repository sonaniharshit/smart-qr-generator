using Microsoft.AspNetCore.Mvc;
using SmartQrGenerator.Web.Models;
using SmartQrGenerator.Web.Services;

namespace SmartQrGenerator.Web.Controllers;

public class HomeController : Controller
{
    private readonly IQrGeneratorService _qrGeneratorService;

    public HomeController(IQrGeneratorService qrGeneratorService)
    {
        _qrGeneratorService = qrGeneratorService;
    }

    public IActionResult Index()
    {
        return View(new QrRequest());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Index(QrRequest model)
    {
        if (!ModelState.IsValid)
            return View(model);

        if (!Uri.TryCreate(model.Url, UriKind.Absolute, out var uriResult) ||
            (uriResult.Scheme != Uri.UriSchemeHttp &&
             uriResult.Scheme != Uri.UriSchemeHttps))
        {
            ModelState.AddModelError(nameof(model.Url), "Please enter a valid website link.");
            return View(model);
        }

        model.QrCodeBase64 = _qrGeneratorService.GenerateQrCode(model.Url!);

        return View(model);
    }
}