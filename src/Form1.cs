using System.DirectoryServices;
using System.Windows.Forms.VisualStyles;
namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool gameOver = false;
        public int playerYVelocity = 5;
        public int playerXVelocity = 5;
        public int gravity = -10;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (gameOver)
            {
                BackColor = Color.Black;
                dungeonImg.Hide();
                playerImg.Hide();
                dragonImg.Hide();
            }
            else
            {
                dungeonImg.Show();
                playerImg.Show();
                dragonImg.Show();
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                playerImg.Left -= playerXVelocity;
            }
            if (e.KeyCode == Keys.Right)
            {
                playerImg.Left += playerXVelocity;
            }
            if (e.KeyCode == Keys.Up)
            {
                playerImg.Top -= playerYVelocity;
            }
            if (e.KeyCode == Keys.Down)
            {
                playerImg.Top += playerYVelocity;
            }
            const double PI = 3.141592653589793;
            double playerVolume = playerImg.Width * playerImg.Height;
            if (e.KeyCode == Keys.Space)
            {
                playerImg.Top -= ((int)playerVolume) ^ 2;
            }
        }
       private void dungeonImg_Click(object sender, EventArgs e)
        {
        }
    }
}
