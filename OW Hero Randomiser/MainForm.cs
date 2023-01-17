namespace OW_Hero_Randomiser
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            
            OnePlayerForm Check = new OnePlayerForm();
            Check.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TwoPlayerForm Check = new TwoPlayerForm();
            Check.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ThreePlayerForm Check = new ThreePlayerForm();
            Check.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FourPlayerForm Check = new FourPlayerForm();
            Check.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FivePlayerForm Check = new FivePlayerForm();
            Check.Show();
            Hide();
        }
    }
}