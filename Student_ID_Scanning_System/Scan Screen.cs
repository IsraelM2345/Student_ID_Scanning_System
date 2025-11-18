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
    public partial class Scan_Screen : Form
    {
        public Scan_Screen()
        {
            InitializeComponent();
        }

        private void Scan_Screen_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        //private void btnCamera_MouseHover(object sender, EventArgs e)
        //{
        //    btnCamera.ForeColor = Color.FromArgb(237, 241, 214);
        //}

        //private void btnCamera_MouseLeave(object sender, EventArgs e)
        //{
        //    btnCamera.ForeColor = Color.FromArgb(96, 153, 102);
        //}

        private void btnQR_Click(object sender, EventArgs e)
        {
            QR_Code qr = new QR_Code();
            qr.TopLevel = false;
            pBody.Controls.Add(qr);
            qr.BringToFront();
            qr.Show();
        }

        private void btnBarcode_Click(object sender, EventArgs e)
        {
            Barcode barcode = new Barcode();
            barcode.TopLevel = false;
            pBody.Controls.Add(barcode);
            barcode.BringToFront();
            barcode.Show();
        }

        private void btnRFID_Click(object sender, EventArgs e)
        {
            RFID rfid = new RFID();
            rfid.TopLevel = false;
            pBody.Controls.Add(rfid);
            rfid.BringToFront();
            rfid.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            MainDashboard dashboard = new MainDashboard();
            dashboard.Show();
        }

        private void lblDashboard_Click(object sender, EventArgs e)
        {
            MainDashboard dashboard = new MainDashboard();
            dashboard.Show();
        }
    }
}
