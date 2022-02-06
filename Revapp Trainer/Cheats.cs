using Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revapp_Trainer
{
    class Cheats
    {
        Mem memory = new Mem();
        RevappHelper revappHelper = new RevappHelper();
        Constants constants = new Constants();

        bool processAlive = false;
        int PID = 0;

        public bool isProcessAlive()
        {
            PID = memory.GetProcIdFromName(constants.processName);

            if (PID != 0)
            {
                processAlive = memory.OpenProcess(PID);

                return processAlive;

            }

            return false;
        }

            public void enableInfiniteAmmo()
        {

            byte[] freezebytesX = { 0xFF, 0x0E, 0x57, 0x8B, 0x7C, 0x24, 0x14 };
            UIntPtr codecavebase = memory.CreateCodeCave("base+637E9", freezebytesX, 7, 1000);
            UIntPtr codecaveAllocAddress = UIntPtr.Add(codecavebase, freezebytesX.Length);
            int newint = (int)codecaveAllocAddress - 7;

            memory.WriteMemory(newint.ToString("X"), "bytes", "0xC7 0x06 0x14 0x00 0x00 0x00");
            memory.WriteMemory(revappHelper.sanitizeAddressLastChar(newint.ToString("X"), "6"), "bytes", "0x57");
            memory.WriteMemory(revappHelper.sanitizeAddressLastChar(newint.ToString("X"), "7"), "bytes", "0x8B 0x7C 0x24 0x14");




            ulong from = revappHelper.stringToUlong(revappHelper.sanitizeAddressLastChar(newint.ToString("X"), "B"));
            ulong to = revappHelper.stringToUlong("0x004637F4");
            memory.WriteMemory(revappHelper.sanitizeAddressLastChar(newint.ToString("X"), "B"), "bytes", revappHelper.jumpAddress(to, from, false));
        }

        public void disableInfinteAmmo()
        {
            memory.WriteMemory("base+637E9", "bytes", "FF 0E 57 8B 7C 24 14");
        }

    }
}
