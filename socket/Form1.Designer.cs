namespace socket
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.serverbtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clientbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.mclosebtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Socket Program";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("양재깨비체B", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(23, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "채팅창 열기";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.serverbtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(35, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 150);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "서버";
            // 
            // serverbtn
            // 
            this.serverbtn.Location = new System.Drawing.Point(19, 87);
            this.serverbtn.Name = "serverbtn";
            this.serverbtn.Size = new System.Drawing.Size(189, 31);
            this.serverbtn.TabIndex = 4;
            this.serverbtn.Text = "Server시작";
            this.serverbtn.UseVisualStyleBackColor = true;
            this.serverbtn.Click += new System.EventHandler(this.Serverbtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clientbtn);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(367, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 150);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "클라이언트";
            // 
            // clientbtn
            // 
            this.clientbtn.Location = new System.Drawing.Point(23, 85);
            this.clientbtn.Name = "clientbtn";
            this.clientbtn.Size = new System.Drawing.Size(189, 31);
            this.clientbtn.TabIndex = 4;
            this.clientbtn.Text = "Client시작";
            this.clientbtn.UseVisualStyleBackColor = true;
            this.clientbtn.Click += new System.EventHandler(this.Clientbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("양재깨비체B", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(27, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 35);
            this.label4.TabIndex = 1;
            this.label4.Text = "채팅창 참여";
            // 
            // mclosebtn
            // 
            this.mclosebtn.Location = new System.Drawing.Point(35, 260);
            this.mclosebtn.Name = "mclosebtn";
            this.mclosebtn.Size = new System.Drawing.Size(566, 30);
            this.mclosebtn.TabIndex = 6;
            this.mclosebtn.Text = "종료";
            this.mclosebtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 309);
            this.Controls.Add(this.mclosebtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "채팅프로그램_3515JunSeYeon";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button serverbtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button clientbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button mclosebtn;
    }
}

