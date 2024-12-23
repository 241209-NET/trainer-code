using Microsoft.AspNetCore.Http.HttpResults;
using PetTracker.API.DTO;
using PetTracker.API.Model;
using PetTracker.API.PetException;
using PetTracker.API.Repository;
using PetTracker.API.Util;

namespace PetTracker.API.Service;

public class OwnerService : IOwnerService
{
    private readonly IOwnerRepository _ownerRepository;

    public OwnerService(IOwnerRepository ownerRepository) => _ownerRepository = ownerRepository;
    
    public IEnumerable<Owner> GetAllOwners()
    {
        return _ownerRepository.GetAllOwners();
    }

    public Owner? GetOwnerById(int id)
    {
        var foundOwner = _ownerRepository.GetOwnerById(id);

        if(foundOwner is null) throw new NoOwnerException("That owner does not exist!");

        return foundOwner;
    }

    public Owner CreateNewOwner(OwnerInDTO newOwner)
    {
        Owner fromDTO = newOwner.DTOToOwner();
        Owner fromDTO2 = Utilities.DTOToObject(newOwner);

        var owner = _ownerRepository.CreateNewOwner(fromDTO);
        return owner;
    }

    public Owner DeleteOwnerById(int id)
    {
        try
        {
            var foundOwner = GetOwnerById(id);
            _ownerRepository.DeleteById(foundOwner!);
            return foundOwner!;
        }
        catch(Exception)
        {
            throw;
        }
    }
}