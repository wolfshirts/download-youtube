using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using YoutubeExplode.Models.MediaStreams;
using YoutubeExplode;


namespace download_youtube
{
    public partial class Form1 : Form
    {
        enum RadioButtonState
        {
            audio,
            video,
            invalid
        }

        private RadioButtonState buttonSelected()
        {
            if (audioRadioButton.Checked)
                return RadioButtonState.audio;
            if (videoRadioButton.Checked)
                return RadioButtonState.video;
            return RadioButtonState.invalid;
        }

        public Form1()
        {
            InitializeComponent();
        }

        string saveFileLocation()
        {
            SaveFileDialog save = new SaveFileDialog();
            if(save.ShowDialog() == DialogResult.OK)
            {
                return save.FileName.ToString();
            }
            else
            {
                return null;
            }
        }

        void invalidSaveError()
        {
            MessageBox.Show("Invalid save location.", "Invalid Save Error");
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            string saveLocation;

            switch (buttonSelected())
            {
                case RadioButtonState.audio:
                    saveLocation = saveFileLocation();
                    if (saveLocation != null)
                        getVideo(urlTextBox.Text, saveLocation, false);
                    else
                    {
                        invalidSaveError();
                        return;
                    }
                    break;
                case RadioButtonState.video: 
                    saveLocation = saveFileLocation();
                    if (saveLocation != null)
                        getVideo(urlTextBox.Text, saveLocation, true);
                    else
                    {
                        invalidSaveError();
                        return;
                    }
                    break;
                case RadioButtonState.invalid: MessageBox.Show("You must select a format.", "Invalid Format Error"); return;
                default:
                    break;
            }
        }

        private async void getVideo( string address, string saveLocation, bool video)
        {
            var client = new YoutubeClient();
            var id = YoutubeClient.ParseVideoId(address);
            var streamInfoSet = await client.GetVideoMediaStreamInfosAsync(id);
            var streamInfo = streamInfoSet.Muxed.WithHighestVideoQuality();
            var ext = streamInfo.Container.GetFileExtension();
            if( video )
                await client.DownloadMediaStreamAsync(streamInfo, saveLocation+"."+ext);
            if (!video)
            {
                await client.DownloadMediaStreamAsync(streamInfo, saveLocation + "." + "mp3");
               // var idMatch = 
            }
        }
    }
}
