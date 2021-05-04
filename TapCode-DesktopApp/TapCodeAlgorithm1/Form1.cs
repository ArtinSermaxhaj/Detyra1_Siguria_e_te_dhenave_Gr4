using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TapCodeAlgorithm1
{
    public partial class TapCode : Form
    {
        public TapCode()
        {
            InitializeComponent();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[,] matrica = new char[5, 5];
            MbusheMatricen(matrica);
            string k = txtPlainText.Text;
            txtCipherText.Text = Enkripto(matrica, k);
            

        }
        private static void MbusheMatricen(char[,] matrica)
        {
            int asciiFillestar = 97;
            for (var x = 0; x < 5; x++)
            {
                for (var y = 0; y < 5; y++)
                {
                    if (asciiFillestar == 107)
                    {
                         asciiFillestar++;
                         y--;
                        continue;
                    }
                    matrica[x, y] = (char)asciiFillestar;
                    asciiFillestar++;
                }
            }
        }
        public static string Enkripto(char[,] matrica, string text)
        {
            text = text.ToLower();
            char[] tekstinchar = text.ToCharArray();
            StringBuilder sb = new StringBuilder();
            foreach (var t in tekstinchar)
            {
                if (Char.IsLower(t))
                {
                    for (var x = 0; x < 5; x++)
                    {
                        bool found = false;
                        for (var y = 0; y < 5; y++)
                        {
                            if (t == matrica[x, y])
                            {
                                found = true;
                                for (var i = 0; i <= x; i++)
                                {
                                    sb.Append(".");
                                }
                                sb.Append(" ");
                                for (var i = 0; i <= y; i++)
                                {
                                    sb.Append(".");
                                }
                                sb.Append("  ");
                                break;
                            }
                            else if (t == 'k')
                            {
                                found = true;
                                char l = 'c';
                                if (l == matrica[x, y])
                                {
                                    for (var i = 0; i <= x; i++)
                                    {
                                        sb.Append(".");
                                    }
                                    sb.Append(" ");
                                    for (var i = 0; i <= y; i++)
                                    {
                                        sb.Append(".");
                                    }
                                    sb.Append("  ");
                                    break;
                                }
                            }
                        }
                        if (found)
                            break;
                    }
                }
            }
            return sb.ToString();
        }

        private void btnDekripto_Click(object sender, EventArgs e)
        {
            char[,] matrica = new char[5, 5];
            MbusheMatricen(matrica);
            txtDecryptedText.Text = Dekripto(matrica, txtCipherText.Text);
        }
        public static string Dekripto(char[,] matrica, string stringienkriptuar)
        {
            string[] stringuShkronjat = stringienkriptuar.Split(new[] {"  "}, StringSplitOptions.None);
            string[,] karakteret = new string[stringuShkronjat.Length - 1, 2];
            StringBuilder sb = new StringBuilder();
            var i = 0;
            var j = 0;
            for (var t = 0; t < stringuShkronjat.Length - 1; t++)
            {
                string[] k = stringuShkronjat[t].Split(' ');
                karakteret[i, j] = k[0];
                karakteret[i, j + 1] = k[1];
                i++;
            }
            for (var kushti = 0; kushti < karakteret.GetLength(0); kushti++)
            {
                int x = 0;
                int y = 0;
                foreach (char c in karakteret[kushti, 0])
                {
                    if (c == '.')
                    {
                        x += 1;
                    }
                }
                x -= 1;
                foreach (char c in karakteret[kushti, 1])
                {
                    y += 1;
                }
                y -= 1;
                char k = matrica[x, y];
                sb.Append(k);
            }
            return sb.ToString();
        }
    }
}
