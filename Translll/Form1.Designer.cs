
namespace Translll
{
    partial class formTranslll
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.cbTopMost = new System.Windows.Forms.CheckBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.gbFrom = new System.Windows.Forms.GroupBox();
            this.rbFromEn = new System.Windows.Forms.RadioButton();
            this.rbFromZh = new System.Windows.Forms.RadioButton();
            this.rbFromAuto = new System.Windows.Forms.RadioButton();
            this.gbTo = new System.Windows.Forms.GroupBox();
            this.rbToEn = new System.Windows.Forms.RadioButton();
            this.rbToZh = new System.Windows.Forms.RadioButton();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.gbFrom.SuspendLayout();
            this.gbTo.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // cbTopMost
            // 
            this.cbTopMost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTopMost.AutoSize = true;
            this.cbTopMost.Checked = true;
            this.cbTopMost.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTopMost.Location = new System.Drawing.Point(221, 104);
            this.cbTopMost.Name = "cbTopMost";
            this.cbTopMost.Size = new System.Drawing.Size(51, 21);
            this.cbTopMost.TabIndex = 1;
            this.cbTopMost.Text = "置顶";
            this.cbTopMost.UseVisualStyleBackColor = true;
            this.cbTopMost.CheckedChanged += new System.EventHandler(this.cbTopMost_CheckedChanged);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResult.Location = new System.Drawing.Point(12, 61);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(95, 35);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Result";
            this.lblResult.SizeChanged += new System.EventHandler(this.lblResult_SizeChanged);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(12, 9);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(38, 17);
            this.lblFrom.TabIndex = 4;
            this.lblFrom.Text = "From";
            // 
            // lblTo
            // 
            this.lblTo.AutoEllipsis = true;
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(12, 35);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(31, 17);
            this.lblTo.TabIndex = 5;
            this.lblTo.Text = "To  ";
            // 
            // gbFrom
            // 
            this.gbFrom.Controls.Add(this.rbFromEn);
            this.gbFrom.Controls.Add(this.rbFromZh);
            this.gbFrom.Controls.Add(this.rbFromAuto);
            this.gbFrom.Location = new System.Drawing.Point(56, 9);
            this.gbFrom.Name = "gbFrom";
            this.gbFrom.Size = new System.Drawing.Size(251, 17);
            this.gbFrom.TabIndex = 6;
            this.gbFrom.TabStop = false;
            this.gbFrom.Paint += new System.Windows.Forms.PaintEventHandler(this.gbFrom_Paint);
            // 
            // rbFromEn
            // 
            this.rbFromEn.AutoSize = true;
            this.rbFromEn.Location = new System.Drawing.Point(160, -2);
            this.rbFromEn.Name = "rbFromEn";
            this.rbFromEn.Size = new System.Drawing.Size(67, 21);
            this.rbFromEn.TabIndex = 2;
            this.rbFromEn.Text = "English";
            this.rbFromEn.UseVisualStyleBackColor = true;
            // 
            // rbFromZh
            // 
            this.rbFromZh.AutoSize = true;
            this.rbFromZh.Location = new System.Drawing.Point(80, -2);
            this.rbFromZh.Name = "rbFromZh";
            this.rbFromZh.Size = new System.Drawing.Size(74, 21);
            this.rbFromZh.TabIndex = 1;
            this.rbFromZh.Text = "简体中文";
            this.rbFromZh.UseVisualStyleBackColor = true;
            // 
            // rbFromAuto
            // 
            this.rbFromAuto.AutoSize = true;
            this.rbFromAuto.Checked = true;
            this.rbFromAuto.Location = new System.Drawing.Point(0, -2);
            this.rbFromAuto.Name = "rbFromAuto";
            this.rbFromAuto.Size = new System.Drawing.Size(74, 21);
            this.rbFromAuto.TabIndex = 0;
            this.rbFromAuto.TabStop = true;
            this.rbFromAuto.Text = "自动选择";
            this.rbFromAuto.UseVisualStyleBackColor = true;
            // 
            // gbTo
            // 
            this.gbTo.Controls.Add(this.rbToEn);
            this.gbTo.Controls.Add(this.rbToZh);
            this.gbTo.Location = new System.Drawing.Point(56, 32);
            this.gbTo.Name = "gbTo";
            this.gbTo.Size = new System.Drawing.Size(251, 20);
            this.gbTo.TabIndex = 7;
            this.gbTo.TabStop = false;
            this.gbTo.Paint += new System.Windows.Forms.PaintEventHandler(this.gbTo_Paint);
            // 
            // rbToEn
            // 
            this.rbToEn.AutoSize = true;
            this.rbToEn.Location = new System.Drawing.Point(160, 1);
            this.rbToEn.Name = "rbToEn";
            this.rbToEn.Size = new System.Drawing.Size(67, 21);
            this.rbToEn.TabIndex = 3;
            this.rbToEn.Text = "English";
            this.rbToEn.UseVisualStyleBackColor = true;
            // 
            // rbToZh
            // 
            this.rbToZh.AutoSize = true;
            this.rbToZh.Checked = true;
            this.rbToZh.Location = new System.Drawing.Point(80, 1);
            this.rbToZh.Name = "rbToZh";
            this.rbToZh.Size = new System.Drawing.Size(74, 21);
            this.rbToZh.TabIndex = 3;
            this.rbToZh.TabStop = true;
            this.rbToZh.Text = "简体中文";
            this.rbToZh.UseVisualStyleBackColor = true;
            // 
            // btnDetails
            // 
            this.btnDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDetails.Location = new System.Drawing.Point(12, 102);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(83, 23);
            this.btnDetails.TabIndex = 8;
            this.btnDetails.Text = "详细内容>>";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClear.Location = new System.Drawing.Point(101, 102);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(50, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnHelp.Location = new System.Drawing.Point(157, 102);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(50, 23);
            this.btnHelp.TabIndex = 10;
            this.btnHelp.Text = "帮助";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // formTranslll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 131);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.gbTo);
            this.Controls.Add(this.gbFrom);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.cbTopMost);
            this.Name = "formTranslll";
            this.Text = "Translll";
            this.TopMost = true;
            this.gbFrom.ResumeLayout(false);
            this.gbFrom.PerformLayout();
            this.gbTo.ResumeLayout(false);
            this.gbTo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.CheckBox cbTopMost;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.GroupBox gbFrom;
        private System.Windows.Forms.RadioButton rbFromEn;
        private System.Windows.Forms.RadioButton rbFromZh;
        private System.Windows.Forms.RadioButton rbFromAuto;
        private System.Windows.Forms.GroupBox gbTo;
        private System.Windows.Forms.RadioButton rbToEn;
        private System.Windows.Forms.RadioButton rbToZh;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnHelp;
    }
}

