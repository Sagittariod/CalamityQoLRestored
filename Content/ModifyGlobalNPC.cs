using System;
using CalamityMod;
using CalamityMod.CalPlayer;
using CalamityMod.Items.Accessories.Vanity;
using CalamityMod.Items.Potions.Alcohol;
using CalamityMod.Items.TreasureBags.MiscGrabBags;
using CalamityMod.NPCs;
using CalamityMod.NPCs.TownNPCs;
using Terraria;
using Terraria.GameContent;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace CruxMod.Content.CalReferencing
{
    public class ModifyGlobalNPC : GlobalNPC
    {
        public override void ModifyShop(NPCShop shop)
        {
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
                .AddWithCustomValue(ItemID.Spaghetti, Item.buyPrice(gold: 5), Condition.DownedSkeletron)
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
        }
    }

}
