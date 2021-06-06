using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Threading;
using System.Text.Json;
using System.Diagnostics;
using Microsoft.Win32;
using System.Web;

namespace Translll
{
    public partial class formTranslll : Form
    {
        public Config config;

        private HttpClient _httpClient;
        public HttpClient HttpClient =>
            _httpClient ?? (_httpClient = new HttpClient());

        private string _previousClipboard;
        public formTranslll()
        {
            InitializeComponent();
            RadioButton[] RBList = {
                rbFromAuto, rbFromEn, rbFromZh,
                rbToEn,rbToZh };
            foreach (var rb in RBList)
            {
                /* 订阅所有 RadioButton 状态改变的事件
                 * 以便在仅改变翻译源和目的的情况下重新发起请求
                 */
                rb.CheckedChanged += new EventHandler(FromOrToChanged);
            }
        }

        private bool IsClipboardChanged() =>
            Clipboard.GetText() != _previousClipboard
            ? true : false;

        private async Task<string> RequestAPIAsync(Config config)
        {
            string QueryString =
                $"{config.ApiUrl}?q={config.Q}&from={config.From}&to={config.To}" +
                $"&appid={config.AppID}&salt={config.Salt}&sign={config.Sign}";
            HttpResponseMessage response = await HttpClient.GetAsync(QueryString);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (IsClipboardChanged())
            {
                UpdateResult();
            }
        }

        private void cbTopMost_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;
        }

        private void gbFrom_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
        }

        private void gbTo_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
        }

        private void FromOrToChanged(object sender, EventArgs e)
        {
            UpdateResult();
        }

        /* 请求 API，获取结果并更新 lblResult
         * 当选择的翻译语言改变或者剪贴板内容变化时调用
         */
        private async void UpdateResult()
        {
            _previousClipboard = Clipboard.GetText();
            config = GetConfig();
            string OriginalResponse = await RequestAPIAsync(config);
            lblResult.Text = TranslateResponse.ParseDest(OriginalResponse);
        }

        // 用按钮的值构造 Config
        private Config GetConfig()
        {
            string from = null;
            string to = null;
            RadioButton[] RBFromList = {
                rbFromAuto, rbFromZh, rbFromEn };
            RadioButton[] RBToList ={
                rbToZh, rbToEn };
            foreach(var rb in RBFromList)
            {
                if (rb.Checked == true)
                {
                    /* 依赖于 RidioButton 的名字，必须为 rbFrom*
                     * 其中 * 为 API 文档中对应语言的缩写
                     * To 的位置类似
                     */
                    from = rb.Name.Replace("rbFrom", "").ToLower();
                }
            }
            foreach (var rb in RBToList)
            {
                if (rb.Checked == true)
                {
                    to = rb.Name.Replace("rbTo", "").ToLower();
                }
            }
            return Config.BuildConfig(from, to, Clipboard.GetText());
        }

        /* 文本改变时，调整整个窗口的大小
         * 防止内容显示不全
         * 由于 AutoSize，文本改变时，首先触发 TextChanged 事件，
         * 然后才是改变 Size，触发 SizeChanged 事件
         * 所以改变窗口大小需要在 SizeChanged 中写，而不是 TextChanged
         */
        private void lblResult_SizeChanged(object sender, EventArgs e)
        {
            if (lblResult.Width >= 300)
                this.Width = lblResult.Width + 30;
            else
                this.Width = 300;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this,"自动翻译剪贴板上的内容","帮助",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            /* 使用 Powershell 的 Start-Process 来用默认浏览器打开网页
             * & 是 powershell 的保留字符，需要用反引号转义
             * 使用 powershell 打开会有窗口
             */
            string Url = config.GetDetailUrl();
            Url = Url.Replace("&", "`&");
            string PSParam = $"Start-Process -FilePath {Url}";
            Process.Start("powershell", PSParam);
        }
    }
}
