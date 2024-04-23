using DependencyInjectionApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionApp.Controllers;


// GET: /api/Code/
// POST: /api/Code/{code}

// Нельзя использовать текстового файлы, sql и статические переменные
[Route("/api/[controller]")]
public class CodeController : Controller
{
    private readonly CodeService codeService;
    public CodeController(CodeService codeService)
    {
        this.codeService = codeService;
    }
    [HttpGet]
    public string GetCode() {
        return this.codeService.Code;
    }

    [HttpPost("{code}")]
    public IActionResult ChangeCode(string code) {
        this.codeService.Code = code;

        return Ok();
    }
}