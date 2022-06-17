using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Depo_Yonetimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*
             * panel ögelerinin genişliğini arttırarak ve timer ögesini kullanarak
             * loading görünümü yaratılması sağlandı.
             * belirlenen süre(interval) bittiğinde girispaneli adlı forma yönlendirir.
             */
            panel2.Width += 6;
            if (panel2.Width >= 500)
            {
                timer1.Stop();
                Form2 girispaneli = new Form2();
                girispaneli.Show();
                this.Hide();
                
            }
        }   
    }
}
