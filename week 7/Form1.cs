using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            char[] huruf2 = txtB_huruf.Text.ToCharArray();
            char index1 = huruf2[0];
            char[] jadi1 = txtB_jadi.Text.ToCharArray();
            char indexjadi = jadi1[0];
            int selisih = indexjadi - index1;
            string[] huruf = new string[26];
            string[] huruf1 = { "a", "b", "c", "d", "e", "f", "g", "h","i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            
            string huruf3 = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 1; i < txtB_kalimat.Text.Length; i++) 
            {
                int jadinya = txtB_kalimat.Text[i];

                if (txtB_kalimat.Text[i] == ' ')
                {
                    txtB_kalimat.Text = 
                }
                
                
            }
            lbl_Hasiljadi.Text = txtB_kalimat.Text;
        }
    }
}
