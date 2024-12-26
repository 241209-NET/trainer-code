using System;
using System.Collections.Generic;

namespace EFScaffold;

public partial class Owner
{
    public int Id { get; set; }

    public string? Address { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Pet> Pets { get; set; } = new List<Pet>();
}
