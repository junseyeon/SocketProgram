using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace socket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Serverbtn_Click(object sender, EventArgs e)
        {
            Form ServerForm = new 채팅창_주인방();
            ServerForm.Show();
        }

        private void Clientbtn_Click(object sender, EventArgs e)
        {
            Form ClientForm = new 채팅창_참여();
            ClientForm.Show();
        }
    }
}
