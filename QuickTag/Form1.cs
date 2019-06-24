using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QuickTag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (string s in listBox1.Items)
                {
                    TagLib.File tagFile = TagLib.File.Create(s);

                    tagFile.Tag.Album = textBox9.Text;

                    tagFile.Save();

                }
                label1.Text = "Process completed: " + DateTime.Now.ToString("h:mm:ss tt");
                textBox9.Text = "";
                listBox1.ClearSelected();
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }
            catch (NullReferenceException ex)
            {
                label9.Text = "No MP3s selected!";
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            


            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                var pathString = folderBrowserDialog1.SelectedPath;
                textBox1.Text = pathString;
                string[] mp3files = Directory.GetFiles(pathString, "*.mp3");
                listBox1.SelectedItem = false;
                listBox1.SelectedItems.Clear();
                listBox1.Items.AddRange(mp3files);


            }




        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                var selectedMP3 = listBox1.SelectedItem.ToString();
                TagLib.File tagFile = TagLib.File.Create(selectedMP3);
                var textyear = tagFile.Tag.Year;
                var album = tagFile.Tag.Album;
                var year = tagFile.Tag.Year.ToString();
                var title = tagFile.Tag.Title;
                var textart = tagFile.Tag.FirstArtist;
                var duration = tagFile.Properties.Duration.ToString();

                textBox2.Text = textart;
                textBox3.Text = title;
                textBox4.Text = album;
                textBox5.Text = year;
                textBox6.Text = duration;

                label3.Text = "";
                label9.Text = "";
            }
            catch (NullReferenceException ex)
            {
                label3.Text = "No selected MP3s.";
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedMP3 = listBox1.SelectedItem.ToString();
                TagLib.File tagFile = TagLib.File.Create(selectedMP3);

                tagFile.Tag.Album = textBox9.Text;
                label1.Text = "Process completed: " + DateTime.Now.ToString("h:mm:ss tt");

                tagFile.Save();
                textBox9.Text = "";
                listBox1.ClearSelected();
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }
            catch (NullReferenceException)
            {
                label9.Text = "No selected MP3s!";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (string s in listBox1.Items)
                {
                    TagLib.File tagFile = TagLib.File.Create(s);

                    tagFile.Tag.Performers = new string[1] { textBox7.Text };
                    label1.Text = "Process completed: " + DateTime.Now.ToString("h:mm:ss tt");

                    tagFile.Save();

                }
                textBox7.Text = "";
                listBox1.ClearSelected();
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }
            catch (NullReferenceException ex)
            {
                label9.Text = "No MP3s selected!";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedMP3 = listBox1.SelectedItem.ToString();
                TagLib.File tagFile = TagLib.File.Create(selectedMP3);

                tagFile.Tag.Title = textBox8.Text;
                label1.Text = "Process completed: " + DateTime.Now.ToString("h:mm:ss tt");

                tagFile.Save();
                textBox8.Text = "";
                listBox1.ClearSelected();
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }
            catch (NullReferenceException ex)
            {
                label9.Text = "No MP3s selected!";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (string s in listBox1.Items)
                {
                    TagLib.File tagFile = TagLib.File.Create(s);

                    uint value = UInt32.Parse(textBox10.Text);


                    tagFile.Tag.Year = value;


                    tagFile.Save();
                    label1.Text = "Process completed: " + DateTime.Now.ToString("h:mm:ss tt");
                }
                
                textBox10.Text = "";
                listBox1.ClearSelected();
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }
            catch (NullReferenceException ex)
            {
                label9.Text = "No MP3s selected!";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedMP3 = listBox1.SelectedItem.ToString();
                TagLib.File tagFile = TagLib.File.Create(selectedMP3);

                tagFile.Tag.Performers = new string[1] { textBox7.Text };
                label1.Text = "Process completed: " + DateTime.Now.ToString("h:mm:ss tt");

                tagFile.Save();
                textBox7.Text = "";
                listBox1.ClearSelected();
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }
            catch (NullReferenceException)
            {
                label9.Text = "No MP3 selected!";
            }
        }
    
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedMP3 = listBox1.SelectedItem.ToString();
                TagLib.File tagFile = TagLib.File.Create(selectedMP3);

                uint value = UInt32.Parse(textBox10.Text);


                tagFile.Tag.Year = value;


                tagFile.Save();
                textBox10.Text = "";
                listBox1.ClearSelected();
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                label1.Text = "Process completed: " + DateTime.Now.ToString("h:mm:ss tt");
            }
            catch (NullReferenceException ex)
            {
                label9.Text = "No selected MP3s!";
            }

        }

    }
}

