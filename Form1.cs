using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Media;

namespace Truck
{
    public partial class Form1 : Form
    {
        //______________________________________ datas
        static string filePath;
        static List<string> front_header = new List<string>(), rear_header = new List<string>();
        static bool unsave = false;
        static int lastRow;

        public class Radio
        {
            public int index;
            public string name;
            public string link;
            public string bitrate;
            public string language;
            public string genre;
            public bool favourite;
        }

        static List<Radio> radios = new List<Radio>();


        //____________________________ app functions
        void Control_Enable(bool set)
        {
            Update_Radio_button.Enabled = Delete_Radio_button.Enabled = Move_button.Enabled = Add_Radio_button.Enabled =
                Reflesh_button.Enabled = Play_Radio_button.Enabled = set;
        }

        void FileSave_enable(bool set)
        {
            saveToolStripMenuItem.Enabled = saveAsToolStripMenuItem.Enabled = closeToolStripMenuItem.Enabled =
                radiosToolStripMenuItem.Enabled = set;
        }

        void Load_Radio_to_editor(int index)
        {
            Name_textBox.Text = radios[index].name;
            Link_textBox.Text = radios[index].link;
            Bitrate_textBox.Text = radios[index].bitrate;
            Language_textBox.Text = radios[index].language;
            Genre_textBox.Text = radios[index].genre;
            Fav_checkBox.Checked = radios[index].favourite;
            lastRow = index;
            Control_Enable(true);
        }

        void Load_all_radio_to_grid()
        {
            dataGridView1.Rows.Clear();
            foreach (var radio_data in radios)
            {
                string description = $"{radio_data.name.ToString()}|{radio_data.genre.ToString()}|{radio_data.language.ToString()}|{radio_data.bitrate.ToString()}|{radio_data.favourite.ToString()}";

                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = index;
                dataGridView1.Rows[index].Cells[1].Value = description;
                dataGridView1.Rows[index].Cells[2].Value = radio_data.link;
            }
        }

        void Load_file(string path)
        {
            string allText = File.ReadAllText(path);

            string[] tempfront_header = allText.Split('{');
            for (int count = 0; count < tempfront_header.Length - 1; count++)
            {
                front_header.Add(tempfront_header[count]);
            }
            string[] temprear_header = allText.Split('}');
            for (int count = 1; count < temprear_header.Length; count++)
            {
                rear_header.Add(temprear_header[count]);
            }

            radios.Clear();
            string[] body = allText.Split('"');
            for (int count = 1; count < body.Length; count += 2)
            {
                string[] content = body[count].Split('|');
                Radio temp_radio = new Radio();
                temp_radio.link = content[0];
                temp_radio.name = content[1];
                temp_radio.genre = content[2];
                temp_radio.language = content[3];
                temp_radio.bitrate = content[4];
                temp_radio.favourite = (content[5] == "1" ? true : false);
                radios.Add(temp_radio);
            }

            Load_all_radio_to_grid();
            FileSave_enable(true);
        }

        void Save_file(string path)
        {
            string output = "";
            foreach (var element in front_header)
            {
                output += (element);
                output += ("{");
            }

            output += ($"\r stream_data: {radios.Count}\r");
            for (int count = 0; count < radios.Count; count++)
            {
                output +=
                    ($" stream_data[{count.ToString()}]: \"{radios[count].link}|{radios[count].name}|{radios[count].genre}|{radios[count].language}|{radios[count].bitrate}|{Fav(count)}\"\r");
            }

            foreach (var element in rear_header)
            {
                output += ("}");
                output += (element);
            }

            File.WriteAllText(path, output.ToString());

            unsave = false;
        }

        void Ask_ToSave()
        {
            if (MessageBox.Show("Do you want to save your changes to your radio list?",
                "Radio unsave", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Save_file(filePath);
            }
        }

        void Check_unsave()
        {
            if (unsave == true)
            {
                Ask_ToSave();
            }
        }

        void AutoOpen_check(string path)
        {
            if (File.Exists(path) == false)
            {
                if (MessageBox.Show("Radio file not found. Do you want to manually locate it?", "Opps",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    OpenDialog();
                }
            }
            else
            {
                Load_file(filePath);
            }
        }

        string Fav(int index)
        {
            return radios[index].favourite == true ? "1" : "0";
        }

        void OpenDialog()
        {
            dataGridView1.Rows.Clear();
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"%USERPROFILE%\Documents";
                openFileDialog.Filter = "live_streams.sii|live_streams.sii|All file|*.*";
                openFileDialog.FilterIndex = 0;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    MessageBox.Show(filePath);
                    Load_file(filePath);
                }
            }
        }

        //--------------------------------------------------- Move functions

        public void Move_Radio_Action(int toindex)
        {
            Radio temp = new Radio();
            //MessageBox.Show(lastRow.ToString() + radios.Count.ToString());
            temp = radios[lastRow];
            radios.RemoveAt(lastRow);
            radios.Insert(toindex, temp);

            Move_Radio_Action_sub();
        }

        void Move_Radio_Action_sub()
        {
            dataGridView1.Rows.Clear();
            Load_all_radio_to_grid();

        }

        //------------------------------------------------- Search functions

