using System;
using System.Collections.Generic;

namespace TeamSourceControl.Models;

/// <summary>
/// A movie
/// </summary>
public partial class Movie
{
    private int _movieId;
    /// <summary>
    /// The movies Id
    /// </summary>
    public int MovieId
    {
        get { return _movieId; }
        set { _movieId = value; }
    }

    /// <summary>
    /// The name of the movie
    /// </summary>
    public string Title { get; set; } = null!;
    /// <summary>
    /// The movie genre
    /// </summary>
    public string Genre { get; set; } = null!;
    /// <summary>
    /// The status of the movie
    /// </summary>
    public string Status { get; set; } = null!;
    /// <summary>
    /// The movie release year
    /// </summary>
    public DateTime ReleaseDate { get; set; }
    /// <summary>
    /// The total runtime of the movie
    /// </summary>
    public TimeSpan RunTime { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    public Movie(string title, string genre, string status, DateTime releaseDate, TimeSpan runtime)
    {
        Title = title;
        Genre = genre;
        Status = status;
        ReleaseDate = releaseDate;
        RunTime = runtime;
    }

}
