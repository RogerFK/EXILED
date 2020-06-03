// -----------------------------------------------------------------------
// <copyright file="Map.cs" company="Exiled Team">
// Copyright (c) Exiled Team. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace Exiled.Events.Handlers
{
    using Exiled.API.Extensions;
    using Exiled.Events.Handlers.EventArgs;
    using static Exiled.Events.Events;

    /// <summary>
    /// Map related events.
    /// </summary>
    public class Map
    {
        /// <summary>
        /// Invoked before placing decals.
        /// </summary>
        public static event CustomEventHandler<PlacingDecalEventArgs> PlacingDecal;

        /// <summary>
        /// Invoked before placing bloods.
        /// </summary>
        public static event CustomEventHandler<PlacingBloodEventArgs> PlacingBlood;

        /// <summary>
        /// Invoked before announcing the light containment zone decontamination.
        /// </summary>
        public static event CustomEventHandler<AnnouncingDecontaminationEventArgs> AnnouncingDecontamination;

        /// <summary>
        /// Invoked before announcing an SCP termination.
        /// </summary>
        public static event CustomEventHandler<AnnouncingScpTerminationEventArgs> AnnouncingScpTermination;

        /// <summary>
        /// Invoked before announcing the NTF entrance.
        /// </summary>
        public static event CustomEventHandler<AnnouncingNtfEntranceEventArgs> AnnouncingNtfEntrance;

        /// <summary>
        /// Invoked before interacting with a door.
        /// </summary>
        public static event CustomEventHandler<InteractingDoorEventArgs> InteractingDoor;

        /// <summary>
        /// Invoked before interacting with an elevator.
        /// </summary>
        public static event CustomEventHandler<InteractingElevatorEventArgs> InteractingElevator;

        /// <summary>
        /// Invoked before interacting with a locker.
        /// </summary>
        public static event CustomEventHandler<InteractingLockerEventArgs> InteractingLocker;

        /// <summary>
        /// Invoked before triggering a tesla.
        /// </summary>
        public static event CustomEventHandler<TriggeringTeslaEventArgs> TriggeringTesla;

        /// <summary>
        /// Invoked before upgrading items in the SCP-914 machine.
        /// </summary>
        public static event CustomEventHandler<UpgradingScp914ItemsEventArgs> UpgradingScp914Items;

        /// <summary>
        /// Invoked before unlocking a generator.
        /// </summary>
        public static event CustomEventHandler<UnlockingGeneratorEventArgs> UnlockingGenerator;

        /// <summary>
        /// Invoked before opening a generator.
        /// </summary>
        public static event CustomEventHandler<OpeningGeneratorEventArgs> OpeningGenerator;

        /// <summary>
        /// Invoked befroe closing a generator.
        /// </summary>
        public static event CustomEventHandler<ClosingGeneratorEventArgs> ClosingGenerator;

        /// <summary>
        /// Invoked before inserting a generator.
        /// </summary>
        public static event CustomEventHandler<InsertingGeneratorTabletEventArgs> InsertingGeneratorTablet;

        /// <summary>
        /// Invoked before ejecting a generator.
        /// </summary>
        public static event CustomEventHandler<EjectingGeneratorTabletEventArgs> EjectingGeneratorTablet;

        /// <summary>
        /// Invoked after a generator has been activated.
        /// </summary>
        public static event CustomEventHandler<GeneratorActivatedEventArgs> GeneratorActivated;

        /// <summary>
        /// Invoked before decontaminating the light containment zone.
        /// </summary>
        public static event CustomEventHandler<DecontaminatingEventArgs> Decontaminating;

        /// <summary>
        /// Invoked before stopping the warhead.
        /// </summary>
        public static event CustomEventHandler<StoppingWarheadEventArgs> StoppingWarhead;

        /// <summary>
        /// Invoked before starting the warhead.
        /// </summary>
        public static event CustomEventHandler<StartingWarheadEventArgs> StartingWarhead;

        /// <summary>
        /// Invoked after the warhead has been detonated.
        /// </summary>
        public static event CustomEventHandler WarheadDetonated;

        /// <summary>
        /// Called before placing a decal.
        /// </summary>
        /// <param name="ev">The <see cref="PlacingDecalEventArgs"/> instance.</param>
        public static void OnPlacingDecal(PlacingDecalEventArgs ev) => PlacingDecal.InvokeSafely(ev);

        /// <summary>
        /// Called before placing bloods.
        /// </summary>
        /// <param name="ev">The <see cref="PlacingDecalEventArgs"/> instance.</param>
        public static void OnPlacingBlood(PlacingBloodEventArgs ev) => PlacingBlood.InvokeSafely(ev);

        /// <summary>
        /// Called before announcing the light containment zone decontamination.
        /// </summary>
        /// <param name="ev">The <see cref="PlacingDecalEventArgs"/> instance.</param>
        public static void OnAnnouncingDecontamination(AnnouncingDecontaminationEventArgs ev) => AnnouncingDecontamination.InvokeSafely(ev);

        /// <summary>
        /// Called before announcing an SCP termination.
        /// </summary>
        /// <param name="ev">The <see cref="PlacingDecalEventArgs"/> instance.</param>
        public static void OnAnnouncingScpTermination(AnnouncingScpTerminationEventArgs ev) => AnnouncingScpTermination.InvokeSafely(ev);

        /// <summary>
        /// Called before announcing the NTF entrance.
        /// </summary>
        /// <param name="ev">The <see cref="PlacingDecalEventArgs"/> instance.</param>
        public static void OnAnnouncingNtfEntrance(AnnouncingNtfEntranceEventArgs ev) => AnnouncingNtfEntrance.InvokeSafely(ev);

        /// <summary>
        /// Called before interacting with a door.
        /// </summary>
        /// <param name="ev">The <see cref="PlacingDecalEventArgs"/> instance.</param>
        public static void OnInteractingDoor(InteractingDoorEventArgs ev) => InteractingDoor.InvokeSafely(ev);

        /// <summary>
        /// Called before interacting with an elevator.
        /// </summary>
        /// <param name="ev">The <see cref="PlacingDecalEventArgs"/> instance.</param>
        public static void OnInteractingElevator(InteractingElevatorEventArgs ev) => InteractingElevator.InvokeSafely(ev);

        /// <summary>
        /// Called before interacting with a locker.
        /// </summary>
        /// <param name="ev">The <see cref="PlacingDecalEventArgs"/> instance.</param>
        public static void OnInteractingLocker(InteractingLockerEventArgs ev) => InteractingLocker.InvokeSafely(ev);

        /// <summary>
        /// Called before triggering a tesla.
        /// </summary>
        /// <param name="ev">The <see cref="TriggeringTeslaEventArgs"/> instance.</param>
        public static void OnTriggeringTesla(TriggeringTeslaEventArgs ev) => TriggeringTesla.InvokeSafely(ev);

        /// <summary>
        /// Called before upgrading items in the SCP-914 machine.
        /// </summary>
        /// <param name="ev">The <see cref="UpgradingScp914ItemsEventArgs"/> instance.</param>
        public static void OnUpgradingScp914Items(UpgradingScp914ItemsEventArgs ev) => UpgradingScp914Items.InvokeSafely(ev);

        /// <summary>
        /// Called before unlocking a generator.
        /// </summary>
        /// <param name="ev">The <see cref="UnlockingGeneratorEventArgs"/> instance.</param>
        public static void OnUnlockingGenerator(UnlockingGeneratorEventArgs ev) => UnlockingGenerator.InvokeSafely(ev);

        /// <summary>
        /// Called before opening a generator.
        /// </summary>
        /// <param name="ev">The <see cref="OpeningGeneratorEventArgs"/> instance.</param>
        public static void OnOpeningGenerator(OpeningGeneratorEventArgs ev) => OpeningGenerator.InvokeSafely(ev);

        /// <summary>
        /// Called before closing a generator.
        /// </summary>
        /// <param name="ev">The <see cref="ClosingGeneratorEventArgs"/> instance.</param>
        public static void OnClosingGenerator(ClosingGeneratorEventArgs ev) => ClosingGenerator.InvokeSafely(ev);

        /// <summary>
        /// Called before inserting a generator.
        /// </summary>
        /// <param name="ev">The <see cref="InsertingGeneratorTabletEventArgs"/> instance.</param>
        public static void OnInsertingGeneratorTablet(InsertingGeneratorTabletEventArgs ev) => InsertingGeneratorTablet.InvokeSafely(ev);

        /// <summary>
        /// Called before ejecting a generator.
        /// </summary>
        /// <param name="ev">The <see cref="EjectingGeneratorTabletEventArgs"/> instance.</param>
        public static void OnEjectingGeneratorTablet(EjectingGeneratorTabletEventArgs ev) => EjectingGeneratorTablet.InvokeSafely(ev);

        /// <summary>
        /// Called after a generator has been activated.
        /// </summary>
        /// <param name="ev">The <see cref="GeneratorActivatedEventArgs"/> instance.</param>
        public static void OnGeneratorActivated(GeneratorActivatedEventArgs ev) => GeneratorActivated.InvokeSafely(ev);

        /// <summary>
        /// Called before decontaminating the light containment zone.
        /// </summary>
        /// <param name="ev">The <see cref="DecontaminatingEventArgs"/> instance.</param>
        public static void OnDecontaminating(DecontaminatingEventArgs ev) => Decontaminating.InvokeSafely(ev);

        /// <summary>
        /// Called before stopping the warhead.
        /// </summary>
        /// <param name="ev">The <see cref="StoppingWarheadEventArgs"/> instance.</param>
        public static void OnStoppingWarhead(StoppingWarheadEventArgs ev) => StoppingWarhead.InvokeSafely(ev);

        /// <summary>
        /// Called before starting the warhead.
        /// </summary>
        /// <param name="ev">The <see cref="StartingWarheadEventArgs"/> instance.</param>
        public static void OnStartingWarhead(StartingWarheadEventArgs ev) => StartingWarhead.InvokeSafely(ev);

        /// <summary>
        /// Called after the warhead has been detonated.
        /// </summary>
        public static void OnWarheadDetonated() => WarheadDetonated.InvokeSafely();
    }
}