﻿using Zad10.Models;

namespace Zad10;

public class GetAccountResponseModel
{
    public string FirstName { get; set; }
    
    public string LastName { get; set; }
    
    public string Email { get; set; }

    public string? Phone { get; set; }
    
    public string Role { get; set; }
    
    public List<GetProductResponseModel> Cart { get; set; }
    
}