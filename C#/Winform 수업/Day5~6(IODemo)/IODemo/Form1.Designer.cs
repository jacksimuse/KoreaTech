namespace IODemo {
  partial class Form1 {
    /// <summary>
    /// 필수 디자이너 변수입니다.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 사용 중인 모든 리소스를 정리합니다.
    /// </summary>
    /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form 디자이너에서 생성한 코드

    /// <summary>
    /// 디자이너 지원에 필요한 메서드입니다. 
    /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
    /// </summary>
    private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.btnBoardInit = new System.Windows.Forms.Button();
            this.btnBoardRun = new System.Windows.Forms.Button();
            this.cbOutList = new System.Windows.Forms.ComboBox();
            this.btnBitOn = new System.Windows.Forms.Button();
            this.btnBitOff = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnIOMonStart = new System.Windows.Forms.Button();
            this.btnIOMonStop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbIn19 = new System.Windows.Forms.CheckBox();
            this.cbIn18 = new System.Windows.Forms.CheckBox();
            this.cbIn17 = new System.Windows.Forms.CheckBox();
            this.cbIn16 = new System.Windows.Forms.CheckBox();
            this.cbIn15 = new System.Windows.Forms.CheckBox();
            this.cbIn07 = new System.Windows.Forms.CheckBox();
            this.cbIn14 = new System.Windows.Forms.CheckBox();
            this.cbIn13 = new System.Windows.Forms.CheckBox();
            this.cbIn06 = new System.Windows.Forms.CheckBox();
            this.cbIn12 = new System.Windows.Forms.CheckBox();
            this.cbIn05 = new System.Windows.Forms.CheckBox();
            this.cbIn11 = new System.Windows.Forms.CheckBox();
            this.cbIn04 = new System.Windows.Forms.CheckBox();
            this.cbIn10 = new System.Windows.Forms.CheckBox();
            this.cbIn03 = new System.Windows.Forms.CheckBox();
            this.cbIn09 = new System.Windows.Forms.CheckBox();
            this.cbIn02 = new System.Windows.Forms.CheckBox();
            this.cbIn08 = new System.Windows.Forms.CheckBox();
            this.cbIn01 = new System.Windows.Forms.CheckBox();
            this.cbIn00 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbOut17 = new System.Windows.Forms.CheckBox();
            this.cbOut16 = new System.Windows.Forms.CheckBox();
            this.cbOut15 = new System.Windows.Forms.CheckBox();
            this.cbOut07 = new System.Windows.Forms.CheckBox();
            this.cbOut14 = new System.Windows.Forms.CheckBox();
            this.cbOut13 = new System.Windows.Forms.CheckBox();
            this.cbOut06 = new System.Windows.Forms.CheckBox();
            this.cbOut12 = new System.Windows.Forms.CheckBox();
            this.cbOut05 = new System.Windows.Forms.CheckBox();
            this.cbOut11 = new System.Windows.Forms.CheckBox();
            this.cbOut04 = new System.Windows.Forms.CheckBox();
            this.cbOut10 = new System.Windows.Forms.CheckBox();
            this.cbOut03 = new System.Windows.Forms.CheckBox();
            this.cbOut09 = new System.Windows.Forms.CheckBox();
            this.cbOut02 = new System.Windows.Forms.CheckBox();
            this.cbOut08 = new System.Windows.Forms.CheckBox();
            this.cbOut01 = new System.Windows.Forms.CheckBox();
            this.cbOut00 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUnldCylBWD = new System.Windows.Forms.Button();
            this.btnMoveCylBWD = new System.Windows.Forms.Button();
            this.btnLoadCylBWD = new System.Windows.Forms.Button();
            this.btnWorkCylBWD = new System.Windows.Forms.Button();
            this.btnUnldCylFWD = new System.Windows.Forms.Button();
            this.btnLoadCylFWD = new System.Windows.Forms.Button();
            this.btnMoveCylFWD = new System.Windows.Forms.Button();
            this.btnWorkCylFWD = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBoardInit
            // 
            this.btnBoardInit.Font = new System.Drawing.Font("굴림", 29F);
            this.btnBoardInit.Location = new System.Drawing.Point(12, 11);
            this.btnBoardInit.Name = "btnBoardInit";
            this.btnBoardInit.Size = new System.Drawing.Size(247, 62);
            this.btnBoardInit.TabIndex = 0;
            this.btnBoardInit.Text = "보드 초기화";
            this.btnBoardInit.UseVisualStyleBackColor = true;
            this.btnBoardInit.Click += new System.EventHandler(this.btnBoardInit_Click);
            // 
            // btnBoardRun
            // 
            this.btnBoardRun.Font = new System.Drawing.Font("굴림", 29F);
            this.btnBoardRun.Location = new System.Drawing.Point(270, 11);
            this.btnBoardRun.Name = "btnBoardRun";
            this.btnBoardRun.Size = new System.Drawing.Size(247, 62);
            this.btnBoardRun.TabIndex = 0;
            this.btnBoardRun.Text = "보드 런";
            this.btnBoardRun.UseVisualStyleBackColor = true;
            this.btnBoardRun.Click += new System.EventHandler(this.btnBoardRun_Click);
            // 
            // cbOutList
            // 
            this.cbOutList.Font = new System.Drawing.Font("굴림", 29F);
            this.cbOutList.FormattingEnabled = true;
            this.cbOutList.Location = new System.Drawing.Point(13, 81);
            this.cbOutList.Name = "cbOutList";
            this.cbOutList.Size = new System.Drawing.Size(137, 47);
            this.cbOutList.TabIndex = 1;
            // 
            // btnBitOn
            // 
            this.btnBitOn.Font = new System.Drawing.Font("굴림", 29F);
            this.btnBitOn.Location = new System.Drawing.Point(165, 80);
            this.btnBitOn.Name = "btnBitOn";
            this.btnBitOn.Size = new System.Drawing.Size(173, 48);
            this.btnBitOn.TabIndex = 0;
            this.btnBitOn.Text = "Bit On";
            this.btnBitOn.UseVisualStyleBackColor = true;
            this.btnBitOn.Click += new System.EventHandler(this.btnBitOn_Click);
            // 
            // btnBitOff
            // 
            this.btnBitOff.Font = new System.Drawing.Font("굴림", 29F);
            this.btnBitOff.Location = new System.Drawing.Point(344, 79);
            this.btnBitOff.Name = "btnBitOff";
            this.btnBitOff.Size = new System.Drawing.Size(173, 48);
            this.btnBitOff.TabIndex = 0;
            this.btnBitOff.Text = "Bit Off";
            this.btnBitOff.UseVisualStyleBackColor = true;
            this.btnBitOff.Click += new System.EventHandler(this.btnBitOff_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnIOMonStart
            // 
            this.btnIOMonStart.Font = new System.Drawing.Font("굴림", 29F);
            this.btnIOMonStart.Location = new System.Drawing.Point(12, 134);
            this.btnIOMonStart.Name = "btnIOMonStart";
            this.btnIOMonStart.Size = new System.Drawing.Size(505, 48);
            this.btnIOMonStart.TabIndex = 0;
            this.btnIOMonStart.Text = "IO Mon Start";
            this.btnIOMonStart.UseVisualStyleBackColor = true;
            this.btnIOMonStart.Click += new System.EventHandler(this.btnIOMonStart_Click);
            // 
            // btnIOMonStop
            // 
            this.btnIOMonStop.Font = new System.Drawing.Font("굴림", 29F);
            this.btnIOMonStop.Location = new System.Drawing.Point(12, 188);
            this.btnIOMonStop.Name = "btnIOMonStop";
            this.btnIOMonStop.Size = new System.Drawing.Size(505, 48);
            this.btnIOMonStop.TabIndex = 0;
            this.btnIOMonStop.Text = "IO Mon Stop";
            this.btnIOMonStop.UseVisualStyleBackColor = true;
            this.btnIOMonStop.Click += new System.EventHandler(this.btnIOMonStop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbIn19);
            this.groupBox1.Controls.Add(this.cbIn18);
            this.groupBox1.Controls.Add(this.cbIn17);
            this.groupBox1.Controls.Add(this.cbIn16);
            this.groupBox1.Controls.Add(this.cbIn15);
            this.groupBox1.Controls.Add(this.cbIn07);
            this.groupBox1.Controls.Add(this.cbIn14);
            this.groupBox1.Controls.Add(this.cbIn13);
            this.groupBox1.Controls.Add(this.cbIn06);
            this.groupBox1.Controls.Add(this.cbIn12);
            this.groupBox1.Controls.Add(this.cbIn05);
            this.groupBox1.Controls.Add(this.cbIn11);
            this.groupBox1.Controls.Add(this.cbIn04);
            this.groupBox1.Controls.Add(this.cbIn10);
            this.groupBox1.Controls.Add(this.cbIn03);
            this.groupBox1.Controls.Add(this.cbIn09);
            this.groupBox1.Controls.Add(this.cbIn02);
            this.groupBox1.Controls.Add(this.cbIn08);
            this.groupBox1.Controls.Add(this.cbIn01);
            this.groupBox1.Controls.Add(this.cbIn00);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 29F);
            this.groupBox1.Location = new System.Drawing.Point(13, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 535);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // cbIn19
            // 
            this.cbIn19.AutoSize = true;
            this.cbIn19.Font = new System.Drawing.Font("굴림", 29F);
            this.cbIn19.Location = new System.Drawing.Point(123, 465);
            this.cbIn19.Name = "cbIn19";
            this.cbIn19.Size = new System.Drawing.Size(104, 43);
            this.cbIn19.TabIndex = 19;
            this.cbIn19.Text = "X19";
            this.cbIn19.UseVisualStyleBackColor = true;
            // 
            // cbIn18
            // 
            this.cbIn18.AutoSize = true;
            this.cbIn18.Font = new System.Drawing.Font("굴림", 29F);
            this.cbIn18.Location = new System.Drawing.Point(123, 419);
            this.cbIn18.Name = "cbIn18";
            this.cbIn18.Size = new System.Drawing.Size(104, 43);
            this.cbIn18.TabIndex = 20;
            this.cbIn18.Text = "X18";
            this.cbIn18.UseVisualStyleBackColor = true;
            // 
            // cbIn17
            // 
            this.cbIn17.AutoSize = true;
            this.cbIn17.Font = new System.Drawing.Font("굴림", 29F);
            this.cbIn17.Location = new System.Drawing.Point(123, 370);
            this.cbIn17.Name = "cbIn17";
            this.cbIn17.Size = new System.Drawing.Size(104, 43);
            this.cbIn17.TabIndex = 18;
            this.cbIn17.Text = "X17";
            this.cbIn17.UseVisualStyleBackColor = true;
            // 
            // cbIn16
            // 
            this.cbIn16.AutoSize = true;
            this.cbIn16.Font = new System.Drawing.Font("굴림", 29F);
            this.cbIn16.Location = new System.Drawing.Point(123, 325);
            this.cbIn16.Name = "cbIn16";
            this.cbIn16.Size = new System.Drawing.Size(104, 43);
            this.cbIn16.TabIndex = 17;
            this.cbIn16.Text = "X16";
            this.cbIn16.UseVisualStyleBackColor = true;
            // 
            // cbIn15
            // 
            this.cbIn15.AutoSize = true;
            this.cbIn15.Font = new System.Drawing.Font("굴림", 29F);
            this.cbIn15.Location = new System.Drawing.Point(123, 280);
            this.cbIn15.Name = "cbIn15";
            this.cbIn15.Size = new System.Drawing.Size(104, 43);
            this.cbIn15.TabIndex = 1;
            this.cbIn15.Text = "X15";
            this.cbIn15.UseVisualStyleBackColor = true;
            // 
            // cbIn07
            // 
            this.cbIn07.AutoSize = true;
            this.cbIn07.Font = new System.Drawing.Font("굴림", 29F);
            this.cbIn07.Location = new System.Drawing.Point(13, 373);
            this.cbIn07.Name = "cbIn07";
            this.cbIn07.Size = new System.Drawing.Size(104, 43);
            this.cbIn07.TabIndex = 2;
            this.cbIn07.Text = "X07";
            this.cbIn07.UseVisualStyleBackColor = true;
            // 
            // cbIn14
            // 
            this.cbIn14.AutoSize = true;
            this.cbIn14.Font = new System.Drawing.Font("굴림", 29F);
            this.cbIn14.Location = new System.Drawing.Point(123, 235);
            this.cbIn14.Name = "cbIn14";
            this.cbIn14.Size = new System.Drawing.Size(104, 43);
            this.cbIn14.TabIndex = 3;
            this.cbIn14.Text = "X14";
            this.cbIn14.UseVisualStyleBackColor = true;
            // 
            // cbIn13
            // 
            this.cbIn13.AutoSize = true;
            this.cbIn13.Font = new System.Drawing.Font("굴림", 29F);
            this.cbIn13.Location = new System.Drawing.Point(123, 190);
            this.cbIn13.Name = "cbIn13";
            this.cbIn13.Size = new System.Drawing.Size(104, 43);
            this.cbIn13.TabIndex = 4;
            this.cbIn13.Text = "X13";
            this.cbIn13.UseVisualStyleBackColor = true;
            // 
            // cbIn06
            // 
            this.cbIn06.AutoSize = true;
            this.cbIn06.Font = new System.Drawing.Font("굴림", 29F);
            this.cbIn06.Location = new System.Drawing.Point(13, 327);
            this.cbIn06.Name = "cbIn06";
            this.cbIn06.Size = new System.Drawing.Size(104, 43);
            this.cbIn06.TabIndex = 5;
            this.cbIn06.Text = "X06";
            this.cbIn06.UseVisualStyleBackColor = true;
            // 
            // cbIn12
            // 
            this.cbIn12.AutoSize = true;
            this.cbIn12.Font = new System.Drawing.Font("굴림", 29F);
            this.cbIn12.Location = new System.Drawing.Point(123, 145);
            this.cbIn12.Name = "cbIn12";
            this.cbIn12.Size = new System.Drawing.Size(104, 43);
            this.cbIn12.TabIndex = 6;
            this.cbIn12.Text = "X12";
            this.cbIn12.UseVisualStyleBackColor = true;
            // 
            // cbIn05
            // 
            this.cbIn05.AutoSize = true;
            this.cbIn05.Font = new System.Drawing.Font("굴림", 29F);
            this.cbIn05.Location = new System.Drawing.Point(13, 281);
            this.cbIn05.Name = "cbIn05";
            this.cbIn05.Size = new System.Drawing.Size(104, 43);
            this.cbIn05.TabIndex = 7;
            this.cbIn05.Text = "X05";
            this.cbIn05.UseVisualStyleBackColor = true;
            // 
            // cbIn11
            // 
            this.cbIn11.AutoSize = true;
            this.cbIn11.Font = new System.Drawing.Font("굴림", 29F);
            this.cbIn11.Location = new System.Drawing.Point(123, 100);
            this.cbIn11.Name = "cbIn11";
            this.cbIn11.Size = new System.Drawing.Size(104, 43);
            this.cbIn11.TabIndex = 8;
            this.cbIn11.Text = "X11";
            this.cbIn11.UseVisualStyleBackColor = true;
            // 
            // cbIn04
            // 
            this.cbIn04.AutoSize = true;
            this.cbIn04.Font = new System.Drawing.Font("굴림", 29F);
            this.cbIn04.Location = new System.Drawing.Point(13, 235);
            this.cbIn04.Name = "cbIn04";
            this.cbIn04.Size = new System.Drawing.Size(104, 43);
            this.cbIn04.TabIndex = 9;
            this.cbIn04.Text = "X04";
            this.cbIn04.UseVisualStyleBackColor = true;
            // 
            // cbIn10
            // 
            this.cbIn10.AutoSize = true;
            this.cbIn10.Font = new System.Drawing.Font("굴림", 29F);
            this.cbIn10.Location = new System.Drawing.Point(123, 51);
            this.cbIn10.Name = "cbIn10";
            this.cbIn10.Size = new System.Drawing.Size(104, 43);
            this.cbIn10.TabIndex = 10;
            this.cbIn10.Text = "X10";
            this.cbIn10.UseVisualStyleBackColor = true;
            // 
            // cbIn03
            // 
            this.cbIn03.AutoSize = true;
            this.cbIn03.Font = new System.Drawing.Font("굴림", 29F);
            this.cbIn03.Location = new System.Drawing.Point(13, 189);
            this.cbIn03.Name = "cbIn03";
            this.cbIn03.Size = new System.Drawing.Size(104, 43);
            this.cbIn03.TabIndex = 11;
            this.cbIn03.Text = "X03";
            this.cbIn03.UseVisualStyleBackColor = true;
            // 
            // cbIn09
            // 
            this.cbIn09.AutoSize = true;
            this.cbIn09.Font = new System.Drawing.Font("굴림", 29F);
            this.cbIn09.Location = new System.Drawing.Point(13, 465);
            this.cbIn09.Name = "cbIn09";
            this.cbIn09.Size = new System.Drawing.Size(104, 43);
            this.cbIn09.TabIndex = 12;
            this.cbIn09.Text = "X09";
            this.cbIn09.UseVisualStyleBackColor = true;
            // 
            // cbIn02
            // 
            this.cbIn02.AutoSize = true;
            this.cbIn02.Font = new System.Drawing.Font("굴림", 29F);
            this.cbIn02.Location = new System.Drawing.Point(13, 143);
            this.cbIn02.Name = "cbIn02";
            this.cbIn02.Size = new System.Drawing.Size(104, 43);
            this.cbIn02.TabIndex = 13;
            this.cbIn02.Text = "X02";
            this.cbIn02.UseVisualStyleBackColor = true;
            // 
            // cbIn08
            // 
            this.cbIn08.AutoSize = true;
            this.cbIn08.Font = new System.Drawing.Font("굴림", 29F);
            this.cbIn08.Location = new System.Drawing.Point(13, 419);
            this.cbIn08.Name = "cbIn08";
            this.cbIn08.Size = new System.Drawing.Size(104, 43);
            this.cbIn08.TabIndex = 14;
            this.cbIn08.Text = "X08";
            this.cbIn08.UseVisualStyleBackColor = true;
            // 
            // cbIn01
            // 
            this.cbIn01.AutoSize = true;
            this.cbIn01.Font = new System.Drawing.Font("굴림", 29F);
            this.cbIn01.Location = new System.Drawing.Point(13, 97);
            this.cbIn01.Name = "cbIn01";
            this.cbIn01.Size = new System.Drawing.Size(104, 43);
            this.cbIn01.TabIndex = 15;
            this.cbIn01.Text = "X01";
            this.cbIn01.UseVisualStyleBackColor = true;
            // 
            // cbIn00
            // 
            this.cbIn00.AutoSize = true;
            this.cbIn00.Font = new System.Drawing.Font("굴림", 29F);
            this.cbIn00.Location = new System.Drawing.Point(13, 51);
            this.cbIn00.Name = "cbIn00";
            this.cbIn00.Size = new System.Drawing.Size(104, 43);
            this.cbIn00.TabIndex = 16;
            this.cbIn00.Text = "X00";
            this.cbIn00.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbOut17);
            this.groupBox2.Controls.Add(this.cbOut16);
            this.groupBox2.Controls.Add(this.cbOut15);
            this.groupBox2.Controls.Add(this.cbOut07);
            this.groupBox2.Controls.Add(this.cbOut14);
            this.groupBox2.Controls.Add(this.cbOut13);
            this.groupBox2.Controls.Add(this.cbOut06);
            this.groupBox2.Controls.Add(this.cbOut12);
            this.groupBox2.Controls.Add(this.cbOut05);
            this.groupBox2.Controls.Add(this.cbOut11);
            this.groupBox2.Controls.Add(this.cbOut04);
            this.groupBox2.Controls.Add(this.cbOut10);
            this.groupBox2.Controls.Add(this.cbOut03);
            this.groupBox2.Controls.Add(this.cbOut09);
            this.groupBox2.Controls.Add(this.cbOut02);
            this.groupBox2.Controls.Add(this.cbOut08);
            this.groupBox2.Controls.Add(this.cbOut01);
            this.groupBox2.Controls.Add(this.cbOut00);
            this.groupBox2.Font = new System.Drawing.Font("굴림", 29F);
            this.groupBox2.Location = new System.Drawing.Point(270, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 535);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // cbOut17
            // 
            this.cbOut17.AutoSize = true;
            this.cbOut17.Font = new System.Drawing.Font("굴림", 29F);
            this.cbOut17.Location = new System.Drawing.Point(129, 427);
            this.cbOut17.Name = "cbOut17";
            this.cbOut17.Size = new System.Drawing.Size(104, 43);
            this.cbOut17.TabIndex = 18;
            this.cbOut17.Text = "Y17";
            this.cbOut17.UseVisualStyleBackColor = true;
            // 
            // cbOut16
            // 
            this.cbOut16.AutoSize = true;
            this.cbOut16.Font = new System.Drawing.Font("굴림", 29F);
            this.cbOut16.Location = new System.Drawing.Point(129, 380);
            this.cbOut16.Name = "cbOut16";
            this.cbOut16.Size = new System.Drawing.Size(104, 43);
            this.cbOut16.TabIndex = 17;
            this.cbOut16.Text = "Y16";
            this.cbOut16.UseVisualStyleBackColor = true;
            // 
            // cbOut15
            // 
            this.cbOut15.AutoSize = true;
            this.cbOut15.Font = new System.Drawing.Font("굴림", 29F);
            this.cbOut15.Location = new System.Drawing.Point(129, 333);
            this.cbOut15.Name = "cbOut15";
            this.cbOut15.Size = new System.Drawing.Size(104, 43);
            this.cbOut15.TabIndex = 1;
            this.cbOut15.Text = "Y15";
            this.cbOut15.UseVisualStyleBackColor = true;
            // 
            // cbOut07
            // 
            this.cbOut07.AutoSize = true;
            this.cbOut07.Font = new System.Drawing.Font("굴림", 29F);
            this.cbOut07.Location = new System.Drawing.Point(19, 380);
            this.cbOut07.Name = "cbOut07";
            this.cbOut07.Size = new System.Drawing.Size(104, 43);
            this.cbOut07.TabIndex = 2;
            this.cbOut07.Text = "Y07";
            this.cbOut07.UseVisualStyleBackColor = true;
            // 
            // cbOut14
            // 
            this.cbOut14.AutoSize = true;
            this.cbOut14.Font = new System.Drawing.Font("굴림", 29F);
            this.cbOut14.Location = new System.Drawing.Point(129, 286);
            this.cbOut14.Name = "cbOut14";
            this.cbOut14.Size = new System.Drawing.Size(104, 43);
            this.cbOut14.TabIndex = 3;
            this.cbOut14.Text = "Y14";
            this.cbOut14.UseVisualStyleBackColor = true;
            // 
            // cbOut13
            // 
            this.cbOut13.AutoSize = true;
            this.cbOut13.Font = new System.Drawing.Font("굴림", 29F);
            this.cbOut13.Location = new System.Drawing.Point(129, 239);
            this.cbOut13.Name = "cbOut13";
            this.cbOut13.Size = new System.Drawing.Size(104, 43);
            this.cbOut13.TabIndex = 4;
            this.cbOut13.Text = "Y13";
            this.cbOut13.UseVisualStyleBackColor = true;
            // 
            // cbOut06
            // 
            this.cbOut06.AutoSize = true;
            this.cbOut06.Font = new System.Drawing.Font("굴림", 29F);
            this.cbOut06.Location = new System.Drawing.Point(19, 333);
            this.cbOut06.Name = "cbOut06";
            this.cbOut06.Size = new System.Drawing.Size(104, 43);
            this.cbOut06.TabIndex = 5;
            this.cbOut06.Text = "Y06";
            this.cbOut06.UseVisualStyleBackColor = true;
            // 
            // cbOut12
            // 
            this.cbOut12.AutoSize = true;
            this.cbOut12.Font = new System.Drawing.Font("굴림", 29F);
            this.cbOut12.Location = new System.Drawing.Point(129, 192);
            this.cbOut12.Name = "cbOut12";
            this.cbOut12.Size = new System.Drawing.Size(104, 43);
            this.cbOut12.TabIndex = 6;
            this.cbOut12.Text = "Y12";
            this.cbOut12.UseVisualStyleBackColor = true;
            // 
            // cbOut05
            // 
            this.cbOut05.AutoSize = true;
            this.cbOut05.Font = new System.Drawing.Font("굴림", 29F);
            this.cbOut05.Location = new System.Drawing.Point(19, 286);
            this.cbOut05.Name = "cbOut05";
            this.cbOut05.Size = new System.Drawing.Size(104, 43);
            this.cbOut05.TabIndex = 7;
            this.cbOut05.Text = "Y05";
            this.cbOut05.UseVisualStyleBackColor = true;
            // 
            // cbOut11
            // 
            this.cbOut11.AutoSize = true;
            this.cbOut11.Font = new System.Drawing.Font("굴림", 29F);
            this.cbOut11.Location = new System.Drawing.Point(129, 145);
            this.cbOut11.Name = "cbOut11";
            this.cbOut11.Size = new System.Drawing.Size(104, 43);
            this.cbOut11.TabIndex = 8;
            this.cbOut11.Text = "Y11";
            this.cbOut11.UseVisualStyleBackColor = true;
            // 
            // cbOut04
            // 
            this.cbOut04.AutoSize = true;
            this.cbOut04.Font = new System.Drawing.Font("굴림", 29F);
            this.cbOut04.Location = new System.Drawing.Point(19, 239);
            this.cbOut04.Name = "cbOut04";
            this.cbOut04.Size = new System.Drawing.Size(104, 43);
            this.cbOut04.TabIndex = 9;
            this.cbOut04.Text = "Y04";
            this.cbOut04.UseVisualStyleBackColor = true;
            // 
            // cbOut10
            // 
            this.cbOut10.AutoSize = true;
            this.cbOut10.Font = new System.Drawing.Font("굴림", 29F);
            this.cbOut10.Location = new System.Drawing.Point(129, 98);
            this.cbOut10.Name = "cbOut10";
            this.cbOut10.Size = new System.Drawing.Size(104, 43);
            this.cbOut10.TabIndex = 10;
            this.cbOut10.Text = "Y10";
            this.cbOut10.UseVisualStyleBackColor = true;
            // 
            // cbOut03
            // 
            this.cbOut03.AutoSize = true;
            this.cbOut03.Font = new System.Drawing.Font("굴림", 29F);
            this.cbOut03.Location = new System.Drawing.Point(19, 192);
            this.cbOut03.Name = "cbOut03";
            this.cbOut03.Size = new System.Drawing.Size(104, 43);
            this.cbOut03.TabIndex = 11;
            this.cbOut03.Text = "Y03";
            this.cbOut03.UseVisualStyleBackColor = true;
            // 
            // cbOut09
            // 
            this.cbOut09.AutoSize = true;
            this.cbOut09.Font = new System.Drawing.Font("굴림", 29F);
            this.cbOut09.Location = new System.Drawing.Point(129, 51);
            this.cbOut09.Name = "cbOut09";
            this.cbOut09.Size = new System.Drawing.Size(104, 43);
            this.cbOut09.TabIndex = 12;
            this.cbOut09.Text = "Y09";
            this.cbOut09.UseVisualStyleBackColor = true;
            // 
            // cbOut02
            // 
            this.cbOut02.AutoSize = true;
            this.cbOut02.Font = new System.Drawing.Font("굴림", 29F);
            this.cbOut02.Location = new System.Drawing.Point(19, 145);
            this.cbOut02.Name = "cbOut02";
            this.cbOut02.Size = new System.Drawing.Size(104, 43);
            this.cbOut02.TabIndex = 13;
            this.cbOut02.Text = "Y02";
            this.cbOut02.UseVisualStyleBackColor = true;
            // 
            // cbOut08
            // 
            this.cbOut08.AutoSize = true;
            this.cbOut08.Font = new System.Drawing.Font("굴림", 29F);
            this.cbOut08.Location = new System.Drawing.Point(19, 429);
            this.cbOut08.Name = "cbOut08";
            this.cbOut08.Size = new System.Drawing.Size(104, 43);
            this.cbOut08.TabIndex = 14;
            this.cbOut08.Text = "Y08";
            this.cbOut08.UseVisualStyleBackColor = true;
            // 
            // cbOut01
            // 
            this.cbOut01.AutoSize = true;
            this.cbOut01.Font = new System.Drawing.Font("굴림", 29F);
            this.cbOut01.Location = new System.Drawing.Point(19, 98);
            this.cbOut01.Name = "cbOut01";
            this.cbOut01.Size = new System.Drawing.Size(104, 43);
            this.cbOut01.TabIndex = 15;
            this.cbOut01.Text = "Y01";
            this.cbOut01.UseVisualStyleBackColor = true;
            // 
            // cbOut00
            // 
            this.cbOut00.AutoSize = true;
            this.cbOut00.Font = new System.Drawing.Font("굴림", 29F);
            this.cbOut00.Location = new System.Drawing.Point(19, 51);
            this.cbOut00.Name = "cbOut00";
            this.cbOut00.Size = new System.Drawing.Size(104, 43);
            this.cbOut00.TabIndex = 16;
            this.cbOut00.Text = "Y00";
            this.cbOut00.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnUnldCylBWD);
            this.groupBox3.Controls.Add(this.btnMoveCylBWD);
            this.groupBox3.Controls.Add(this.btnLoadCylBWD);
            this.groupBox3.Controls.Add(this.btnWorkCylBWD);
            this.groupBox3.Controls.Add(this.btnUnldCylFWD);
            this.groupBox3.Controls.Add(this.btnLoadCylFWD);
            this.groupBox3.Controls.Add(this.btnMoveCylFWD);
            this.groupBox3.Controls.Add(this.btnWorkCylFWD);
            this.groupBox3.Font = new System.Drawing.Font("굴림", 29F);
            this.groupBox3.Location = new System.Drawing.Point(545, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(606, 285);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cyl Manual";
            // 
            // btnUnldCylBWD
            // 
            this.btnUnldCylBWD.Font = new System.Drawing.Font("굴림", 29F);
            this.btnUnldCylBWD.Location = new System.Drawing.Point(306, 213);
            this.btnUnldCylBWD.Name = "btnUnldCylBWD";
            this.btnUnldCylBWD.Size = new System.Drawing.Size(285, 49);
            this.btnUnldCylBWD.TabIndex = 0;
            this.btnUnldCylBWD.Text = "UnldCyl Bwd";
            this.btnUnldCylBWD.UseVisualStyleBackColor = true;
            this.btnUnldCylBWD.Click += new System.EventHandler(this.btnUnldCylBWD_Click);
            // 
            // btnMoveCylBWD
            // 
            this.btnMoveCylBWD.Font = new System.Drawing.Font("굴림", 29F);
            this.btnMoveCylBWD.Location = new System.Drawing.Point(306, 159);
            this.btnMoveCylBWD.Name = "btnMoveCylBWD";
            this.btnMoveCylBWD.Size = new System.Drawing.Size(285, 49);
            this.btnMoveCylBWD.TabIndex = 0;
            this.btnMoveCylBWD.Text = "MoveCyl Bwd";
            this.btnMoveCylBWD.UseVisualStyleBackColor = true;
            this.btnMoveCylBWD.Click += new System.EventHandler(this.btnMoveCylBWD_Click);
            // 
            // btnLoadCylBWD
            // 
            this.btnLoadCylBWD.Font = new System.Drawing.Font("굴림", 29F);
            this.btnLoadCylBWD.Location = new System.Drawing.Point(306, 55);
            this.btnLoadCylBWD.Name = "btnLoadCylBWD";
            this.btnLoadCylBWD.Size = new System.Drawing.Size(285, 49);
            this.btnLoadCylBWD.TabIndex = 0;
            this.btnLoadCylBWD.Text = "LoadCyl Bwd";
            this.btnLoadCylBWD.UseVisualStyleBackColor = true;
            this.btnLoadCylBWD.Click += new System.EventHandler(this.btnLoadCylBWD_Click);
            // 
            // btnWorkCylBWD
            // 
            this.btnWorkCylBWD.Font = new System.Drawing.Font("굴림", 29F);
            this.btnWorkCylBWD.Location = new System.Drawing.Point(306, 107);
            this.btnWorkCylBWD.Name = "btnWorkCylBWD";
            this.btnWorkCylBWD.Size = new System.Drawing.Size(285, 49);
            this.btnWorkCylBWD.TabIndex = 0;
            this.btnWorkCylBWD.Text = "WorkCyl Bwd";
            this.btnWorkCylBWD.UseVisualStyleBackColor = true;
            this.btnWorkCylBWD.Click += new System.EventHandler(this.btnWorkCylBWD_Click);
            // 
            // btnUnldCylFWD
            // 
            this.btnUnldCylFWD.Font = new System.Drawing.Font("굴림", 29F);
            this.btnUnldCylFWD.Location = new System.Drawing.Point(6, 213);
            this.btnUnldCylFWD.Name = "btnUnldCylFWD";
            this.btnUnldCylFWD.Size = new System.Drawing.Size(285, 49);
            this.btnUnldCylFWD.TabIndex = 0;
            this.btnUnldCylFWD.Text = "UnldCyl Fwd";
            this.btnUnldCylFWD.UseVisualStyleBackColor = true;
            this.btnUnldCylFWD.Click += new System.EventHandler(this.btnUnldCylFWD_Click);
            // 
            // btnLoadCylFWD
            // 
            this.btnLoadCylFWD.Font = new System.Drawing.Font("굴림", 29F);
            this.btnLoadCylFWD.Location = new System.Drawing.Point(6, 55);
            this.btnLoadCylFWD.Name = "btnLoadCylFWD";
            this.btnLoadCylFWD.Size = new System.Drawing.Size(285, 49);
            this.btnLoadCylFWD.TabIndex = 0;
            this.btnLoadCylFWD.Text = "LoadCyl Fwd";
            this.btnLoadCylFWD.UseVisualStyleBackColor = true;
            this.btnLoadCylFWD.Click += new System.EventHandler(this.btnLoadCylFWD_Click);
            // 
            // btnMoveCylFWD
            // 
            this.btnMoveCylFWD.Font = new System.Drawing.Font("굴림", 29F);
            this.btnMoveCylFWD.Location = new System.Drawing.Point(6, 159);
            this.btnMoveCylFWD.Name = "btnMoveCylFWD";
            this.btnMoveCylFWD.Size = new System.Drawing.Size(285, 49);
            this.btnMoveCylFWD.TabIndex = 0;
            this.btnMoveCylFWD.Text = "MoveCyl Fwd";
            this.btnMoveCylFWD.UseVisualStyleBackColor = true;
            this.btnMoveCylFWD.Click += new System.EventHandler(this.btnMoveCylFWD_Click);
            // 
            // btnWorkCylFWD
            // 
            this.btnWorkCylFWD.Font = new System.Drawing.Font("굴림", 29F);
            this.btnWorkCylFWD.Location = new System.Drawing.Point(6, 107);
            this.btnWorkCylFWD.Name = "btnWorkCylFWD";
            this.btnWorkCylFWD.Size = new System.Drawing.Size(285, 49);
            this.btnWorkCylFWD.TabIndex = 0;
            this.btnWorkCylFWD.Text = "WorkCyl Fwd";
            this.btnWorkCylFWD.UseVisualStyleBackColor = true;
            this.btnWorkCylFWD.Click += new System.EventHandler(this.btnWorkCylFWD_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 789);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbOutList);
            this.Controls.Add(this.btnBoardRun);
            this.Controls.Add(this.btnBitOff);
            this.Controls.Add(this.btnIOMonStop);
            this.Controls.Add(this.btnIOMonStart);
            this.Controls.Add(this.btnBitOn);
            this.Controls.Add(this.btnBoardInit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnBoardInit;
    private System.Windows.Forms.Button btnBoardRun;
    private System.Windows.Forms.ComboBox cbOutList;
    private System.Windows.Forms.Button btnBitOn;
    private System.Windows.Forms.Button btnBitOff;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Button btnIOMonStart;
    private System.Windows.Forms.Button btnIOMonStop;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Button btnWorkCylBWD;
    private System.Windows.Forms.Button btnWorkCylFWD;
    private System.Windows.Forms.CheckBox cbIn15;
    private System.Windows.Forms.CheckBox cbIn07;
    private System.Windows.Forms.CheckBox cbIn14;
    private System.Windows.Forms.CheckBox cbIn13;
    private System.Windows.Forms.CheckBox cbIn06;
    private System.Windows.Forms.CheckBox cbIn12;
    private System.Windows.Forms.CheckBox cbIn05;
    private System.Windows.Forms.CheckBox cbIn11;
    private System.Windows.Forms.CheckBox cbIn04;
    private System.Windows.Forms.CheckBox cbIn10;
    private System.Windows.Forms.CheckBox cbIn03;
    private System.Windows.Forms.CheckBox cbIn09;
    private System.Windows.Forms.CheckBox cbIn02;
    private System.Windows.Forms.CheckBox cbIn08;
    private System.Windows.Forms.CheckBox cbIn01;
    private System.Windows.Forms.CheckBox cbIn00;
    private System.Windows.Forms.CheckBox cbOut15;
    private System.Windows.Forms.CheckBox cbOut07;
    private System.Windows.Forms.CheckBox cbOut14;
    private System.Windows.Forms.CheckBox cbOut13;
    private System.Windows.Forms.CheckBox cbOut06;
    private System.Windows.Forms.CheckBox cbOut12;
    private System.Windows.Forms.CheckBox cbOut05;
    private System.Windows.Forms.CheckBox cbOut11;
    private System.Windows.Forms.CheckBox cbOut04;
    private System.Windows.Forms.CheckBox cbOut10;
    private System.Windows.Forms.CheckBox cbOut03;
    private System.Windows.Forms.CheckBox cbOut09;
    private System.Windows.Forms.CheckBox cbOut02;
    private System.Windows.Forms.CheckBox cbOut08;
    private System.Windows.Forms.CheckBox cbOut01;
    private System.Windows.Forms.CheckBox cbOut00;
    private System.Windows.Forms.Button btnUnldCylBWD;
    private System.Windows.Forms.Button btnMoveCylBWD;
    private System.Windows.Forms.Button btnLoadCylBWD;
    private System.Windows.Forms.Button btnUnldCylFWD;
    private System.Windows.Forms.Button btnLoadCylFWD;
    private System.Windows.Forms.Button btnMoveCylFWD;
        private System.Windows.Forms.CheckBox cbOut16;
        private System.Windows.Forms.CheckBox cbOut17;
        private System.Windows.Forms.CheckBox cbIn19;
        private System.Windows.Forms.CheckBox cbIn18;
        private System.Windows.Forms.CheckBox cbIn17;
        private System.Windows.Forms.CheckBox cbIn16;
        private System.Windows.Forms.Timer timer2;
    }
}

