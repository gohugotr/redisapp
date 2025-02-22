using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace RedisInMemoryApp.Controllers;

public class ProductController : Controller
{
    private IMemoryCache _memoryCache;
    
    public ProductController(IMemoryCache memoryCache)
    {
        _memoryCache = memoryCache;
    }
    // GET
    public IActionResult Index()
    {
       
        return View();
    }
}