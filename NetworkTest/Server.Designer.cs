namespace NetworkTest
{
    partial class Server
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
            System.Windows.Forms.Button btn_server_send;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_server_ip = new System.Windows.Forms.TextBox();
            this.txt_server_port = new System.Windows.Forms.TextBox();
            this.btn_server_open = new System.Windows.Forms.Button();
            this.btn_server_exit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_server_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.server_content = new System.Windows.Forms.TextBox();
            this.txt_server_send = new System.Windows.Forms.TextBox();
            btn_server_send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("한컴 바겐세일 M", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "채팅방 정보";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("한컴 바겐세일 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(23, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("한컴 바겐세일 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(23, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Port";
            // 
            // txt_server_ip
            // 
            this.txt_server_ip.Location = new System.Drawing.Point(73, 51);
            this.txt_server_ip.Name = "txt_server_ip";
            this.txt_server_ip.Size = new System.Drawing.Size(169, 21);
            this.txt_server_ip.TabIndex = 3;
            // 
            // txt_server_port
            // 
            this.txt_server_port.Location = new System.Drawing.Point(73, 81);
            this.txt_server_port.Name = "txt_server_port";
            this.txt_server_port.Size = new System.Drawing.Size(169, 21);
            this.txt_server_port.TabIndex = 4;
            // 
            // btn_server_open
            // 
            this.btn_server_open.Font = new System.Drawing.Font("한컴 백제 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_server_open.Location = new System.Drawing.Point(284, 51);
            this.btn_server_open.Name = "btn_server_open";
            this.btn_server_open.Size = new System.Drawing.Size(105, 83);
            this.btn_server_open.TabIndex = 5;
            this.btn_server_open.Text = "채팅방 열기";
            this.btn_server_open.UseVisualStyleBackColor = true;
            // 
            // btn_server_exit
            // 
            this.btn_server_exit.Font = new System.Drawing.Font("한컴 백제 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_server_exit.Location = new System.Drawing.Point(421, 52);
            this.btn_server_exit.Name = "btn_server_exit";
            this.btn_server_exit.Size = new System.Drawing.Size(105, 82);
            this.btn_server_exit.TabIndex = 6;
            this.btn_server_exit.Text = "채팅방 종료";
            this.btn_server_exit.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("한컴 바겐세일 M", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(13, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 24);
            this.label4.TabIndex = 7;
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // txt_server_name
            // 
            this.txt_server_name.Location = new System.Drawing.Point(73, 113);
            this.txt_server_name.Name = "txt_server_name";
            this.txt_server_name.Size = new System.Drawing.Size(169, 21);
            this.txt_server_name.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("한컴 바겐세일 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(23, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Name";
            // 
            // server_content
            // 
            this.server_content.Location = new System.Drawing.Point(26, 150);
            this.server_content.Multiline = true;
            this.server_content.Name = "server_content";
            this.server_content.Size = new System.Drawing.Size(500, 297);
            this.server_content.TabIndex = 10;
            // 
            // txt_server_send
            // 
            this.txt_server_send.Location = new System.Drawing.Point(27, 459);
            this.txt_server_send.Name = "txt_server_send";
            this.txt_server_send.Size = new System.Drawing.Size(411, 21);
            this.txt_server_send.TabIndex = 11;
            // 
            // btn_server_send
            // 
            btn_server_send.Font = new System.Drawing.Font("한컴 바겐세일 M", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            btn_server_send.Location = new System.Drawing.Point(448, 458);
            btn_server_send.Name = "btn_server_send";
            btn_server_send.Size = new System.Drawing.Size(77, 22);
            btn_server_send.TabIndex = 12;
            btn_server_send.Text = "보내기";
            btn_server_send.UseVisualStyleBackColor = true;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 495);
            this.Controls.Add(btn_server_send);
            this.Controls.Add(this.txt_server_send);
            this.Controls.Add(this.server_content);
            this.Controls.Add(this.txt_server_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_server_exit);
            this.Controls.Add(this.btn_server_open);
            this.Controls.Add(this.txt_server_port);
            this.Controls.Add(this.txt_server_ip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Server";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_server_ip;
        private System.Windows.Forms.TextBox txt_server_port;
        private System.Windows.Forms.Button btn_server_open;
        private System.Windows.Forms.Button btn_server_exit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_server_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox server_content;
        private System.Windows.Forms.TextBox txt_server_send;
    }
}