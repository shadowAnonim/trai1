using System;
using System.Collections.Generic;

namespace AvaloniaApplication1.Data;

public partial class Client
{
    public string LastName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string Gender { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string? Photo { get; set; }

    public DateOnly BirthDate { get; set; }

    public string Email { get; set; } = null!;

    public DateOnly RegistrationDate { get; set; }

    public int Id { get; set; }
}
