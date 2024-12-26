using Microsoft.EntityFrameworkCore;
using PetTracker.API.Data;
using PetTracker.API.Model;

namespace PetTracker.API.Repository;

public class PetRepository : IPetRepository
{
    //Need the DB Object to work with.
    private readonly PetContext _petContext;

    public PetRepository(PetContext petContext) => _petContext = petContext;

    public IEnumerable<Pet> GetAllPets()
    {
        return _petContext.Pets
            .Include(p => p.Owners)
            .ToList();
    }

    public Pet CreateNewPet(Pet newPet)
    {
        //Insert into Pets Values (newPet)
        _petContext.Pets.Add(newPet);
        _petContext.SaveChanges();

        //Synchronous VS Asynchronous
        _petContext.SaveChangesAsync();


        return newPet;
    }

    public Pet? GetPetById(int id)
    {
        return _petContext.Pets.Find(id);
    }

    public void DeletePetById(int id)
    {
        var pet = GetPetById(id);
        _petContext.Pets.Remove(pet!);
        _petContext.SaveChanges();
    }

    public IEnumerable<Pet> GetPetByName(string name)
    {
       var petList = _petContext.Pets.Where(p => p.Name.Contains(name)).ToList();
       return petList;
    }
}