using Microsoft.EntityFrameworkCore;
using PetTracker.API.Data;
using PetTracker.API.Model;

namespace PetTracker.API.Repository;

public class OwnerRepository : IOwnerRepository
{
    private readonly PetContext _petContext;

    public OwnerRepository(PetContext petContext) => _petContext = petContext;

    public IEnumerable<Owner> GetAllOwners()
    {
        return _petContext.Owners.ToList();
    }

    public Owner CreateNewOwner(Owner newOwner)
    {
        _petContext.Owners.Add(newOwner);
        _petContext.SaveChanges();
        return newOwner;
    }
}