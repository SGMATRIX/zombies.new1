﻿namespace Zombies
{
    class Offsets
    {
        public static int PlayerBase = 0x1083F4B8;
        public static int JumpHeightBase = 0x109361E8;
        public static int CMDBufferBase = 0x120A35C0;
        public static int ZMXPScaleBase = 0x108674B0;
        public static int XPScaleBase = 0x10AEF2F0;


        public static class PlayerCompPtr
        {
            public static int ArraySizeOffset = 0xB940;
            public static int InfraredVision = 0xE66;
            public static int GodMode = 0xE67;
            public static int RunSpeed = 0x5C30;
            public static int Ammo = 0x13D4;
            public static int Points = 0x5D14;
            public static int RapidFire1 = 0xE6C;
            public static int RapidFire2 = 0xE80;
            public static int Name = 0x5BDA;
            public static int CurrentUsedWeaponID = 0x28;
            public static int SetWeaponID = 0xB0;
            public static int PC_Name = 0x5C0A;
            public static int PC_RunSpeed = 0x5C60;

            public static int CritKill1 = 0x10CC;
            public static int CritKill2 = 0x10D2;
            public static int CritKill3 = 0x10E4;
            public static int CritKill4 = 0x10E8;
            public static int CritKill5 = 0x10C4;
            public static int CritKill6 = 0x10C8;
            public static int CritKill7 = 0x10D4;
            public static int CritKill8 = 0x10D6;

            public static int KillCount = 0x5CE8;
        }


        public class PlayerPedPtr
        {
            public static int Coords = 0x2D4;
            public static int HeadingXY = 0x38;
            public static int HeadingZ = 0x34;
            public static int ArraySizeOffset = 0x5F8;
        }

        public class ZombieBotListBase
        {
            public static int BotMaxHealth = 0x39C;
            public static int BotHealth = 0x398;
            public static int BotArraySizeOffset = 0x5F8;
            public static int Coords = 0x2D4;
        }

        public class ZombieGlobalClass
        {
            public static int ZombieLeftCount = 0x3C;
        }

        public class ZombieXpScaleBase
        {
            public static int XPGun = 0x30;
            public static int XPUserReal = 0x40;
        }
    }
}
