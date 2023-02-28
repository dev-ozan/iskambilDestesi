namespace iskambilDestesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] iskambil = {"Kupa", "Maça", "Karo", "Sinek"};


        private void olusturButton_Click(object sender, EventArgs e)
        {
            for(int x = 0 ; x <= iskambil.Length; x++)
            {
                for(int y=1 ; y <= 13; y++)
                {
                    desteListbox.Items.Add(iskambil[x] + y);

                }

            }
        }
    }
}