using System;
using System.IO;
using System.Media;
using System.Windows.Forms;
using NAudio.Wave;

namespace Pikachu_team21
{
    class AmThanh
    {
        private static AmThanh _instance;
        private SoundPlayer amNen;
        private bool isPlaying = false;

        public bool IsPlaying() { return isPlaying; }
        public static AmThanh Instance => _instance ?? (_instance = new AmThanh());

        private AmThanh() { }

        public void PlaySou(string tenAmthanh)
        {
            StopSou();
            var resource = Properties.Resources.ResourceManager.GetObject(tenAmthanh);

            if (resource is byte[] byteArray)
            {
                using (var stream = new MemoryStream(byteArray))
                {
                    amNen = new SoundPlayer(stream);
                    amNen.PlayLooping();
                    isPlaying = true;
                }
            }
            else
            {
                MessageBox.Show($"Resource '{tenAmthanh}' không phải âm thanh hợp lệ, kiểm tra lại địnhu dạng file trong resources!");
            }
        }

        public void StopSou()
        {
            amNen?.Stop();
            amNen = null;
            isPlaying = false;
        }

        public void PlayEffect(string effectName) 
        {
            var resource = Properties.Resources.ResourceManager.GetObject(effectName);

            if (resource is byte[] byteArray)
            {
                using (var stream = new MemoryStream(byteArray))
                {
                    amNen = new SoundPlayer(stream);
                    amNen.Play();
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
