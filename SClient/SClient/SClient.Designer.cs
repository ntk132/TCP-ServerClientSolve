namespace SClient
{
    partial class SClient
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
            this.btConnect = new System.Windows.Forms.Button();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNum1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNum2 = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btSub = new System.Windows.Forms.Button();
            this.btMulti = new System.Windows.Forms.Button();
            this.btDivide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(269, 22);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(75, 75);
            this.btConnect.TabIndex = 37;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(105, 72);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(150, 22);
            this.tbPort.TabIndex = 36;
            this.tbPort.Text = "13600";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Port:";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(105, 32);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(150, 22);
            this.tbAddress.TabIndex = 34;
            this.tbAddress.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Địa chỉ IP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Số 1:";
            // 
            // tbNum1
            // 
            this.tbNum1.Location = new System.Drawing.Point(105, 124);
            this.tbNum1.Name = "tbNum1";
            this.tbNum1.Size = new System.Drawing.Size(150, 22);
            this.tbNum1.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "Số 2:";
            // 
            // tbNum2
            // 
            this.tbNum2.Location = new System.Drawing.Point(105, 164);
            this.tbNum2.Name = "tbNum2";
            this.tbNum2.Size = new System.Drawing.Size(150, 22);
            this.tbNum2.TabIndex = 36;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(278, 123);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(25, 25);
            this.btAdd.TabIndex = 37;
            this.btAdd.Text = "+";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "Tổng 2 số:";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(39, 243);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(216, 22);
            this.tbResult.TabIndex = 39;
            // 
            // btSub
            // 
            this.btSub.Location = new System.Drawing.Point(319, 124);
            this.btSub.Name = "btSub";
            this.btSub.Size = new System.Drawing.Size(25, 25);
            this.btSub.TabIndex = 37;
            this.btSub.Text = "-";
            this.btSub.UseVisualStyleBackColor = true;
            this.btSub.Click += new System.EventHandler(this.btSub_Click);
            // 
            // btMulti
            // 
            this.btMulti.Location = new System.Drawing.Point(278, 161);
            this.btMulti.Name = "btMulti";
            this.btMulti.Size = new System.Drawing.Size(25, 25);
            this.btMulti.TabIndex = 37;
            this.btMulti.Text = "*";
            this.btMulti.UseVisualStyleBackColor = true;
            this.btMulti.Click += new System.EventHandler(this.btMulti_Click);
            // 
            // btDivide
            // 
            this.btDivide.Location = new System.Drawing.Point(319, 161);
            this.btDivide.Name = "btDivide";
            this.btDivide.Size = new System.Drawing.Size(25, 25);
            this.btDivide.TabIndex = 37;
            this.btDivide.Text = "/";
            this.btDivide.UseVisualStyleBackColor = true;
            this.btDivide.Click += new System.EventHandler(this.btDivide_Click);
            // 
            // SClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 291);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btSub);
            this.Controls.Add(this.btDivide);
            this.Controls.Add(this.btMulti);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tbNum2);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.tbNum1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SClient";
            this.Text = "SClient";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SClient_FormClosing);
            this.Load += new System.EventHandler(this.SClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNum1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNum2;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btSub;
        private System.Windows.Forms.Button btMulti;
        private System.Windows.Forms.Button btDivide;
    }
}