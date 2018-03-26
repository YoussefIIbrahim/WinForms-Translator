using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Translator
{
    public partial class aForm : Form
    {
        List<string> firstLang = new List<string>();
        List<string> secondLang = new List<string>();
        bool italicFlag = false;
        bool boldFlag = false;
        bool underlineFlag = false;
        Form childForm = new Form();

        public aForm()
        {
            InitializeComponent();
            childForm.StartPosition = FormStartPosition.CenterParent;
            childForm.MinimizeBox = false;
            childForm.MaximizeBox = false;
            childForm.ShowIcon = false;
            childForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            loadFonts();
        }

        public bool validator(string original)
        {
            if (original.All(char.IsLetter) && original != "")
            {
                return Regex.IsMatch(original, @"^[a-zA-Z]+$");
            }
            else
            {
                return false;
            }
        }



        public void Readfile(string filepath)
        {
            string []lines = System.IO.File.ReadAllLines(filepath);

            for (int i = 0; i < lines.Length; i++)
            {
                string[] words = lines[i].Split(' ');
                if (i == 0)
                {
                    aHeader.Text = words[0];
                    aHeader2.Text = words[1];
                }
                else
                {
                    if (validator(words[0])&&validator(words[1]))
                    {
                        firstLang.Add(words[0]);
                        secondLang.Add(words[1]);
                        ListViewItem lvi = new ListViewItem(words[0]);
                        lvi.SubItems.Add(words[1]); //2nd column from datatable
                        aList.Items.Add(lvi);
                    }
                }

            }
        }

        private void aLoad_Click(object sender, System.EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)

            {
                Readfile(openFileDialog1.FileName);
            }
        }

        private void export_Click(object sender, System.EventArgs e)
        {
            List<string> lines = new List<string>();
            
            foreach (ListViewItem item in aList.Items)
            {
                lines.Add(item.SubItems[0].Text + " " + item.SubItems[1].Text);
            }

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveFileDialog1.OpenFile());
                writer.WriteLine(aHeader.Text + " " + aHeader2.Text);
                foreach (ListViewItem item in aList.Items)
                {
                    writer.WriteLine(item.SubItems[0].Text + " " + item.SubItems[1].Text);
                }
                writer.Dispose();

                writer.Close();

            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            string orig = aRichBox.Text.ToLower();
            if (finder(orig)==-1)
            {
                aRichBox2.ForeColor = System.Drawing.Color.Red;
                aRichBox2.Text = orig;
            }
            else
            {
                aRichBox2.ForeColor = System.Drawing.Color.Black;
                aRichBox2.Text = secondLang[finder(orig)];
            }

        }

        private int finder(string orig)
        {
            for(int i=0; i<firstLang.Count; i++)
            {
                if(orig.Equals(firstLang[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        private void toolStripButton1_Click(object sender, System.EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                aRichBox.BackColor = colorDialog1.Color;
            }
        }

        private void loadFonts()
        {
            aFontDropDown.Text = aRichBox.Font.Name;   
            foreach (FontFamily fontFamily in FontFamily.Families)
            {
                ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
                toolStripMenuItem.Name = fontFamily.Name;
                toolStripMenuItem.Text = fontFamily.Name;
                toolStripMenuItem.Click += new System.EventHandler(toolStripMenuItemClick);
                aFontDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripMenuItem });
            }
        }
        private void toolStripMenuItemClick(object sender, System.EventArgs e)
        {
            var drop = sender as ToolStripMenuItem;
            aFontDropDown.Text = drop.Text;
            aRichBox.Font = new Font(drop.Text, 12);
        }

        private void toolStripButton2_Click(object sender, System.EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                aRichBox.ForeColor = colorDialog1.Color;
            }
        }

        private void toolStripButton3_Click(object sender, System.EventArgs e)
        {
            italicFlag = !italicFlag;
            if (italicFlag)
            {
                aRichBox.Font = new Font(aRichBox.Font, (FontStyle.Italic | aRichBox.Font.Style));

            }
            else
            {
                if (underlineFlag)
                {
                    if (boldFlag)
                    {
                        aRichBox.Font = new Font(aRichBox.Font, (FontStyle.Bold | FontStyle.Underline));
                    }
                    else
                    {
                        aRichBox.Font = new Font(aRichBox.Font, FontStyle.Underline);
                    }
                }
                else
                {
                    if (boldFlag)
                    {
                        aRichBox.Font = new Font(aRichBox.Font, FontStyle.Bold);
                    }
                    else
                    {
                        aRichBox.Font = new Font(aRichBox.Font, FontStyle.Regular);
                    }
                }
            }
            toolStripButton3.Checked = !toolStripButton3.Checked;

        }

        private void toolStripButton4_Click(object sender, System.EventArgs e)
        {
            boldFlag = !boldFlag;
            if (boldFlag)
            {
                aRichBox.Font = new Font(aRichBox.Font, (FontStyle.Bold | aRichBox.Font.Style));
            }
            else
            {
                if(underlineFlag)
                {
                    if (italicFlag)
                    {
                        aRichBox.Font = new Font(aRichBox.Font, (FontStyle.Italic | FontStyle.Underline));
                    }
                    else
                    {
                        aRichBox.Font = new Font(aRichBox.Font, FontStyle.Underline);
                    }
                }
                else
                {
                    if (italicFlag)
                    {
                        aRichBox.Font = new Font(aRichBox.Font, FontStyle.Italic);
                    }
                    else
                    {
                        aRichBox.Font = new Font(aRichBox.Font, FontStyle.Regular);
                    }
                }
            }
            toolStripButton4.Checked = !toolStripButton4.Checked;
        }

        private void toolStripButton5_Click(object sender, System.EventArgs e)
        {
            underlineFlag = !underlineFlag;
            if (underlineFlag)
            {
                aRichBox.Font = new Font(aRichBox.Font, (FontStyle.Underline | aRichBox.Font.Style));

            }
            else
            {
                if (boldFlag)
                {
                    if (italicFlag)
                    {
                        aRichBox.Font = new Font(aRichBox.Font, (FontStyle.Italic | FontStyle.Bold));
                    }
                    else
                    {
                        aRichBox.Font = new Font(aRichBox.Font, FontStyle.Bold);
                    }
                }
                else
                {
                    if (italicFlag)
                    {
                        aRichBox.Font = new Font(aRichBox.Font, FontStyle.Italic);
                    }
                    else
                    {
                        aRichBox.Font = new Font(aRichBox.Font, FontStyle.Regular);
                    }
                }
            }
            toolStripButton5.Checked = !toolStripButton5.Checked;
        }

        private void addButton_Click(object sender, System.EventArgs e)
        {
            Enabled = false;
            childForm.ShowDialog(this);
            Enabled = true;
        }
    }
}
