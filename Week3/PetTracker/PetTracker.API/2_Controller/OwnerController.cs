using Microsoft.AspNetCore.Mvc;
using PetTracker.API.Model;
using PetTracker.API.Service;

namespace PetTracker.API.Controller;

[Route("api/[controller]")]
[ApiController]
public class OwnerController : ControllerBase
{   
    private readonly IOwnerService _ownerService;

    public OwnerController(IOwnerService ownerService) => _ownerService = ownerService;

    [HttpGet]
    public IActionResult GetAllOwners()
    {
        var ownerList = _ownerService.GetAllOwners();
        return Ok(ownerList);
    }

    [HttpPost]
    public IActionResult CreateNewOwner(Owner newOwner)
    {
        var owner = _ownerService.CreateNewOwner(newOwner);
        return Ok(owner);
    }
}