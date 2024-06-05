using Microsoft.AspNetCore.Mvc;
using Zad10.Exceptions;
using Zad10.RequestModel;
using Zad10.Services;

namespace Zad10.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController(IDbService _dbService) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateProduct(PostProductRequestModel request, CancellationToken cancellationToken)
    {
        try
        {
            await _dbService.AddProductAsync(request, cancellationToken);
            return Created();
        }
        catch (NotFoundException ex)
        {
            return NotFound(ex.Message);
        }
    }
}