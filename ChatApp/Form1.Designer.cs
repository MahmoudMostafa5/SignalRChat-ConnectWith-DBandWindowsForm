
namespace ChatApp
{
    partial class Form1
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
            this.txt_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_group = new System.Windows.Forms.Label();
            this.txt_nam = new System.Windows.Forms.TextBox();
            this.txt_msg = new System.Windows.Forms.TextBox();
            this.txt_grp = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_join = new System.Windows.Forms.Button();
            this.btn_sendgroup = new System.Windows.Forms.Button();
            this.lb_msg = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.AutoSize = true;
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(99, 35);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(81, 29);
            this.txt_name.TabIndex = 0;
            this.txt_name.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Message";
            // 
            // txt_group
            // 
            this.txt_group.AutoSize = true;
            this.txt_group.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_group.Location = new System.Drawing.Point(40, 211);
            this.txt_group.Name = "txt_group";
            this.txt_group.Size = new System.Drawing.Size(82, 29);
            this.txt_group.TabIndex = 2;
            this.txt_group.Text = "Group";
            // 
            // txt_nam
            // 
            this.txt_nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nam.Location = new System.Drawing.Point(265, 29);
            this.txt_nam.Multiline = true;
            this.txt_nam.Name = "txt_nam";
            this.txt_nam.Size = new System.Drawing.Size(272, 35);
            this.txt_nam.TabIndex = 3;
            // 
            // txt_msg
            // 
            this.txt_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_msg.Location = new System.Drawing.Point(182, 128);
            this.txt_msg.Multiline = true;
            this.txt_msg.Name = "txt_msg";
            this.txt_msg.Size = new System.Drawing.Size(198, 37);
            this.txt_msg.TabIndex = 4;
            // 
            // txt_grp
            // 
            this.txt_grp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_grp.Location = new System.Drawing.Point(182, 203);
            this.txt_grp.Multiline = true;
            this.txt_grp.Name = "txt_grp";
            this.txt_grp.Size = new System.Drawing.Size(198, 37);
            this.txt_grp.TabIndex = 5;
            // 
            // btn_send
            // 
            this.btn_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.Location = new System.Drawing.Point(423, 128);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(154, 37);
            this.btn_send.TabIndex = 6;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_join
            // 
            this.btn_join.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_join.Location = new System.Drawing.Point(423, 203);
            this.btn_join.Name = "btn_join";
            this.btn_join.Size = new System.Drawing.Size(154, 37);
            this.btn_join.TabIndex = 7;
            this.btn_join.Text = "Join";
            this.btn_join.UseVisualStyleBackColor = true;
            this.btn_join.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_sendgroup
            // 
            this.btn_sendgroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sendgroup.Location = new System.Drawing.Point(207, 299);
            this.btn_sendgroup.Name = "btn_sendgroup";
            this.btn_sendgroup.Size = new System.Drawing.Size(206, 38);
            this.btn_sendgroup.TabIndex = 8;
            this.btn_sendgroup.Text = "Send to Group";
            this.btn_sendgroup.UseVisualStyleBackColor = true;
            this.btn_sendgroup.Click += new System.EventHandler(this.btn_sendgroup_Click);
            // 
            // lb_msg
            // 
            this.lb_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_msg.FormattingEnabled = true;
            this.lb_msg.ItemHeight = 29;
            this.lb_msg.Location = new System.Drawing.Point(45, 406);
            this.lb_msg.Name = "lb_msg";
            this.lb_msg.Size = new System.Drawing.Size(510, 149);
            this.lb_msg.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 627);
            this.Controls.Add(this.lb_msg);
            this.Controls.Add(this.btn_sendgroup);
            this.Controls.Add(this.btn_join);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txt_grp);
            this.Controls.Add(this.txt_msg);
            this.Controls.Add(this.txt_nam);
            this.Controls.Add(this.txt_group);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_group;
        private System.Windows.Forms.TextBox txt_nam;
        private System.Windows.Forms.TextBox txt_msg;
        private System.Windows.Forms.TextBox txt_grp;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_join;
        private System.Windows.Forms.Button btn_sendgroup;
        private System.Windows.Forms.ListBox lb_msg;
    }
}

