using BlueRain;
using System;

namespace Zombies.Features
{
    class InfiniteAmmo
    {
        private IntPtr _baseAddress;
        private NativeMemory _memory;

        public InfiniteAmmo(IntPtr baseAddress, NativeMemory memory)
        {
            _baseAddress = baseAddress;
            _memory = memory;
        }

        public void DoInfiniteAmmo()
        {
            for (int i = 0; i < 6; i++)
            {
                _memory.Write(false, 50, _baseAddress + Offsets.PlayerBase, (IntPtr)(Offsets.PlayerCompPtr.ArraySizeOffset * i) + Offsets.PlayerCompPtr.Ammo);
            }
        }
    }
}
