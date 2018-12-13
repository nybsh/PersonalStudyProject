using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBTool
{    
    public partial class dataOperate : Form
    {
        private SqlServerHelper dbHelper = new SqlServerHelper();
        private string GeneratePath;
        private string curFileName = string.Empty;
        public dataOperate()
        {
            InitializeComponent();
        }

        private void btn_Folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog mydialog = new FolderBrowserDialog();
            if (mydialog.ShowDialog() == DialogResult.OK)
            {
                this.txt_DataPath.Text = mydialog.SelectedPath;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Txt_tips_TextChanged(object sender, System.EventArgs e)
        {
            //将光标位置设置到当前内容的末尾
            this.Txt_tips.SelectionStart = this.Txt_tips.Text.Length;
            //滚动到光标位置
            this.Txt_tips.ScrollToCaret();
        }

        private void ShowTips(string msg)
        {
            msg = string.Format("{0}{1}", msg, Environment.NewLine);
            if (this.Txt_tips.InvokeRequired)
            {
                this.Invoke((Action<string>)delegate (string tips)
                {
                    this.Txt_tips.AppendText(tips);
                }, msg);
            }
            else
            {
                this.Txt_tips.AppendText(msg);
            }
        }
        private void btn_Ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(this.Txt_DbConnectStr.Text))
                {
                    ShowTips("请指定数据库连接串...");
                    return;
                }
                var initDbRet = dbHelper.Init(this.Txt_DbConnectStr.Text);
                if (!initDbRet.Item1)
                {
                    ShowTips(initDbRet.Item2);
                    return;
                }
                if (this.txt_DataPath.Text.Length <= 0)
                {
                    ShowTips("请指定源数据目录...");
                    return;
                }
                this.Cursor = Cursors.WaitCursor;
                this.btn_Ok.Enabled = false;                
                DirectoryInfo originalFolder = new DirectoryInfo(this.txt_DataPath.Text);
                if (originalFolder == null) 
                {
                    ShowTips("指定的源数据目录不存在，请确认。");
                    return;
                }
                ShowTips("数据脚本文件开始执行...");
                Task.Factory.StartNew(() =>
                {
                    try
                    {
                        ScanFile(originalFolder);
                        ShowTips("数据脚本文件执行完成！");
                    }
                    catch (Exception ex)
                    {
                        ShowTips(string.Format("数据脚本文件【{1}】执行失败：{0}", ex.Message, this.curFileName));
                    }
                }).ContinueWith(t =>
                {
                    
                });
            }
            catch(Exception ex)
            {
                ShowTips("计算出现错误，请确保参数设置正确");
            }
            finally
            {
                this.btn_Ok.Enabled = true;
                this.Cursor = Cursors.Default;
            }
        }

        private void btn_OperGenerateFolder_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.GeneratePath))
            {
                System.Diagnostics.Process.Start("Explorer.exe", this.GeneratePath);
            }
            else
            {
                ShowTips("尚未生成文件目录，请先执行计算。");
            }
        }

        private void ScanFile(FileSystemInfo info)
        {
            if (!info.Exists)
            {
                return;
            }
            DirectoryInfo dir = info as DirectoryInfo;
            if (dir == null)
            {
                return;
            }
            ShowTips(string.Format("正在执行【{0}】的数据...", dir.Name));
            FileSystemInfo[] files = dir.GetFileSystemInfos();
            files = files.OrderBy(p => p.Name).ToArray();
            foreach (var item in files)
            {
                FileInfo file = item as FileInfo;
                if (file != null)
                {
                    if (file.Extension.Equals(".sql", StringComparison.OrdinalIgnoreCase))
                    {
                        this.curFileName = file.Name;
                        string sqlStr = File.ReadAllText(file.FullName);
                        if (!string.IsNullOrWhiteSpace(sqlStr))
                        {
                            if (!dbHelper.ExecuteNonQuery(sqlStr))
                            {
                                ShowTips(string.Format("{0}----执行失败", file.FullName));
                            }
                            else
                            {
                                ShowTips(file.FullName);
                            }
                        }
                    }
                }
                else
                {
                    ScanFile(item);
                }
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            this.Txt_tips.Text = string.Empty;
        }
    }
}
