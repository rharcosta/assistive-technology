namespace tcc
{
    partial class FrmTeclado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.CaixaTexto = new System.Windows.Forms.RichTextBox();
            this.tkbVolume = new System.Windows.Forms.TrackBar();
            this.tkbVelocidade = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQ = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.btnO = new System.Windows.Forms.Button();
            this.btnI = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.btnY = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnW = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.btnH = new System.Windows.Forms.Button();
            this.btnJ = new System.Windows.Forms.Button();
            this.btnK = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnÇ = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnV = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.btnPonto = new System.Windows.Forms.Button();
            this.btnZ = new System.Windows.Forms.Button();
            this.btnSPACE = new System.Windows.Forms.Button();
            this.btnLIMPAR = new System.Windows.Forms.Button();
            this.btnBACKSPACE = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnENTER = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.lblPrevisao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tkbVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbVelocidade)).BeginInit();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(736, 18);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(75, 23);
            this.btnExecutar.TabIndex = 0;
            this.btnExecutar.Text = "Falar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // CaixaTexto
            // 
            this.CaixaTexto.BackColor = System.Drawing.Color.Black;
            this.CaixaTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaixaTexto.ForeColor = System.Drawing.Color.White;
            this.CaixaTexto.Location = new System.Drawing.Point(0, 38);
            this.CaixaTexto.Name = "CaixaTexto";
            this.CaixaTexto.Size = new System.Drawing.Size(848, 164);
            this.CaixaTexto.TabIndex = 1;
            this.CaixaTexto.Text = "";
            // 
            // tkbVolume
            // 
            this.tkbVolume.Location = new System.Drawing.Point(51, 10);
            this.tkbVolume.Maximum = 100;
            this.tkbVolume.Name = "tkbVolume";
            this.tkbVolume.Size = new System.Drawing.Size(291, 45);
            this.tkbVolume.TabIndex = 2;
            this.tkbVolume.TickFrequency = 10;
            this.tkbVolume.Value = 50;
            // 
            // tkbVelocidade
            // 
            this.tkbVelocidade.Location = new System.Drawing.Point(428, 10);
            this.tkbVelocidade.Minimum = -10;
            this.tkbVelocidade.Name = "tkbVelocidade";
            this.tkbVelocidade.Size = new System.Drawing.Size(291, 45);
            this.tkbVelocidade.TabIndex = 3;
            this.tkbVelocidade.TickFrequency = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Volume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(362, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Velocidade";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tkbVolume);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnExecutar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tkbVelocidade);
            this.panel1.Location = new System.Drawing.Point(12, 468);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 58);
            this.panel1.TabIndex = 6;
            // 
            // btnQ
            // 
            this.btnQ.BackColor = System.Drawing.Color.White;
            this.btnQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ.Location = new System.Drawing.Point(39, 229);
            this.btnQ.Name = "btnQ";
            this.btnQ.Size = new System.Drawing.Size(37, 35);
            this.btnQ.TabIndex = 7;
            this.btnQ.Text = "Q";
            this.btnQ.UseVisualStyleBackColor = false;
            this.btnQ.Click += new System.EventHandler(this.btnBotao_Click);
            // 
            // btnP
            // 
            this.btnP.BackColor = System.Drawing.Color.White;
            this.btnP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP.Location = new System.Drawing.Point(426, 229);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(37, 35);
            this.btnP.TabIndex = 20;
            this.btnP.Text = "P";
            this.btnP.UseVisualStyleBackColor = false;
            this.btnP.Click += new System.EventHandler(this.btnBotao_Click);
            // 
            // btnO
            // 
            this.btnO.BackColor = System.Drawing.Color.White;
            this.btnO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnO.Location = new System.Drawing.Point(383, 229);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(37, 35);
            this.btnO.TabIndex = 21;
            this.btnO.Text = "O";
            this.btnO.UseVisualStyleBackColor = false;
            this.btnO.Click += new System.EventHandler(this.btnBotao_Click);
            // 
            // btnI
            // 
            this.btnI.BackColor = System.Drawing.Color.White;
            this.btnI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnI.Location = new System.Drawing.Point(340, 229);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(37, 35);
            this.btnI.TabIndex = 22;
            this.btnI.Text = "I";
            this.btnI.UseVisualStyleBackColor = false;
            this.btnI.Click += new System.EventHandler(this.btnBotao_Click);
            // 
            // btnU
            // 
            this.btnU.BackColor = System.Drawing.Color.White;
            this.btnU.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnU.Location = new System.Drawing.Point(297, 229);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(37, 35);
            this.btnU.TabIndex = 23;
            this.btnU.Text = "U";
            this.btnU.UseVisualStyleBackColor = false;
            this.btnU.Click += new System.EventHandler(this.btnBotao_Click);
            // 
            // btnY
            // 
            this.btnY.BackColor = System.Drawing.Color.White;
            this.btnY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnY.Location = new System.Drawing.Point(254, 229);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(37, 35);
            this.btnY.TabIndex = 24;
            this.btnY.Text = "Y";
            this.btnY.UseVisualStyleBackColor = false;
            this.btnY.Click += new System.EventHandler(this.btnBotao_Click);
            // 
            // btnT
            // 
            this.btnT.BackColor = System.Drawing.Color.White;
            this.btnT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnT.Location = new System.Drawing.Point(211, 229);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(37, 35);
            this.btnT.TabIndex = 25;
            this.btnT.Text = "T";
            this.btnT.UseVisualStyleBackColor = false;
            this.btnT.Click += new System.EventHandler(this.btnBotao_Click);
            // 
            // btnR
            // 
            this.btnR.BackColor = System.Drawing.Color.White;
            this.btnR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnR.Location = new System.Drawing.Point(168, 229);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(37, 35);
            this.btnR.TabIndex = 26;
            this.btnR.Text = "R";
            this.btnR.UseVisualStyleBackColor = false;
            this.btnR.Click += new System.EventHandler(this.btnBotao_Click);
            // 
            // btnE
            // 
            this.btnE.BackColor = System.Drawing.Color.White;
            this.btnE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnE.Location = new System.Drawing.Point(125, 229);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(37, 35);
            this.btnE.TabIndex = 27;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = false;
            this.btnE.Click += new System.EventHandler(this.btnBotao_Click);
            // 
            // btnW
            // 
            this.btnW.BackColor = System.Drawing.Color.White;
            this.btnW.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnW.Location = new System.Drawing.Point(82, 229);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(37, 35);
            this.btnW.TabIndex = 28;
            this.btnW.Text = "W";
            this.btnW.UseVisualStyleBackColor = false;
            this.btnW.Click += new System.EventHandler(this.btnBotao_Click);
            // 
            // btnS
            // 
            this.btnS.BackColor = System.Drawing.Color.White;
            this.btnS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS.Location = new System.Drawing.Point(82, 281);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(37, 35);
            this.btnS.TabIndex = 39;
            this.btnS.Text = "S";
            this.btnS.UseVisualStyleBackColor = false;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.Color.White;
            this.btnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.Location = new System.Drawing.Point(125, 281);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(37, 35);
            this.btnD.TabIndex = 38;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnF
            // 
            this.btnF.BackColor = System.Drawing.Color.White;
            this.btnF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF.Location = new System.Drawing.Point(168, 281);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(37, 35);
            this.btnF.TabIndex = 37;
            this.btnF.Text = "F";
            this.btnF.UseVisualStyleBackColor = false;
            this.btnF.Click += new System.EventHandler(this.btnF_Click);
            // 
            // btnG
            // 
            this.btnG.BackColor = System.Drawing.Color.White;
            this.btnG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnG.Location = new System.Drawing.Point(211, 281);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(37, 35);
            this.btnG.TabIndex = 36;
            this.btnG.Text = "G";
            this.btnG.UseVisualStyleBackColor = false;
            this.btnG.Click += new System.EventHandler(this.btnG_Click);
            // 
            // btnH
            // 
            this.btnH.BackColor = System.Drawing.Color.White;
            this.btnH.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnH.Location = new System.Drawing.Point(254, 281);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(37, 35);
            this.btnH.TabIndex = 35;
            this.btnH.Text = "H";
            this.btnH.UseVisualStyleBackColor = false;
            this.btnH.Click += new System.EventHandler(this.btnH_Click);
            // 
            // btnJ
            // 
            this.btnJ.BackColor = System.Drawing.Color.White;
            this.btnJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJ.Location = new System.Drawing.Point(297, 281);
            this.btnJ.Name = "btnJ";
            this.btnJ.Size = new System.Drawing.Size(37, 35);
            this.btnJ.TabIndex = 34;
            this.btnJ.Text = "J";
            this.btnJ.UseVisualStyleBackColor = false;
            this.btnJ.Click += new System.EventHandler(this.btnJ_Click);
            // 
            // btnK
            // 
            this.btnK.BackColor = System.Drawing.Color.White;
            this.btnK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnK.Location = new System.Drawing.Point(340, 281);
            this.btnK.Name = "btnK";
            this.btnK.Size = new System.Drawing.Size(37, 35);
            this.btnK.TabIndex = 33;
            this.btnK.Text = "K";
            this.btnK.UseVisualStyleBackColor = false;
            this.btnK.Click += new System.EventHandler(this.btnK_Click);
            // 
            // btnL
            // 
            this.btnL.BackColor = System.Drawing.Color.White;
            this.btnL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL.Location = new System.Drawing.Point(383, 281);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(37, 35);
            this.btnL.TabIndex = 32;
            this.btnL.Text = "L";
            this.btnL.UseVisualStyleBackColor = false;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // btnÇ
            // 
            this.btnÇ.BackColor = System.Drawing.Color.White;
            this.btnÇ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnÇ.Location = new System.Drawing.Point(426, 281);
            this.btnÇ.Name = "btnÇ";
            this.btnÇ.Size = new System.Drawing.Size(37, 35);
            this.btnÇ.TabIndex = 31;
            this.btnÇ.Text = "Ç";
            this.btnÇ.UseVisualStyleBackColor = false;
            this.btnÇ.Click += new System.EventHandler(this.btnÇ_Click);
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.White;
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.Location = new System.Drawing.Point(39, 281);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(37, 35);
            this.btnA.TabIndex = 29;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.White;
            this.btnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.Location = new System.Drawing.Point(106, 331);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(37, 35);
            this.btnX.TabIndex = 49;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.White;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(149, 331);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(37, 35);
            this.btnC.TabIndex = 48;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnV
            // 
            this.btnV.BackColor = System.Drawing.Color.White;
            this.btnV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnV.Location = new System.Drawing.Point(192, 331);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(37, 35);
            this.btnV.TabIndex = 47;
            this.btnV.Text = "V";
            this.btnV.UseVisualStyleBackColor = false;
            this.btnV.Click += new System.EventHandler(this.btnV_Click);
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.Color.White;
            this.btnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB.Location = new System.Drawing.Point(235, 331);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(37, 35);
            this.btnB.TabIndex = 46;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnN
            // 
            this.btnN.BackColor = System.Drawing.Color.White;
            this.btnN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN.Location = new System.Drawing.Point(278, 331);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(37, 35);
            this.btnN.TabIndex = 45;
            this.btnN.Text = "N";
            this.btnN.UseVisualStyleBackColor = false;
            this.btnN.Click += new System.EventHandler(this.btnN_Click);
            // 
            // btnM
            // 
            this.btnM.BackColor = System.Drawing.Color.White;
            this.btnM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnM.Location = new System.Drawing.Point(321, 331);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(37, 35);
            this.btnM.TabIndex = 44;
            this.btnM.Text = "M";
            this.btnM.UseVisualStyleBackColor = false;
            this.btnM.Click += new System.EventHandler(this.btnM_Click);
            // 
            // btnVirgula
            // 
            this.btnVirgula.BackColor = System.Drawing.Color.White;
            this.btnVirgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVirgula.Location = new System.Drawing.Point(364, 331);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(37, 35);
            this.btnVirgula.TabIndex = 43;
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = false;
            this.btnVirgula.Click += new System.EventHandler(this.button27_Click);
            // 
            // btnPonto
            // 
            this.btnPonto.BackColor = System.Drawing.Color.White;
            this.btnPonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPonto.Location = new System.Drawing.Point(407, 331);
            this.btnPonto.Name = "btnPonto";
            this.btnPonto.Size = new System.Drawing.Size(37, 35);
            this.btnPonto.TabIndex = 42;
            this.btnPonto.Text = ".";
            this.btnPonto.UseVisualStyleBackColor = false;
            this.btnPonto.Click += new System.EventHandler(this.button28_Click);
            // 
            // btnZ
            // 
            this.btnZ.BackColor = System.Drawing.Color.White;
            this.btnZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZ.Location = new System.Drawing.Point(63, 331);
            this.btnZ.Name = "btnZ";
            this.btnZ.Size = new System.Drawing.Size(37, 35);
            this.btnZ.TabIndex = 40;
            this.btnZ.Text = "Z";
            this.btnZ.UseVisualStyleBackColor = false;
            this.btnZ.Click += new System.EventHandler(this.btnZ_Click);
            // 
            // btnSPACE
            // 
            this.btnSPACE.BackColor = System.Drawing.Color.White;
            this.btnSPACE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSPACE.Location = new System.Drawing.Point(106, 383);
            this.btnSPACE.Name = "btnSPACE";
            this.btnSPACE.Size = new System.Drawing.Size(295, 35);
            this.btnSPACE.TabIndex = 50;
            this.btnSPACE.Text = "SPACE";
            this.btnSPACE.UseVisualStyleBackColor = false;
            this.btnSPACE.Click += new System.EventHandler(this.btnSPACE_Click);
            // 
            // btnLIMPAR
            // 
            this.btnLIMPAR.BackColor = System.Drawing.Color.White;
            this.btnLIMPAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLIMPAR.Location = new System.Drawing.Point(469, 281);
            this.btnLIMPAR.Name = "btnLIMPAR";
            this.btnLIMPAR.Size = new System.Drawing.Size(163, 35);
            this.btnLIMPAR.TabIndex = 51;
            this.btnLIMPAR.Text = "LIMPAR TUDO";
            this.btnLIMPAR.UseVisualStyleBackColor = false;
            this.btnLIMPAR.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBACKSPACE
            // 
            this.btnBACKSPACE.BackColor = System.Drawing.Color.White;
            this.btnBACKSPACE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBACKSPACE.Location = new System.Drawing.Point(469, 229);
            this.btnBACKSPACE.Name = "btnBACKSPACE";
            this.btnBACKSPACE.Size = new System.Drawing.Size(163, 35);
            this.btnBACKSPACE.TabIndex = 52;
            this.btnBACKSPACE.Text = "BACKSPACE";
            this.btnBACKSPACE.UseVisualStyleBackColor = false;
            this.btnBACKSPACE.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnENTER
            // 
            this.btnENTER.BackColor = System.Drawing.Color.White;
            this.btnENTER.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnENTER.Location = new System.Drawing.Point(469, 331);
            this.btnENTER.Name = "btnENTER";
            this.btnENTER.Size = new System.Drawing.Size(93, 35);
            this.btnENTER.TabIndex = 53;
            this.btnENTER.Text = "ENTER";
            this.btnENTER.UseVisualStyleBackColor = false;
            this.btnENTER.Click += new System.EventHandler(this.button3_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(848, 35);
            this.statusStrip1.TabIndex = 55;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(206, 30);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.White;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(677, 229);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(37, 35);
            this.btn7.TabIndex = 56;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.White;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(732, 229);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(37, 35);
            this.btn8.TabIndex = 57;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.White;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(786, 229);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(37, 35);
            this.btn9.TabIndex = 58;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.White;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(677, 281);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(37, 35);
            this.btn4.TabIndex = 59;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.button8_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.White;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(732, 281);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(37, 35);
            this.btn5.TabIndex = 60;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.button9_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.White;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(786, 281);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(37, 35);
            this.btn6.TabIndex = 61;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.button10_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.White;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(677, 331);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(37, 35);
            this.btn1.TabIndex = 62;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.button11_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.White;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(732, 331);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(37, 35);
            this.btn2.TabIndex = 63;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.button12_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.White;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(786, 331);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(37, 35);
            this.btn3.TabIndex = 64;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.button13_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.White;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(732, 383);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(37, 35);
            this.btn0.TabIndex = 65;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // lblPrevisao
            // 
            this.lblPrevisao.AutoSize = true;
            this.lblPrevisao.Location = new System.Drawing.Point(41, 205);
            this.lblPrevisao.Name = "lblPrevisao";
            this.lblPrevisao.Size = new System.Drawing.Size(35, 13);
            this.lblPrevisao.TabIndex = 66;
            this.lblPrevisao.Text = "label3";
            // 
            // FrmTeclado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(848, 547);
            this.Controls.Add(this.lblPrevisao);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnENTER);
            this.Controls.Add(this.btnBACKSPACE);
            this.Controls.Add(this.btnLIMPAR);
            this.Controls.Add(this.btnSPACE);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnV);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnN);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.btnVirgula);
            this.Controls.Add(this.btnPonto);
            this.Controls.Add(this.btnZ);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnF);
            this.Controls.Add(this.btnG);
            this.Controls.Add(this.btnH);
            this.Controls.Add(this.btnJ);
            this.Controls.Add(this.btnK);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.btnÇ);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.btnW);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnT);
            this.Controls.Add(this.btnY);
            this.Controls.Add(this.btnU);
            this.Controls.Add(this.btnI);
            this.Controls.Add(this.btnO);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.btnQ);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CaixaTexto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTeclado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teclado Assistivo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tkbVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbVelocidade)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.RichTextBox CaixaTexto;
        private System.Windows.Forms.TrackBar tkbVolume;
        private System.Windows.Forms.TrackBar tkbVelocidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQ;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnO;
        private System.Windows.Forms.Button btnI;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.Button btnY;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnW;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button btnG;
        private System.Windows.Forms.Button btnH;
        private System.Windows.Forms.Button btnJ;
        private System.Windows.Forms.Button btnK;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnÇ;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnV;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.Button btnPonto;
        private System.Windows.Forms.Button btnZ;
        private System.Windows.Forms.Button btnSPACE;
        private System.Windows.Forms.Button btnLIMPAR;
        private System.Windows.Forms.Button btnBACKSPACE;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnENTER;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Label lblPrevisao;
    }
}

