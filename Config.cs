using Humanizer;
using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace EclipsedHeart
{
    public class CalamityQoLRestoredConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [Label("Health Loss Conversion Rate")]
        [Tooltip("The percentage of damage taken that is converted into permanent health loss.")]
        [Range(0f, 1f)]
        [DefaultValue(0.25f)]
        public float HealthLossConversionRate { get; set; }

        [Label("Barrier Crush Delay")]
        [Tooltip("The amount of time in ticks it takes for barrier to be regained after damage.")]
        [Range(0, 300)]
        [DefaultValue(60)]
        public int BarrierCrushDelay { get; set; }

        [Label("Early Loop Spawns")]
        [Tooltip("Allows elite and lunar enemies to spawn before looping with reduced damage reduction.")]
        [DefaultValue(0)]
        public bool EarlyEliteSpawns { get; set; }

        [Label("Enraged Bosses")]
        [Tooltip("Bosses attack incredibly often, stacks with Blood Moon.")]
        [DefaultValue(0)]
        public bool EnragedBosses { get; set; }

        [Label("Eclipsed Heart Items")]
        [Tooltip("Adds brand new items to find in runs! *Requires a restart to take effect*")]
        [DefaultValue(0)]
        public bool NewItems { get; set; }

    }
}