﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZombieGame.Game.Enums;

namespace ZombieGame.Game.Prefabs.Weapons
{
    public sealed class Pistol : Weapon
    {
        public Pistol() : base(WeaponTypes.Pistol, ProjectileTypes.PistolProjectile)
        {
            FireRate = 60f;
        }
    }
}
