using CalamityMod.Projectiles.Rogue;
using System.Reflection;
using Terraria;
using Terraria.ModLoader;

namespace CalamityQoLRestored.Content
{
    public class ModifyGlobalProjectile : GlobalProjectile
    {
        public override bool AppliesToEntity(Projectile entity, bool lateInstantiation)
        {
            return entity.type == ModContent.ProjectileType<NanoblackMain>();
        }

        public override void PostAI(Projectile projectile)
        {
            // Ensure we are targeting the right projectile and the config is active
            if (projectile.type != ModContent.ProjectileType<NanoblackMain>() || !ModContent.GetInstance<CalamityQoLRestoredConfig>().NanoblackAccesibility)
                return;

            // 1f - LightspeedCarveState_CanImperfect
            // 2f - LightspeedCarveState_CanPerfect
            if (projectile.localAI[0] != 0f && projectile.ai[2] == 1f)
            {
                projectile.ai[2] = 2f;
                projectile.netUpdate = true;
            }
        }
    }
}