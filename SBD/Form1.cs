using System;
using System.Windows.Forms;

namespace SBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void loadTicketGrid()
        {
            // TODO: This line of code loads data into the 'dataSet3.BILETI' table. You can move, or remove it, as needed.
            this.bILETITableAdapter.Fill(this.dataSet3.BILETI);
        }

        public void loadBusGrid()
        {
            // TODO: This line of code loads data into the 'dataSet3.AVTOBUSI' table. You can move, or remove it, as needed.
            this.aVTOBUSITableAdapter.Fill(this.dataSet3.AVTOBUSI);
        }

        public void loadStaffGrid()
        {
            // TODO: This line of code loads data into the 'dataSet3.SLUJITELI' table. You can move, or remove it, as needed.
            this.sLUJITELITableAdapter.Fill(this.dataSet3.SLUJITELI);
        }

        public void loadClientGrid()
        {
            // TODO: This line of code loads data into the 'dataSet3.KLIENTI' table. You can move, or remove it, as needed.
            this.kLIENTITableAdapter.Fill(this.dataSet3.KLIENTI);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadBusGrid();  
            loadClientGrid();
            loadStaffGrid();
            loadTicketGrid();
        }

        private void busToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBusForm frm = new AddBusForm(this);
            frm.ShowDialog();
        }

        private void busToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UpdateBusForm frm = new UpdateBusForm(this);
            frm.ShowDialog();
        }

        private void byDestinationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LookupByDestinationForm frm = new LookupByDestinationForm();
            frm.ShowDialog();
        }

        private void ticketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTicketForm frm = new AddTicketForm(this);
            frm.ShowDialog();
        }

        private void byToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LookupByDate frm = new LookupByDate();
            frm.ShowDialog();
        }

        private void byHourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LookupByHour frm = new LookupByHour();
            frm.ShowDialog();
        }

        private void byClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LookupByClient frm = new LookupByClient();
            frm.ShowDialog();
        }

        private void byEmptySeatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LookupByEmptySeats frm = new LookupByEmptySeats();
            frm.ShowDialog();
        }

        private void busToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteBusForm frm = new DeleteBusForm(this);
            frm.ShowDialog();
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClientForm frm = new AddClientForm(this);
            frm.ShowDialog();
        }

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLineForm frm = new AddLineForm(this);
            frm.ShowDialog();
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStaffForm frm = new AddStaffForm(this);
            frm.ShowDialog();
        }

        private void destinationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddDestinationForm frm = new AddDestinationForm(this);
            frm.ShowDialog();
        }

        private void reservationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddReservationForm frm = new AddReservationForm(this);
            frm.ShowDialog();
        }

        private void ticketToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteTicketForm frm = new DeleteTicketForm(this);
            frm.ShowDialog();
        }

        private void destinationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteDestinationForm frm = new DeleteDestinationForm(this);
            frm.ShowDialog();
        }

        private void ticketToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UpdateTicketForm frm = new UpdateTicketForm(this);
            frm.ShowDialog();
        }

        private void destinationToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UpdateDestinationForm frm = new UpdateDestinationForm(this);
            frm.ShowDialog();
        }

        private void clientToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UpdateClientForm frm = new UpdateClientForm(this);
            frm.ShowDialog();
        }

        private void lineToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UpdateLineForm frm = new UpdateLineForm(this);
            frm.ShowDialog();
        }

        private void reservationToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UpdateReservationForm frm = new UpdateReservationForm(this);
            frm.ShowDialog();
        }

        private void staffToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UpdateStaffForm frm = new UpdateStaffForm(this);
            frm.ShowDialog();
        }
    }
}