        public string[] Search_String(char type)
        {
            string[] toReturn = new string[radios.Count];
            switch (type)
            {
                case 'n':
                    for (int count = 0; count < radios.Count; count++)
                    {
                        toReturn[count] = radios[count].name;
                    }
                    break;

                case 'l':
                    for (int count = 0; count < radios.Count; count++)
                    {
                        toReturn[count] = radios[count].link;
                    }
                    break;

                case 'g':
                    for (int count = 0; count < radios.Count; count++)
                    {
                        toReturn[count] = radios[count].genre;
                    }
                    break;

                case 'b':
                    for (int count = 0; count < radios.Count; count++)
                    {
                        toReturn[count] = radios[count].bitrate;
                    }
                    break;

                case 'L':
                    for (int count = 0; count < radios.Count; count++)
                    {
                        toReturn[count] = radios[count].language;
                    }
                    break;

                case 'f':
                    for (int count = 0; count < radios.Count; count++)
                    {
                        toReturn[count] = radios[count].favourite.ToString();
                    }
                    break;

                default:
                    MessageBox.Show("Did you selected a search type?", "This app has a doubt", MessageBoxButtons.OK, MessageBoxIcon.Question); ;
                    break;
            }

            return toReturn; 
        }

        public int Search_SetLength()
        {
            return radios.Count;
        }

        public bool Search_byFavourite(int index)
        {
            return radios[index].favourite;
        }


        //_________________________________________________ form function

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                Load_Radio_to_editor(e.RowIndex);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
                Load_Radio_to_editor(e.RowIndex);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                Load_Radio_to_editor(e.RowIndex);
        }

        private void Reflesh_button_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            Load_all_radio_to_grid();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = @"%USERPROFILE%\Documents";
                saveFileDialog.FileName = "live_streams.sii";
                saveFileDialog.Filter = "live_streams.sii|live_streams.sii|All file|*.*";
                saveFileDialog.FilterIndex = 0;
                saveFileDialog.RestoreDirectory = true;

                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string saveAsPath = saveFileDialog.FileName;
                    Save_file(saveAsPath);
                }
            }
        }

        private void Update_Radio_button_Click(object sender, EventArgs e)
        {
            unsave = true;
            Radio temp = new Radio();
            temp.index = lastRow;
            temp.link = Link_textBox.Text;
            temp.name = Name_textBox.Text;
            temp.genre = Genre_textBox.Text;
            temp.language = Language_textBox.Text;
            temp.bitrate = Bitrate_textBox.Text;
            temp.favourite = Fav_checkBox.Checked;

            radios.RemoveAt(lastRow);
            radios.Insert(lastRow, temp);
            dataGridView1.Rows[lastRow].Cells[1].Value =
                $"{Name_textBox.Text}|{Genre_textBox.Text}|{Language_textBox.Text}|{Bitrate_textBox.Text}|{Fav(lastRow)}";
            dataGridView1.Rows[lastRow].Cells[2].Value = Link_textBox.Text;
        }

        private void Add_Radio_button_Click(object sender, EventArgs e)
        {
            unsave = true;
            Radio temp = new Radio();
            radios.Add(temp);
            int index = dataGridView1.Rows.Add();
            dataGridView1.Rows[index].Cells[0].Value = index;
        }

        private void Add_Radio_button_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Add a empty radio to the end of the list", Add_Radio_button);
        }

        private void Reflesh_button_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Make sure the list actually storing temp data match your expectation before you save", Reflesh_button);
        }

        private void Move_button_Click(object sender, EventArgs e)
        {
            unsave = true;
            Move move = new Move();
            MessageBox.Show("After moving radio, reflesh list to see changes.", "This is a known issue", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            move.Show();
            move.MaxIndex_Set(radios.Count - 1);
        }

        private void resetChangesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Load_file(filePath);
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unsave = true;
            radios.Clear();
            Load_all_radio_to_grid();
        }

        private void Delete_Radio_button_Click(object sender, EventArgs e)
        {
            unsave = true;
            radios.RemoveAt(lastRow);
            dataGridView1.Rows.RemoveAt(lastRow);
            for(int index = lastRow; index < radios.Count; index++)
            {
                dataGridView1.Rows[index].Cells[0].Value = index;
            }
            Control_Enable(false);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Check_unsave();
        }

        private void openETS2RadioListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Check_unsave();
            var envirPath = @"%USERPROFILE%\Documents\Euro Truck Simulator 2\live_streams.sii";
            filePath = Environment.ExpandEnvironmentVariables(envirPath);
            AutoOpen_check(filePath);
            
        }

        private void openATSRadioListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Check_unsave();
            var envirPath = @"%USERPROFILE%\Documents\American Truck Simulator\live_streams.sii";
            filePath = Environment.ExpandEnvironmentVariables(envirPath);
            AutoOpen_check(filePath);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Check_unsave();
            FileSave_enable(false);
            Control_Enable(false);
            dataGridView1.Rows.Clear();
            radios.Clear();
            unsave = false;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save_file(filePath);
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search searchForm = new Search();
            searchForm.Show();
        }

        private void Play_Radio_button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(radios[lastRow].link);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Check_unsave();
            OpenDialog();
        }
    }
}
