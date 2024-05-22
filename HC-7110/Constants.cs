﻿using HC_7110.Domain.Objects;

namespace HC_7110;

public class Constants
{
    public static ICollection<Library> Libraries = new List<Library>
    {
        new()
        {
            Id = Guid.NewGuid(),
            Name = "The Simpsons",
            Slug = "the-simpsons"
        },
        new()
        {
            Id = Guid.NewGuid(),
            Name = "Family Guy",
            Slug = "family-guy"
        }
    };
}