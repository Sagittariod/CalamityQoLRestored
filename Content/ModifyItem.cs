using CalamityMod;
using CalamityMod.Items.Accessories;
using CalamityMod.Items.Critters;
using CalamityMod.Items.Fishing.AstralCatches;
using CalamityMod.Items.Fishing.BrimstoneCragCatches;
using CalamityMod.Items.Fishing.SulphurCatches;
using CalamityMod.Items.Fishing.SunkenSeaCatches;
using CalamityMod.Items.Materials;
using CalamityMod.Items.Pets;
using CalamityMod.Items.Placeables.Abyss;
using CalamityMod.Items.Placeables.FurnitureAcidwood;
using CalamityMod.Items.Placeables.Ores;
using CalamityMod.Items.Placeables.SunkenSea;
using CalamityMod.Items.Potions;
using CalamityMod.Items.Tools;
using CalamityMod.Items.Tools.ClimateChange;
using CalamityMod.Items.Tools.SpawnBlocker;
using CalamityMod.Items.TreasureBags.MiscGrabBags;
using CalamityMod.Items.Weapons.Magic;
using CalamityMod.Items.Weapons.Melee;
using CalamityMod.Items.Weapons.Ranged;
using CalamityMod.Items.Weapons.Rogue;
using CalamityMod.Items.Weapons.Summon;
using CalamityMod.Items.Weapons.Typeless;
using CalamityMod.NPCs.Astral;
using CalamityMod.NPCs.SunkenSea;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using tModPorter;

namespace CalamityQoLRestored.Content
{
    public class ModifyItem : GlobalItem
    {
        public static IItemDropRuleCondition PostKS(bool ui = true) => Condition.DownedKingSlime.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostDS(bool ui = true) => CalamityConditions.DownedDesertScourge.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostEoC(bool ui = true) => Condition.DownedEyeOfCthulhu.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostCrab(bool ui = true) => CalamityConditions.DownedCrabulon.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostEvil1(bool ui = true) => Condition.DownedEowOrBoc.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostHM(bool ui = true) => CalamityConditions.DownedHiveMind.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostPerfs(bool ui = true) => CalamityConditions.DownedPerforator.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostEvil2(bool ui = true) => CalamityConditions.DownedHiveMindOrPerforator.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostQB(bool ui = true) => Condition.DownedQueenBee.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostDeer(bool ui = true) => Condition.DownedDeerclops.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostSkele(bool ui = true) => Condition.DownedSkeletron.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostSG(bool ui = true) => CalamityConditions.DownedSlimeGod.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition Hardmode(bool ui = true) => Condition.Hardmode.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostQS(bool ui = true) => Condition.DownedQueenSlime.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostCryo(bool ui = true) => CalamityConditions.DownedCryogen.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostAS(bool ui = true) => CalamityConditions.DownedAquaticScourge.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostBrim(bool ui = true) => CalamityConditions.DownedBrimstoneElemental.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostDest(bool ui = true) => Condition.DownedDestroyer.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostTwins(bool ui = true) => Condition.DownedTwins.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostSP(bool ui = true) => Condition.DownedSkeletronPrime.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition Post1Mechs(bool ui = true) => Condition.DownedMechBossAny.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition Post3Mechs(bool ui = true) => Condition.DownedMechBossAll.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostCal(bool ui = true) => CalamityConditions.DownedCalamitasClone.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostPlant(bool ui = true) => Condition.DownedPlantera.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostCalPlant(bool ui = true) => CalamityConditions.DownedCalamitasCloneOrPlantera.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostLevi(bool ui = true) => CalamityConditions.DownedLeviathan.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostAureus(bool ui = true) => CalamityConditions.DownedAstrumAureus.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostGolem(bool ui = true) => Condition.DownedGolem.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostPBG(bool ui = true) => CalamityConditions.DownedPlaguebringer.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostEoL(bool ui = true) => Condition.DownedEmpressOfLight.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostFish(bool ui = true) => Condition.DownedDukeFishron.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostRav(bool ui = true) => CalamityConditions.DownedRavager.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostLC(bool ui = true) => Condition.DownedCultist.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostAD(bool ui = true) => CalamityConditions.DownedAstrumDeus.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostML(bool ui = true) => Condition.DownedMoonLord.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostGuard(bool ui = true) => CalamityConditions.DownedGuardians.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostBirb(bool ui = true) => CalamityConditions.DownedBumblebird.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostProv(bool ui = true) => CalamityConditions.DownedProvidence.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostSig(bool ui = true) => CalamityConditions.DownedSignus.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostSW(bool ui = true) => CalamityConditions.DownedStormWeaver.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostCV(bool ui = true) => CalamityConditions.DownedCeaselessVoid.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostPolter(bool ui = true) => CalamityConditions.DownedPolterghast.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostOD(bool ui = true) => CalamityConditions.DownedOldDuke.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostDoG(bool ui = true) => CalamityConditions.DownedDevourerOfGods.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostYharon(bool ui = true) => CalamityConditions.DownedYharon.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostExos(bool ui = true) => CalamityConditions.DownedExoMechs.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostSCal(bool ui = true) => CalamityConditions.DownedSupremeCalamitas.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostAEW(bool ui = true) => CalamityConditions.DownedPrimordialWyrm.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostClam(bool ui = true) => CalamityConditions.DownedClam.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostClamHM(bool ui = true) => CalamityConditions.DownedBuffedClam.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostGSS(bool ui = true) => CalamityConditions.DownedGreatSandShark.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostBetsy(bool ui = true) => CalamityConditions.DownedBetsy.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostT1AR(bool ui = true) => CalamityConditions.DownedAcidRainT1.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);
        public static IItemDropRuleCondition PostT2AR(bool ui = true) => CalamityConditions.DownedAcidRainT2.ToDropCondition(ui ? ShowItemDropInUI.Always : ShowItemDropInUI.Never);

