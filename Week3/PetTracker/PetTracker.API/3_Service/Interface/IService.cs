using PetTracker.API.Model;

namespace PetTracker.API.Service;

public interface IPetService
{
    Pet CreateNewPet(Pet newPet);
    IEnumerable<Pet> GetAllPets();
    Pet? GetPetById(int id);
    IEnumerable<Pet> GetPetByName(string name);
    Pet? DeletePetById(int id);
}

public interface IOwnerService
{
    IEnumerable<Owner> GetAllOwners();
    Owner CreateNewOwner(Owner newOwner);
}