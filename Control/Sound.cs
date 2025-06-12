using System;
using System.IO;
using System.Media;
using System.Windows.Forms;
using NAudio.Wave;

namespace Pikachu_team21
{
    class Sound
    {
        private static Sound _instance;
        private SoundPlayer backgroundPlayer;
        private bool isPlaying = false;

        public bool IsPlaying() { return isPlaying; }
        public static Sound Instance => _instance ?? (_instance = new Sound());

        private Sound() { }

        public void PlaySou(string resourceName)
        {
            StopSou();
            var resource = Properties.Resources.ResourceManager.GetObject(resourceName);

            if (resource is byte[] byteArray)
            {
                using (var stream = new MemoryStream(byteArray))
                {
                    backgroundPlayer = new SoundPlayer(stream);
                    backgroundPlayer.PlayLooping();
                    isPlaying = true;
                }
            }
            else
            {
                MessageBox.Show($"Resource '{resourceName}' không phải âm thanh hợp lệ, kiểm tra lại địnhu dạng file trong resources!");
            }
        }

        public void StopSou()
        {
            backgroundPlayer?.Stop();
            backgroundPlayer = null;
            isPlaying = false;
        }

        public void PlayEffect(string effectName) 
        {
            var resource = Properties.Resources.ResourceManager.GetObject(effectName);

            if (resource is byte[] byteArray)
            {
                using (var stream = new MemoryStream(byteArray))
                {
                    backgroundPlayer = new SoundPlayer(stream);
                    backgroundPlayer.Play();
                    isPlaying = true;
                }
            }
            else
            {
                MessageBox.Show($"Resource '{effectName}' không phải âm thanh hợp lệ, kiểm tra lại địnhu dạng file trong resources!");
            }
        }
    }
}
