using Microsoft.AspNetCore.Mvc;
using PetTracker.API.Model;
using PetTracker.API.Service;

namespace PetTracker.API.Controller;

[Route("api/[controller]")]
[ApiController]
public class PetController : ControllerBase
{   
    private readonly IPetService _petService;

    public PetController(IPetService petService)
    {
        _petService = petService;
    }

    [HttpGet]
    public IActionResult GetAllPets()
    {
        var petList = _petService.GetAllPets();        
        return Ok(petList);
    }

    [HttpPost]
    public IActionResult CreateNewPet(Pet newPet)
    {
        var pet = _petService.CreateNewPet(newPet);
        return Ok(pet);
    }

    [HttpGet("{id}")]
    public IActionResult GetPetById(int id)
    {
        var findPet = _petService.GetPetById(id);

        if(findPet is null) return NotFound();
        
        return Ok(findPet);
    }

    [HttpDelete]
    public IActionResult DeletePet(int id)
    {
        var deletePet = _petService.DeletePetById(id);

        if(deletePet is null) return NotFound();

        return Ok(deletePet);
    }

    // [HttpDelete]
    // public IActionResult DeletePet(int id)
    // {

    // }
}