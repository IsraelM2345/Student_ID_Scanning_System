using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_ID_Scanning_System
{
    public partial class MainDashboard : Form
    {
        public MainDashboard()
        {
            InitializeComponent();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            ConfirmLogout();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ConfirmLogout();
        }

        private void ConfirmLogout()
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }


        private void MainDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void btnScanID_Click(object sender, EventArgs e)
        {
            Scan_Screen scan = new Scan_Screen();
            scan.Show(); 
            //this.Hide();
        }

        private void lblScanID_Click(object sender, EventArgs e)
        {
            Scan_Screen scan = new Scan_Screen();
            scan.Show();
        }

        private void btnBarcode_Click(object sender, EventArgs e)
        {
            Barcode barcode = new Barcode();
            barcode.Show();
        }

        private void btnQRCode_Click(object sender, EventArgs e)
        {
            QR_Code qrCode = new QR_Code();
            qrCode.Show();
        }

        private void btnRFID_Click(object sender, EventArgs e)
        {
            RFID rfid = new RFID();
            rfid.Show();
        }

        private void btnStudentRecord_Click(object sender, EventArgs e)
        {
            Student_Record studentRecord = new Student_Record();
            studentRecord.Show();
        }

        private void lblStudentRecord_Click(object sender, EventArgs e)
        {
            Student_Record studentRecord = new Student_Record();
            studentRecord.Show();
        }
    }
}
