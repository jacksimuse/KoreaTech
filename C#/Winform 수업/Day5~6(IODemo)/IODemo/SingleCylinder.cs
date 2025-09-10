using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IODemo {
  class SingleCylinder {
    //명사
    //편솔 출력, 전진감지 입력, 후진감지 입력
    private int fwdBit;
    private int isFwdBit, isBwdBit;
    IO io;

    public SingleCylinder(int _fwdBit, int _isFwdBit, int _isBwdBit, IO _io) {
      fwdBit = _fwdBit;
      isFwdBit = _isFwdBit;
      isBwdBit = _isBwdBit;
      io = _io;
    }

    //동사
    //전진, 후진, 전진되어있는지?, 후진되어있는지?
    public void Fwd() {
      io.BitOn(fwdBit);
    }
    public void Bwd() {
      io.BitOff(fwdBit);
    }
    public bool IsFwd() {
      if (io.X[isFwdBit] == true && io.X[isBwdBit] == false)
        return true;
      else
        return false;
    }
    public bool IsBwd() {
      if (io.X[isFwdBit] == false && io.X[isBwdBit] == true)
        return true;
      else
        return false;
    }
  }
}
