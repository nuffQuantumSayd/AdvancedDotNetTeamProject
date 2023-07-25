using System;
using System.Collections.Generic;

namespace TeamSourceControl.Models;

public partial class Actor
{
    public int ActorId { get; set; }

    public string ActorFirstName { get; set; } = null!;

    public string ActorLastName { get; set; } = null!;

    public bool ActorFollowed { get; set; }
}
