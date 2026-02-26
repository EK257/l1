namespace l1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = (int)numericUpDown1.Value;
            int n2 = (int)numericUpDown2.Value;
            int n3 = (int)numericUpDown3.Value;
            int n4 = (int)numericUpDown4.Value;
            int n5 = (int)numericUpDown5.Value;
            int n6 = (int)numericUpDown6.Value;
            int n7 = (int)numericUpDown7.Value;
            int n8 = (int)numericUpDown8.Value;
            int n9 = (int)numericUpDown9.Value;
            int n10 = (int)numericUpDown10.Value;

            int[] mas = { n1, n2, n3, n4, n5, n6, n7, n8, n9, n10 };

            int sum = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                sum += mas[i];
            }
            label1.Text = "Сумма: " + sum.ToString();
        }
    }
}
