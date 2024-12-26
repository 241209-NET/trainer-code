using System;
using System.Collections.Generic;

namespace EFScaffold;

public partial class Pet
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Type { get; set; }

    public DateOnly? Birthday { get; set; }

    public virtual ICollection<Owner> Owners { get; set; } = new List<Owner>();
}
