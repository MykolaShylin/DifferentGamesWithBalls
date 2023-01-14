namespace SaluteWinFormsApp
{
    public partial class SaluteForm : Form
    {
        public SaluteForm()
        {
            InitializeComponent();
        }

        private void SaluteForm_MouseDown(object sender, MouseEventArgs e)
        {
            var random = new Random();
            var count = random.Next(35, 51);

            for (int i = 0; i < count; i++)
            {
                var salute = new SaluteBall(this, e.X, e.Y);
                salute.Start();
            }
        }
    }
}