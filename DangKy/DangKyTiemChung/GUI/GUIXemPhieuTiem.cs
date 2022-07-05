﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DangKyTiemChung.BLL;
namespace DangKyTiemChung.GUI
{
    public partial class GUIXemPhieuTiem : Form
    {
        public GUIXemPhieuTiem()
        {
            InitializeComponent();
        }

        private void XemPhieuTiem_Load(object sender, EventArgs e)
        {
            string _makh = GUITraCuu.makh;
            if (_makh == null)
                _makh = GUIDangNhap.ma;
            DataTable dt = new DataTable();
            PhieuTiem.LayTT_PT(_makh).Fill(dt);
            view_phieudangky.DataSource = dt;
        }
    }
}
