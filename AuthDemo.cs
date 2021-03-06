using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RBLXAuthy;

namespace SimpleRobloxAuthForm6969
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Required startup code. It needs to be in form load or beginning of your console app or else it wont work.
            RBLXAuth.init(); // loads rblxauth.
            RBLXAuth.pastebin = ""; // this is where you will put the whitelisted users roblox usernames in a pastebin raw link.
            /// End of required code
            pictureBox1.ImageLocation = RBLXAuth.get_avatar(); // Loads users avatar into picturebox
        }

        private void button1_Click(object sender, EventArgs e) //  Check if whitelisted 
        {

            if (RBLXAuth.IsWhitelisted())
            {
                label1.Text = "whitelisted";
               // do your shit here if its successful
            }
            else
            {
                label1.Text = "not whitelisted";
                // bad
            }
        }

        private void button2_Click(object sender, EventArgs e) // Get username button
        {
            string username = RBLXAuth.get_username();
            MessageBox.Show(username);
        }

        private void button4_Click(object sender, EventArgs e) // Get id button
        {
            string robloxid = RBLXAuth.id;
            MessageBox.Show(robloxid);
        }
        
        
        private void button5_Click(object sender, EventArgs e) // Get HWID button
        {
            string hwid = RBLXAuth.get_hwid();
            MessageBox.Show(hwid);
        }
    }
}
