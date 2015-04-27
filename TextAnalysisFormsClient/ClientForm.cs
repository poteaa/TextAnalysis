///////////////////////////////////////////////////////////
//  ClientForm.cs
//  Implementation of the Class ClientForm
//  Created on:  08/03/2015
//  Author: Diego Fernando Alvarez Andrade Cel: 3103121656 Cel: 3103121656
///////////////////////////////////////////////////////////

namespace TextAnalysisFormsClient
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using RestSharp;
    using TextAnalysisFormsClient.Facades;
    using TextAnalysisModel;

    public partial class ClientForm : Form
    {
        public static int solvedPackages;
        private int sentPackages;
        private DateTime startDate;
        private Client client;
        private ThreadStart ts;
        private Thread sendThread;
        private bool send;

        public delegate void Failure();
        Failure failure;

        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            int clientId = r.Next(1000, 20000);
            client = new Client(clientId, "Client" + clientId);
            txtId.Text = client.Id.ToString();
            txtName.Text = client.Name;
            ts = new ThreadStart(SendPostText);
            failure = new Failure(GenerateFailure);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            send = true;
            sentPackages = 0;
            solvedPackages = 0;
            btnSend.Enabled = false;
            lblSending.Visible = true;
            txtSent.Text = string.Empty;
            txtSolved.Text = string.Empty;

            sendThread = new Thread(ts);
            sendThread.Start();

            btnStop.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.Now - startDate;
            send = false;
            btnSend.Enabled = true;
            btnStop.Enabled = false;
            lblSending.Visible = false;

            sendThread.Abort();
            if (span.Seconds > 0)
            {
                float rate = sentPackages / span.Seconds;
                txtSent.Text = string.Format("{0}/s", rate);
                rate = solvedPackages / span.Seconds;
                txtSolved.Text = string.Format("{0}/s", rate);
            }
            else
            {
                txtSent.Text = "Not available";
                txtSolved.Text = "Not available";
            }
        }

        private void SendPostText()
        {
            ClientRestFacade facade = new ClientRestFacade(Method.POST);
            startDate = DateTime.Now;

            while (send)
            {
                client.Text = Utility.Util.CreateRandomText();
                facade.SendPostRequest(client, failure);
                sentPackages++;
            }
        }

        private void GenerateFailure()
        {
            //TODO: failure managment
        }
    }
}
