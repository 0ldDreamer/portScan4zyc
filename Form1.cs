using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace portScan4zyc
{
    public partial class Form1 : Form
    {
        //主机地址
        private string hostAddress;
        //起始端口
        private int start;
        //终止端口
        private int end;
        //端口号
        private int port;
        //定义线程对象
        private Thread scanThread;
        //定义端口状态数据（开放则为true，否则为false）
        private bool[] done = new bool[65526];
        private bool OK;

        public Form1()
        {
            InitializeComponent();
            //不进行跨线程检查
            CheckForIllegalCrossThreadCalls = false;
        }



        /// <summary>
        /// 判断端口是否合理
        /// </summary>
        /// <returns></returns>
        private bool decideAddress()
        {
            //判断端口号是否合理
            if ((start >= 0 && start <= 65536) && (end >= 0 && end <= 65536) && (start <= end))
                return true;
            else
                return false;
        }

        private void PortScan()
        {
            double x;
            string xian;
            //显示扫描状态
            show.AppendText(Environment.NewLine + Environment.NewLine);
            //循环抛出线程扫描端口
            for (int i = start; i <= end; i++)
            {
                x = (double)(i - start + 1) / (end - start + 1);
                xian = x.ToString("0%");
                port = i;
                //使用该端口的扫描线程
                scanThread = new Thread(new ThreadStart(Scan));
                scanThread.Start();
                //使线程睡眠
                System.Threading.Thread.Sleep(100);
                //进度条值改变
                pb.Text = xian;
                pb.Value = i;
            }
            while (!OK)
            {
                OK = true;
                for (int i = start; i <= end; i++)
                {
                    if (!done[i])
                    {
                        OK = false;
                        break;
                    }
                }
                System.Threading.Thread.Sleep(1000);
            }
            show.AppendText(Environment.NewLine + "扫描结束！" + Environment.NewLine);
            //输入框textbox只读属性取消
            tbHost.ReadOnly = false;
            tbSPort.ReadOnly = false;
            tbEPort.ReadOnly = false;
        }


        /// <summary>
        /// 扫描某个端口
        /// </summary>
        private void Scan()
        {
            int portnow = port;
            //创建线程变量
            Thread Threadnow = scanThread;
            //扫描端口，成功则写入信息
            done[portnow] = true;
            //创建TcpClient对象，TcpClient用于为TCP网络服务提供客户端连接
            TcpClient objTCP = null;
            try
            {
                //用于TcpClient对象扫描端口
                objTCP = new TcpClient(hostAddress, portnow);
                //扫描到则显示到显示框
                show.AppendText("端口 " + port + " 开放！" + Environment.NewLine);
            }
            catch
            {
                //未扫描到，则会抛出错误
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                //初始化
                show.Clear();
                pb.Text = "0%";

                //获取ip地址和始末端口号
                hostAddress = tbHost.Text;
                start = Int32.Parse(tbSPort.Text);
                end = Int32.Parse(tbEPort.Text);

                if (decideAddress()) // 端口合理
                {
                    //让输入的textbox只读，无法改变
                    tbHost.ReadOnly = true;
                    tbSPort.ReadOnly = true;
                    tbEPort.ReadOnly = true;
                    //设置进度条的范围
                    pb.Minimum = start;
                    pb.Maximum = end;

                    //显示框显示
                    show.AppendText("zyc的端口扫描器" + Environment.NewLine + Environment.NewLine);
                    //调用端口扫描函数
                    PortScan();
                }
                else
                {
                    //若端口号不合理，弹窗报错
                    MessageBox.Show("输入错误，端口范围为[0-65536]!");
                }
            }
            catch
            {
                //若输入的端口号为非整型，则弹窗报错
                MessageBox.Show("输入错误，端口范围为[0-65536]!");
            }
        }

        private void pb_Click(object sender, EventArgs e)
        {

        }
    }
}

