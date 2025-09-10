using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NMCMotionSDK;
using static NMCMotionSDK.NMCSDKLib;
using System.Windows.Forms;

namespace IODemo {
  class IO {
    const ushort boardID = 0; //static 변수
    readonly ushort ecatAddr = 1; //instance 변수
    const ushort BUF_OUT = 0;
    const ushort BUF_IN = 1;
    private bool[] x = new bool[32];
    private bool[] y = new bool[32];

    public bool[] X {
      get { return x; }
    }
    public bool[] Y {
      get { return y; }
    }

    public bool BoardInit() {
      //NMCMotionSDK.NMCSDKLib.MC_STATUS ms;
      //using NMCMotionSDK; 를 통해 namespace명 생략 가능
      //NMCSDKLib.MC_STATUS ms;

      //ms = NMCMotionSDK.NMCSDKLib.MC_MasterInit(boardID);
      //using static NMCMotionSDK.NMCSDKLib; 를 통해 class명 생략 가능
      MC_STATUS ms = MC_MasterInit(boardID);

      if (ms != MC_STATUS.MC_OK) {
        MessageBox.Show("BoardInit 실패: Code=" + ms.ToString());
        return false;
      }
      else {
        MessageBox.Show("BoardInit 성공");
        return true;
      }
    }
    public bool BoardRun() {
      MC_STATUS ms = MC_MasterRUN(boardID);

      if(ms != MC_STATUS.MC_OK) {
        MessageBox.Show("BoardRun 실패: Code=" + ms.ToString());
        return false;
      }
      else {
        MessageBox.Show("BoardRun 성공");
        return true;
      }
    }
    public bool BitOn(int bit) {
      uint offset = (uint)(bit/8);
      byte bitOffset = (byte)(bit%8);
      MC_STATUS ms =
      MC_IO_WRITE_BIT(boardID, ecatAddr, offset, bitOffset, true);

      if (ms != MC_STATUS.MC_OK)
        return false;
      return true;
    }
    public bool BitOff(int bit) {
      uint offset = (uint)(bit / 8);
      byte bitOffset = (byte)(bit % 8);
      MC_STATUS ms =
      MC_IO_WRITE_BIT(boardID, ecatAddr, offset, bitOffset, false);

      if (ms != MC_STATUS.MC_OK)
        return false;
      return true;
    }
    public bool IOUpdate() {
      uint outOffset = 0;
      uint inOffset = 4;
      uint outData = 0;
      uint inData = 0;

      MC_STATUS msOutput =  
        MC_IO_READ_DWORD(boardID, ecatAddr, BUF_OUT, outOffset, ref outData);
      MC_STATUS msInput =
        MC_IO_READ_DWORD(boardID, ecatAddr, BUF_IN, inOffset, ref inData);

      if ((msOutput != MC_STATUS.MC_OK) || (msInput != MC_STATUS.MC_OK))
        return false;

      for (int i = 0; i < 32; i++) {
        int mask = 0x01 << i;
        if ((mask & inData) != 0)
          x[i] = true;
        else
          x[i] = false;

        y[i] = ((mask & outData) != 0) ? true : false;
      }

      return true;
    }
  }
}
