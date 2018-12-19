namespace ImageProcessingSystem
{
    partial class FaceCheck
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
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_kind_message = new System.Windows.Forms.Label();
            this.lb_sex_message = new System.Windows.Forms.Label();
            this.lb_face_message = new System.Windows.Forms.Label();
            this.lb_age_message = new System.Windows.Forms.Label();
            this.lb_kind = new System.Windows.Forms.Label();
            this.lb_sex = new System.Windows.Forms.Label();
            this.lb_face = new System.Windows.Forms.Label();
            this.lb_age = new System.Windows.Forms.Label();
            this.comboBoxCameras = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.btn_vd = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Location = new System.Drawing.Point(53, 44);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(234, 218);
            this.videoSourcePlayer1.TabIndex = 0;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_kind_message);
            this.groupBox1.Controls.Add(this.lb_sex_message);
            this.groupBox1.Controls.Add(this.lb_face_message);
            this.groupBox1.Controls.Add(this.lb_age_message);
            this.groupBox1.Controls.Add(this.lb_kind);
            this.groupBox1.Controls.Add(this.lb_sex);
            this.groupBox1.Controls.Add(this.lb_face);
            this.groupBox1.Controls.Add(this.lb_age);
            this.groupBox1.Location = new System.Drawing.Point(504, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 218);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            // 
            // lb_kind_message
            // 
            this.lb_kind_message.AutoSize = true;
            this.lb_kind_message.Location = new System.Drawing.Point(64, 168);
            this.lb_kind_message.Name = "lb_kind_message";
            this.lb_kind_message.Size = new System.Drawing.Size(0, 15);
            this.lb_kind_message.TabIndex = 11;
            // 
            // lb_sex_message
            // 
            this.lb_sex_message.AutoSize = true;
            this.lb_sex_message.Location = new System.Drawing.Point(64, 125);
            this.lb_sex_message.Name = "lb_sex_message";
            this.lb_sex_message.Size = new System.Drawing.Size(0, 15);
            this.lb_sex_message.TabIndex = 10;
            // 
            // lb_face_message
            // 
            this.lb_face_message.AutoSize = true;
            this.lb_face_message.Location = new System.Drawing.Point(64, 84);
            this.lb_face_message.Name = "lb_face_message";
            this.lb_face_message.Size = new System.Drawing.Size(0, 15);
            this.lb_face_message.TabIndex = 9;
            // 
            // lb_age_message
            // 
            this.lb_age_message.AutoSize = true;
            this.lb_age_message.Location = new System.Drawing.Point(64, 36);
            this.lb_age_message.Name = "lb_age_message";
            this.lb_age_message.Size = new System.Drawing.Size(0, 15);
            this.lb_age_message.TabIndex = 8;
            // 
            // lb_kind
            // 
            this.lb_kind.AutoSize = true;
            this.lb_kind.Location = new System.Drawing.Point(6, 168);
            this.lb_kind.Name = "lb_kind";
            this.lb_kind.Size = new System.Drawing.Size(52, 15);
            this.lb_kind.TabIndex = 7;
            this.lb_kind.Text = "人种：";
            // 
            // lb_sex
            // 
            this.lb_sex.AutoSize = true;
            this.lb_sex.Location = new System.Drawing.Point(6, 125);
            this.lb_sex.Name = "lb_sex";
            this.lb_sex.Size = new System.Drawing.Size(52, 15);
            this.lb_sex.TabIndex = 6;
            this.lb_sex.Text = "性别：";
            // 
            // lb_face
            // 
            this.lb_face.AutoSize = true;
            this.lb_face.Location = new System.Drawing.Point(6, 84);
            this.lb_face.Name = "lb_face";
            this.lb_face.Size = new System.Drawing.Size(52, 15);
            this.lb_face.TabIndex = 5;
            this.lb_face.Text = "表情：";
            // 
            // lb_age
            // 
            this.lb_age.AutoSize = true;
            this.lb_age.Location = new System.Drawing.Point(6, 36);
            this.lb_age.Name = "lb_age";
            this.lb_age.Size = new System.Drawing.Size(52, 15);
            this.lb_age.TabIndex = 4;
            this.lb_age.Text = "年龄：";
            // 
            // comboBoxCameras
            // 
            this.comboBoxCameras.FormattingEnabled = true;
            this.comboBoxCameras.Location = new System.Drawing.Point(153, 309);
            this.comboBoxCameras.Name = "comboBoxCameras";
            this.comboBoxCameras.Size = new System.Drawing.Size(121, 23);
            this.comboBoxCameras.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "识别";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "摄像头列表：";
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(417, 361);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(82, 27);
            this.close.TabIndex = 7;
            this.close.Text = "关闭";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // btn_vd
            // 
            this.btn_vd.Location = new System.Drawing.Point(53, 4);
            this.btn_vd.Name = "btn_vd";
            this.btn_vd.Size = new System.Drawing.Size(78, 34);
            this.btn_vd.TabIndex = 8;
            this.btn_vd.Text = "连接";
            this.btn_vd.UseVisualStyleBackColor = true;
            this.btn_vd.Click += new System.EventHandler(this.btn_vd_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(212, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 34);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // FaceCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_vd);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxCameras);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.videoSourcePlayer1);
            this.Name = "FaceCheck";
            this.Text = "FaceCheck";
            this.Load += new System.EventHandler(this.FaceCheck_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_kind_message;
        private System.Windows.Forms.Label lb_sex_message;
        private System.Windows.Forms.Label lb_face_message;
        private System.Windows.Forms.Label lb_age_message;
        private System.Windows.Forms.Label lb_kind;
        private System.Windows.Forms.Label lb_sex;
        private System.Windows.Forms.Label lb_face;
        private System.Windows.Forms.Label lb_age;
        private System.Windows.Forms.ComboBox comboBoxCameras;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button btn_vd;
        private System.Windows.Forms.Button btn_save;
    }
}