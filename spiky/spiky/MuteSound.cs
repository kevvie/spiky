using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace spiky
{
    class MuteSound
    {
        [DllImport("winmm.dll")]
        public static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);

        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);

     public MuteSound()
      {
         // Calculate the volume that's being set
         int NewVolume = (0);
         // Set the same volume for both the left and the right channels
         uint NewVolumeAllChannels = (((uint)NewVolume & 0x0000ffff) | ((uint)NewVolume << 16));
         // Set the volume
         waveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels);
      }
    }
}
