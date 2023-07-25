using System;
using System.Collections.Generic;

namespace TeamSourceControl.Models;

public partial class Movie
{
    public int MovieId { get; set; }

    public string MovieName { get; set; } = null!;

    public string MovieGenre { get; set; } = null!;

    public string MovieStatus { get; set; } = null!;

    public DateTime ReleaseYear { get; set; }

    public TimeSpan RunTime { get; set; }
}
