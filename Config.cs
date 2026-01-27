using Humanizer;
using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace CalamityQoLRestored
{
    public class CalamityQoLRestoredConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [Label("Starter Bag Additions")]
        [Tooltip("Adds back multiple items to the Starter Bag's loot. Toggling may require a restart to take effect!")]
        [DefaultValue(1)]
        public bool StarterBagAdditions { get; set; }

        [Label("Vanilla Item Recipes")]
        [Tooltip("Adds recipes for many different uncraftable items. Toggling may require a restart to take effect!")]
        [DefaultValue(1)]
        public bool VanillaItemRecipes { get; set; }

        [Label("Town NPC Shop Additions")]
        [Tooltip("Reintroduces many different items to the shops of Town NPCs. Toggling may require a restart to take effect!")]
        [DefaultValue(1)]
        public bool NPCShopChanges { get; set; }

        [Label("Calamity Biome Crate Additions")]
        [Tooltip("Reintroduces many removed items found within Calamity biome crates. Toggling may require a restart to take effect!")]
        [DefaultValue(1)]
        public bool CrateAdditions { get; set; }

        [Label("Enemy Drop Rate Boost")]
        [Tooltip("Reverts reductions to many different item drop rates.")]
        [DefaultValue(1)]
        public bool EnemyDropRateChanges { get; set; }

        [Label("Universal Expert Item Drops")]
        [Tooltip("Allows expert-exclusive items to be available in Normal mode. Toggling may require a restart to take effect!")]
        [DefaultValue(1)]
        public bool ExpertGatekeepRemoval { get; set; }

        [Label("Fruit Drop Rate Boost")]
        [Tooltip("Increases the chance for fruits to be dropped from most tree variants.")]
        [DefaultValue(1)]
        public bool FruitChanceBuffs { get; set; }

        [Label("Early Cosmolight")]
        [Tooltip("Allows Cosmolight to be obtainable at the start of Hardmode. Toggling may require a restart to take effect!")]
        [DefaultValue(1)]
        public bool EarlyCosmolight { get; set; }


        [Header("New Additions")]

        [Label("Early Bakidon")]
        [Tooltip("Allows Bakidon to be obtainable late into pre-Hardmode. Toggling may require a restart to take effect!")]
        [DefaultValue(0)]
        public bool EarlyBakidon { get; set; }

        [Label("Shimmerable Boss Weapon Drops")]
        [Tooltip("Allows for non-legendary weapons dropped by a boss to be shimmered into one another. Toggling may require a restart to take effect!")]
        [DefaultValue(0)]
        public bool ShimmerCycles { get; set; }

    }
}