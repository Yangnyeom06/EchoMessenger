namespace EchoMesseger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(textBox1.Text))
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
            }
        }
    }
}
