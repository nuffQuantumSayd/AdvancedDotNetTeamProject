using System;
using System.Collections.Generic;

namespace TeamSourceControl.Models;

/// <summary>
/// A movie
/// </summary>
public partial class Movie
{
    /// <summary>
    /// The movies Id
    /// </summary>
    public int MovieId { get; set; }
    /// <summary>
    /// The name of the movie
    /// </summary>
    public string MovieName { get; set; } = null!;
    /// <summary>
    /// The movie genre
    /// </summary>
    public string MovieGenre { get; set; } = null!;
    /// <summary>
    /// The status of the movie
    /// </summary>
    public string MovieStatus { get; set; } = null!;
    /// <summary>
    /// The movie release year
    /// </summary>
    public DateTime ReleaseYear { get; set; }
    /// <summary>
    /// The total runtime of the movie
    /// </summary>
    public TimeSpan RunTime { get; set; }
}