        public override void SetStaticDefaults()
        {
            SetStaticDefaults_ShimmerRecipes();
        }

        public override void ModifyItemLoot(Item item, ItemLoot itemLoot)
        {
            CalamityQoLRestoredConfig config = ModContent.GetInstance<CalamityQoLRestoredConfig>();

            if (item.type == ModContent.ItemType<StarterBag>())
            {
                if (!config.StarterBagAdditions)
                    return;

                itemLoot.Add(ItemID.MiningPotion, 1, 1, 1);
                itemLoot.Add(ItemID.SpelunkerPotion, 1, 2, 2);
                itemLoot.Add(ItemID.SwiftnessPotion, 1, 3, 3);
                itemLoot.Add(ItemID.GillsPotion, 1, 2, 2);
                itemLoot.Add(ItemID.ShinePotion, 1, 1, 1);
                itemLoot.Add(ItemID.Chest, 1, 3, 3);
                itemLoot.Add(ItemID.Bomb, 1, 10, 10);
            }

            if (!config.CrateAdditions) // Abandon all hope ye who crater here
                return;

            // Astral Crate-specific drops
            if (item.type == ModContent.ItemType<AstralCrate>())
            {
                var postAureus = new LeadingConditionRule(PostAureus());

                itemLoot.RemoveWhere(rule => rule is CommonDrop drop && drop.itemId == ModContent.ItemType<StarblightSoot>()); // Already exists as a rule
                itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<StarblightSoot>(), 1, 5, 10));

                IItemDropRule[] weaponPool =
                {
                    ItemDropRule.Common(ModContent.ItemType<StellarKnife>()),
                    ItemDropRule.Common(ModContent.ItemType<AstralachneaStaff>()),
                    ItemDropRule.Common(ModContent.ItemType<TitanArm>()),
                    ItemDropRule.Common(ModContent.ItemType<HivePod>()),
                    ItemDropRule.Common(ModContent.ItemType<AstralScythe>())
                };
                var weaponRule = new OneFromRulesRule(10, weaponPool);
                postAureus.Add(weaponRule);

                IItemDropRule[] orePool =
                {
                    ItemDropRule.Common(ModContent.ItemType<AstralOre>(), 1, 10, 20),
                    ItemDropRule.Common(ItemID.Meteorite, 1, 10, 20)
                };
                var oreRule = new OneFromRulesRule(5, orePool);
                postAureus.Add(oreRule);

                IItemDropRule[] astralPotions =
                {
                    ItemDropRule.Common(ModContent.ItemType<GravityNormalizerPotion>(), 1, 1, 3),
                    ItemDropRule.Common(ModContent.ItemType<AstralInjection>(), 1, 1, 3)
                };
                var potionRule = new OneFromRulesRule(10, astralPotions);
                postAureus.Add(potionRule);

