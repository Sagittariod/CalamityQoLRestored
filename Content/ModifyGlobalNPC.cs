using CalamityMod;
using CalamityMod.Buffs.Summon;
using CalamityMod.CalPlayer;
using CalamityMod.Items.Accessories;
using CalamityMod.Items.Accessories.Vanity;
using CalamityMod.Items.Accessories.Wings;
using CalamityMod.Items.Materials;
using CalamityMod.Items.Potions.Alcohol;
using CalamityMod.Items.TreasureBags.MiscGrabBags;
using CalamityMod.Items.Weapons.Magic;
using CalamityMod.Items.Weapons.Melee;
using CalamityMod.Items.Weapons.Ranged;
using CalamityMod.Items.Weapons.Rogue;
using CalamityMod.Items.Weapons.Summon;
using CalamityMod.NPCs;
using CalamityMod.NPCs.Abyss;
using CalamityMod.NPCs.AcidRain;
using CalamityMod.NPCs.AquaticScourge;
using CalamityMod.NPCs.Astral;
using CalamityMod.NPCs.AstrumAureus;
using CalamityMod.NPCs.AstrumDeus;
using CalamityMod.NPCs.BrimstoneElemental;
using CalamityMod.NPCs.Bumblebirb;
using CalamityMod.NPCs.CalClone;
using CalamityMod.NPCs.CeaselessVoid;
using CalamityMod.NPCs.Crabulon;
using CalamityMod.NPCs.Cryogen;
using CalamityMod.NPCs.DesertScourge;
using CalamityMod.NPCs.DevourerofGods;
using CalamityMod.NPCs.ExoMechs.Ares;
using CalamityMod.NPCs.HiveMind;
using CalamityMod.NPCs.Leviathan;
using CalamityMod.NPCs.OldDuke;
using CalamityMod.NPCs.Perforator;
using CalamityMod.NPCs.PlaguebringerGoliath;
using CalamityMod.NPCs.Polterghast;
using CalamityMod.NPCs.ProfanedGuardians;
using CalamityMod.NPCs.Providence;
using CalamityMod.NPCs.Ravager;
using CalamityMod.NPCs.Signus;
using CalamityMod.NPCs.SlimeGod;
using CalamityMod.NPCs.StormWeaver;
using CalamityMod.NPCs.SulphurousSea;
using CalamityMod.NPCs.SunkenSea;
using CalamityMod.NPCs.SupremeCalamitas;
using CalamityMod.NPCs.TownNPCs;
using CalamityMod.NPCs.Yharon;
using CalamityQoLRestored;
using CalamityQoLRestored.Content.Items;
using System;
using Terraria;
using Terraria.GameContent;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;

namespace CalamityQolRestored.Content
{
    public class ModifyGlobalNPC : GlobalNPC
    {
        // Logic for re-implementing Calamity's alternate method of obtaining a Golden Fishing Rod
        internal const float TrasherEatDistance = 96f;
        public static readonly Condition TrasherTextCondition = new Condition(
            Language.GetOrRegister("Mods.CalamityMod.Condition.Drops.TrasherKill"),
            () => true
        );

        public static readonly IItemDropRuleCondition AnglerFedToTrasherCondition = new DelegateCondition((info) =>
        {
            foreach (NPC nearby in Main.ActiveNPCs)
            {
                // Check if the nearby NPC is a Trasher
                if (nearby.type == ModContent.NPCType<Trasher>())
                {
                    if (info.npc.Distance(nearby.Center) < TrasherEatDistance)
                        return true;
                }
            }
            return false;
        });

        // The text is a separate rule so it doesn't show up on the non-Trasher Fishing Rod drop which only occurs if the Angler is not fed to a Trasher
        public static IItemDropRuleCondition TrasherText => TrasherTextCondition.ToDropCondition(ShowItemDropInUI.Always);


