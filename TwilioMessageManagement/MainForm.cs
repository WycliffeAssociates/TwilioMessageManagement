using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using Twilio.Base;
using Twilio.Rest.Api.V2010.Account;

namespace TwilioMessageManagement
{
    public partial class MainForm : Form
    {
        BindingList<MessageResource> messages;
        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadMessages(string sid, string token)
        {
            List<string> columnsToKeep = new List<string>()
            {
                "Body",
                "Sid",
                "Direction",
                "To",
                "From",
                "DateCreated"
            };
            this.messages = new BindingList<MessageResource>();
            try
            {
                TwilioClient.Init(sid, token);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Connecting to Twilio: " + ex.Message);
                return;
            }
            ResourceSet<MessageResource> twilioMessages;
            try
            {
                twilioMessages = MessageResource.Read();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Getting Messages: " + ex.Message);
                return;
            }

            foreach (var message in twilioMessages)
            {
                messages.Add(message);
            }
            grdMessages.DataSource = messages;

            // Figure out which columns to remove
            List<string> columnsToRemove = new List<string>();
            foreach (DataGridViewColumn column in grdMessages.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                if (!columnsToKeep.Contains(column.Name))
                {
                    columnsToRemove.Add(column.Name);
                }
            }
            foreach (var c in columnsToRemove)
            {
                grdMessages.Columns.Remove(c);
            }

            grdMessages.Columns.Add(new DataGridViewColumn(new DataGridViewButtonCell() { UseColumnTextForButtonValue = true }) { HeaderText = "Delete" });
        }

        private void grdMessages_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;
            if (e.ColumnIndex != -1 && grdMessages.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                string currentSid = (string)grid.CurrentRow.Cells["SID"].Value;
                try
                {
                    MessageResource.Delete(currentSid);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error deleting Message: " + ex.Message);
                    return;
                }
                grdMessages.ClearSelection();
                grdMessages.Rows.RemoveAt(grid.CurrentRow.Index);
                grdMessages.Refresh();
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            lblProgress.Visible = true;
            LoadMessages(txtSid.Text.Trim(), txtToken.Text.Trim());
            lblProgress.Visible = false;
        }
    }
}
