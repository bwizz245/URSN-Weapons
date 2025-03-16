using static Scripts.Structure.WeaponDefinition;
using static Scripts.Structure.WeaponDefinition.AmmoDef;
using static Scripts.Structure.WeaponDefinition.AmmoDef.EjectionDef;
using static Scripts.Structure.WeaponDefinition.AmmoDef.EjectionDef.SpawnType;
using static Scripts.Structure.WeaponDefinition.AmmoDef.ShapeDef.Shapes;
using static Scripts.Structure.WeaponDefinition.AmmoDef.DamageScaleDef.CustomScalesDef.SkipMode;
using static Scripts.Structure.WeaponDefinition.AmmoDef.GraphicDef;
using static Scripts.Structure.WeaponDefinition.AmmoDef.FragmentDef;
using static Scripts.Structure.WeaponDefinition.AmmoDef.PatternDef.PatternModes;
using static Scripts.Structure.WeaponDefinition.AmmoDef.FragmentDef.TimedSpawnDef.PointTypes;
using static Scripts.Structure.WeaponDefinition.AmmoDef.TrajectoryDef;
using static Scripts.Structure.WeaponDefinition.AmmoDef.TrajectoryDef.ApproachDef.Conditions;
using static Scripts.Structure.WeaponDefinition.AmmoDef.TrajectoryDef.ApproachDef.UpRelativeTo;
using static Scripts.Structure.WeaponDefinition.AmmoDef.TrajectoryDef.ApproachDef.FwdRelativeTo;
using static Scripts.Structure.WeaponDefinition.AmmoDef.TrajectoryDef.ApproachDef.ReInitCondition;
using static Scripts.Structure.WeaponDefinition.AmmoDef.TrajectoryDef.ApproachDef.RelativeTo;
using static Scripts.Structure.WeaponDefinition.AmmoDef.TrajectoryDef.ApproachDef.ConditionOperators;
using static Scripts.Structure.WeaponDefinition.AmmoDef.TrajectoryDef.ApproachDef.StageEvents;
using static Scripts.Structure.WeaponDefinition.AmmoDef.TrajectoryDef.ApproachDef;
using static Scripts.Structure.WeaponDefinition.AmmoDef.TrajectoryDef.GuidanceType;
using static Scripts.Structure.WeaponDefinition.AmmoDef.DamageScaleDef;
using static Scripts.Structure.WeaponDefinition.AmmoDef.DamageScaleDef.ShieldDef.ShieldType;
using static Scripts.Structure.WeaponDefinition.AmmoDef.DamageScaleDef.DeformDef.DeformTypes;
using static Scripts.Structure.WeaponDefinition.AmmoDef.AreaOfDamageDef;
using static Scripts.Structure.WeaponDefinition.AmmoDef.AreaOfDamageDef.Falloff;
using static Scripts.Structure.WeaponDefinition.AmmoDef.AreaOfDamageDef.AoeShape;
using static Scripts.Structure.WeaponDefinition.AmmoDef.EwarDef;
using static Scripts.Structure.WeaponDefinition.AmmoDef.EwarDef.EwarMode;
using static Scripts.Structure.WeaponDefinition.AmmoDef.EwarDef.EwarType;
using static Scripts.Structure.WeaponDefinition.AmmoDef.EwarDef.PushPullDef.Force;
using static Scripts.Structure.WeaponDefinition.AmmoDef.GraphicDef.LineDef;
using static Scripts.Structure.WeaponDefinition.AmmoDef.GraphicDef.LineDef.FactionColor;
using static Scripts.Structure.WeaponDefinition.AmmoDef.GraphicDef.LineDef.TracerBaseDef;
using static Scripts.Structure.WeaponDefinition.AmmoDef.GraphicDef.LineDef.Texture;
using static Scripts.Structure.WeaponDefinition.AmmoDef.GraphicDef.DecalDef;
using static Scripts.Structure.WeaponDefinition.AmmoDef.DamageScaleDef.DamageTypes.Damage;