        public override void ModifyShop(NPCShop shop)
        {
            CalamityQoLRestoredConfig config = ModContent.GetInstance<CalamityQoLRestoredConfig>();
            if (!config.NPCShopChanges)
                return;

            if (shop.NpcType == NPCID.Merchant)
            {
                shop.AddWithCustomValue(ItemID.ArcheryPotion, Item.buyPrice(gold: 3), Condition.DownedEyeOfCthulhu)
                .AddWithCustomValue(ItemID.TitanPotion, Item.buyPrice(gold: 2), Condition.DownedSkeletron)
                .AddWithCustomValue(ItemID.ApprenticeBait, Item.buyPrice(silver: 5), Condition.DownedEyeOfCthulhu)
                .AddWithCustomValue(ItemID.JourneymanBait, Item.buyPrice(silver: 15), Condition.DownedSkeletron)
                .AddWithCustomValue(ItemID.MasterBait, Item.buyPrice(silver: 50), Condition.DownedPlantera)
                ;
            }

            if (shop.NpcType == NPCID.Dryad)
            {
                shop.AddWithCustomValue(ItemID.ThornsPotion, Item.buyPrice(gold: 1))
                .AddWithCustomValue(ItemID.FeatherfallPotion, Item.buyPrice(gold: 1))
                .AddWithCustomValue(ItemID.RegenerationPotion, Item.buyPrice(gold: 2), Condition.DownedEowOrBoc)
                .AddWithCustomValue(ItemID.SwiftnessPotion, Item.buyPrice(gold: 3), Condition.DownedEowOrBoc)
                ;
            }

            if (shop.NpcType == NPCID.Demolitionist)
            {
                shop.AddWithCustomValue(ItemID.MiningPotion, Item.buyPrice(gold: 1), Condition.DownedEyeOfCthulhu)
                .AddWithCustomValue(ItemID.IronskinPotion, Item.buyPrice(gold: 1), Condition.DownedEyeOfCthulhu)
                .AddWithCustomValue(ItemID.ShinePotion, Item.buyPrice(gold: 1), Condition.DownedEyeOfCthulhu)
                .AddWithCustomValue(ItemID.SpelunkerPotion, Item.buyPrice(gold: 2), Condition.DownedEowOrBoc)
                .AddWithCustomValue(ItemID.ObsidianSkinPotion, Item.buyPrice(gold: 2), Condition.DownedSkeletron)
                .AddWithCustomValue(ItemID.EndurancePotion, Item.buyPrice(gold: 3), Condition.DownedSkeletron)
                ;
            }

            if (shop.NpcType == NPCID.ArmsDealer)
            {
                shop.AddWithCustomValue(ItemID.HunterPotion, Item.buyPrice(gold: 2))
                .AddWithCustomValue(ItemID.BattlePotion, Item.buyPrice(gold: 2), Condition.DownedEowOrBoc)
                .AddWithCustomValue(ItemID.AmmoReservationPotion, Item.buyPrice(gold: 1))
                .AddWithCustomValue(ItemID.TacticalShotgun, Item.buyPrice(platinum: 1), Condition.DownedGolem)
                .AddWithCustomValue(ItemID.SniperRifle, Item.buyPrice(platinum: 1), Condition.DownedGolem)
                .AddWithCustomValue(ItemID.RifleScope, Item.buyPrice(platinum: 1), Condition.DownedGolem)
                ;
            }

            if (shop.NpcType == NPCID.GoblinTinkerer)
            {
                shop.AddWithCustomValue(ItemID.StinkPotion, Item.buyPrice(gold: 1))
                //.AddWithCustomValue(ItemID.Spaghetti, Item.buyPrice(gold: 5), Condition.DownedSkeletron)
                ;
            }

            if (shop.NpcType == NPCID.WitchDoctor)
            {
                shop.AddWithCustomValue(ItemID.SummoningPotion, Item.buyPrice(gold: 3))
                .AddWithCustomValue(ItemID.CalmingPotion, Item.buyPrice(gold: 1))
                .AddWithCustomValue(ItemID.RagePotion, Item.buyPrice(gold: 3))
                .AddWithCustomValue(ItemID.WrathPotion, Item.buyPrice(gold: 3))
                .AddWithCustomValue(ItemID.InfernoPotion, Item.buyPrice(gold: 2))
                ;
            }

            if (shop.NpcType == NPCID.Wizard)
            {
                shop.AddWithCustomValue(ItemID.ManaRegenerationPotion, Item.buyPrice(gold: 3))
                .AddWithCustomValue(ItemID.MagicPowerPotion, Item.buyPrice(gold: 3))
                .AddWithCustomValue(ItemID.GravitationPotion, Item.buyPrice(gold: 2))
                .AddWithCustomValue(ItemID.SpectreStaff, Item.buyPrice(platinum: 1), Condition.DownedGolem)
                .AddWithCustomValue(ItemID.InfernoFork, Item.buyPrice(platinum: 1), Condition.DownedGolem)
                .AddWithCustomValue(ItemID.ShadowbeamStaff, Item.buyPrice(platinum: 1), Condition.DownedGolem)
                .AddWithCustomValue(ItemID.MagnetSphere, Item.buyPrice(platinum: 1), Condition.DownedGolem)
                .AddWithCustomValue(ItemID.RodofDiscord, Item.buyPrice(platinum: 20), Condition.InHallow)
                ;
            }

            if (shop.NpcType == NPCID.Cyborg)
            {
                shop.AddWithCustomValue(ItemID.RocketLauncher, Item.buyPrice(platinum: 1), Condition.DownedGolem)
                ;
            }

            if (shop.NpcType == NPCID.PartyGirl)
            {
                shop.AddWithCustomValue(ItemID.HeartreachPotion, Item.buyPrice(gold: 2))
                .AddWithCustomValue(ItemID.LifeforcePotion, Item.buyPrice(gold: 4), Condition.Hardmode)
                .AddWithCustomValue(ItemID.LovePotion, Item.buyPrice(gold: 1))
                ;
            }
        }

        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            CalamityQoLRestoredConfig config = ModContent.GetInstance<CalamityQoLRestoredConfig>();

