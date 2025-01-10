namespace Quiz
{
    public partial class Form1 : Form
    {
        private Color originalcolor;
        public Form1()
        {
            InitializeComponent();
            originalcolor = button1.BackColor;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            await Task.Delay(500);
            button1.BackColor = originalcolor;
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
            await Task.Delay(500);
            button3.BackColor = originalcolor;
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Red;
            await Task.Delay(500);
            button4.BackColor = originalcolor;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.LightGreen;
            await Task.Delay(500);
            button2.BackColor = originalcolor;
        }
    }
}
