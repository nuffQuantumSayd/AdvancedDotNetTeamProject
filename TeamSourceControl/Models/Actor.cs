using System;
using System.Collections.Generic;

namespace TeamSourceControl.Models;

/// <summary>
/// An actor 
/// </summary>
public partial class Actor
{
    /// <summary>
    /// The actors Id
    /// </summary>
    public int ActorId { get; set; }
    /// <summary>
    /// The actors first name
    /// </summary>
    public string ActorFirstName { get; set; } = null!;
    /// <summary>
    /// The actors last name
    /// </summary>
    public string ActorLastName { get; set; } = null!;
    /// <summary>
    /// The actors following
    /// </summary>
    public bool ActorFollowed { get; set; }
}
