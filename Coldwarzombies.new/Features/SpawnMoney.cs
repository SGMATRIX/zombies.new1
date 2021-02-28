using BlueRain;
using System;

namespace Zombies.Features
{
    class SpawnMoney
    {
        private IntPtr _baseAddress;
        private NativeMemory _memory;

        public SpawnMoney(IntPtr baseAddress, NativeMemory memory)
        {
            _baseAddress = baseAddress;
            _memory = memory;
        }

        public void InfiniteMoney()
        {
            for (int i = 0; i < 9; i++)
            {
               _memory.Write(true, 80000000, _baseAddress + Offsets.PlayerBase, (IntPtr) (Offsets.PlayerCompPtr.ArraySizeOffset* i) + Offsets.PlayerCompPtr.Points);
            }
        }
    }
}
