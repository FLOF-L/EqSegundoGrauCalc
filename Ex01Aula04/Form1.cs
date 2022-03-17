using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex01Aula04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            EqSegundoGrau minhaeq = new EqSegundoGrau();

            minhaeq.setA(textBox1.Text);
            minhaeq.setB(textBox2.Text);
            minhaeq.setC(textBox3.Text);

            EqSegundoGrauBLL.validaDados(minhaeq);
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
            }
            else
            {
                MessageBox.Show("X1" + minhaeq.calcX1() + "X2" + minhaeq.calcX2());

                textBox1.Enabled = false;//a
                textBox2.Enabled = false;//b
                textBox3.Enabled = false;//c
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox1.Focus();
        }

       
    }
}
