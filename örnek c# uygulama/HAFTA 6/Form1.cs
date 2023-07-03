namespace HAFTA_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("izmir");
            listBox1.Items.Add("antalya");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedItem != null)
                {
                    textBox2.Text = listBox1.SelectedItem.ToString();
                    textBox3.Text = listBox1.SelectedIndex.ToString();
                }
                else
                {
                    MessageBox.Show("listeden deðer seçiniz");
                }
            }

            catch (NullReferenceException ex) 
            { MessageBox.Show("hata olustu:" + ex.Message); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else
            {
                MessageBox.Show("listeden silenecek deðer seçiniz");
            }
        }
    }
}