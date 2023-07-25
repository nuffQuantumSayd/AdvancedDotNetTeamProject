﻿using System;
using System.Collections.Generic;

namespace TeamSourceControl.Models;

public partial class MoviesWithActor
{
    public int? MovieId { get; set; }

    public int? ActorId { get; set; }

    public virtual Actor? Actor { get; set; }

    public virtual Movie? Movie { get; set; }
}