using System.ComponentModel;

namespace Scripts
{
    partial class Parts {
        private AmmoDef AP30x185 => new AmmoDef {
            AmmoMagazine = "URSN_M76Cartridge",
            AmmoRound = "30mm M76 AP",
            TerminalName = "30mm Armor Piercing",
            BaseDamage = 120f,
            BaseDamageCutoff = 48f,
            DecayPerShot = 0.0216666f,
            HardPointUsable = true,
            Shape = new ShapeDef {
                Shape = LineShape,
                Diameter = 20
            },
            Fragment = new FragmentDef {
                AmmoRound = "30mmAPFrag",
                Fragments = 50,
                Degrees = 30,
                MaxChildren = 0,
                IgnoreArming = true,
                ArmWhenHit = false,

            },
            DamageScales = new DamageScaleDef {
                DamageVoxels = false,
                SelfDamage = true,
                HealthHitModifier = 1,
                Grids = new GridSizeDef {
                    Large = 1f,
                    Small = 1f
                },
                Armor = new ArmorDef {
                    Armor = 1f,
                    NonArmor = 0.25f
                },
                Shields = new ShieldDef {
                    Modifier = 1.5f,
                },
                DamageType = new DamageTypes {
                    Base = Kinetic,
                    Shield = Kinetic
                }
            },
            Trajectory = new TrajectoryDef {
                MaxLifeTime = 156,
                DesiredSpeed = 1160,
                MaxTrajectory = 3000,
                GravityMultiplier = 1f
            },
            AmmoGraphics = new GraphicDef {
                VisualProbability = 1f,
                ShieldHitDraw = false,
                Decals = new DecalDef {
                    MaxAge = 3600,
                    Map = new[] {
                        new TextureMapDef {
                            HitMaterial = "Metal",
                            DecalMaterial = "GunBullet"
                        },
                        new TextureMapDef {
                            HitMaterial = "Glass",
                            DecalMaterial = "GunBullet"
                        }
                    }
                },
                Lines = new LineDef {
                    Tracer = new TracerBaseDef {
                        Enable = true,
                        Length = 5f,
                        Width = 0.1f,
                        Color = Color(red: 3, green: 2, blue: 1, alpha: 1),
                        FactionColor = DontUse,
                        VisualFadeStart = 0,
                        VisualFadeEnd = 0,
                        AlwaysDraw = false,
                        Textures = new[] {
                            "WeaponLaser"
                        },
                        TextureMode = Normal
                    }
                }
            }
        };

        private AmmoDef AP30x185Frag => new AmmoDef {
            AmmoMagazine = "Energy",
            AmmoRound = "30mmAPFrag",
            EnergyCost = 0f,
            BaseDamage = 20f,
            BaseDamageCutoff = 20f,
            Health = 0,
            DecayPerShot = 0f,
            HardPointUsable = false,
            Shape = new ShapeDef {
                Shape = LineShape
            },
            DamageScales = new DamageScaleDef {
                DamageVoxels = false,
                HealthHitModifier = 1,
                Characters = 2f,
                Grids = new GridSizeDef { 
                    Large = 1f,
                    Small = 1f
                },
                Armor = new ArmorDef {
                    Armor = 0.25f,
                    NonArmor = 1f
                },
                Shields = new ShieldDef { 
                    Modifier = 1.5f,
                    Type = Default
                },
                DamageType = new DamageTypes { 
                    Base = Kinetic,
                    Shield = Kinetic
                },
                Deform = new DeformDef { 
                    DeformType = NoDeform
                }
            },
            Trajectory = new TrajectoryDef { 
                MaxLifeTime = 2,
                DesiredSpeed = 500,
                MaxTrajectory = 20f,
                GravityMultiplier = 0f,
                SpeedVariance = Random(start: 0, end: 0)
            }
        };
    }
}