                // Compile all changes into the complete item pool.
                itemLoot.Add(postAureus);
            }

            // Evil crate drops
            if (item.type == ItemID.CorruptFishingCrate || item.type == ItemID.CorruptFishingCrateHard || item.type == ItemID.CrimsonFishingCrate || item.type == ItemID.CrimsonFishingCrateHard)
                itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<BlightedGel>(), 5, 5, 8));

            // Dungeon crate drops
            if (item.type == ItemID.DungeonFishingCrate || item.type == ItemID.DungeonFishingCrateHard)
            {
                itemLoot.Add(ItemDropRule.Common(ItemID.Ectoplasm, 3, 5, 10));
                itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<Necroplasm>(), 5, 5, 10));
            }

            // Sunk The In
            if (item.type == ModContent.ItemType<EutrophicCrate>() || item.type == ModContent.ItemType<PrismCrate>())
            {
                itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<PrismShard>(), 1, 5, 10));
                itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<SeaPrism>(), 1, 2, 5));
                itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<SeaMinnowItem>(), 5, 1, 3));
            }

            // Titanium Crate
            if (item.type == ItemID.GoldenCrateHard)
                itemLoot.Add(ItemDropRule.ByCondition(PostYharon(), ModContent.ItemType<AuricOre>(), 14, 20, 35));

            // Hallowed Crate drops
            if (item.type == ItemID.HallowedFishingCrate || item.type == ItemID.HallowedFishingCrateHard)
                itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<UnholyEssence>(), 5, 5, 8));

            // Hydrothermic Crate-specific drops
            if (item.type == ModContent.ItemType<HydrothermalCrate>())
            {
                itemLoot.RemoveWhere(rule => rule is OneFromRulesRule pool && pool.options.Any(opt =>
                    opt is CommonDrop d && d.itemId == ModContent.ItemType<Archerfish>()));

                var postT1Acid = new LeadingConditionRule(PostT1AR());
                var postT2Acid = new LeadingConditionRule(PostT2AR());
                var postClone = new LeadingConditionRule(PostCal());
                var postGolem = new LeadingConditionRule(PostGolem());
                var postPolter = new LeadingConditionRule(PostPolter());

                postT1Acid.Add(ItemDropRule.Common(ModContent.ItemType<SulphuricScale>(), 10, 1, 3));
                postT2Acid.Add(ItemDropRule.Common(ModContent.ItemType<CorrodedFossil>(), 10, 1, 3));

                IItemDropRule[] lumenylPool = new IItemDropRule[] 
                {
                    ItemDropRule.Common(ModContent.ItemType<DepthCells>(), 1, 2, 5),
                    ItemDropRule.Common(ModContent.ItemType<Lumenyl>(), 1, 2, 5),
                    ItemDropRule.Common(ModContent.ItemType<PlantyMush>(), 1, 2, 5)
                };
                postClone.Add(new OneFromRulesRule(5, lumenylPool));

                postGolem.Add(ItemDropRule.Common(ModContent.ItemType<ScoriaOre>(), 5, 16, 28));
                postGolem.Add(ItemDropRule.Common(ModContent.ItemType<ScoriaBar>(), 15, 4, 7));

                postGolem.Add(ItemDropRule.Common(ModContent.ItemType<ReaperTooth>(), 10, 1, 5));

                var postSkeletron = new LeadingConditionRule(PostSkele());

                IItemDropRule[] abyssEquips = new IItemDropRule[] 
                {
                    ItemDropRule.Common(ModContent.ItemType<StrangeOrb>()),
                    ItemDropRule.Common(ModContent.ItemType<TorrentialTear>()),
                    ItemDropRule.Common(ModContent.ItemType<DepthCharm>()),
                    ItemDropRule.Common(ModContent.ItemType<IronBoots>()),
                    ItemDropRule.Common(ModContent.ItemType<AnechoicPlating>())
                };
                postSkeletron.Add(new OneFromRulesRule(4, abyssEquips));

                IItemDropRule[] abyssWeapons = new IItemDropRule[] 
                {
                    ItemDropRule.Common(ModContent.ItemType<Archerfish>()),
                    ItemDropRule.Common(ModContent.ItemType<BallOFugu>()),
                    ItemDropRule.Common(ModContent.ItemType<HerringStaff>()),
                    ItemDropRule.Common(ModContent.ItemType<Lionfish>()),
                    ItemDropRule.Common(ModContent.ItemType<BlackAnurian>())
                };
                postSkeletron.Add(new OneFromRulesRule(10, abyssWeapons));

                IItemDropRule[] t2AcidDrops = new IItemDropRule[] 
                {
                    ItemDropRule.Common(ModContent.ItemType<SkyfinBombers>()),
                    ItemDropRule.Common(ModContent.ItemType<NuclearFuelRod>()),
                    ItemDropRule.Common(ModContent.ItemType<SulphurousGrabber>()),
                    ItemDropRule.Common(ModContent.ItemType<FlakToxicannon>()),
                    ItemDropRule.Common(ModContent.ItemType<SpentFuelContainer>()),
                    ItemDropRule.Common(ModContent.ItemType<SlitheringEels>()),
                    ItemDropRule.Common(ModContent.ItemType<BelchingSaxophone>())
                };
                postT2Acid.Add(new OneFromRulesRule(10, t2AcidDrops));

                IItemDropRule[] hydroPotions = new IItemDropRule[] 
                {
                    ItemDropRule.Common(ItemID.ObsidianSkinPotion, 1, 1, 3),
                    ItemDropRule.Common(ItemID.SwiftnessPotion, 1, 1, 3),
                    ItemDropRule.Common(ItemID.IronskinPotion, 1, 1, 3),
                    ItemDropRule.Common(ItemID.NightOwlPotion, 1, 1, 3),
                    ItemDropRule.Common(ItemID.ShinePotion, 1, 1, 3),
                    ItemDropRule.Common(ItemID.MiningPotion, 1, 1, 3),
                    ItemDropRule.Common(ItemID.HeartreachPotion, 1, 1, 3),
                    ItemDropRule.Common(ModContent.ItemType<AnechoicCoating>(), 1, 1, 3),
                    ItemDropRule.Common(ItemID.TrapsightPotion, 1, 1, 3)
                };
                itemLoot.Add(new OneFromRulesRule(10, hydroPotions));

                itemLoot.Add(postT1Acid);
                itemLoot.Add(postT2Acid);
                itemLoot.Add(postClone);
                itemLoot.Add(postGolem);
                itemLoot.Add(postSkeletron);
            }

            // Iron Crates
            if (item.type == ItemID.IronCrate || item.type == ItemID.IronCrateHard)
            {
                itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<AncientBoneDust>(), 4, 1, 13));
                itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<WulfrumMetalScrap>(), 4, 2, 5));
            }

            // Jungle Crates
            if (item.type == ItemID.JungleFishingCrate || item.type == ItemID.JungleFishingCrateHard)
            {
                itemLoot.Add(ItemDropRule.ByCondition(PostPlant(), ModContent.ItemType<PerennialOre>(), 14, 20, 35));
                itemLoot.Add(ItemDropRule.ByCondition(PostPlant(), ModContent.ItemType<PerennialBar>(), 6, 4, 7));

                itemLoot.Add(ItemDropRule.ByCondition(PostGolem(), ModContent.ItemType<PlagueCellCanister>(), 3, 5, 10));

                itemLoot.Add(ItemDropRule.ByCondition(PostProv(), ModContent.ItemType<UelibloomOre>(), 14, 20, 35));
                itemLoot.Add(ItemDropRule.ByCondition(PostProv(), ModContent.ItemType<UelibloomBar>(), 6, 4, 7));
            }

            // Monolith Crates
            if (item.type == ModContent.ItemType<MonolithCrate>())
            {
                itemLoot.Add(ItemDropRule.Common(ItemID.FallenStar, 1, 5, 10));
                itemLoot.Add(ItemDropRule.Common(ItemID.Meteorite, 5, 10, 20));
                itemLoot.Add(ItemDropRule.Common(ItemID.MeteoriteBar, 10, 1, 3));

                itemLoot.Add(ItemDropRule.Common(ItemID.Firefly, 3, 1, 1));
                itemLoot.Add(ItemDropRule.Common(ItemID.MeteoriteBar, 10, 1, 3));
                itemLoot.Add(ItemDropRule.Common(ItemID.MeteoriteBar, 10, 1, 3));

                IItemDropRule[] rareBaitPool = new IItemDropRule[] 
                {
                    ItemDropRule.Common(ItemID.EnchantedNightcrawler, 1, 1, 3),
                    ItemDropRule.Common(ModContent.ItemType<TwinklerItem>(), 1, 1, 3),
                    ItemDropRule.Common(ModContent.ItemType<ArcturusAstroidean>(), 1, 1, 3)
                };

                itemLoot.Add(new SequentialRulesNotScalingWithLuckRule(
                    1,
                    new OneFromRulesRule(3, ItemDropRule.Common(ItemID.Firefly, 1, 1, 3)), // 33.33% Chance
                    new OneFromRulesRule(5, rareBaitPool) // 20.00% Chance
                ));
            }

            if (item.type == ItemID.LavaCrate || item.type == ItemID.LavaCrateHard)
                itemLoot.Add(ItemDropRule.ByCondition(Hardmode(), ModContent.ItemType<EssenceofHavoc>(), 5, 4, 7));

            if (item.type == ItemID.FloatingIslandFishingCrate || item.type == ItemID.FloatingIslandFishingCrateHard)
            {
                itemLoot.Add(ItemDropRule.ByCondition(PostEvil2(), ModContent.ItemType<AerialiteOre>(), 6, 5, 10));
                itemLoot.Add(ItemDropRule.ByCondition(PostEvil2(), ModContent.ItemType<AerialiteBar>(), 14, 4, 7));
                itemLoot.Add(ItemDropRule.ByCondition(Hardmode(), ModContent.ItemType<EssenceofSunlight>(), 5, 4, 7));
                itemLoot.Add(ItemDropRule.ByCondition(PostML(), ModContent.ItemType<ExodiumCluster>(), 2, 25, 50));
            }

            if (item.type == ModContent.ItemType<SlagCrate>() || item.type == ModContent.ItemType<BrimstoneCrate>())
            {
                IItemDropRule[] ech = new IItemDropRule[]
                {
                    ItemDropRule.Common(ItemID.Hellstone, 4, 2, 5),
                    ItemDropRule.Common(ItemID.Obsidian, 1, 2, 5),
                };
                itemLoot.Add(new OneFromRulesRule(1, ech));

                ItemDropRule.Common(ItemID.HellstoneBar, 10, 1, 3);
            }

            if (item.type == ModContent.ItemType<BrimstoneCrate>())
            {
                IItemDropRule[] ech = new IItemDropRule[]
                {
                    ItemDropRule.Common(ModContent.ItemType<UnholyCore>(), 10, 1, 3),
                    ItemDropRule.Common(ModContent.ItemType<Bloodstone>(), 2, 1, 3),
                };
                itemLoot.Add(new OneFromRulesRule(1, ech));
            }

            if (item.type == ModContent.ItemType<SulphurousCrate>())
            {
                itemLoot.RemoveWhere(rule => rule is OneFromRulesRule pool && pool.options.Any(opt =>
                    opt is CommonDrop d && d.itemId == ModContent.ItemType<BrokenWaterFilter>()));

                itemLoot.RemoveWhere(rule => rule is OneFromRulesRule pool && pool.options.Any(opt =>
                    opt is CommonDrop d && d.itemId == ModContent.ItemType<SulphurousSand>()));

                itemLoot.RemoveWhere(rule => rule is OneFromRulesRule pool && pool.options.Any(opt =>
                    opt is CommonDrop d && d.itemId == ModContent.ItemType<Archerfish>()));

                itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<Acidwood>(), 1, 5, 10));
                itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<SulphurousSand>(), 1, 5, 10));
                itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<SulphurousSandstone>(), 1, 5, 10));
                itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<HardenedSulphurousSandstone>(), 1, 5, 10));

                var postT1Acid = new LeadingConditionRule(PostT1AR());
                postT1Acid.Add(ItemDropRule.Common(ModContent.ItemType<SulphuricScale>(), 10, 1, 3));
                itemLoot.Add(postT1Acid);

                var postSkeletron = new LeadingConditionRule(PostSkele());

                IItemDropRule[] abyssEquips = new IItemDropRule[] 
                {
                    ItemDropRule.Common(ModContent.ItemType<StrangeOrb>()),
                    ItemDropRule.Common(ModContent.ItemType<TorrentialTear>()),
                    ItemDropRule.Common(ModContent.ItemType<DepthCharm>()),
                    ItemDropRule.Common(ModContent.ItemType<IronBoots>()),
                    ItemDropRule.Common(ModContent.ItemType<AnechoicPlating>())
                };
                postSkeletron.Add(new OneFromRulesRule(4, abyssEquips));

                IItemDropRule[] abyssWeapons = new IItemDropRule[] 
                {
                    ItemDropRule.Common(ModContent.ItemType<Archerfish>()),
                    ItemDropRule.Common(ModContent.ItemType<BallOFugu>()),
                    ItemDropRule.Common(ModContent.ItemType<HerringStaff>()),
                    ItemDropRule.Common(ModContent.ItemType<Lionfish>()),
                    ItemDropRule.Common(ModContent.ItemType<BlackAnurian>())
                };
                postSkeletron.Add(new OneFromRulesRule(10, abyssWeapons));
                itemLoot.Add(postSkeletron);

                IItemDropRule[] sulphurousPotions = new IItemDropRule[] 
                {
                    ItemDropRule.Common(ItemID.ObsidianSkinPotion, 1, 1, 3),
                    ItemDropRule.Common(ItemID.SwiftnessPotion, 1, 1, 3),
                    ItemDropRule.Common(ItemID.IronskinPotion, 1, 1, 3),
                    ItemDropRule.Common(ItemID.NightOwlPotion, 1, 1, 3),
                    ItemDropRule.Common(ItemID.ShinePotion, 1, 1, 3),
                    ItemDropRule.Common(ItemID.MiningPotion, 1, 1, 3),
                    ItemDropRule.Common(ItemID.HeartreachPotion, 1, 1, 3),
                    ItemDropRule.Common(ModContent.ItemType<AnechoicCoating>(), 1, 1, 3),
                    ItemDropRule.Common(ItemID.TrapsightPotion, 1, 1, 3)
                };
                itemLoot.Add(new OneFromRulesRule(10, sulphurousPotions));
            }

            if (item.type == ItemID.WoodenCrate || item.type == ItemID.WoodenCrateHard)
            {
                itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<WulfrumMetalScrap>(), 5, 5, 10));
            }
        }

        private void SetStaticDefaults_ShimmerRecipes()
        {
            CalamityQoLRestoredConfig config = ModContent.GetInstance<CalamityQoLRestoredConfig>();
            if (!config.ShimmerCycles)
                return;


            // -- Boss Shimmer Drop Cycles --
            // These cycles follow the order of: Melee Weapons A to Z -> Ranged Weapons A to Z -> Magic Weapons A to Z -> Summon Weapons A to Z -> Rogue Weapons A to Z (Based off of their in-game names)
            // Note that only a select amount of vanilla bosses have an array of equally-likely weapon drops, so the amount of drop pools affected may seem odd at first glance.

            //Profaned Guardian Drop Swap
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<RelicOfDeliverance>()] = ModContent.ItemType<RelicOfResilience>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<RelicOfResilience>()] = ModContent.ItemType<RelicOfConvergence>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<RelicOfConvergence>()] = ModContent.ItemType<RelicOfDeliverance>();

            // Queen Bee
            ItemID.Sets.ShimmerTransformToItem[ItemID.BeeKeeper] = ItemID.BeesKnees;
            ItemID.Sets.ShimmerTransformToItem[ItemID.BeesKnees] = ItemID.BeeGun;
            ItemID.Sets.ShimmerTransformToItem[ItemID.BeeGun] = ModContent.ItemType<HardenedHoneycomb>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<HardenedHoneycomb>()] = ItemID.BeeKeeper;

            // Deerclops
            ItemID.Sets.ShimmerTransformToItem[ItemID.LucyTheAxe] = ItemID.PewMaticHorn;
            ItemID.Sets.ShimmerTransformToItem[ItemID.PewMaticHorn] = ItemID.WeatherPain;
            ItemID.Sets.ShimmerTransformToItem[ItemID.WeatherPain] = ItemID.HoundiusShootius;
            ItemID.Sets.ShimmerTransformToItem[ItemID.HoundiusShootius] = ItemID.LucyTheAxe;

            // Wall of Flesh
            ItemID.Sets.ShimmerTransformToItem[ItemID.BreakerBlade] = ItemID.ClockworkAssaultRifle;
            ItemID.Sets.ShimmerTransformToItem[ItemID.ClockworkAssaultRifle] = ModContent.ItemType<Meowthrower>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<Meowthrower>()] = ItemID.LaserRifle;
            ItemID.Sets.ShimmerTransformToItem[ItemID.LaserRifle] = ModContent.ItemType<BlackHawkRemote>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<BlackHawkRemote>()] = ItemID.FireWhip;
            ItemID.Sets.ShimmerTransformToItem[ItemID.FireWhip] = ModContent.ItemType<BlastBarrel>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<BlastBarrel>()] = ItemID.BreakerBlade;

            // Plantera
            ItemID.Sets.ShimmerTransformToItem[ItemID.FlowerPow] = ItemID.Seedler;
            ItemID.Sets.ShimmerTransformToItem[ItemID.Seedler] = ItemID.GrenadeLauncher;
            ItemID.Sets.ShimmerTransformToItem[ItemID.GrenadeLauncher] = ItemID.VenusMagnum;
            ItemID.Sets.ShimmerTransformToItem[ItemID.VenusMagnum] = ItemID.LeafBlower;
            ItemID.Sets.ShimmerTransformToItem[ItemID.LeafBlower] = ItemID.NettleBurst;
            ItemID.Sets.ShimmerTransformToItem[ItemID.NettleBurst] = ItemID.WaspGun;
            ItemID.Sets.ShimmerTransformToItem[ItemID.WaspGun] = ItemID.FlowerPow;

            // Golem
            ItemID.Sets.ShimmerTransformToItem[ItemID.EyeoftheGolem] = ItemID.SunStone;
            ItemID.Sets.ShimmerTransformToItem[ItemID.SunStone] = ItemID.GolemFist;
            ItemID.Sets.ShimmerTransformToItem[ItemID.GolemFist] = ItemID.PossessedHatchet;
            ItemID.Sets.ShimmerTransformToItem[ItemID.PossessedHatchet] = ItemID.Stynger;
            ItemID.Sets.ShimmerTransformToItem[ItemID.Stynger] = ItemID.HeatRay;
            ItemID.Sets.ShimmerTransformToItem[ItemID.HeatRay] = ItemID.StaffofEarth;
            ItemID.Sets.ShimmerTransformToItem[ItemID.StaffofEarth] = ItemID.EyeoftheGolem;

            // Duke Fishron
            ItemID.Sets.ShimmerTransformToItem[ItemID.Flairon] = ItemID.Tsunami;
            ItemID.Sets.ShimmerTransformToItem[ItemID.Tsunami] = ItemID.BubbleGun;
            ItemID.Sets.ShimmerTransformToItem[ItemID.BubbleGun] = ItemID.RazorbladeTyphoon;
            ItemID.Sets.ShimmerTransformToItem[ItemID.RazorbladeTyphoon] = ItemID.TempestStaff;
            ItemID.Sets.ShimmerTransformToItem[ItemID.TempestStaff] = ModContent.ItemType<DukesDecapitator>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<DukesDecapitator>()] = ItemID.Flairon;

            // Empress of Light (Yes these are actually the IDs)
            ItemID.Sets.ShimmerTransformToItem[ItemID.PiercingStarlight] = ItemID.FairyQueenRangedItem;
            ItemID.Sets.ShimmerTransformToItem[ItemID.FairyQueenRangedItem] = ItemID.FairyQueenMagicItem;
            ItemID.Sets.ShimmerTransformToItem[ItemID.FairyQueenMagicItem] = ItemID.SparkleGuitar;
            ItemID.Sets.ShimmerTransformToItem[ItemID.SparkleGuitar] = ItemID.RainbowWhip;
            ItemID.Sets.ShimmerTransformToItem[ItemID.RainbowWhip] = ItemID.PiercingStarlight;

            // Moon Lord
            ItemID.Sets.ShimmerTransformToItem[ItemID.Meowmere] = ItemID.StarWrath;
            ItemID.Sets.ShimmerTransformToItem[ItemID.StarWrath] = ItemID.Terrarian;
            ItemID.Sets.ShimmerTransformToItem[ItemID.Terrarian] = ItemID.Celeb2;
            ItemID.Sets.ShimmerTransformToItem[ItemID.Celeb2] = ItemID.SDMG;
            ItemID.Sets.ShimmerTransformToItem[ItemID.SDMG] = ItemID.LastPrism;
            ItemID.Sets.ShimmerTransformToItem[ItemID.LastPrism] = ItemID.LunarFlareBook;
            ItemID.Sets.ShimmerTransformToItem[ItemID.LunarFlareBook] = ItemID.MoonlordTurretStaff;
            ItemID.Sets.ShimmerTransformToItem[ItemID.MoonlordTurretStaff] = ItemID.RainbowCrystalStaff;
            ItemID.Sets.ShimmerTransformToItem[ItemID.RainbowCrystalStaff] = ModContent.ItemType<UtensilPoker>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<UtensilPoker>()] = ItemID.Meowmere;




            // Slime God
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<AbyssalTome>()] = ModContent.ItemType<EldritchTome>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<EldritchTome>()] = ModContent.ItemType<CorroslimeStaff>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<CorroslimeStaff>()] = ModContent.ItemType<CrimslimeStaff>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<CrimslimeStaff>()] = ModContent.ItemType<OverloadedBlaster>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<OverloadedBlaster>()] = ModContent.ItemType<AbyssalTome>();

            // Astrum Aureus
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<AlulaAustralis>()] = ModContent.ItemType<BorealisBomber>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<BorealisBomber>()] = ModContent.ItemType<AuroradicalThrow>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<AuroradicalThrow>()] = ModContent.ItemType<Nebulash>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<Nebulash>()] = ModContent.ItemType<AuroraBlazer>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<AuroraBlazer>()] = ModContent.ItemType<AlulaAustralis>();

            // Levi
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<AnahitasArpeggio>()] = ModContent.ItemType<Atlantis>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<Atlantis>()] = ModContent.ItemType<GastricBelcherStaff>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<GastricBelcherStaff>()] = ModContent.ItemType<Whitewater>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<Whitewater>()] = ModContent.ItemType<Greentide>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<Greentide>()] = ModContent.ItemType<Leviatitan>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<Leviatitan>()] = ModContent.ItemType<AnahitasArpeggio>();

            // Perfs
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<BloodBath>()] = ModContent.ItemType<FleshOfInfidelity>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<FleshOfInfidelity>()] = ModContent.ItemType<ToothBall>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<ToothBall>()] = ModContent.ItemType<Aorta>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<Aorta>()] = ModContent.ItemType<SausageMaker>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<SausageMaker>()] = ModContent.ItemType<VeinBurster>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<VeinBurster>()] = ModContent.ItemType<Eviscerator>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<Eviscerator>()] = ModContent.ItemType<BloodBath>();

            // Aquatic Scourge
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<Downpour>()] = ModContent.ItemType<DeepseaStaff>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<DeepseaStaff>()] = ModContent.ItemType<ScourgeoftheSeas>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<ScourgeoftheSeas>()] = ModContent.ItemType<SubmarineShocker>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<SubmarineShocker>()] = ModContent.ItemType<Barinautical>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<Barinautical>()] = ModContent.ItemType<Downpour>();

            // polter
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<FatesReveal>()] = ModContent.ItemType<GhastlyVisage>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<GhastlyVisage>()] = ModContent.ItemType<EtherealSubjugator>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<EtherealSubjugator>()] = ModContent.ItemType<GhoulishGouger>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<GhoulishGouger>()] = ModContent.ItemType<BansheeHook>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<BansheeHook>()] = ModContent.ItemType<TerrorBlade>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<TerrorBlade>()] = ModContent.ItemType<DaemonsFlame>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<DaemonsFlame>()] = ModContent.ItemType<FatesReveal>();

            // Rav
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<Hematemesis>()] = ModContent.ItemType<SpikecragStaff>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<SpikecragStaff>()] = ModContent.ItemType<CraniumSmasher>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<CraniumSmasher>()] = ModContent.ItemType<UltimusCleaver>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<UltimusCleaver>()] = ModContent.ItemType<RealmRavager>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<RealmRavager>()] = ModContent.ItemType<Hematemesis>();

            // Scal
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<Heresy>()] = ModContent.ItemType<Vehemence>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<Vehemence>()] = ModContent.ItemType<Perdition>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<Perdition>()] = ModContent.ItemType<Vigilance>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<Vigilance>()] = ModContent.ItemType<Sacrifice>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<Sacrifice>()] = ModContent.ItemType<Violence>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<Violence>()] = ModContent.ItemType<Condemnation>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<Condemnation>()] = ModContent.ItemType<Heresy>();

            // DoG
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<HyperdeathRiftScepter>()] = ModContent.ItemType<VoidEaterMarionette>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<VoidEaterMarionette>()] = ModContent.ItemType<DimensionTearingDisk>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<DimensionTearingDisk>()] = ModContent.ItemType<MawOfInfinity>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<MawOfInfinity>()] = ModContent.ItemType<TheObliterator>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<TheObliterator>()] = ModContent.ItemType<ThreadOfEradication>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<ThreadOfEradication>()] = ModContent.ItemType<HyperdeathRiftScepter>();

            // Crabby
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<HyphaeRod>()] = ModContent.ItemType<PuffShroom>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<PuffShroom>()] = ModContent.ItemType<InfestedClawmerang>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<InfestedClawmerang>()] = ModContent.ItemType<Mycoroot>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<Mycoroot>()] = ModContent.ItemType<MycelialClaws>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<MycelialClaws>()] = ModContent.ItemType<Fungicide>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<Fungicide>()] = ModContent.ItemType<HyphaeRod>();

            // calcloneney
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<LashesofChaos>()] = ModContent.ItemType<EntropysVigil>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<EntropysVigil>()] = ModContent.ItemType<Oblivion>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<Oblivion>()] = ModContent.ItemType<Animosity>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<Animosity>()] = ModContent.ItemType<LashesofChaos>();

            // yharis
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<PhoenixFlameBarrage>()] = ModContent.ItemType<YharonsKindleStaff>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<YharonsKindleStaff>()] = ModContent.ItemType<TheFinalDawn>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<TheFinalDawn>()] = ModContent.ItemType<Wrathwing>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<Wrathwing>()] = ModContent.ItemType<DragonRage>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<DragonRage>()] = ModContent.ItemType<TheBurningSky>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<TheBurningSky>()] = ModContent.ItemType<ChickenCannon>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<ChickenCannon>()] = ModContent.ItemType<DragonsBreath>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<DragonsBreath>()] = ModContent.ItemType<PhoenixFlameBarrage>();

            // pbg
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<PlagueStaff>()] = ModContent.ItemType<FuelCellBundle>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<FuelCellBundle>()] = ModContent.ItemType<InfectedRemote>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<InfectedRemote>()] = ModContent.ItemType<TheSyringe>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<TheSyringe>()] = ModContent.ItemType<Virulence>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<Virulence>()] = ModContent.ItemType<TheHive>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<TheHive>()] = ModContent.ItemType<Malevolence>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<Malevolence>()] = ModContent.ItemType<PlagueStaff>();

            // provi
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<PurgeGuzzler>()] = ModContent.ItemType<DazzlingStabberStaff>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<DazzlingStabberStaff>()] = ModContent.ItemType<MoltenAmputator>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<MoltenAmputator>()] = ModContent.ItemType<BurningRevelation>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<BurningRevelation>()] = ModContent.ItemType<HolyCollider>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<HolyCollider>()] = ModContent.ItemType<BlissfulBombardier>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<BlissfulBombardier>()] = ModContent.ItemType<TelluricGlare>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<TelluricGlare>()] = ModContent.ItemType<PurgeGuzzler>();

            // Dragonfolly
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<RougeSlash>()] = ModContent.ItemType<GildedProboscis>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<GildedProboscis>()] = ModContent.ItemType<GoldenEagle>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<GoldenEagle>()] = ModContent.ItemType<RougeSlash>();

            // Desert Scourge
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<SandstreamScepter>()] = ModContent.ItemType<BrittleStarStaff>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<BrittleStarStaff>()] = ModContent.ItemType<ScourgeoftheDesert>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<ScourgeoftheDesert>()] = ModContent.ItemType<SaharaSlicers>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<SaharaSlicers>()] = ModContent.ItemType<Barinade>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<Barinade>()] = ModContent.ItemType<SandstreamScepter>();

            // Brimmy
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<SeethingDischarge>()] = ModContent.ItemType<DormantBrimseeker>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<DormantBrimseeker>()] = ModContent.ItemType<Brimlance>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<Brimlance>()] = ModContent.ItemType<Hellborn>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<Hellborn>()] = ModContent.ItemType<SeethingDischarge>();

            // Hive Mind
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<ShaderainStaff>()] = ModContent.ItemType<DankStaff>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<DankStaff>()] = ModContent.ItemType<RotBall>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<RotBall>()] = ModContent.ItemType<PerfectDark>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<PerfectDark>()] = ModContent.ItemType<Shadethrower>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<Shadethrower>()] = ModContent.ItemType<ShaderainStaff>();

            // Cryogen
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<SnowstormStaff>()] = ModContent.ItemType<Icebreaker>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<Icebreaker>()] = ModContent.ItemType<Avalanche>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<Avalanche>()] = ModContent.ItemType<HoarfrostBow>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<HoarfrostBow>()] = ModContent.ItemType<SnowstormStaff>();

            // Astrum Deus
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<StarShower>()] = ModContent.ItemType<StarspawnHelixStaff>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<StarspawnHelixStaff>()] = ModContent.ItemType<RegulusRiot>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<RegulusRiot>()] = ModContent.ItemType<TheMicrowave>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<TheMicrowave>()] = ModContent.ItemType<StarSputter>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<StarSputter>()] = ModContent.ItemType<StarShower>();

            // Old Duke
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<VitriolicViper>()] = ModContent.ItemType<CadaverousCarrion>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<CadaverousCarrion>()] = ModContent.ItemType<MutatedTruffle>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<MutatedTruffle>()] = ModContent.ItemType<ToxicantTwister>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<ToxicantTwister>()] = ModContent.ItemType<InsidiousImpaler>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<InsidiousImpaler>()] = ModContent.ItemType<FetidEmesis>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<FetidEmesis>()] = ModContent.ItemType<SepticSkewer>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<SepticSkewer>()] = ModContent.ItemType<VitriolicViper>();

            // Storm Weaver
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<TheStorm>()] = ModContent.ItemType<Volterion>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<Volterion>()] = ModContent.ItemType<SkytideDragoon>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<SkytideDragoon>()] = ModContent.ItemType<TheStorm>();

            // Ceaseless
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<MirrorBlade>()] = ModContent.ItemType<VoidConcentrationStaff>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<VoidConcentrationStaff>()] = ModContent.ItemType<MirrorBlade>();

            // Signus
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<CosmicKunai>()] = ModContent.ItemType<Cosmilamp>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<Cosmilamp>()] = ModContent.ItemType<CosmicKunai>();
        }
    }
}