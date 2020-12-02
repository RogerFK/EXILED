// -----------------------------------------------------------------------
// <copyright file="ElevatorType.cs" company="Exiled Team">
// Copyright (c) Exiled Team. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace Exiled.API.Enums
{
    /// <summary>
    /// The unique type of elevator.
    /// </summary>
    public enum ElevatorType : byte
    {
        /// <summary>
        /// Unknown elevator Type.
        /// </summary>
        Unknown,

        /// <summary>
        /// Entrance Gate A elevator.
        /// </summary>
        GateA,

        /// <summary>
        /// Entrance Gate B elevator.
        /// </summary>
        GateB,

        /// <summary>
        /// Heavy Containment Zone Nuke elevator.
        /// </summary>
        Nuke,

        /// <summary>
        /// Heavy Containment Zone SCP-049 elevator.
        /// </summary>
        Scp049,

        /// <summary>
        /// Light Containment Zone checkpoint A elevator.
        /// </summary>
        LczA,

        /// <summary>
        /// Light Containment Zone checkpoint B elevator.
        /// </summary>
        LczB,
    }
}
