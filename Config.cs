using Humanizer;
using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace CalamityQoLRestored
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

        [Label("Starter Bag Additions")]
        [Tooltip("Adds back multiple items to the Starter Bag's loot.")]
        [DefaultValue(1)]
        public bool StarterBagAdditions { get; set; }

        [Label("Vanilla Item Recipes")]
        [Tooltip("Adds recipes for many different uncraftable items. TOGGLING REQUIRES A RESTART TO TAKE EFFECT")]
        [DefaultValue(1)]
        public bool VanillaItemRecipes { get; set; }

        [Label("Town NPC Shop Additions")]
        [Tooltip("Reintroduces many different items to the shops of Town NPCs.")]
        [DefaultValue(1)]
        public bool NPCShopChanges { get; set; }

        [Label("Calamity Biome Crate Additions")]
        [Tooltip("Reintroduces many removed items found within Calamity biome crates.")]
        [DefaultValue(1)]
        public bool CrateAdditions { get; set; }

        [Label("Shimmerable Boss Weapon Drops")]
        [Tooltip("Allows for non-legendary weapons dropped by a boss to be shimmered into one another.")]
        [DefaultValue(0)]
        public bool ShimmerCycles { get; set; }

        [Label("Fruit Drop Rate Boost")]
        [Tooltip("Increases the chance for fruits to be dropped from most tree variants.")]
        [DefaultValue(1)]
        public bool FruitChanceBuffs { get; set; }

        [Label("Early Cosmolight")]
        [Tooltip("Allows Cosmolight to be obtainable at the start of Hardmode.")]
        [DefaultValue(1)]
        public bool EarlyCosmolight { get; set; }

        [Label("Early Bakidon")]
        [Tooltip("Allows Bakidon to be obtainable late into pre-Hardmode.")]
        [DefaultValue(1)]
        public bool EarlyBakidon { get; set; }

    }
}