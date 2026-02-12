using CalamityMod;
using CalamityMod.Items.Materials;
using CalamityMod.Items.Tools.ClimateChange;
using CalamityMod.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CalamityQoLRestored.Content
{
    public class ModifyRecipes : ModSystem
    {
        public override void AddRecipes() => ModifyRecipes.HandleRecipes();

        #region Recipe Group Definitions
        public static int HardmodeAnvil, HardmodeForge, AnyLargeGem, AnyFood;
        public static int AnyCopperOre, AnySilverOre, AnyGoldOre, AnyEvilOre, AnyCobaltOre, AnyMythrilOre, AnyAdamantiteOre;
        public static int AnyCopperBar, AnySilverBar, AnyGoldBar, AnyEvilBar, AnyCobaltBar, AnyMythrilBar, AnyAdamantiteBar;
        public static int AnyEvilPowder, Boss2Material, CursedFlameIchor, AnyEvilWater, AnyEvilFlask;
        public static int AnyStoneBlock, AnySnowBlock, AnyIceBlock, AnySiltBlock, AnyEvilBlock, AnyGoodBlock;
        public static int AnyWoodenSword, AnyHallowedHelmet, AnyHallowedPlatemail, AnyHallowedGreaves, AnyGoldCrown, LunarPickaxe, LunarHamaxe;
        public static int AnyManaFlower, AnyQuiver, AnyTombstone, AnyWings;

        public static void HandleRecipes()
        {
            CalamityQoLRestoredConfig config = ModContent.GetInstance<CalamityQoLRestoredConfig>();

            if (config.EarlyCosmolight)
            {
                Recipe.Create(ItemType<Cosmolight>()).
                AddIngredient(ItemID.FallenStar, 10).
                AddIngredient(ItemID.SoulofLight, 7).
                AddIngredient(ItemID.SoulofNight, 7).
                AddIngredient(ItemType<EssenceofSunlight>(), 5).
                AddTile(TileID.Anvils).
                Register().
                AddDecraftCondition(CalamityConditions.DownedAstrumDeus);
            }

            if (config.EarlyBakidon)
            {
                Recipe.Create(ItemType<Bakidon>()).
                AddIngredient(ItemID.FallenStar, 5).
                AddIngredient(ItemID.HellstoneBar, 5).
                AddTile(TileID.Hellforge).
                Register().
                AddDecraftCondition(Condition.Hardmode);
            }


            if (!config.VanillaItemRecipes)
                return;

            EditVanillaRecipes();

            // Black Lens
            Recipe.Create(ItemID.BlackLens).
                AddIngredient(ItemID.Lens).
                AddIngredient(ItemID.BlackDye).
                AddTile(TileID.DyeVat).
                Register();

            // Lava Fishing Hook
            Recipe.Create(ItemID.LavaFishingHook).
                AddIngredient(ItemID.HellstoneBar, 10).
                AddIngredient(ItemID.Seashell).
                AddTile(TileID.Hellforge).
                Register();

            // Bug Net
            Recipe.Create(ItemID.BugNet).
                AddIngredient(ItemID.Cobweb, 30).
                AddRecipeGroup("AnyCopperBar", 3).
                AddTile(TileID.Anvils).
                Register().
                DisableDecraft();

            // Staff of Regrowth
            Recipe.Create(ItemID.StaffofRegrowth).
                AddIngredient(ItemID.RichMahogany, 10).
                AddIngredient(ItemID.JungleSpores, 5).
                AddIngredient(ItemID.JungleRose).
                AddTile(TileID.WorkBenches).
                Register().
                DisableDecraft();

            // Sky Mill
            Recipe.Create(ItemID.SkyMill).
                AddIngredient(ItemID.SunplateBlock, 10).
                AddIngredient(ItemID.Cloud, 5).
                AddIngredient(ItemID.RainCloud, 3).
                AddTile(TileID.Anvils).
                Register().
                DisableDecraft();

            // Ice Machine
            Recipe.Create(ItemID.IceMachine).
                AddRecipeGroup("AnyIceBlock", 10).
                AddRecipeGroup("AnySnowBlock", 5).
                AddRecipeGroup("IronBar", 5).
                AddTile(TileID.Anvils).
                Register().
                DisableDecraft();

            // Desert Minecart
            Recipe.Create(ItemID.DesertMinecart).
                AddIngredient(ItemID.Minecart).
                AddIngredient(ItemID.SandstoneBrick, 20).
                AddTile(TileID.Anvils).
                Register().
                DisableDecraft();

            // Guide Voodoo Doll
            Recipe.Create(ItemID.GuideVoodooDoll).
                AddIngredient(ItemID.Leather, 2).
                AddRecipeGroup(AnyEvilPowder, 10).
                AddTile(TileID.Hellforge).
                Register().
                DisableDecraft();

            // Temple Key
            Recipe.Create(ItemID.TempleKey).
                AddIngredient(ItemID.JungleSpores, 15).
                AddIngredient(ItemID.RichMahogany, 10).
                AddIngredient(ItemID.SoulofLight, 5).
                AddIngredient(ItemID.SoulofNight, 5).
                AddTile(TileID.MythrilAnvil).
                Register().
                DisableDecraft();

            // Shuriken
            Recipe.Create(ItemID.Shuriken, 50).
                AddRecipeGroup("IronBar").
                AddTile(TileID.Anvils).
                Register().
                DisableDecraft();

            // Throwing Knife
            Recipe.Create(ItemID.ThrowingKnife, 50).
                AddRecipeGroup("IronBar").
                AddTile(TileID.Anvils).
                Register().
                DisableDecraft();

            // Band of Regeneration
            Recipe.Create(ItemID.BandofRegeneration).
                AddIngredient(ItemID.Shackle).
                AddIngredient(ItemID.LifeCrystal).
                AddTile(TileID.Anvils).
                Register().
                DisableDecraft();

            // Adhesive Bandage
            Recipe.Create(ItemID.AdhesiveBandage).
                AddIngredient(ItemID.Silk, 10).
                AddIngredient(ItemID.Gel, 10).
                AddIngredient(ItemID.HealingPotion).
                AddTile(TileID.Anvils).
                Register().
                DisableDecraft();

            // Metal Detector
            Recipe.Create(ItemID.MetalDetector).
                AddIngredient(ItemID.Wire, 10).
                AddIngredient(ItemID.SpelunkerGlowstick, 5).
                AddRecipeGroup("AnyCopperBar", 5).
                AddTile(TileID.Anvils).
                Register().
                DisableDecraft();

            // Vitamins
            Recipe.Create(ItemID.Vitamins).
                AddIngredient(ItemID.BottledWater).
                AddIngredient(ItemID.Waterleaf, 3).
                AddIngredient(ItemID.Blinkroot, 3).
                AddIngredient(ItemID.Daybloom, 3).
                AddIngredient<BloodOrb>(5).
                AddTile(TileID.AlchemyTable).
                Register().
                DisableDecraft();

            // Ice Boomerang
            Recipe.Create(ItemID.IceBoomerang).
                AddIngredient(ItemID.WoodenBoomerang).
                AddRecipeGroup(AnyIceBlock, 20).
                AddRecipeGroup(AnySnowBlock, 10).
                AddIngredient(ItemID.Shiverthorn).
                AddTile(TileID.Anvils).
                Register().
                DisableDecraft();

            /* // Umbrella
            Recipe.Create(ItemID.Umbrella).
                AddIngredient(ItemID.Silk, 5).
                AddRecipeGroup("AnyCopperBar", 2).
                AddTile(TileID.Loom).
                Register().
                DisableDecraft(); */

            /* // Wooden Boomerang
            Recipe.Create(ItemID.WoodenBoomerang).
                AddIngredient(ItemID.Wood, 7).
                AddTile(TileID.WorkBenches).
                Register().
                DisableDecraft(); */

            /* // Ice Skates
            Recipe.Create(ItemID.IceSkates).
                AddIngredient(ItemID.FlinxFur, 3).
                AddRecipeGroup("IronBar", 5).
                AddTile(TileID.Anvils).
                Register(); */

            /* // Shiny Red Balloon
            Recipe.Create(ItemID.ShinyRedBalloon).
                AddIngredient(ItemID.WhiteString).
                AddIngredient(ItemID.Gel, 15).
                AddIngredient(ItemID.Cloud, 5).
                AddTile(TileID.Solidifier).
                Register().
                DisableDecraft(); */

            // Living Loom
            Recipe.Create(ItemID.LivingLoom).
                AddIngredient(ItemID.Loom).
                AddIngredient(ItemID.Vine, 2).
                AddTile(TileID.Sawmill).
                Register().
                DisableDecraft();

            // Living Wood Wand
            Recipe.Create(ItemID.LivingWoodWand).
                AddIngredient(ItemID.Wood, 10).
                AddTile(TileID.LivingLoom).
                Register().
                DisableDecraft();

            // Living Leaf Wand
            Recipe.Create(ItemID.LeafWand).
                AddIngredient(ItemID.Wood, 10).
                AddTile(TileID.LivingLoom).
                Register().
                DisableDecraft();

            // Living Mahogany Wand
            Recipe.Create(ItemID.LivingMahoganyWand).
                AddIngredient(ItemID.RichMahogany, 10).
                AddTile(TileID.LivingLoom).
                Register().
                DisableDecraft();

            // Living Mahogany Leaf Wand
            Recipe.Create(ItemID.LivingMahoganyLeafWand).
                AddIngredient(ItemID.RichMahogany, 10).
                AddTile(TileID.LivingLoom).
                Register().
                DisableDecraft();

            // Frozen Turtle Shell
            Recipe.Create(ItemID.FrozenTurtleShell).
                AddIngredient(ItemID.TurtleShell, 2).
                AddIngredient<EssenceofEleum>(4).
                AddTile(TileID.Anvils).
                Register().
                DisableDecraft();

            // Bezoar
            Recipe.Create(ItemID.Bezoar).
                AddIngredient(ItemID.JungleSpores, 5).
                AddIngredient(ItemID.Stinger, 5).
                AddTile(TileID.Anvils).
                Register().
                DisableDecraft();

            // Celestial Magnet
            Recipe.Create(ItemID.CelestialMagnet).
                AddIngredient(ItemID.TreasureMagnet).
                AddIngredient(ItemID.FallenStar, 5).
                AddTile(TileID.Anvils).
                Register().
                DisableDecraft();

            // Feral Claws
            Recipe.Create(ItemID.FeralClaws).
                AddIngredient(ItemID.Leather, 10).
                AddTile(TileID.Anvils).
                Register().
                DisableDecraft();

            // Flare Gun
            Recipe.Create(ItemID.FlareGun).
                AddRecipeGroup("AnyCopperBar", 5).
                AddIngredient(ItemID.Torch, 10).
                AddTile(TileID.Anvils).
                Register().
                DisableDecraft();

            // Lihzahrd Power Cell
            Recipe.Create(ItemID.LihzahrdPowerCell).
                AddIngredient(ItemID.LihzahrdBrick, 5).
                AddIngredient(ItemID.Ectoplasm).
                AddIngredient<EssenceofSunlight>().
                AddTile(TileID.LihzahrdFurnace).
                Register().
                DisableDecraft();

            // Magic Quiver
            Recipe.Create(ItemID.MagicQuiver).
                AddIngredient(ItemID.EndlessQuiver).
                AddIngredient(ItemID.PixieDust, 5).
                AddIngredient(ItemID.Lens, 3).
                AddIngredient(ItemID.SoulofLight, 5).
                AddTile(TileID.CrystalBall).
                Register().
                DisableDecraft();

            /* // Bloody Tear
            Recipe.Create(ItemID.BloodMoonStarter).
                AddIngredient<BloodOrb>(10).
                AddRecipeGroup("AnyCopperBar", 3).
                AddTile(TileID.Anvils).
                Register().
                DisableDecraft(); */

            // Trifold Map (confusion)
            Recipe.Create(ItemID.TrifoldMap).
                AddIngredient(ItemID.Silk, 10).
                AddIngredient(ItemID.SoulofLight, 10).
                AddTile(TileID.Anvils).
                Register().
                DisableDecraft();

            // Fast Clock (slow)
            Recipe.Create(ItemID.FastClock).
                AddIngredient(ItemID.Timer1Second).
                AddIngredient(ItemID.PixieDust, 25).
                AddTile(TileID.Anvils).
                Register().
                DisableDecraft();

            // Nazar (curse)
            Recipe.Create(ItemID.Nazar).
                AddIngredient(ItemID.SoulofNight, 10).
                AddIngredient(ItemID.Lens, 3).
                AddTile(TileID.Anvils).
                Register().
                DisableDecraft();

            // Megaphone (silence)
            Recipe.Create(ItemID.Megaphone).
                AddRecipeGroup(AnyCobaltBar, 5).
                AddIngredient(ItemID.Wire, 10).
                AddTile(TileID.Anvils).
                Register().
                DisableDecraft();

            // Blindfold (darkness)
            Recipe.Create(ItemID.Blindfold).
                AddIngredient(ItemID.Silk, 10).
                AddIngredient(ItemID.TatteredCloth).
                AddTile(TileID.Anvils).
                Register().
                DisableDecraft();

            // Pocket Mirror (petrification)
            Recipe.Create(ItemID.PocketMirror).
                AddIngredient(ItemID.Glass, 10).
                AddRecipeGroup(AnyGoldBar, 8).
                AddIngredient(ItemID.CrystalShard, 8).
                AddTile(TileID.Anvils).
                Register().
                DisableDecraft();

        }

        internal static void EditVanillaRecipes()
        {
            #pragma warning disable CS8321
            static Func<Recipe, bool> Vanilla(int itemID) => r => r.Mod is null && r.HasResult(itemID);
            static Func<Recipe, bool> VanillaEach(params int[] itemIDs) => r => r.Mod is null && itemIDs.Any(r.HasResult);
            static Func<Recipe, bool> Produces(int itemID) => r => r.HasResult(itemID);
            static void Disable(Recipe r) => r.DisableRecipe();
            static Action<Recipe> ChangeResultStack(int stack) => r => r.createItem.stack = stack;
            static Action<Recipe> AddIngredient(int itemID, int stack = 1) => r => r.AddIngredient(itemID, stack);
            static Action<Recipe> AddGroup(int groupID, int stack = 1) => r => r.AddRecipeGroup(groupID, stack);
            static Action<Recipe> ChangeIngredientStack(int itemID, int stack = 1) => r => r.ChangeIngredientStack(itemID, stack);
            static Action<Recipe> ReplaceIngredient(int oldItemID, int newItemID) => r =>
            {
                int idx = r.IngredientIndex(oldItemID);
                if (idx == -1)
                    return;
                Item newIngredient = new Item();
                newIngredient.SetDefaults(newItemID);
                newIngredient.stack = r.requiredItem[idx].stack;
                r.requiredItem[idx] = newIngredient;
            };
            static Action<Recipe> RemoveIngredient(int itemID) => r => r.RemoveIngredient(itemID);
            static Action<Recipe> SwapIngredients(int i1, int i2) => r =>
            {
                if (r.requiredItem.Count < i1 + 1 || r.requiredItem.Count < i2 + 1)
                    return;
                var store = r.requiredItem[i1];
                r.requiredItem[i1] = r.requiredItem[i2];
                r.requiredItem[i2] = store;
            };
            static Action<Recipe> ReplaceTile(int oldTileID, int newTileID) => r =>
            {
                int idx = r.requiredTile.IndexOf(oldTileID);
                if (idx == -1)
                    return;
                r.requiredTile[idx] = newTileID;
            };
                #pragma warning restore CS8321
            var edits = new Dictionary<Func<Recipe, bool>, Action<Recipe>>(128)
            {
                { Vanilla(ItemID.MiniNukeI), Disable },
                { Vanilla(ItemID.MiniNukeII), Disable },
            };
            IEnumerator<Recipe> recipeEnumerator = Main.recipe.ToList().GetEnumerator();
            while (recipeEnumerator.MoveNext())
            {
                Recipe r = recipeEnumerator.Current;
                foreach (var kv in edits)
                    if (kv.Key.Invoke(r))
                        kv.Value.Invoke(r);
            }
        }
        #endregion
    }
}