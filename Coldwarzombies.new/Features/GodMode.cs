using BlueRain;
using System;

namespace Zombies.Features
{
    class GodMode
    {
        private IntPtr _baseAddress;
        private NativeMemory _memory;

        public GodMode(IntPtr baseAddress, NativeMemory memory)
        {
            _baseAddress = baseAddress;
            _memory = memory;
        }

        public void EnableGodMode()
        {
            for (int i = 0; i < 4; i++)
            {
                _memory.Write<byte>(false, 0xA0, _baseAddress + Offsets.PlayerBase, (IntPtr)(Offsets.PlayerCompPtr.ArraySizeOffset * i) + Offsets.PlayerCompPtr.GodMode);
            }
        }

        public void DisableGodMode()
        {
            for (int i = 0; i < 5; i++)
            {
                _memory.Write<byte>(false, 0x20, _baseAddress + Offsets.PlayerBase, (IntPtr)(Offsets.PlayerCompPtr.ArraySizeOffset * i) + Offsets.PlayerCompPtr.GodMode);

            }
        }
    }
}
