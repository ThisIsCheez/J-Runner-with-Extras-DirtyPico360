﻿namespace JRunner.Panels
{
    partial class NandInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageNand = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxSmcVer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCbType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxConsole = new System.Windows.Forms.TextBox();
            this.labelcon = new System.Windows.Forms.Label();
            this.textBoxpd_cb = new System.Windows.Forms.TextBox();
            this.labelpd_cb = new System.Windows.Forms.Label();
            this.textBoxldv_cb = new System.Windows.Forms.TextBox();
            this.labelldv_cb = new System.Windows.Forms.Label();
            this.textBoxpd_1 = new System.Windows.Forms.TextBox();
            this.labelpd_1 = new System.Windows.Forms.Label();
            this.textBoxpd_0 = new System.Windows.Forms.TextBox();
            this.labelpd_0 = new System.Windows.Forms.Label();
            this.textBoxldv_1 = new System.Windows.Forms.TextBox();
            this.labelldv_1 = new System.Windows.Forms.Label();
            this.textBoxldv_0 = new System.Windows.Forms.TextBox();
            this.labelldv_0 = new System.Windows.Forms.Label();
            this.label6bl_p1 = new System.Windows.Forms.Label();
            this.textBox6BL_p1 = new System.Windows.Forms.TextBox();
            this.textBox7BL_p1 = new System.Windows.Forms.TextBox();
            this.label7bl_p1 = new System.Windows.Forms.Label();
            this.label2bla = new System.Windows.Forms.Label();
            this.textBox4BL = new System.Windows.Forms.TextBox();
            this.label5bl = new System.Windows.Forms.Label();
            this.label6bl_p0 = new System.Windows.Forms.Label();
            this.label4bl = new System.Windows.Forms.Label();
            this.label2blb = new System.Windows.Forms.Label();
            this.textBox2BLb = new System.Windows.Forms.TextBox();
            this.textBox5BL = new System.Windows.Forms.TextBox();
            this.textBox2BLa = new System.Windows.Forms.TextBox();
            this.textBox6BL_p0 = new System.Windows.Forms.TextBox();
            this.textBox7BL_p0 = new System.Windows.Forms.TextBox();
            this.label7bl_p0 = new System.Windows.Forms.Label();
            this.label2bl = new System.Windows.Forms.Label();
            this.tabPageKV = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblhashed = new System.Windows.Forms.Label();
            this.btnConsoleId = new System.Windows.Forms.Button();
            this.txtconsole = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textMfrDate = new System.Windows.Forms.TextBox();
            this.lblfcrt = new System.Windows.Forms.Label();
            this.txtkvtype = new System.Windows.Forms.TextBox();
            this.labelkv = new System.Windows.Forms.Label();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.labelregion = new System.Windows.Forms.Label();
            this.textBoxConsoleId = new System.Windows.Forms.TextBox();
            this.labelconsole = new System.Windows.Forms.Label();
            this.txtDvdKey = new System.Windows.Forms.TextBox();
            this.txtOsig = new System.Windows.Forms.TextBox();
            this.labelserial = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.labelosig = new System.Windows.Forms.Label();
            this.labeldvdkey = new System.Windows.Forms.Label();
            this.tabPageBadBlocks = new System.Windows.Forms.TabPage();
            this.txtBadBlocks = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPageNand.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageKV.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPageBadBlocks.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Controls.Add(this.tabPageNand);
            this.tabControl1.Controls.Add(this.tabPageKV);
            this.tabControl1.Controls.Add(this.tabPageBadBlocks);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(343, 299);
            this.tabControl1.TabIndex = 24;
            this.tabControl1.DragDrop += new System.Windows.Forms.DragEventHandler(this.NandInfo_DragDrop);
            this.tabControl1.DragEnter += new System.Windows.Forms.DragEventHandler(this.NandInfo_DragEnter);
            // 
            // tabPageNand
            // 
            this.tabPageNand.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageNand.Controls.Add(this.groupBox1);
            this.tabPageNand.Location = new System.Drawing.Point(4, 22);
            this.tabPageNand.Name = "tabPageNand";
            this.tabPageNand.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNand.Size = new System.Drawing.Size(335, 273);
            this.tabPageNand.TabIndex = 0;
            this.tabPageNand.Text = "Bootloaders and SMC";
            // 
            // groupBox1
            // 
            this.groupBox1.AllowDrop = true;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.groupBox1.Controls.Add(this.textBoxSmcVer);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxCbType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxConsole);
            this.groupBox1.Controls.Add(this.labelcon);
            this.groupBox1.Controls.Add(this.textBoxpd_cb);
            this.groupBox1.Controls.Add(this.labelpd_cb);
            this.groupBox1.Controls.Add(this.textBoxldv_cb);
            this.groupBox1.Controls.Add(this.labelldv_cb);
            this.groupBox1.Controls.Add(this.textBoxpd_1);
            this.groupBox1.Controls.Add(this.labelpd_1);
            this.groupBox1.Controls.Add(this.textBoxpd_0);
            this.groupBox1.Controls.Add(this.labelpd_0);
            this.groupBox1.Controls.Add(this.textBoxldv_1);
            this.groupBox1.Controls.Add(this.labelldv_1);
            this.groupBox1.Controls.Add(this.textBoxldv_0);
            this.groupBox1.Controls.Add(this.labelldv_0);
            this.groupBox1.Controls.Add(this.label6bl_p1);
            this.groupBox1.Controls.Add(this.textBox6BL_p1);
            this.groupBox1.Controls.Add(this.textBox7BL_p1);
            this.groupBox1.Controls.Add(this.label7bl_p1);
            this.groupBox1.Controls.Add(this.label2bla);
            this.groupBox1.Controls.Add(this.textBox4BL);
            this.groupBox1.Controls.Add(this.label5bl);
            this.groupBox1.Controls.Add(this.label6bl_p0);
            this.groupBox1.Controls.Add(this.label4bl);
            this.groupBox1.Controls.Add(this.label2blb);
            this.groupBox1.Controls.Add(this.textBox2BLb);
            this.groupBox1.Controls.Add(this.textBox5BL);
            this.groupBox1.Controls.Add(this.textBox2BLa);
            this.groupBox1.Controls.Add(this.textBox6BL_p0);
            this.groupBox1.Controls.Add(this.textBox7BL_p0);
            this.groupBox1.Controls.Add(this.label7bl_p0);
            this.groupBox1.Controls.Add(this.label2bl);
            this.groupBox1.Location = new System.Drawing.Point(4, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 269);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.NandInfo_DragDrop);
            this.groupBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.NandInfo_DragEnter);
            // 
            // textBoxSmcVer
            // 
            this.textBoxSmcVer.Location = new System.Drawing.Point(254, 15);
            this.textBoxSmcVer.Name = "textBoxSmcVer";
            this.textBoxSmcVer.ReadOnly = true;
            this.textBoxSmcVer.Size = new System.Drawing.Size(62, 20);
            this.textBoxSmcVer.TabIndex = 71;
            this.textBoxSmcVer.TabStop = false;
            this.textBoxSmcVer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSmcVer.DoubleClick += new System.EventHandler(this.textBoxSmcVer_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "CB Type";
            // 
            // textBoxCbType
            // 
            this.textBoxCbType.Location = new System.Drawing.Point(254, 79);
            this.textBoxCbType.Name = "textBoxCbType";
            this.textBoxCbType.ReadOnly = true;
            this.textBoxCbType.Size = new System.Drawing.Size(62, 20);
            this.textBoxCbType.TabIndex = 69;
            this.textBoxCbType.TabStop = false;
            this.textBoxCbType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCbType.DoubleClick += new System.EventHandler(this.textBoxCbType_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "SMC Version";
            // 
            // textBoxConsole
            // 
            this.textBoxConsole.Location = new System.Drawing.Point(74, 15);
            this.textBoxConsole.Name = "textBoxConsole";
            this.textBoxConsole.ReadOnly = true;
            this.textBoxConsole.Size = new System.Drawing.Size(96, 20);
            this.textBoxConsole.TabIndex = 67;
            this.textBoxConsole.TabStop = false;
            this.textBoxConsole.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxConsole.DoubleClick += new System.EventHandler(this.textBoxConsole_DoubleClick);
            // 
            // labelcon
            // 
            this.labelcon.AutoSize = true;
            this.labelcon.Location = new System.Drawing.Point(27, 18);
            this.labelcon.Name = "labelcon";
            this.labelcon.Size = new System.Drawing.Size(45, 13);
            this.labelcon.TabIndex = 66;
            this.labelcon.Text = "Console";
            // 
            // textBoxpd_cb
            // 
            this.textBoxpd_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxpd_cb.Location = new System.Drawing.Point(254, 47);
            this.textBoxpd_cb.Name = "textBoxpd_cb";
            this.textBoxpd_cb.ReadOnly = true;
            this.textBoxpd_cb.Size = new System.Drawing.Size(62, 20);
            this.textBoxpd_cb.TabIndex = 65;
            this.textBoxpd_cb.TabStop = false;
            this.textBoxpd_cb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxpd_cb.DoubleClick += new System.EventHandler(this.textBoxpd_cb_DoubleClick);
            // 
            // labelpd_cb
            // 
            this.labelpd_cb.AutoSize = true;
            this.labelpd_cb.Location = new System.Drawing.Point(230, 50);
            this.labelpd_cb.Name = "labelpd_cb";
            this.labelpd_cb.Size = new System.Drawing.Size(22, 13);
            this.labelpd_cb.TabIndex = 64;
            this.labelpd_cb.Text = "PD";
            // 
            // textBoxldv_cb
            // 
            this.textBoxldv_cb.Location = new System.Drawing.Point(204, 47);
            this.textBoxldv_cb.Name = "textBoxldv_cb";
            this.textBoxldv_cb.ReadOnly = true;
            this.textBoxldv_cb.Size = new System.Drawing.Size(23, 20);
            this.textBoxldv_cb.TabIndex = 63;
            this.textBoxldv_cb.TabStop = false;
            this.textBoxldv_cb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxldv_cb.DoubleClick += new System.EventHandler(this.textBoxldv_cb_DoubleClick);
            // 
            // labelldv_cb
            // 
            this.labelldv_cb.AutoSize = true;
            this.labelldv_cb.Location = new System.Drawing.Point(174, 50);
            this.labelldv_cb.Name = "labelldv_cb";
            this.labelldv_cb.Size = new System.Drawing.Size(28, 13);
            this.labelldv_cb.TabIndex = 62;
            this.labelldv_cb.Text = "LDV";
            // 
            // textBoxpd_1
            // 
            this.textBoxpd_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxpd_1.Location = new System.Drawing.Point(254, 239);
            this.textBoxpd_1.Name = "textBoxpd_1";
            this.textBoxpd_1.ReadOnly = true;
            this.textBoxpd_1.Size = new System.Drawing.Size(62, 20);
            this.textBoxpd_1.TabIndex = 61;
            this.textBoxpd_1.TabStop = false;
            this.textBoxpd_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxpd_1.DoubleClick += new System.EventHandler(this.textBoxpd_1_DoubleClick);
            // 
            // labelpd_1
            // 
            this.labelpd_1.AutoSize = true;
            this.labelpd_1.Location = new System.Drawing.Point(230, 242);
            this.labelpd_1.Name = "labelpd_1";
            this.labelpd_1.Size = new System.Drawing.Size(22, 13);
            this.labelpd_1.TabIndex = 60;
            this.labelpd_1.Text = "PD";
            // 
            // textBoxpd_0
            // 
            this.textBoxpd_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxpd_0.Location = new System.Drawing.Point(91, 239);
            this.textBoxpd_0.Name = "textBoxpd_0";
            this.textBoxpd_0.ReadOnly = true;
            this.textBoxpd_0.Size = new System.Drawing.Size(62, 20);
            this.textBoxpd_0.TabIndex = 59;
            this.textBoxpd_0.TabStop = false;
            this.textBoxpd_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxpd_0.DoubleClick += new System.EventHandler(this.textBoxpd_0_DoubleClick);
            // 
            // labelpd_0
            // 
            this.labelpd_0.AutoSize = true;
            this.labelpd_0.Location = new System.Drawing.Point(67, 242);
            this.labelpd_0.Name = "labelpd_0";
            this.labelpd_0.Size = new System.Drawing.Size(22, 13);
            this.labelpd_0.TabIndex = 58;
            this.labelpd_0.Text = "PD";
            // 
            // textBoxldv_1
            // 
            this.textBoxldv_1.Location = new System.Drawing.Point(204, 239);
            this.textBoxldv_1.MaxLength = 2;
            this.textBoxldv_1.Name = "textBoxldv_1";
            this.textBoxldv_1.ReadOnly = true;
            this.textBoxldv_1.Size = new System.Drawing.Size(23, 20);
            this.textBoxldv_1.TabIndex = 57;
            this.textBoxldv_1.TabStop = false;
            this.textBoxldv_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxldv_1.DoubleClick += new System.EventHandler(this.textBoxldv_1_DoubleClick);
            // 
            // labelldv_1
            // 
            this.labelldv_1.AutoSize = true;
            this.labelldv_1.Location = new System.Drawing.Point(174, 242);
            this.labelldv_1.Name = "labelldv_1";
            this.labelldv_1.Size = new System.Drawing.Size(28, 13);
            this.labelldv_1.TabIndex = 55;
            this.labelldv_1.Text = "LDV";
            // 
            // textBoxldv_0
            // 
            this.textBoxldv_0.Location = new System.Drawing.Point(41, 239);
            this.textBoxldv_0.MaxLength = 2;
            this.textBoxldv_0.Name = "textBoxldv_0";
            this.textBoxldv_0.ReadOnly = true;
            this.textBoxldv_0.Size = new System.Drawing.Size(23, 20);
            this.textBoxldv_0.TabIndex = 54;
            this.textBoxldv_0.TabStop = false;
            this.textBoxldv_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxldv_0.DoubleClick += new System.EventHandler(this.textBoxldv_0_DoubleClick);
            // 
            // labelldv_0
            // 
            this.labelldv_0.AutoSize = true;
            this.labelldv_0.Location = new System.Drawing.Point(11, 242);
            this.labelldv_0.Name = "labelldv_0";
            this.labelldv_0.Size = new System.Drawing.Size(28, 13);
            this.labelldv_0.TabIndex = 53;
            this.labelldv_0.Text = "LDV";
            // 
            // label6bl_p1
            // 
            this.label6bl_p1.AutoSize = true;
            this.label6bl_p1.Location = new System.Drawing.Point(171, 178);
            this.label6bl_p1.Name = "label6bl_p1";
            this.label6bl_p1.Size = new System.Drawing.Size(81, 13);
            this.label6bl_p1.TabIndex = 49;
            this.label6bl_p1.Text = "CF Patch Slot 1";
            // 
            // textBox6BL_p1
            // 
            this.textBox6BL_p1.Location = new System.Drawing.Point(254, 175);
            this.textBox6BL_p1.Name = "textBox6BL_p1";
            this.textBox6BL_p1.ReadOnly = true;
            this.textBox6BL_p1.Size = new System.Drawing.Size(62, 20);
            this.textBox6BL_p1.TabIndex = 51;
            this.textBox6BL_p1.TabStop = false;
            this.textBox6BL_p1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox6BL_p1.DoubleClick += new System.EventHandler(this.textBox6BL_p1_DoubleClick);
            // 
            // textBox7BL_p1
            // 
            this.textBox7BL_p1.Location = new System.Drawing.Point(254, 207);
            this.textBox7BL_p1.Name = "textBox7BL_p1";
            this.textBox7BL_p1.ReadOnly = true;
            this.textBox7BL_p1.Size = new System.Drawing.Size(62, 20);
            this.textBox7BL_p1.TabIndex = 52;
            this.textBox7BL_p1.TabStop = false;
            this.textBox7BL_p1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox7BL_p1.DoubleClick += new System.EventHandler(this.textBox7BL_p1_DoubleClick);
            // 
            // label7bl_p1
            // 
            this.label7bl_p1.AutoSize = true;
            this.label7bl_p1.Location = new System.Drawing.Point(169, 210);
            this.label7bl_p1.Name = "label7bl_p1";
            this.label7bl_p1.Size = new System.Drawing.Size(83, 13);
            this.label7bl_p1.TabIndex = 50;
            this.label7bl_p1.Text = "CG Patch Slot 1";
            // 
            // label2bla
            // 
            this.label2bla.AutoSize = true;
            this.label2bla.Location = new System.Drawing.Point(55, 50);
            this.label2bla.Name = "label2bla";
            this.label2bla.Size = new System.Drawing.Size(34, 13);
            this.label2bla.TabIndex = 42;
            this.label2bla.Text = "CB_A";
            // 
            // textBox4BL
            // 
            this.textBox4BL.Location = new System.Drawing.Point(91, 111);
            this.textBox4BL.Name = "textBox4BL";
            this.textBox4BL.ReadOnly = true;
            this.textBox4BL.Size = new System.Drawing.Size(62, 20);
            this.textBox4BL.TabIndex = 45;
            this.textBox4BL.TabStop = false;
            this.textBox4BL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4BL.DoubleClick += new System.EventHandler(this.textBox4BL_DoubleClick);
            // 
            // label5bl
            // 
            this.label5bl.AutoSize = true;
            this.label5bl.Location = new System.Drawing.Point(68, 146);
            this.label5bl.Name = "label5bl";
            this.label5bl.Size = new System.Drawing.Size(21, 13);
            this.label5bl.TabIndex = 38;
            this.label5bl.Text = "CE";
            // 
            // label6bl_p0
            // 
            this.label6bl_p0.AutoSize = true;
            this.label6bl_p0.Location = new System.Drawing.Point(8, 179);
            this.label6bl_p0.Name = "label6bl_p0";
            this.label6bl_p0.Size = new System.Drawing.Size(81, 13);
            this.label6bl_p0.TabIndex = 39;
            this.label6bl_p0.Text = "CF Patch Slot 0";
            // 
            // label4bl
            // 
            this.label4bl.AutoSize = true;
            this.label4bl.Location = new System.Drawing.Point(67, 114);
            this.label4bl.Name = "label4bl";
            this.label4bl.Size = new System.Drawing.Size(22, 13);
            this.label4bl.TabIndex = 37;
            this.label4bl.Text = "CD";
            // 
            // label2blb
            // 
            this.label2blb.AutoSize = true;
            this.label2blb.Location = new System.Drawing.Point(55, 82);
            this.label2blb.Name = "label2blb";
            this.label2blb.Size = new System.Drawing.Size(34, 13);
            this.label2blb.TabIndex = 41;
            this.label2blb.Text = "CB_B";
            // 
            // textBox2BLb
            // 
            this.textBox2BLb.Location = new System.Drawing.Point(91, 79);
            this.textBox2BLb.Name = "textBox2BLb";
            this.textBox2BLb.ReadOnly = true;
            this.textBox2BLb.Size = new System.Drawing.Size(62, 20);
            this.textBox2BLb.TabIndex = 44;
            this.textBox2BLb.TabStop = false;
            this.textBox2BLb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2BLb.DoubleClick += new System.EventHandler(this.textBox2BLb_DoubleClick);
            // 
            // textBox5BL
            // 
            this.textBox5BL.Location = new System.Drawing.Point(91, 143);
            this.textBox5BL.Name = "textBox5BL";
            this.textBox5BL.ReadOnly = true;
            this.textBox5BL.Size = new System.Drawing.Size(62, 20);
            this.textBox5BL.TabIndex = 46;
            this.textBox5BL.TabStop = false;
            this.textBox5BL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox5BL.DoubleClick += new System.EventHandler(this.textBox5BL_DoubleClick);
            // 
            // textBox2BLa
            // 
            this.textBox2BLa.Location = new System.Drawing.Point(91, 47);
            this.textBox2BLa.Name = "textBox2BLa";
            this.textBox2BLa.ReadOnly = true;
            this.textBox2BLa.Size = new System.Drawing.Size(62, 20);
            this.textBox2BLa.TabIndex = 43;
            this.textBox2BLa.TabStop = false;
            this.textBox2BLa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2BLa.DoubleClick += new System.EventHandler(this.textBox2BLa_DoubleClick);
            // 
            // textBox6BL_p0
            // 
            this.textBox6BL_p0.Location = new System.Drawing.Point(91, 175);
            this.textBox6BL_p0.Name = "textBox6BL_p0";
            this.textBox6BL_p0.ReadOnly = true;
            this.textBox6BL_p0.Size = new System.Drawing.Size(62, 20);
            this.textBox6BL_p0.TabIndex = 47;
            this.textBox6BL_p0.TabStop = false;
            this.textBox6BL_p0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox6BL_p0.DoubleClick += new System.EventHandler(this.textBox6BL_p0_DoubleClick);
            // 
            // textBox7BL_p0
            // 
            this.textBox7BL_p0.Location = new System.Drawing.Point(91, 207);
            this.textBox7BL_p0.Name = "textBox7BL_p0";
            this.textBox7BL_p0.ReadOnly = true;
            this.textBox7BL_p0.Size = new System.Drawing.Size(62, 20);
            this.textBox7BL_p0.TabIndex = 48;
            this.textBox7BL_p0.TabStop = false;
            this.textBox7BL_p0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox7BL_p0.DoubleClick += new System.EventHandler(this.textBox7BL_p0_DoubleClick);
            // 
            // label7bl_p0
            // 
            this.label7bl_p0.AutoSize = true;
            this.label7bl_p0.Location = new System.Drawing.Point(6, 210);
            this.label7bl_p0.Name = "label7bl_p0";
            this.label7bl_p0.Size = new System.Drawing.Size(83, 13);
            this.label7bl_p0.TabIndex = 40;
            this.label7bl_p0.Text = "CG Patch Slot 0";
            // 
            // label2bl
            // 
            this.label2bl.AutoSize = true;
            this.label2bl.Location = new System.Drawing.Point(68, 50);
            this.label2bl.Name = "label2bl";
            this.label2bl.Size = new System.Drawing.Size(21, 13);
            this.label2bl.TabIndex = 29;
            this.label2bl.Text = "CB";
            // 
            // tabPageKV
            // 
            this.tabPageKV.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageKV.Controls.Add(this.groupBox2);
            this.tabPageKV.Location = new System.Drawing.Point(4, 22);
            this.tabPageKV.Name = "tabPageKV";
            this.tabPageKV.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKV.Size = new System.Drawing.Size(335, 273);
            this.tabPageKV.TabIndex = 1;
            this.tabPageKV.Text = "Keyvault";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblhashed);
            this.groupBox2.Controls.Add(this.btnConsoleId);
            this.groupBox2.Controls.Add(this.txtconsole);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textMfrDate);
            this.groupBox2.Controls.Add(this.lblfcrt);
            this.groupBox2.Controls.Add(this.txtkvtype);
            this.groupBox2.Controls.Add(this.labelkv);
            this.groupBox2.Controls.Add(this.txtRegion);
            this.groupBox2.Controls.Add(this.labelregion);
            this.groupBox2.Controls.Add(this.textBoxConsoleId);
            this.groupBox2.Controls.Add(this.labelconsole);
            this.groupBox2.Controls.Add(this.txtDvdKey);
            this.groupBox2.Controls.Add(this.txtOsig);
            this.groupBox2.Controls.Add(this.labelserial);
            this.groupBox2.Controls.Add(this.txtSerial);
            this.groupBox2.Controls.Add(this.labelosig);
            this.groupBox2.Controls.Add(this.labeldvdkey);
            this.groupBox2.Location = new System.Drawing.Point(4, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 269);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 73;
            this.label5.Text = "Month/Day/Year";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblhashed
            // 
            this.lblhashed.AutoSize = true;
            this.lblhashed.Location = new System.Drawing.Point(118, 50);
            this.lblhashed.Name = "lblhashed";
            this.lblhashed.Size = new System.Drawing.Size(88, 13);
            this.lblhashed.TabIndex = 72;
            this.lblhashed.Text = "Hashed Keyvault";
            // 
            // btnConsoleId
            // 
            this.btnConsoleId.Location = new System.Drawing.Point(215, 142);
            this.btnConsoleId.Name = "btnConsoleId";
            this.btnConsoleId.Size = new System.Drawing.Size(95, 22);
            this.btnConsoleId.TabIndex = 26;
            this.btnConsoleId.Text = "View: Native";
            this.btnConsoleId.UseVisualStyleBackColor = true;
            this.btnConsoleId.Click += new System.EventHandler(this.btnConsoleId_Click);
            // 
            // txtconsole
            // 
            this.txtconsole.Location = new System.Drawing.Point(74, 15);
            this.txtconsole.Name = "txtconsole";
            this.txtconsole.ReadOnly = true;
            this.txtconsole.Size = new System.Drawing.Size(96, 20);
            this.txtconsole.TabIndex = 71;
            this.txtconsole.TabStop = false;
            this.txtconsole.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtconsole.DoubleClick += new System.EventHandler(this.textBoxConsole_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Console";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "MFR Date";
            // 
            // textMfrDate
            // 
            this.textMfrDate.Location = new System.Drawing.Point(74, 79);
            this.textMfrDate.Name = "textMfrDate";
            this.textMfrDate.ReadOnly = true;
            this.textMfrDate.Size = new System.Drawing.Size(135, 20);
            this.textMfrDate.TabIndex = 68;
            this.textMfrDate.TabStop = false;
            this.textMfrDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textMfrDate.DoubleClick += new System.EventHandler(this.txtMfrDate_DoubleClick);
            // 
            // lblfcrt
            // 
            this.lblfcrt.AutoSize = true;
            this.lblfcrt.Location = new System.Drawing.Point(223, 50);
            this.lblfcrt.Name = "lblfcrt";
            this.lblfcrt.Size = new System.Drawing.Size(81, 13);
            this.lblfcrt.TabIndex = 66;
            this.lblfcrt.Text = "FCRT Required";
            this.lblfcrt.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtkvtype
            // 
            this.txtkvtype.Location = new System.Drawing.Point(74, 47);
            this.txtkvtype.Name = "txtkvtype";
            this.txtkvtype.ReadOnly = true;
            this.txtkvtype.Size = new System.Drawing.Size(23, 20);
            this.txtkvtype.TabIndex = 42;
            this.txtkvtype.TabStop = false;
            this.txtkvtype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtkvtype.DoubleClick += new System.EventHandler(this.txtkvtype_DoubleClick);
            // 
            // labelkv
            // 
            this.labelkv.AutoSize = true;
            this.labelkv.Location = new System.Drawing.Point(24, 50);
            this.labelkv.Name = "labelkv";
            this.labelkv.Size = new System.Drawing.Size(48, 13);
            this.labelkv.TabIndex = 41;
            this.labelkv.Text = "KV Type";
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(74, 175);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.ReadOnly = true;
            this.txtRegion.Size = new System.Drawing.Size(135, 20);
            this.txtRegion.TabIndex = 40;
            this.txtRegion.TabStop = false;
            this.txtRegion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRegion.DoubleClick += new System.EventHandler(this.txtRegion_DoubleClick);
            // 
            // labelregion
            // 
            this.labelregion.AutoSize = true;
            this.labelregion.Location = new System.Drawing.Point(31, 178);
            this.labelregion.Name = "labelregion";
            this.labelregion.Size = new System.Drawing.Size(41, 13);
            this.labelregion.TabIndex = 39;
            this.labelregion.Text = "Region";
            // 
            // textBoxConsoleId
            // 
            this.textBoxConsoleId.Location = new System.Drawing.Point(74, 143);
            this.textBoxConsoleId.Name = "textBoxConsoleId";
            this.textBoxConsoleId.ReadOnly = true;
            this.textBoxConsoleId.Size = new System.Drawing.Size(135, 20);
            this.textBoxConsoleId.TabIndex = 38;
            this.textBoxConsoleId.TabStop = false;
            this.textBoxConsoleId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxConsoleId.DoubleClick += new System.EventHandler(this.textBoxConsoleId_DoubleClick);
            // 
            // labelconsole
            // 
            this.labelconsole.AutoSize = true;
            this.labelconsole.Location = new System.Drawing.Point(13, 146);
            this.labelconsole.Name = "labelconsole";
            this.labelconsole.Size = new System.Drawing.Size(59, 13);
            this.labelconsole.TabIndex = 37;
            this.labelconsole.Text = "Console ID";
            // 
            // txtDvdKey
            // 
            this.txtDvdKey.Location = new System.Drawing.Point(74, 239);
            this.txtDvdKey.Name = "txtDvdKey";
            this.txtDvdKey.ReadOnly = true;
            this.txtDvdKey.Size = new System.Drawing.Size(235, 20);
            this.txtDvdKey.TabIndex = 35;
            this.txtDvdKey.TabStop = false;
            this.txtDvdKey.DoubleClick += new System.EventHandler(this.txtDvdKey_DoubleClick);
            // 
            // txtOsig
            // 
            this.txtOsig.Location = new System.Drawing.Point(74, 207);
            this.txtOsig.Name = "txtOsig";
            this.txtOsig.ReadOnly = true;
            this.txtOsig.Size = new System.Drawing.Size(235, 20);
            this.txtOsig.TabIndex = 34;
            this.txtOsig.TabStop = false;
            this.txtOsig.DoubleClick += new System.EventHandler(this.txtOsig_DoubleClick);
            // 
            // labelserial
            // 
            this.labelserial.AutoSize = true;
            this.labelserial.Location = new System.Drawing.Point(39, 114);
            this.labelserial.Name = "labelserial";
            this.labelserial.Size = new System.Drawing.Size(33, 13);
            this.labelserial.TabIndex = 30;
            this.labelserial.Text = "Serial";
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(74, 111);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.ReadOnly = true;
            this.txtSerial.Size = new System.Drawing.Size(135, 20);
            this.txtSerial.TabIndex = 33;
            this.txtSerial.TabStop = false;
            this.txtSerial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSerial.DoubleClick += new System.EventHandler(this.txtSerial_DoubleClick);
            // 
            // labelosig
            // 
            this.labelosig.AutoSize = true;
            this.labelosig.Location = new System.Drawing.Point(39, 210);
            this.labelosig.Name = "labelosig";
            this.labelosig.Size = new System.Drawing.Size(33, 13);
            this.labelosig.TabIndex = 31;
            this.labelosig.Text = "OSIG";
            // 
            // labeldvdkey
            // 
            this.labeldvdkey.AutoSize = true;
            this.labeldvdkey.Location = new System.Drawing.Point(21, 242);
            this.labeldvdkey.Name = "labeldvdkey";
            this.labeldvdkey.Size = new System.Drawing.Size(51, 13);
            this.labeldvdkey.TabIndex = 32;
            this.labeldvdkey.Text = "DVD Key";
            // 
            // tabPageBadBlocks
            // 
            this.tabPageBadBlocks.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageBadBlocks.Controls.Add(this.txtBadBlocks);
            this.tabPageBadBlocks.Location = new System.Drawing.Point(4, 22);
            this.tabPageBadBlocks.Name = "tabPageBadBlocks";
            this.tabPageBadBlocks.Size = new System.Drawing.Size(335, 273);
            this.tabPageBadBlocks.TabIndex = 2;
            this.tabPageBadBlocks.Text = "Bad Blocks";
            // 
            // txtBadBlocks
            // 
            this.txtBadBlocks.BackColor = System.Drawing.SystemColors.Control;
            this.txtBadBlocks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBadBlocks.Location = new System.Drawing.Point(0, 0);
            this.txtBadBlocks.Multiline = true;
            this.txtBadBlocks.Name = "txtBadBlocks";
            this.txtBadBlocks.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBadBlocks.Size = new System.Drawing.Size(335, 273);
            this.txtBadBlocks.TabIndex = 0;
            this.txtBadBlocks.TabStop = false;
            this.txtBadBlocks.Text = "No Nand Loaded";
            this.txtBadBlocks.DoubleClick += new System.EventHandler(this.txtBadBlocks_DoubleClick);
            // 
            // NandInfo
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "NandInfo";
            this.Size = new System.Drawing.Size(344, 299);
            this.Load += new System.EventHandler(this.NandInfo_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.NandInfo_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.NandInfo_DragEnter);
            this.tabControl1.ResumeLayout(false);
            this.tabPageNand.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageKV.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPageBadBlocks.ResumeLayout(false);
            this.tabPageBadBlocks.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageNand;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxpd_cb;
        private System.Windows.Forms.Label labelpd_cb;
        private System.Windows.Forms.TextBox textBoxldv_cb;
        private System.Windows.Forms.Label labelldv_cb;
        private System.Windows.Forms.TextBox textBoxpd_1;
        private System.Windows.Forms.Label labelpd_1;
        private System.Windows.Forms.TextBox textBoxpd_0;
        private System.Windows.Forms.Label labelpd_0;
        private System.Windows.Forms.TextBox textBoxldv_1;
        private System.Windows.Forms.Label labelldv_1;
        private System.Windows.Forms.TextBox textBoxldv_0;
        private System.Windows.Forms.Label labelldv_0;
        private System.Windows.Forms.Label label6bl_p1;
        private System.Windows.Forms.TextBox textBox6BL_p1;
        private System.Windows.Forms.TextBox textBox7BL_p1;
        private System.Windows.Forms.Label label7bl_p1;
        private System.Windows.Forms.TextBox textBox4BL;
        private System.Windows.Forms.Label label5bl;
        private System.Windows.Forms.Label label6bl_p0;
        private System.Windows.Forms.Label label4bl;
        private System.Windows.Forms.Label label2blb;
        private System.Windows.Forms.TextBox textBox2BLb;
        private System.Windows.Forms.TextBox textBox5BL;
        private System.Windows.Forms.TextBox textBox2BLa;
        private System.Windows.Forms.TextBox textBox6BL_p0;
        private System.Windows.Forms.TextBox textBox7BL_p0;
        private System.Windows.Forms.Label label7bl_p0;
        private System.Windows.Forms.Label label2bl;
        private System.Windows.Forms.TabPage tabPageKV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblfcrt;
        private System.Windows.Forms.TextBox txtkvtype;
        private System.Windows.Forms.Label labelkv;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.Label labelregion;
        private System.Windows.Forms.TextBox textBoxConsoleId;
        private System.Windows.Forms.Label labelconsole;
        private System.Windows.Forms.TextBox txtDvdKey;
        private System.Windows.Forms.TextBox txtOsig;
        private System.Windows.Forms.Label labelserial;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label labelosig;
        private System.Windows.Forms.Label labeldvdkey;
        private System.Windows.Forms.TabPage tabPageBadBlocks;
        private System.Windows.Forms.TextBox txtBadBlocks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textMfrDate;
        private System.Windows.Forms.Label label2bla;
        private System.Windows.Forms.Label labelcon;
        private System.Windows.Forms.TextBox textBoxConsole;
        private System.Windows.Forms.TextBox txtconsole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCbType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConsoleId;
        private System.Windows.Forms.Label lblhashed;
        private System.Windows.Forms.TextBox textBoxSmcVer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
