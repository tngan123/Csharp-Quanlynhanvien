using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_Quanlynhanvien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
 lsbhovaten.Items.Add("Giang\tkhùng");
            lsbhovaten.Items.Add("Bảo\tThy");
            lsbhovaten.Items.Add("Tuyết\tNgân");
                 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lsbhovaten.Items.Add(txtten.Text);
            txtten.Text = string.Empty;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            lsbhovaten.Items.RemoveAt(lsbhovaten.SelectedIndex);

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (lsbhovaten.SelectedIndex < 0) return;
            lsbhovaten.Items[lsbhovaten.SelectedIndex] = txtten.Text;
        }
    }
}
