using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace socket
{
    
    public partial class 채팅창_주인방 : Form
    {

        int portNum;
        long ipNum;

        public 채팅창_주인방()
        {
            InitializeComponent();

            IPEndPoint ep = new IPEndPoint( ipNum, portNum );
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            server.Bind(ep);
        }

        private void Roomip_TextChanged(object sender, EventArgs e)
        {
            ipNum = Convert.ToInt32(roomip.Text);
        }

        private void Roomport_TextChanged(object sender, EventArgs e)
        {
            portNum = Convert.ToInt32(roomport.Text);
        }

        private void Serveropenbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
