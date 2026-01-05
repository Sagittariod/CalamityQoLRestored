using CalamityMod;
using CalamityMod.Items.Tools;
using CalamityMod.Items.TreasureBags.MiscGrabBags;
using CalamityMod.Items.Weapons.Magic;
using CalamityMod.Items.Weapons.Melee;
using CalamityMod.Items.Weapons.Ranged;
using CalamityMod.Items.Weapons.Rogue;
using CalamityMod.Items.Weapons.Summon;
using CalamityMod.Items.Weapons.Typeless;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityQoLRestored.Content
{
    public class ModifyItem : GlobalItem
    {

        public override void SetStaticDefaults()
        {
            SetStaticDefaults_ShimmerRecipes();
        }

        public override void ModifyItemLoot(Item item, ItemLoot itemLoot)
        {
            if (item.type == ModContent.ItemType<StarterBag>())
            {
                CalamityQoLRestoredConfig config = ModContent.GetInstance<CalamityQoLRestoredConfig>();
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