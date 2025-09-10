using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IODemo {
  class Machine {
    public Machine(IO _io) {
      workCyl = new SingleCylinder(2, 3, 2, _io);
      moveCyl_F = new SingleCylinder(3, 5, 4, _io);
            moveCyl_B = new SingleCylinder(4, 5, 4, _io);
            unldCyl_F = new SingleCylinder(5, 7, 6, _io);
            unldCyl_B = new SingleCylinder(6, 7, 6, _io);
            loadCyl = new DoubleCylinder(0, 1, 1, 0, _io);
    }
    private SingleCylinder workCyl;
    private SingleCylinder moveCyl_F;
        private SingleCylinder moveCyl_B;
        private SingleCylinder unldCyl_F;
        private SingleCylinder unldCyl_B;
        private DoubleCylinder loadCyl;
    //loadCyl, moveCyl, unldCyl

    public SingleCylinder WorkCyl { get { return workCyl; } }
    public SingleCylinder MoveCyl_F { get { return moveCyl_F; } }
        public SingleCylinder MoveCyl_B { get { return moveCyl_B; } }
        public SingleCylinder UnldCyl_F { get { return unldCyl_F; } }
        public SingleCylinder UnldCyl_B { get { return unldCyl_B; } }
    public DoubleCylinder LoadCyl { get { return loadCyl; } }
  }
}
