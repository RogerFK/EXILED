// -----------------------------------------------------------------------
// <copyright file="RespawningTeamEventArgs.cs" company="Exiled Team">
// Copyright (c) Exiled Team. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace Exiled.Events.EventArgs
{
    using System;
    using System.Collections.Generic;

    using Exiled.API.Features;

    using Respawning;

    /// <summary>
    /// Contains all informations before spawning a wave of <see cref="Team.CHI"/> or <see cref="Team.MTF"/>..
    /// </summary>
    public class RespawningTeamEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RespawningTeamEventArgs"/> class.
        /// </summary>
        /// <param name="players"><inheritdoc cref="Players"/></param>
        /// <param name="maximumRespawnAmount"><inheritdoc cref="MaximumRespawnAmount"/></param>
        /// <param name="nextKnownTeam"><inheritdoc cref="NextKnownTeam"/></param>
        public RespawningTeamEventArgs(List<Player> players, int maximumRespawnAmount, SpawnableTeamType nextKnownTeam)
        {
            Players = players;
            MaximumRespawnAmount = maximumRespawnAmount;
            NextKnownTeam = nextKnownTeam;
        }

        /// <summary>
        /// Gets the list of players that are going to be respawned.
        /// </summary>
        public List<Player> Players { get; }

        /// <summary>
        /// Gets or sets the maximum amount of respawnable players.
        /// </summary>
        public int MaximumRespawnAmount { get; set; }

        /// <summary>
        /// Gets or sets a value indicating what the next respawnable team is..
        /// </summary>
        public SpawnableTeamType NextKnownTeam { get; set; }
    }
}
