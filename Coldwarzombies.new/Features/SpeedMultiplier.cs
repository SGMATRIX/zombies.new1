using BlueRain;
using System;

namespace Zombies.Features
{
    class SpeedMultiplier
    {
        private IntPtr _baseAddress;
        private NativeMemory _memory;

        public SpeedMultiplier(IntPtr baseAddress, NativeMemory memory)
        {
            _baseAddress = baseAddress;
            _memory = memory;
        }

        public void SetSpeed(float speed)
        {
            for (int i = 0; i < 10; i++)
            {
                _memory.Write(false, speed, _baseAddress + Offsets.PlayerBase, (IntPtr)(Offsets.PlayerCompPtr.ArraySizeOffset * i) + Offsets.PlayerCompPtr.RunSpeed);
            }
        }

    }
}
