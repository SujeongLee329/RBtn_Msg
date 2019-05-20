﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RBtn_Msg
{
    public partial class Form1 : Form
    {
        private MessageBoxButtons mbb;
        private MessageBoxIcon mbi;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            if (this.rbOk.Checked)
            {
                this.mbb = MessageBoxButtons.OK;
            } else if (this.rbOkCancel.Checked)
            {
                this.mbb = MessageBoxButtons.OKCancel;
            }else if (this.rbYesNo.Checked)
            {
                this.mbb = MessageBoxButtons.YesNo;
            }else if (this.rbError.Checked)
            {
                
            }else if (this.rbInformation.Checked)
            {
                
            }else if (this.rbQuestion.Checked)
            {

            }
            MessageBox.Show("메시지 박스를 확인하세요", "알림", mbb, mbi);
        }
    }
}
