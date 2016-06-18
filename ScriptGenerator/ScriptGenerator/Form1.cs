using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ScriptGenerator
{
    public partial class frm_ScriptGenerator : Form
    {
        public frm_ScriptGenerator()
        {
            InitializeComponent();
        }

        private void btn_OpenInput_Click(object sender, EventArgs e)
        {
            if (openInputFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openInputFileDialog.FileName);
                rtb_Input.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void btn_OpenPattern_Click_1(object sender, EventArgs e)
        {
            if (openPatternFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openPatternFileDialog.FileName);
                rtb_Pattern.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void btn_saveScript_Click(object sender, EventArgs e)
        {
            String str = rtb_Output.Text;
            saveFile(str);
        }

        private void saveFile(String str)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                StreamWriter sw = new StreamWriter(saveFileDialog.FileName, false, utf8);
                sw.Write(str);
                sw.Close();
                MessageBox.Show("Datei erfolgreich gespeichert: " + saveFileDialog.FileName);
            }
        }

        private void btn_GenerateScript_Click(object sender, EventArgs e)
        {
            List<string> input = rtb_Input.Text.Split('\n').ToList();
            List<string> pattern = rtb_Pattern.Text.Split('\n').ToList();
            String output = "";

            foreach (string value in input)
            {
                foreach (string tmpPattern in pattern)
                    if (output.Length == 0) {
                        output = tmpPattern.Replace("%%variable%%", value);
                    } else {
                        output = output + "\n" + tmpPattern.Replace("%%variable%%", value);
                    }
            }
            rtb_Output.Text = output;
        }

        private void btn_SavePattern_Click(object sender, EventArgs e)
        {
            String str = rtb_Pattern.Text;
            saveFile(str);
        }
    }
}
