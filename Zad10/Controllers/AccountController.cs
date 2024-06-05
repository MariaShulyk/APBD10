using Zad10.Exceptions;
using Zad10.Services;
using Microsoft.AspNetCore.Mvc;

namespace Zad10.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AccountsController(IDbService _dbService) : ControllerBase
{

    [HttpGet("{accountId:int}")]
    public async Task<IActionResult> GetAccount(int accountId, CancellationToken cancellationToken)
    {
        try
        {
            var result = await _dbService.GetAccountByIdAsync(accountId, cancellationToken);
            if (result == null)
            {
                return NotFound($"Account with id: {accountId} does not exist");
            }

            return Ok(result);
        }
        catch (NotFoundException ex)
        {
            return NotFound(ex.Message);
        }
    }
}