namespace NetworkTest
{
    partial class Client
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
            System.Windows.Forms.Button btn_client_send;
            this.label1 = new System.Windows.Forms.Label();
            this.txt_client_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_client_exit = new System.Windows.Forms.Button();
            this.btn_client_open = new System.Windows.Forms.Button();
            this.txt_client_port = new System.Windows.Forms.TextBox();
            this.txt_client_ip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_client_send = new System.Windows.Forms.TextBox();
            this.client_content = new System.Windows.Forms.TextBox();
            btn_client_send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("한컴 바겐세일 M", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "접속할 채팅방 정보";
            // 
            // txt_client_name
            // 
            this.txt_client_name.Location = new System.Drawing.Point(74, 108);
            this.txt_client_name.Name = "txt_client_name";
            this.txt_client_name.Size = new System.Drawing.Size(169, 21);
            this.txt_client_name.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("한컴 바겐세일 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(24, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("한컴 바겐세일 M", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(14, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 24);
            this.label4.TabIndex = 16;
            // 
            // btn_client_exit
            // 
            this.btn_client_exit.Font = new System.Drawing.Font("한컴 백제 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_client_exit.Location = new System.Drawing.Point(422, 47);
            this.btn_client_exit.Name = "btn_client_exit";
            this.btn_client_exit.Size = new System.Drawing.Size(105, 82);
            this.btn_client_exit.TabIndex = 15;
            this.btn_client_exit.Text = "채팅방 종료";
            this.btn_client_exit.UseVisualStyleBackColor = true;
            // 
            // btn_client_open
            // 
            this.btn_client_open.Font = new System.Drawing.Font("한컴 백제 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_client_open.Location = new System.Drawing.Point(285, 46);
            this.btn_client_open.Name = "btn_client_open";
            this.btn_client_open.Size = new System.Drawing.Size(105, 83);
            this.btn_client_open.TabIndex = 14;
            this.btn_client_open.Text = "채팅방 참여";
            this.btn_client_open.UseVisualStyleBackColor = true;
            // 
            // txt_client_port
            // 
            this.txt_client_port.Location = new System.Drawing.Point(74, 76);
            this.txt_client_port.Name = "txt_client_port";
            this.txt_client_port.Size = new System.Drawing.Size(169, 21);
            this.txt_client_port.TabIndex = 13;
            // 
            // txt_client_ip
            // 
            this.txt_client_ip.Location = new System.Drawing.Point(74, 46);
            this.txt_client_ip.Name = "txt_client_ip";
            this.txt_client_ip.Size = new System.Drawing.Size(169, 21);
            this.txt_client_ip.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("한컴 바겐세일 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(24, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("한컴 바겐세일 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(24, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "IP ";
            // 
            // btn_client_send
            // 
            btn_client_send.Font = new System.Drawing.Font("한컴 바겐세일 M", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            btn_client_send.Location = new System.Drawing.Point(449, 449);
            btn_client_send.Name = "btn_client_send";
            btn_client_send.Size = new System.Drawing.Size(77, 22);
            btn_client_send.TabIndex = 21;
            btn_client_send.Text = "보내기";
            btn_client_send.UseVisualStyleBackColor = true;
            // 
            // txt_client_send
            // 
            this.txt_client_send.Location = new System.Drawing.Point(28, 450);
            this.txt_client_send.Name = "txt_client_send";
            this.txt_client_send.Size = new System.Drawing.Size(411, 21);
            this.txt_client_send.TabIndex = 20;
            // 
            // client_content
            // 
            this.client_content.Location = new System.Drawing.Point(27, 141);
            this.client_content.Multiline = true;
            this.client_content.Name = "client_content";
            this.client_content.Size = new System.Drawing.Size(500, 297);
            this.client_content.TabIndex = 19;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 483);
            this.Controls.Add(btn_client_send);
            this.Controls.Add(this.txt_client_send);
            this.Controls.Add(this.client_content);
            this.Controls.Add(this.txt_client_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_client_exit);
            this.Controls.Add(this.btn_client_open);
            this.Controls.Add(this.txt_client_port);
            this.Controls.Add(this.txt_client_ip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Client";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_client_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_client_exit;
        private System.Windows.Forms.Button btn_client_open;
        private System.Windows.Forms.TextBox txt_client_port;
        private System.Windows.Forms.TextBox txt_client_ip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_client_send;
        private System.Windows.Forms.TextBox client_content;
    }
}