using System;
using System.Collections.Generic;
using System.Linq;
using CalamityMod.Enums;
using CalamityMod.Items.Accessories.Vanity;
using CalamityMod.Items.Tools;
using CalamityMod.Items.VanillaArmorChanges;
using CalamityMod.Items.Weapons.Melee;
using CalamityMod.Tiles.Abyss;
using CalamityMod.Tiles.Astral;
using CalamityMod.Tiles.DraedonStructures;
using CalamityMod.Tiles.DraedonSummoner;
using CalamityMod.Tiles.Furniture.CraftingStations;
using CalamityMod.Tiles.SunkenSea;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.GameContent.Achievements;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CalamityQoLRestored.Content
{
    public class ModifyGlobalTile : GlobalTile
    {
        CalamityQoLRestoredConfig config = ModContent.GetInstance<CalamityQoLRestoredConfig>();

        public override void PreShakeTree(int x, int y, TreeTypes treeType)
        {
            if (!config.FruitChanceBuffs)
                return;

            // Add an additional 25% chance to drop vanilla fruits
            if (WorldGen.genRand.NextBool(4))
            {
                int treeDropItemType = 0;
                switch (treeType)
                {
                    case TreeTypes.Forest:

                        switch (WorldGen.genRand.Next(5))
                        {
                            case 0:
                                treeDropItemType = ItemID.Apple;
                                break;
                            case 1:
                                treeDropItemType = ItemID.Apricot;
                                break;
                            case 2:
                                treeDropItemType = ItemID.Peach;
                                break;
                            case 3:
                                treeDropItemType = ItemID.Grapefruit;
                                break;
                            default:
                                treeDropItemType = ItemID.Lemon;
                                break;
                        }
                        break;

                    case TreeTypes.Snow:
                        treeDropItemType = WorldGen.genRand.NextBool() ? ItemID.Cherry : ItemID.Plum;
                        break;

                    case TreeTypes.Jungle:
                        treeDropItemType = WorldGen.genRand.NextBool() ? ItemID.Mango : ItemID.Pineapple;
                        break;

                    case TreeTypes.Palm:
                        if (WorldGen.IsPalmOasisTree(x))
                            treeDropItemType = WorldGen.genRand.NextBool() ? ItemID.Banana : ItemID.Coconut;
                        break;

                    case TreeTypes.PalmCorrupt:
                        if (WorldGen.genRand.NextBool())
                            treeDropItemType = WorldGen.genRand.NextBool() ? ItemID.BlackCurrant : ItemID.Elderberry;
                        else if (WorldGen.IsPalmOasisTree(x))
                            treeDropItemType = WorldGen.genRand.NextBool() ? ItemID.Banana : ItemID.Coconut;
                        else
                            treeDropItemType = WorldGen.genRand.NextBool() ? ItemID.BlackCurrant : ItemID.Elderberry;
                        break;

                    case TreeTypes.Corrupt:
                        treeDropItemType = WorldGen.genRand.NextBool() ? ItemID.BlackCurrant : ItemID.Elderberry;
                        break;

                    case TreeTypes.PalmHallowed:
                        if (WorldGen.genRand.NextBool())
                            treeDropItemType = WorldGen.genRand.NextBool() ? ItemID.Dragonfruit : ItemID.Starfruit;
                        else if (WorldGen.IsPalmOasisTree(x))
                            treeDropItemType = WorldGen.genRand.NextBool() ? ItemID.Banana : ItemID.Coconut;
                        else
                            treeDropItemType = WorldGen.genRand.NextBool() ? ItemID.Dragonfruit : ItemID.Starfruit;
                        break;

                    case TreeTypes.Hallowed:
                        treeDropItemType = WorldGen.genRand.NextBool() ? ItemID.Dragonfruit : ItemID.Starfruit;
                        break;

                    case TreeTypes.PalmCrimson:
                        if (WorldGen.genRand.NextBool())
                            treeDropItemType = WorldGen.genRand.NextBool() ? ItemID.BloodOrange : ItemID.Rambutan;
                        else if (WorldGen.IsPalmOasisTree(x))
                            treeDropItemType = WorldGen.genRand.NextBool() ? ItemID.Banana : ItemID.Coconut;
                        else
                            treeDropItemType = WorldGen.genRand.NextBool() ? ItemID.BloodOrange : ItemID.Rambutan;
                        break;

                    case TreeTypes.Crimson:
                        treeDropItemType = WorldGen.genRand.NextBool() ? ItemID.BloodOrange : ItemID.Rambutan;
                        break;

                    case TreeTypes.Ash:
                        treeDropItemType = WorldGen.genRand.NextBool() ? ItemID.Pomegranate : ItemID.SpicyPepper;
                        break;

                    default:
                        break;
                }

                if (treeDropItemType != 0)
                    Item.NewItem(WorldGen.GetItemSource_FromTreeShake(x, y), x * 16, y * 16, 16, 16, treeDropItemType);
            }
        }
    }
}
