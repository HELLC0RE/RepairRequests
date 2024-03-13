using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepairRequests
{
    public partial class ChooseForm : Form
    {
        public ChooseForm()
        {
            InitializeComponent();
        }

        private void createRequest_Click(object sender, EventArgs e)
        {
            RequestForm requestForm = new RequestForm();
            requestForm.ShowDialog();
        }

        private void openRequestList_Click(object sender, EventArgs e)
        {
            RequestsList requestsList = new RequestsList();
            requestsList.ShowDialog();
        }
    }
}
