//Data transfer object
using PetTracker.API.Model;

namespace PetTracker.API.DTO;

public class OwnerInDTO
{
    public required string Name { get; set; }
    public string? Address { get; set; }

    public Owner DTOToOwner()
    {
        return new Owner{Name = this.Name, Address = this.Address};
    }
}