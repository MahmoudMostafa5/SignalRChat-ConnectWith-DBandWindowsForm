using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _proxy.Invoke("joinGroup", txt_grp.Text, txt_nam.Text);
        }
        IHubProxy _proxy;

        private void Form1_Load(object sender, EventArgs e)
        {
            //define Connection
            HubConnection con = new HubConnection("http://localhost:64605/");

            //Create Proxy
            _proxy = con.CreateHubProxy("chat");

            //Start Connection
            con.Start();

            //define callBack Method
            _proxy.On<string, string>("newMessage", (n, m) => lb_msg.Invoke(new Action(() => lb_msg.Items.Add(n + " : " + m))));
            _proxy.On<string, string>("newMember", (n, g) => lb_msg.Invoke(new Action(() => lb_msg.Items.Add(n + " : " + g))));

            _proxy.On<string, string, string>("messageGroup", (g, n, m) => lb_msg.Invoke(new Action(() => lb_msg.Items.Add(g + " ( " + n + " ) : " + " : " + m))));

        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            _proxy.Invoke("sendMessage", txt_nam.Text, txt_msg.Text);
        }

        private void btn_sendgroup_Click(object sender, EventArgs e)
        {
            _proxy.Invoke("sentToGroup", txt_grp.Text, txt_nam.Text, txt_msg.Text);
        }
    }
}
