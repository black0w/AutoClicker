using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClicker_Black0wl
{
    public static class SoundPlayer
    {
        public static void PlayStartSound()
        {
            using (var soundPlayer = new System.Media.SoundPlayer(Properties.Resources.switch_3))
            {
                soundPlayer.Play();
            }
        }

        public static void PlayStopSound()
        {
            using (var soundPlayer = new System.Media.SoundPlayer(Properties.Resources.switch_7))
            {
                soundPlayer.Play();
            }
        }
    }
}
