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
using System.Runtime.InteropServices;

namespace Abdallah_Amir_s_Project
{
    public partial class Musicly : Form
    {
        //Code to get round edges[1]
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );



        public Musicly()
        {
            InitializeComponent();
            //Code to get round edges[2]
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            //Code to make a button highlight[1]
            panel1.Height = selectButton.Height;
            panel1.Top = selectButton.Top;
            panel1.Left = selectButton.Left;
            selectButton.BackColor = Color.FromArgb(148, 20, 25);

        }

        //Code to make a button highlight[2]
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Local variables to help us with file selecting
        String[] paths, files;

        private void musicList_SelectedIndexChanged(object sender, EventArgs e)
        {
            WDM.URL = paths[musicList.SelectedIndex];
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            //Code to drag the window
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //Code to drag the window
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Exit the application
            Application.Exit();
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            //Minimize the window
            this.WindowState = FormWindowState.Minimized;
        }

        private void exitButton_MouseHover(object sender, EventArgs e)
        {
            //Show a small text box when hovered on
            ToolTip exitTP = new ToolTip();
            exitTP.SetToolTip(this.exitButton, "Exit Musicly");
        }

        private void minButton_MouseHover(object sender, EventArgs e)
        {
            //Show a small text box when hovered on
            ToolTip minTP = new ToolTip();
            minTP.SetToolTip(this.minButton, "Minimize Musicly");
        }

        private void Musicly_MouseDown(object sender, MouseEventArgs e)
        {
            //Code to drag the window
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            WDM.URL = paths[musicList.SelectedIndex + 1];
            musicList.SelectedIndex += 1;
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            WDM.URL = paths[musicList.SelectedIndex - 1];
            musicList.SelectedIndex -= 1;
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            //Code to make the Select Songs button funtion
            //Code to make it highlight when hovered on
            panel1.Height = selectButton.Height;
            panel1.Top = selectButton.Top;
            panel1.Left = selectButton.Left;
            selectButton.BackColor = Color.FromArgb(148, 20, 25);

            //Code to add all selected items to the music list
            musicList.Items.Clear();

            Array.Clear(paths, 0, paths.Length);

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                //error here make it so that paths is unlimited
                paths = ofd.FileNames;

                for (int i = 0; i < files.Length; i++)
                {
                    musicList.Items.Add(files[i]);
                }
            }
        }
    }
}
