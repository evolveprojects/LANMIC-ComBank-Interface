using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LANMIC_ComBank_Interface.Config;
using LANMIC_ComBank_Interface.Data;
using LANMIC_ComBank_Interface.HelpServices;
using LANMIC_ComBank_Interface.Models.DatabaseModels;
using log4net;
using Microsoft.VisualBasic.ApplicationServices;

namespace LANMIC_ComBank_Interface.Forms.Tools
{
    public partial class frmUserCreation : Form
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private readonly AppDbContext db;

        public frmUserCreation()
        {
            InitializeComponent();
            //horizontal line
            ControlHelpers.AddHorizontalSeparator(this);
            db = new AppDbContext(AppConfigService.ConnectionString());
          
        }    
 
        private void frmUserCreation_Load(object sender, EventArgs e)
        {
            LoadDataGridData();
        }



        private void LoadDataGridData()
        {
            List<UserDetails> userDetails = (from ud in db.UserDetails
                                             select new UserDetails
                                             {
                                                 ID = ud.ID,
                                                 Username = ud.Username,
                                                 IsActive = ud.IsActive
                                             }).ToList();
            if (userDetails.Count > 0)
            {
                dgvUserDetails.Rows.Clear();

                foreach (var user in userDetails)
                {
                    dgvUserDetails.Rows.Add(
                        user.ID,
                        user.IsActive,
                        user.Username,
                        user.IsActive ? "Active" : "In Active"
                    );
                }


            }
        }
     
        

    }
}
