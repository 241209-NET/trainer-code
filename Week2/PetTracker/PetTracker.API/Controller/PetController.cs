using Microsoft.AspNetCore.Mvc;
using PetTracker.API.Model;

namespace PetTracker.API.Controller;

[Route("api/[controller]")]
[ApiController]
public class PetController : ControllerBase
{   
    List<Pet> petList = [
        new Pet{Id = 1, Name = "Nyla", Type = "cat"},
        new Pet{Id = 2, Name = "Buddy", Type = "bird"},
        new Pet{Id = 3, Name = "Rover", Type = "dog"},
        new Pet{Id = 4, Name = "Stella", Type = "cat"},
        new Pet{Id = 5, Name = "Cali", Type = "cat"}
    ];

    [HttpGet]
    public IActionResult GetAllPets()
    {
        return Ok(petList);
    }

    [HttpPost]
    public IActionResult CreatePet(Pet newPet)
    {
        petList.Add(newPet);
        return Ok(petList);
    }

    [HttpDelete]
    public IActionResult DeletePet(string name)
    {
        var findPet = petList.FirstOrDefault(p => p.Name == name);

        if(findPet is null) return NotFound();

        petList.Remove(findPet);
        return Ok(petList);
    }

    // [HttpDelete]
    // public IActionResult DeletePet(int id)
    // {

    // }
}