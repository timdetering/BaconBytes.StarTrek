namespace BaconBytes.StarTrekNet
{
    internal enum Command
    {
        ListCommands = -1,

        /// <summary>
        /// Set course.
        /// </summary>
        SetCourse,

        /// <summary>
        /// Short-range sensor scan.
        /// </summary>
        ShortRangeScan,

        /// <summary>
        /// Long-range sensor scan.
        /// </summary>
        LongRangeScan,

        /// <summary>
        /// Fire phasers.
        /// </summary>
        FirePhasers,

        /// <summary>
        /// Fire photon torpedoes.
        /// </summary>
        FireTorpedoes,

        /// <summary>
        /// Shield control.
        /// </summary>
        Shields,

        /// <summary>
        /// Damage control report.
        /// </summary>
        DamageControl,

        /// <summary>
        /// Call on library computer.
        /// </summary>
        Library,

        Exit = 9,
    }
}
