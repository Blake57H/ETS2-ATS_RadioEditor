using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Truck
{
    public partial class Search : Form
    {    
        
        
        
        
        //____________________________________________________DATA
        static char flag = char.MinValue;
        string[] search_string;


        //---------------------------------------------------- Form Function

        bool Compare_Search(char[] searchChar)
        {
            char[] compare = Search_textBox.Text.ToCharArray();
            int compareMatch = 0;

            if (compare.Length > searchChar.Length) return false;
            else
            {
                for(int count = 0; count < searchChar.Length; count++)
                {
                    if(char.ToLower(compare[compareMatch]) == char.ToLower(searchChar[count]))
                    {
                        compareMatch++;
                        if (compareMatch == compare.Length) return true;
                    }
                    else
                    {
                        compareMatch = 0;
                    }
                }

                return false;
            }

        }


        //---------------------------------------------------- Object Function
        public Search()
        {
            InitializeComponent();
        }

        private void Name_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            flag = 'n';
        }

        private void Link_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            flag = 'l';
        }

        private void Genre_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            flag = 'g';
        }

        private void Bitrate_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            flag = 'b';
        }

        private void Language_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            flag = 'L';
        }

        private void Fav_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            flag = 'f';
            textBox2.Text = "All radios that marked \"Favourited\" will be displayed using favourited to search";
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            textBox2.Text = "";
            int length = form1.Search_SetLength(), matches = 0;
            search_string = new string[length];

            search_string = form1.Search_String(flag);

            if(flag == 'n' || flag == 'l'||flag == 'g'|| flag == 'b'||flag == 'L')
            {
                for(int count = 0; count < search_string.Length; count++)
                {
                    char[] chars = search_string[count].ToCharArray();
                    if (Compare_Search(chars) == true)
                    {
                        textBox2.Text += $"Index {count.ToString()}: {search_string[count]}\r\n";
                        matches++;
                    }
                }
                textBox2.Text += $"Search completed, {matches.ToString()} found.\r\n";
            }
            else if (flag == 'f')
            {
                for(int count = 0; count < search_string.Length; count++)
                {
                    if(form1.Search_byFavourite(count) == true)
                    {
                        textBox2.Text += $"Index {count.ToString()}\r\n";
                        matches++;
                    }
                }
                textBox2.Text += $"Search completed, {matches.ToString()} found.\r\n";
            }
            else
            {
                MessageBox.Show("Search function flag error");
            }
        }
    }
}