            if (!config.AlternateTerraprismaObtainmentMethod)
                goto GoldenFishingRodSection; // Skip this section.

            if (npc.type == NPCID.HallowBoss)
            {
                npcLoot.Add(ItemDropRule.Common(ItemID.EmpressBlade, 3)); // 1 in 3 chance, separate from any other loot tables.
            }


        GoldenFishingRodSection:

            if (!config.AlternateGoldenFishingRodObtainmentMethod)
                goto EnemyDropChangeZone; // Skip this section.

            if (npc.type == NPCID.Angler)
            {
                LeadingConditionRule trasherLCR = new LeadingConditionRule(AnglerFedToTrasherCondition);
                trasherLCR.Add(ItemDropRule.ByCondition(TrasherText, ItemID.GoldenFishingRod));
                npcLoot.Add(trasherLCR);
            }


        EnemyDropChangeZone:

            if (!config.EnemyDropRateChanges)
                goto AnglingKitZone; // Skip this section.

            // Reverting all astral enemy weapon drop rates to be 14.29% (from 10%)
            if (npc.type == ModContent.NPCType<Aries>())
            {
                npcLoot.RemoveWhere(rule => rule is CommonDrop drop && drop.itemId == ModContent.ItemType<StellarKnife>());
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<StellarKnife>(), 7));
            }
            else if (npc.type == ModContent.NPCType<Astraglomerate>())
            {
                npcLoot.RemoveWhere(rule => rule is CommonDrop drop && drop.itemId == ModContent.ItemType<HivePod>());
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<HivePod>(), 7));
            }
            else if (npc.type == ModContent.NPCType<AstralSlime>())
            {
                npcLoot.RemoveWhere(rule => rule is CommonDrop drop && drop.itemId == ModContent.ItemType<AbandonedSlimeStaff>());
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<AbandonedSlimeStaff>(), 7));
            }
            else if (npc.type == ModContent.NPCType<AstralachneaGround>())
            {
                npcLoot.RemoveWhere(rule => rule is CommonDrop drop && drop.itemId == ModContent.ItemType<AstralachneaStaff>());
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<AstralachneaStaff>(), 7));
            }
            else if (npc.type == ModContent.NPCType<AstralachneaWall>())
            {
                npcLoot.RemoveWhere(rule => rule is CommonDrop drop && drop.itemId == ModContent.ItemType<AstralachneaStaff>());
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<AstralachneaStaff>(), 7));
            }
            else if (npc.type == ModContent.NPCType<Atlas>())
            {
                npcLoot.RemoveWhere(rule => rule is CommonDrop drop && drop.itemId == ModContent.ItemType<TitanArm>());
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<TitanArm>(), 7));
            }
            else if (npc.type == ModContent.NPCType<Mantis>())
            {
                npcLoot.RemoveWhere(rule => rule is CommonDrop drop && drop.itemId == ModContent.ItemType<AstralScythe>());
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<AstralScythe>(), 7));
            }
            else if (npc.type == ModContent.NPCType<Nova>())
            {
                npcLoot.RemoveWhere(rule => rule is CommonDrop drop && drop.itemId == ModContent.ItemType<GloriousEnd>());
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<GloriousEnd>(), 7));

                npcLoot.RemoveWhere(rule => rule is CommonDrop drop && drop.itemId == ModContent.ItemType<StellarCannon>());
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<StellarCannon>(), 7));
            }
            else if (npc.type == ModContent.NPCType<StellarCulex>())
            {
                npcLoot.RemoveWhere(rule => rule is CommonDrop drop && drop.itemId == ModContent.ItemType<StarbusterCore>());
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<StarbusterCore>(), 7));
            }

            if (npc.type == ModContent.NPCType<AquaticUrchin>())
            {
                npcLoot.RemoveWhere(rule => rule is CommonDrop drop && drop.itemId == ModContent.ItemType<UrchinStinger>());
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<UrchinStinger>(), 10));
            }

            if (npc.type == NPCID.ArmoredSkeleton)
            {
                npcLoot.RemoveWhere(rule => rule is CommonDrop drop && drop.itemId == ItemID.BeamSword);
                npcLoot.Add(ItemDropRule.Common(ItemID.BeamSword, 40));
            }

            if (npc.type == NPCID.BlackRecluse)
            {
                npcLoot.RemoveWhere(rule => rule is CommonDrop drop && drop.itemId == ItemID.PoisonStaff);
                npcLoot.Add(ItemDropRule.Common(ItemID.PoisonStaff, 20));
            }

            if (npc.type == NPCID.BloodJelly ||
                npc.type == NPCID.BlueJellyfish ||
                npc.type == ModContent.NPCType<BoxJellyfish>() ||
                npc.type == ModContent.NPCType<CannonballJellyfish>() ||
                npc.type == ModContent.NPCType<GhostBell>() ||
                npc.type == NPCID.GreenJellyfish ||
                npc.type == NPCID.PinkJellyfish)
            {
                npcLoot.RemoveWhere(rule => rule is CommonDrop drop && drop.itemId == ItemID.JellyfishNecklace);
                npcLoot.Add(ItemDropRule.Common(ItemID.JellyfishNecklace, 25));
            }

            if (npc.type == NPCID.BlueJellyfish)
            {
                npcLoot.RemoveWhere(rule => rule is CommonDrop drop && drop.itemId == ModContent.ItemType<CleansingJelly>());
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<CleansingJelly>(), 7));
            }

            if (npc.type == NPCID.BrainScrambler ||
                npc.type == NPCID.GigaZapper ||
                npc.type == NPCID.GrayGrunt ||
                npc.type == NPCID.RayGunner ||
                npc.type == NPCID.ScutlixRider)
            {
                npcLoot.RemoveWhere(rule => rule is CommonDrop drop && drop.itemId == ModContent.ItemType<DoomsdayDevice>());
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<DoomsdayDevice>(), 50));

                npcLoot.RemoveWhere(rule => rule is CommonDrop drop && drop.itemId == ModContent.ItemType<NullificationPistol>());
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<NullificationPistol>(), 50));

                npcLoot.RemoveWhere(rule => rule is CommonDrop drop && drop.itemId == ModContent.ItemType<Wingman>());
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Wingman>(), 50));
            }

            if (npc.type == NPCID.SandsharkCorrupt || npc.type == NPCID.SandsharkCrimson || npc.type == NPCID.DesertGhoulCorruption || npc.type == NPCID.DesertGhoulCrimson)
            {
                npcLoot.RemoveWhere(rule => rule is CommonDrop drop && drop.itemId == ItemID.DarkShard);
                npcLoot.Add(ItemDropRule.Common(ItemID.DarkShard, 10));
            }

            if (npc.type == NPCID.SandsharkHallow || npc.type == NPCID.DesertGhoulHallow)
            {
                npcLoot.RemoveWhere(rule => rule is CommonDrop drop && drop.itemId == ItemID.LightShard);
                npcLoot.Add(ItemDropRule.Common(ItemID.LightShard, 10));
            }

            if (npc.type == ModContent.NPCType<FlakCrab>())
            {
                npcLoot.RemoveWhere(rule => rule is CommonDrop drop && drop.itemId == ModContent.ItemType<FlakToxicannon>());
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<FlakToxicannon>(), 10));
            }

            if (npc.type == NPCID.Harpy)
            {
                npcLoot.RemoveWhere(rule => rule is CommonDrop drop && drop.itemId == ItemID.GiantHarpyFeather);
                npcLoot.Add(ItemDropRule.Common(ItemID.LightShard, 80));
            }

            if (npc.type == NPCID.Hellbat)
            {
                npcLoot.RemoveWhere(rule => rule is CommonDrop drop && drop.itemId == ItemID.MagmaStone);
                npcLoot.Add(ItemDropRule.Common(ItemID.MagmaStone, 75));
            }

            if (npc.type == NPCID.IceTortoise)
            {
                npcLoot.RemoveWhere(rule => rule is CommonDrop drop && drop.itemId == ItemID.FrozenTurtleShell);
                npcLoot.Add(ItemDropRule.Common(ItemID.FrozenTurtleShell, 20));
            }

            if (npc.type == NPCID.Lavabat)
            {
                npcLoot.RemoveWhere(rule => rule is CommonDrop drop && drop.itemId == ItemID.MagmaStone);
                npcLoot.Add(ItemDropRule.Common(ItemID.MagmaStone, 33));
            }

            if (npc.type == NPCID.MaggotZombie)
            {
                npcLoot.RemoveWhere(rule => rule is CommonDrop drop && drop.itemId == ModContent.ItemType<BloodOrb>());
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BloodOrb>(), 5));
            }

            if (npc.type == ModContent.NPCType<MorayEel>())
            {
                npcLoot.RemoveWhere(rule => rule is CommonDrop drop && drop.itemId == ItemID.Flipper);
                npcLoot.Add(ItemDropRule.Common(ItemID.Flipper, 10));
            }

            if (npc.type == NPCID.SkeletonArcher)
            {
                npcLoot.RemoveWhere(rule => rule is CommonDrop drop && drop.itemId == ItemID.MagicQuiver);
                npcLoot.Add(ItemDropRule.Common(ItemID.MagicQuiver, 20));

                npcLoot.RemoveWhere(rule => rule is CommonDrop drop && drop.itemId == ItemID.Marrow);
                npcLoot.Add(ItemDropRule.Common(ItemID.Marrow, 40));
            }

            if (npc.type == NPCID.TheBride || npc.type == NPCID.TheGroom)
            {
                npcLoot.RemoveWhere(rule => rule is CommonDrop drop && drop.itemId == ModContent.ItemType<BloodOrb>());
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BloodOrb>(), 1));
            }

        AnglingKitZone:

            if (!config.AnglingKitsRestored)
                goto ExpertReversionZone; // Skip this section.

            if (npc.type == ModContent.NPCType<DesertScourgeHead>())
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<SandyAnglingKit>(), 1));
            }

            if (npc.type == ModContent.NPCType<AquaticScourgeHead>())
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BleachedAnglingKit>(), 1));
            }


        ExpertReversionZone:

            if (!config.ExpertGatekeepRemoval)
                return;

            void RevertExpertGating(int itemId)
            {
                // Remove existing drop rule
                npcLoot.RemoveWhere(rule => rule is CommonDrop drop && drop.itemId == itemId);
                var normalOnly = npcLoot.DefineNormalOnlyDropSet();
                normalOnly.Add(itemId);
            }

            // Apparently can't use modcontent for switch cases so this is what we have to work with
            if (npc.type == ModContent.NPCType<DesertScourgeHead>())
                RevertExpertGating(ModContent.ItemType<OceanCrest>());

            else if (npc.type == ModContent.NPCType<Crabulon>())
                RevertExpertGating(ModContent.ItemType<FungalClump>());

            else if (npc.type == ModContent.NPCType<HiveMind>())
                RevertExpertGating(ModContent.ItemType<RottenBrain>());

            else if (npc.type == ModContent.NPCType<PerforatorHive>())
                RevertExpertGating(ModContent.ItemType<BloodyWormTooth>());

            else if (npc.type == ModContent.NPCType<SlimeGodCore>())
                RevertExpertGating(ModContent.ItemType<ManaPolarizer>());

            else if (npc.type == ModContent.NPCType<Cryogen>())
                RevertExpertGating(ModContent.ItemType<SoulofCryogen>());

            else if (npc.type == ModContent.NPCType<AquaticScourgeHead>())
                RevertExpertGating(ModContent.ItemType<AquaticEmblem>());

            else if (npc.type == ModContent.NPCType<CalamityMod.NPCs.BrimstoneElemental.BrimstoneElemental>()) // Skull
                RevertExpertGating(ModContent.ItemType<FlameLickedShell>());

            else if (npc.type == ModContent.NPCType<CalamitasClone>())
                RevertExpertGating(ModContent.ItemType<VoidofCalamity>());

            else if (npc.type == ModContent.NPCType<Leviathan>())
                RevertExpertGating(ModContent.ItemType<LeviathanAmbergris>());

            else if (npc.type == ModContent.NPCType<AstrumAureus>())
                RevertExpertGating(ModContent.ItemType<InterstellarStompers>());

            else if (npc.type == ModContent.NPCType<PlaguebringerGoliath>())
                RevertExpertGating(ModContent.ItemType<ToxicHeart>());

            else if (npc.type == ModContent.NPCType<RavagerBody>())
                RevertExpertGating(ModContent.ItemType<BloodPact>());

            else if (npc.type == ModContent.NPCType<Dragonfolly>())
                RevertExpertGating(ModContent.ItemType<DynamoStemCells>());

            else if (npc.type == ModContent.NPCType<ProfanedGuardianCommander>())
                RevertExpertGating(ModContent.ItemType<WarbanneroftheRighteous>());

            else if (npc.type == ModContent.NPCType<Providence>())
                RevertExpertGating(ModContent.ItemType<BlazingCore>());

            else if (npc.type == ModContent.NPCType<Signus>())
                RevertExpertGating(ModContent.ItemType<SpectralVeil>());

            else if (npc.type == ModContent.NPCType<CeaselessVoid>())
                RevertExpertGating(ModContent.ItemType<TheEvolution>());

            else if (npc.type == ModContent.NPCType<StormWeaverHead>())
                RevertExpertGating(ModContent.ItemType<ArcFlashRing>());

            else if (npc.type == ModContent.NPCType<Polterghast>())
                RevertExpertGating(ModContent.ItemType<Affliction>());

            else if (npc.type == ModContent.NPCType<OldDuke>())
                RevertExpertGating(ModContent.ItemType<OldDukeScales>());

            else if (npc.type == ModContent.NPCType<DevourerofGodsHead>())
                RevertExpertGating(ModContent.ItemType<NebulousCore>());

            else if (npc.type == ModContent.NPCType<Yharon>())
                RevertExpertGating(ModContent.ItemType<YharimsGift>());

            else if (npc.type == ModContent.NPCType<SupremeCalamitas>())
                RevertExpertGating(ModContent.ItemType<Calamity>());

            else if (npc.type == ModContent.NPCType<AresBody>())
                RevertExpertGating(ModContent.ItemType<DraedonsHeart>());

            // Vanilla 
            else
            {
                switch (npc.type)
                {
                    case NPCID.KingSlime:
                        RevertExpertGating(ItemID.RoyalGel);
                        break;

                    case NPCID.EyeofCthulhu:
                        RevertExpertGating(ItemID.EoCShield);
                        break;

                    case NPCID.EaterofWorldsHead:
                    case NPCID.EaterofWorldsBody:
                    case NPCID.EaterofWorldsTail:
                        LeadingConditionRule eowDeathRule = new LeadingConditionRule(new Conditions.LegacyHack_IsABoss());

                        npcLoot.RemoveWhere(rule => rule is CommonDrop drop && drop.itemId == ItemID.WormScarf);

                        eowDeathRule.OnSuccess(ItemDropRule.Common(ItemID.WormScarf));
                        npcLoot.Add(eowDeathRule);
                        break;

                    case NPCID.BrainofCthulhu:
                        RevertExpertGating(ItemID.BrainOfConfusion);
                        break;

                    case NPCID.QueenBee:
                        RevertExpertGating(ItemID.HiveBackpack);
                        break;

                    case NPCID.SkeletronHead:
                        RevertExpertGating(ItemID.BoneHelm);
                        RevertExpertGating(ItemID.BoneGlove);
                        break;

                    case NPCID.WallofFlesh:
                        RevertExpertGating(ItemID.DemonHeart);
                        break;

                    case NPCID.QueenSlimeBoss:
                        RevertExpertGating(ItemID.VolatileGelatin);
                        break;

                    case NPCID.Retinazer:
                    case NPCID.Spazmatism:
                    case NPCID.SkeletronPrime:
                    case NPCID.TheDestroyer:
                        RevertExpertGating(ItemID.MechanicalWagonPiece);
                        RevertExpertGating(ItemID.MechanicalWheelPiece);
                        RevertExpertGating(ItemID.MechanicalBatteryPiece);
                        break;

                    case NPCID.Plantera:
                        RevertExpertGating(ItemID.SporeSac);
                        break;

                    case NPCID.Golem:
                        RevertExpertGating(ItemID.ShinyStone);
                        break;

                    case NPCID.DukeFishron:
                        RevertExpertGating(ItemID.ShrimpyTruffle);
                        break;

                    case NPCID.HallowBoss:
                        RevertExpertGating(ItemID.EmpressFlightBooster);
                        break;

                    case NPCID.MoonLordCore:
                        RevertExpertGating(ItemID.GravityGlobe);
                        RevertExpertGating(ItemID.SuspiciousLookingTentacle);
                        RevertExpertGating(ItemID.LongRainbowTrailWings);
                        break;
                }
            }
        }
    }

    // Replicated from Calamity's DropHelper class for re-implementing the special Golden Fishing Rod obtainment condition
    public class DelegateCondition(Func<DropAttemptInfo, bool> condition) : IItemDropRuleCondition
    {
        private readonly Func<DropAttemptInfo, bool> condition = condition;

        public bool CanDrop(DropAttemptInfo info) => condition(info);

        public bool CanShowItemDropInUI() => true;

        public string GetConditionDescription() => null;
    }
}
