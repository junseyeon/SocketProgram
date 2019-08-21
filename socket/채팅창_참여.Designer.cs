namespace socket
{
    partial class 채팅창_참여
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.myip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.namechange = new System.Windows.Forms.Button();
            this.myname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.clientclosebtn = new System.Windows.Forms.Button();
            this.clientconnectbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.connectport = new System.Windows.Forms.TextBox();
            this.connectip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(22, 282);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(575, 273);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "[--- 채팅에 참여를 시작합니다 ---]\n[--- ☆☆님 환영합니다!  ---]";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.myip);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.namechange);
            this.groupBox2.Controls.Add(this.myname);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(21, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(576, 125);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "내 정보";
            // 
            // myip
            // 
            this.myip.Location = new System.Drawing.Point(119, 32);
            this.myip.Multiline = true;
            this.myip.Name = "myip";
            this.myip.Size = new System.Drawing.Size(416, 26);
            this.myip.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "나의 아이피";
            // 
            // namechange
            // 
            this.namechange.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.namechange.Location = new System.Drawing.Point(438, 78);
            this.namechange.Name = "namechange";
            this.namechange.Size = new System.Drawing.Size(97, 24);
            this.namechange.TabIndex = 3;
            this.namechange.Text = "변경";
            this.namechange.UseVisualStyleBackColor = true;
            // 
            // myname
            // 
            this.myname.Location = new System.Drawing.Point(119, 78);
            this.myname.Name = "myname";
            this.myname.Size = new System.Drawing.Size(258, 26);
            this.myname.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "나의 기본 이름";
            // 
            // clientclosebtn
            // 
            this.clientclosebtn.Location = new System.Drawing.Point(537, 27);
            this.clientclosebtn.Name = "clientclosebtn";
            this.clientclosebtn.Size = new System.Drawing.Size(60, 97);
            this.clientclosebtn.TabIndex = 8;
            this.clientclosebtn.Text = "종료";
            this.clientclosebtn.UseVisualStyleBackColor = true;
            // 
            // clientconnectbtn
            // 
            this.clientconnectbtn.Location = new System.Drawing.Point(470, 27);
            this.clientconnectbtn.Name = "clientconnectbtn";
            this.clientconnectbtn.Size = new System.Drawing.Size(61, 97);
            this.clientconnectbtn.TabIndex = 7;
            this.clientconnectbtn.Text = "참여";
            this.clientconnectbtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.connectport);
            this.groupBox1.Controls.Add(this.connectip);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(21, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 110);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "접속할 채팅방 정보";
            // 
            // connectport
            // 
            this.connectport.Location = new System.Drawing.Point(96, 68);
            this.connectport.Name = "connectport";
            this.connectport.Size = new System.Drawing.Size(258, 26);
            this.connectport.TabIndex = 3;
            // 
            // connectip
            // 
            this.connectip.Location = new System.Drawing.Point(96, 30);
            this.connectip.Multiline = true;
            this.connectip.Name = "connectip";
            this.connectip.Size = new System.Drawing.Size(258, 26);
            this.connectip.TabIndex = 2;
            this.connectip.TextChanged += new System.EventHandler(this.Connectip_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // 채팅창_참여
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 574);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.clientclosebtn);
            this.Controls.Add(this.clientconnectbtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "채팅창_참여";
            this.Text = "채팅창_참여";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button namechange;
        private System.Windows.Forms.TextBox myname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button clientclosebtn;
        private System.Windows.Forms.Button clientconnectbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox connectport;
        private System.Windows.Forms.TextBox connectip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox myip;
        private System.Windows.Forms.Label label3;
    }
}