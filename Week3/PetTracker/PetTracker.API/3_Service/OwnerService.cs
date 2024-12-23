using PetTracker.API.Model;
using PetTracker.API.Repository;

namespace PetTracker.API.Service;

public class OwnerService : IOwnerService
{
    private readonly IOwnerRepository _ownerRepository;

    public OwnerService(IOwnerRepository ownerRepository) => _ownerRepository = ownerRepository;
    
    public IEnumerable<Owner> GetAllOwners()
    {
        return _ownerRepository.GetAllOwners();
    }

    public Owner CreateNewOwner(Owner newOwner)
    {
        var owner = _ownerRepository.CreateNewOwner(newOwner);
        return owner;
    }
}