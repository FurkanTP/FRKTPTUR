using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRKTPTUR2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fRKTPTURDataSet.Subeler' table. You can move, or remove it, as needed.
            this.subelerTableAdapter.Fill(this.fRKTPTURDataSet.Subeler);
            // TODO: This line of code loads data into the 'fRKTPTURDataSet.Otobüs' table. You can move, or remove it, as needed.
            this.otobüsTableAdapter.Fill(this.fRKTPTURDataSet.Otobüs);
            // TODO: This line of code loads data into the 'fRKTPTURDataSet.Sefer' table. You can move, or remove it, as needed.
            this.seferTableAdapter.Fill(this.fRKTPTURDataSet.Sefer);
            // TODO: This line of code loads data into the 'fRKTPTURDataSet1.sp_SeferIptal' table. You can move, or remove it, as needed.
            this.sp_SeferIptalTableAdapter.Fill(this.fRKTPTURDataSet1.sp_SeferIptal);
            // TODO: This line of code loads data into the 'fRKTPTURDataSet.Personel' table. You can move, or remove it, as needed.
            this.personelTableAdapter.Fill(this.fRKTPTURDataSet.Personel);

        }
    }
}
