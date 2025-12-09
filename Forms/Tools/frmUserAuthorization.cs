using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LANMIC_ComBank_Interface.HelpServices;

namespace LANMIC_ComBank_Interface.Forms.Tools.UserAuthorization
{
    public partial class frmUserAuthorization : Form
    {
        public frmUserAuthorization()
        {
            InitializeComponent();
            ControlHelpers.AddHorizontalSeparator(this);
        }

        private void chkNew_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtOperationalModule_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var view = chkView.Checked;
            var create = chkNew.Checked;
            var edit = chkEdit.Checked;
            var del = chkDelete.Checked;
            var print = chkPrint.Checked;
            byte encodedPermissions = PermissionUtilities.Encode(view, create, edit, del, print);
            MessageBox.Show($"Encoded Permissions: {encodedPermissions}");

            var sds = PermissionUtilities.Decode(encodedPermissions);

        }
    }
}
