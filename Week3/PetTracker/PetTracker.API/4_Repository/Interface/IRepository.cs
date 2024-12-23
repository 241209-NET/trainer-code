using PetTracker.API.Model;

namespace PetTracker.API.Repository;

public interface IPetRepository
{
    //CRUD
    Pet CreateNewPet(Pet newPet); 
    IEnumerable<Pet> GetAllPets(); 
    Pet? GetPetById(int id); 
    IEnumerable<Pet> GetPetByName(string name);
    void DeletePetById(int id);    
}

public interface IOwnerRepository
{
    //CRUD
    IEnumerable<Owner> GetAllOwners();
    Owner CreateNewOwner(Owner newOwner);    
}