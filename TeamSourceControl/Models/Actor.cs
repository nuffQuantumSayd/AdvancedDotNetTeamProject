using System;
using System.Collections.Generic;

namespace TeamSourceControl.Models;

/// <summary>
/// An actor 
/// </summary>
public partial class Actor
{
    private int _actorId;
    /// <summary>
    /// The actors Id
    /// </summary>
    public int ActorId 
    {
        get { return _actorId; }
        set { _actorId = value; } 
    }

    /// <summary>
    /// The actors first name
    /// </summary>
    public string FirstName { get; set; } = null!;
    /// <summary>
    /// The actors last name
    /// </summary>
    public string LastName { get; set; } = null!;
    /// <summary>
    /// The actors following
    /// </summary>
    public bool Followed { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    public Actor(string fname, string lname, bool followed)
    {
        FirstName = fname;
        LastName = lname;
        Followed = followed;
    }
}
