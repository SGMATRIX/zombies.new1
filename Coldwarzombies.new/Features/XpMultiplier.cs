using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using BlueRain;

namespace Zombies.Features
{
    class XpMultiplier
    {
        private IntPtr _baseAddress;
        private NativeMemory _memory;

        public XpMultiplier(IntPtr baseAddress, NativeMemory memory)
        {
            _baseAddress = baseAddress;
            _memory = memory;
        }

        public void PlayerXpMultiplier(float multiplier)
        {
            for (int i = 0; i < 11; i++)
            {
                _memory.Write(_baseAddress + Offsets.XPScaleBase + Offsets.ZombieXpScaleBase.XPUserReal, multiplier + (i * 0x28));
                //_memory.Write(_baseAddress + Offsets.ZMXPScaleBase + Offsets.ZombieXpScaleBase.XPUserFake, multiplier);
            }
        }

        public void GunXpMultiplier(float multiplier)
        {
            for (int i = 0; i < 12; i++)
            {
                _memory.Write(_baseAddress + Offsets.XPScaleBase + Offsets.ZombieXpScaleBase.XPGun, multiplier + (i * 0x30));
            }
        }
    }
}
