using System;
using System.Collections.Generic;

namespace TeamSourceControl.Models;

/// <summary>
/// The Movies that can have multiple actors
/// </summary>
public partial class MoviesWithActor
{
    /// <summary>
    /// The movie Id
    /// </summary>
    public int? MovieId { get; set; }
    /// <summary>
    /// The Actor Id
    /// </summary>
    public int? ActorId { get; set; }
    /// <summary>
    /// The actor
    /// </summary>
    public virtual Actor? Actor { get; set; }
    /// <summary>
    /// The movie
    /// </summary>
    public virtual Movie? Movie { get; set; }
}
