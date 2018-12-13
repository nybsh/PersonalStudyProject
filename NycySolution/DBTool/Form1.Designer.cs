namespace DBTool
{
    partial class dataOperate
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dataOperate));
            this.label5 = new System.Windows.Forms.Label();
            this.txt_DataPath = new System.Windows.Forms.TextBox();
            this.btn_Folder = new System.Windows.Forms.Button();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OperGenerateFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_DbConnectStr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_tips = new System.Windows.Forms.RichTextBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(10, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "数据库脚本目录：";
            // 
            // txt_DataPath
            // 
            this.txt_DataPath.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_DataPath.Location = new System.Drawing.Point(152, 97);
            this.txt_DataPath.Name = "txt_DataPath";
            this.txt_DataPath.ReadOnly = true;
            this.txt_DataPath.Size = new System.Drawing.Size(313, 26);
            this.txt_DataPath.TabIndex = 8;
            // 
            // btn_Folder
            // 
            this.btn_Folder.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Folder.Location = new System.Drawing.Point(464, 96);
            this.btn_Folder.Name = "btn_Folder";
            this.btn_Folder.Size = new System.Drawing.Size(75, 29);
            this.btn_Folder.TabIndex = 9;
            this.btn_Folder.Text = "浏览>>";
            this.btn_Folder.UseVisualStyleBackColor = true;
            this.btn_Folder.Click += new System.EventHandler(this.btn_Folder_Click);
            // 
            // btn_Ok
            // 
            this.btn_Ok.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Ok.Location = new System.Drawing.Point(363, 349);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(85, 42);
            this.btn_Ok.TabIndex = 11;
            this.btn_Ok.Text = "生成文件";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Cancel.Location = new System.Drawing.Point(454, 349);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(85, 42);
            this.btn_Cancel.TabIndex = 12;
            this.btn_Cancel.Text = "关闭程序";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_OperGenerateFolder
            // 
            this.btn_OperGenerateFolder.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OperGenerateFolder.Location = new System.Drawing.Point(103, 349);
            this.btn_OperGenerateFolder.Name = "btn_OperGenerateFolder";
            this.btn_OperGenerateFolder.Size = new System.Drawing.Size(163, 42);
            this.btn_OperGenerateFolder.TabIndex = 13;
            this.btn_OperGenerateFolder.Text = "打开生成文件目录";
            this.btn_OperGenerateFolder.UseVisualStyleBackColor = true;
            this.btn_OperGenerateFolder.Visible = false;
            this.btn_OperGenerateFolder.Click += new System.EventHandler(this.btn_OperGenerateFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "数据库类型：";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(153, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "MySql";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(10, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "数据库连接串：";
            // 
            // Txt_DbConnectStr
            // 
            this.Txt_DbConnectStr.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Txt_DbConnectStr.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Txt_DbConnectStr.Location = new System.Drawing.Point(153, 58);
            this.Txt_DbConnectStr.Name = "Txt_DbConnectStr";
            this.Txt_DbConnectStr.Size = new System.Drawing.Size(387, 26);
            this.Txt_DbConnectStr.TabIndex = 17;
            this.Txt_DbConnectStr.Text = "server=127.0.0.1;database=test;user id=znjs;password=123456;";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(259, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "（目前只支持MySql数据库）";
            // 
            // Txt_tips
            // 
            this.Txt_tips.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Txt_tips.ForeColor = System.Drawing.Color.Blue;
            this.Txt_tips.Location = new System.Drawing.Point(14, 131);
            this.Txt_tips.Name = "Txt_tips";
            this.Txt_tips.ReadOnly = true;
            this.Txt_tips.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Txt_tips.Size = new System.Drawing.Size(525, 212);
            this.Txt_tips.TabIndex = 19;
            this.Txt_tips.Text = "";
            this.Txt_tips.TextChanged += Txt_tips_TextChanged;
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_clear.Location = new System.Drawing.Point(12, 349);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(85, 42);
            this.button_clear.TabIndex = 20;
            this.button_clear.Text = "清空";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // dataOperate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(552, 403);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.Txt_tips);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_DbConnectStr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_OperGenerateFolder);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.btn_Folder);
            this.Controls.Add(this.txt_DataPath);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dataOperate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据脚本批量执行";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_DataPath;
        private System.Windows.Forms.Button btn_Folder;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OperGenerateFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_DbConnectStr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox Txt_tips;
        private System.Windows.Forms.Button button_clear;
    }
}

