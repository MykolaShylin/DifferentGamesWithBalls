using SaluteWinFormsApp;
using System.Windows.Forms;

namespace AutoBlowUpSaluteWinFormApp
{
    public partial class AutoBlowUpSaluteForm : Form
    {
        Random random = new Random();
        LaunchingStarterSaluteBall launchSaluteBall;
        public AutoBlowUpSaluteForm()
        {
            InitializeComponent();
        }
        private void LaunchSaluteButton_Click(object sender, EventArgs e)
        {
            LaunchSaluteButton.Enabled = false;
            LightUp();
        }

        private void rocketLauncherTimer_Tick(object sender, EventArgs e)
        {
            if (launchSaluteBall.IsTimeToBlowUp())
            {
                if (launchSaluteBall.BlowUp())
                {
                    launchSaluteBall.Stop();
                    var x = launchSaluteBall.GetX();
                    var y = launchSaluteBall.GetY();
                    SaluteExplosion(x, y);
                    launchSaluteBall.Clear();
                    LightUp();
                }
            }
            
        }
        public void SaluteExplosion(float x, float y)
        {
            var count = random.Next(35, 51);
            for (int i = 0; i < count; i++)
            {
                var salute = new SaluteBall(this, x, y);
                salute.Start();
            }
        }
        private void LightUp()
        {
            launchSaluteBall = new(this);
            launchSaluteBall.Start();
            rocketLauncherTimer.Enabled = true;            
        }
    }
}