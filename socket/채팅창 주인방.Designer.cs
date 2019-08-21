namespace socket
{
    partial class 채팅창_주인방
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.roomport = new System.Windows.Forms.TextBox();
            this.roomip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serveropenbtn = new System.Windows.Forms.Button();
            this.serverclosebtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.servernamebtn = new System.Windows.Forms.Button();
            this.servername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.roomport);
            this.groupBox1.Controls.Add(this.roomip);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "채팅방 정보";
            // 
            // roomport
            // 
            this.roomport.Location = new System.Drawing.Point(96, 72);
            this.roomport.Name = "roomport";
            this.roomport.Size = new System.Drawing.Size(258, 26);
            this.roomport.TabIndex = 7;
            this.roomport.TextChanged += new System.EventHandler(this.Roomport_TextChanged);
            // 
            // roomip
            // 
            this.roomip.Location = new System.Drawing.Point(96, 25);
            this.roomip.Name = "roomip";
            this.roomip.Size = new System.Drawing.Size(258, 26);
            this.roomip.TabIndex = 6;
            this.roomip.TextChanged += new System.EventHandler(this.Roomip_TextChanged);
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
            // serveropenbtn
            // 
            this.serveropenbtn.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.serveropenbtn.Location = new System.Drawing.Point(435, 25);
            this.serveropenbtn.Name = "serveropenbtn";
            this.serveropenbtn.Size = new System.Drawing.Size(68, 97);
            this.serveropenbtn.TabIndex = 1;
            this.serveropenbtn.Text = "열기";
            this.serveropenbtn.UseVisualStyleBackColor = true;
            this.serveropenbtn.Click += new System.EventHandler(this.Serveropenbtn_Click);
            // 
            // serverclosebtn
            // 
            this.serverclosebtn.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.serverclosebtn.Location = new System.Drawing.Point(519, 25);
            this.serverclosebtn.Name = "serverclosebtn";
            this.serverclosebtn.Size = new System.Drawing.Size(69, 97);
            this.serverclosebtn.TabIndex = 2;
            this.serverclosebtn.Text = "닫기";
            this.serverclosebtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.servernamebtn);
            this.groupBox2.Controls.Add(this.servername);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(12, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(576, 92);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "내 정보";
            // 
            // servernamebtn
            // 
            this.servernamebtn.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.servernamebtn.Location = new System.Drawing.Point(449, 34);
            this.servernamebtn.Name = "servernamebtn";
            this.servernamebtn.Size = new System.Drawing.Size(97, 24);
            this.servernamebtn.TabIndex = 3;
            this.servernamebtn.Text = "변경";
            this.servernamebtn.UseVisualStyleBackColor = true;
            // 
            // servername
            // 
            this.servername.Location = new System.Drawing.Point(150, 34);
            this.servername.Name = "servername";
            this.servername.Size = new System.Drawing.Size(258, 26);
            this.servername.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "기본 이름";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 251);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(575, 302);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "[--- 참여자를 기다리는 중 입니다. ---]\n[--- 채팅을 시작해 보세요 ---]";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // 채팅창_주인방
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 575);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.serverclosebtn);
            this.Controls.Add(this.serveropenbtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "채팅창_주인방";
            this.Text = "채팅창_주인방";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button serveropenbtn;
        private System.Windows.Forms.Button serverclosebtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button servernamebtn;
        private System.Windows.Forms.TextBox servername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox roomport;
        private System.Windows.Forms.TextBox roomip;
    }
}