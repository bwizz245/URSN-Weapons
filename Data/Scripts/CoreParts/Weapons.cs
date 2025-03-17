using static Scripts.Structure;
using static Scripts.Structure.WeaponDefinition;
using static Scripts.Structure.WeaponDefinition.ModelAssignmentsDef;
using static Scripts.Structure.WeaponDefinition.HardPointDef;
using static Scripts.Structure.WeaponDefinition.HardPointDef.Prediction;
using static Scripts.Structure.WeaponDefinition.TargetingDef.BlockTypes;
using static Scripts.Structure.WeaponDefinition.TargetingDef.Threat;
using static Scripts.Structure.WeaponDefinition.TargetingDef;
using static Scripts.Structure.WeaponDefinition.TargetingDef.CommunicationDef.Comms;
using static Scripts.Structure.WeaponDefinition.TargetingDef.CommunicationDef.SecurityMode;
using static Scripts.Structure.WeaponDefinition.HardPointDef.HardwareDef;
using static Scripts.Structure.WeaponDefinition.HardPointDef.HardwareDef.HardwareType;

namespace Scripts {
    partial class Parts {
        WeaponDefinition URSN_Mjolnir => new WeaponDefinition {
            Assignments = new ModelAssignmentsDef {
                MountPoints = new[] {
                    new MountPointDef {
                        SubtypeId = "URSN_Mjolnir",
                        SpinPartId = "URSN_MjolnirBarrels",
                        MuzzlePartId = "URSN_MjolnirBarrels",
                        AzimuthPartId = "None",
                        ElevationPartId = "None",
                        DurabilityMod = 1f
                    }
                },
                Muzzles = new[] {
                    "muzzle_projectile_1"
                }
            },
            Targeting = new TargetingDef {
                Threats = new[] {
                    Grids,
                    Characters,
                    Projectiles
                },
                SubSystems = new[] {
                    Offense,
                    Thrust,
                    Power,
                    Steering,
                    Any
                },
                ClosestFirst = true,
                IgnoreDumbProjectiles = true,
                LockedSmartOnly = true,
                MinimumDiameter = 0,
                MaximumDiameter = 0,
                MinTargetDistance = 0,
                MaxTargetDistance = 0,
                TopTargets = 4,
                CycleTargets = 0,
                TopBlocks = 8,
                CycleBlocks = 0,
                StopTrackingSpeed = 0,
                UniqueTargetPerWeapon = false,
                MaxTrackingTime = 0,
                ShootBlanks = false,
                FocusOnly = false,
                EvictUniqueTargets = false,
                Communications = new CommunicationDef { 
                    StoreTargets = false,
                    StorageLimit = 0,
                    MaxConnections = 0,
                    StoreLimitPerBlock = false,
                    Mode = NoComms,
                    TargetPersists = false,
                    Security = Private
                }
            },
            HardPoint = new HardPointDef {
                PartName = "Mjolnir",
                DeviateShotAngle = 0.2f,
                AimLeadingPrediction = Accurate,
                DelayCeaseFire = 0,
                CanShootSubmerged = false,
                NpcSafe = false,
                ScanTrackOnly = false,
                Ui = new UiDef {
                    RateOfFire = true,
                    RateOfFireMin = 0.25f
                },
                HardWare = new HardwareDef {
                    InventorySize = 0.105f,
                    IdlePower = 0.001f,
                    Type = BlockWeapon
                },
                Other = new OtherDef {
                    RotateBarrelAxis = 3
                },
                Loading = new LoadingDef {
                    RateOfFire = 3600,
                    BarrelsPerShot = 1,
                    TrajectilesPerBarrel = 1,
                    ReloadTime = 0,
                    MagsToLoad = 1,
                    HeatPerShot = 5,
                    MaxHeat = 3000,
                    Cooldown = 0.95f,
                    HeatSinkRate = 100,
                    DegradeRof = true,
                    BarrelSpinRate = 600,
                    InventoryFillAmount = 0.5f,
                    InventoryLowAmount = 0.2f,
                    UseWorldInventoryVolumeMultiplier = true
                },
                Audio = new HardPointAudioDef {
                    FiringSound = "WepShipGatlingShot",
                    FiringSoundPerShot = true,
                    BarrelRotationSound = "WepShipGatlingRotation",
                    FireSoundEndDelay = 6
                }
            },
            Ammos = new[] {
                AP30x185
            }
        };
    }
}
