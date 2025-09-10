using NMCMotionSDK;
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
using static NMCMotionSDK.NMCSDKLib;

namespace IODemo {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
      io = new IO();
      machine = new Machine(io);
      CreateOutList();
    }

    IO io;
    Machine machine;

    private void CreateOutList() {
      for (int i = 0; i < 20; i++) {
        cbOutList.Items.Add(i);
      }
    }
    private void UIUpdate() {
      cbIn00.Checked = io.X[0];
      cbIn01.Checked = io.X[1];
      cbIn02.Checked = io.X[2];
      cbIn03.Checked = io.X[3];
      cbIn04.Checked = io.X[4];
      cbIn05.Checked = io.X[5];
      cbIn06.Checked = io.X[6];
      cbIn07.Checked = io.X[7];
      cbIn08.Checked = io.X[8];
      cbIn09.Checked = io.X[9];
      cbIn10.Checked = io.X[10];
      cbIn11.Checked = io.X[11];
      cbIn12.Checked = io.X[12];
      cbIn13.Checked = io.X[13];
      cbIn14.Checked = io.X[14];
      cbIn15.Checked = io.X[15];
      cbIn16.Checked = io.X[16];
      cbIn17.Checked = io.X[17];
      cbIn18.Checked = io.X[18];
      cbIn19.Checked = io.X[19];

      cbOut00.Checked = io.Y[0];
      cbOut01.Checked = io.Y[1];
      cbOut02.Checked = io.Y[2];
      cbOut03.Checked = io.Y[3];
      cbOut04.Checked = io.Y[4];
      cbOut05.Checked = io.Y[5];
      cbOut06.Checked = io.Y[6];
      cbOut07.Checked = io.Y[7];
      cbOut08.Checked = io.Y[8];
      cbOut09.Checked = io.Y[9];
      cbOut10.Checked = io.Y[10];
      cbOut11.Checked = io.Y[11];
      cbOut12.Checked = io.Y[12];
      cbOut13.Checked = io.Y[13];
      cbOut14.Checked = io.Y[14];
      cbOut15.Checked = io.Y[15];
      cbOut16.Checked = io.Y[16];
      cbOut17.Checked = io.Y[17];
        }

    private void btnBoardInit_Click(object sender, EventArgs e) {
      io.BoardInit();
    }

    private void btnBoardRun_Click(object sender, EventArgs e) {
      io.BoardRun();
    }

    private void btnBitOn_Click(object sender, EventArgs e) {
      int bit = int.Parse(cbOutList.Text);
      io.BitOn(bit);
    }

    private void btnBitOff_Click(object sender, EventArgs e) {
      int bit = int.Parse(cbOutList.Text);
      io.BitOff(bit);
    }

    private void timer1_Tick(object sender, EventArgs e) {
      io.IOUpdate();
      UIUpdate();
    }

    private void btnIOMonStart_Click(object sender, EventArgs e) {
      timer1.Start();
    }

    private void btnIOMonStop_Click(object sender, EventArgs e) {
      timer1.Stop();
    }

    private void btnWorkCylFWD_Click(object sender, EventArgs e) {
      machine.WorkCyl.Fwd();
    }

    private void btnWorkCylBWD_Click(object sender, EventArgs e) {
      machine.WorkCyl.Bwd();
    }


        private void button8_Click(object sender, EventArgs e)
        {
            //bool isRead = false;
            //uint inData = 0;
            //byte bData = 0;
            //uint offSet = 4;
            //ushort uData = 0;
            //MC_STATUS ms1 = MC_IO_READ_DWORD(0, 1, 1, offSet, ref inData);
            //MC_STATUS ms2 = MC_IO_READ_BIT(0, 1, 1, offSet, 0,ref isRead);
            //MC_STATUS ms3 = MC_IO_READ_BYTE(0, 1, 1, offSet, ref bData);
            //MC_STATUS ms4 = MC_IO_READ_WORD(0, 1, 1, offSet, ref uData);

        }

        private void btnLoadCylFWD_Click(object sender, EventArgs e)
        {
            machine.LoadCyl.Fwd();
        }

        private void btnLoadCylBWD_Click(object sender, EventArgs e)
        {
            machine.LoadCyl.Bwd();
        }

        private void btnMoveCylFWD_Click(object sender, EventArgs e)
        {
            machine.MoveCyl_F.Fwd();
            Thread.Sleep(2500);
            machine.MoveCyl_F.Bwd();
        }

        private void btnMoveCylBWD_Click(object sender, EventArgs e)
        {
            //Thread.Sleep(1000);
            // timer1.Stop();
            //machine.UnldCyl_F.Fwd();
            //Thread.Sleep(2500);
            //machine.UnldCyl_B.Bwd();
            // timer1.Start();

            machine.MoveCyl_B.Fwd();
            Thread.Sleep(2500);
            machine.MoveCyl_B.Bwd();
        }

        private void btnUnldCylFWD_Click(object sender, EventArgs e)
        {
            machine.UnldCyl_F.Fwd();
            Thread.Sleep(3000);
            machine.UnldCyl_F.Bwd();
        }

        private void btnUnldCylBWD_Click(object sender, EventArgs e)
        {
            machine.UnldCyl_B.Fwd();
            Thread.Sleep(3000);
            machine.UnldCyl_B.Bwd();
        }
    }
}
