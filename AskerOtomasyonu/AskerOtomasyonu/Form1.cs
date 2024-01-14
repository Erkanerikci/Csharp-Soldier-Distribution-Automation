using System.Collections;

namespace AskerOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList askerler = new ArrayList();
        ArrayList sehirler = new ArrayList();
        ArrayList yedeksehir = new ArrayList();
        ArrayList atama = new ArrayList();


        private void askerekle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            askerler.Add(textBox1.Text);
            textBox1.Text = "";
        }

        private void sehirekle_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox2.Text);
            sehirler.Add(textBox2.Text);
            textBox2.Text = "";
        }

        private void askerdagit_Click(object sender, EventArgs e)
        {
            if(askerler.Count !=0 && sehirler.Count !=0)
            {
                Random rnd = new Random();
                yedeksehir.AddRange(sehirler);
                int askertut;
                int sehirtut;
                int askersayi = askerler.Count;
                for(int i = 0; i < askersayi; i++)
                {
                    if(sehirler.Count !=0)
                    {

                    
                        askertut = rnd.Next(0, askerler.Count);
                        sehirtut = rnd.Next(0, sehirler.Count);

                        atama.Add($"{askerler[askertut]}==> {sehirler[sehirtut]}");
                        askerler.RemoveAt(askertut);
                        sehirler.RemoveAt(sehirtut);
                    }
                    else
                    {
                        i--;
                        sehirler.AddRange(yedeksehir);
                    }
                }
                foreach(object gezi in atama)
                {
                    listBox3.Items.Add(gezi);
                }
            }
            else
            {
                MessageBox.Show("En az bir asker ve þehir olmalýdýr.");
            }
        }

        private void temizle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            askerler.Clear();
            sehirler.Clear();
            yedeksehir.Clear();
            
        }
    }
}
