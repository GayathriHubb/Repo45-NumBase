namespace NumberBaseConverter
{
    partial class FormNumBase
    {
        private System.ComponentModel.IContainer Components = null;

        protected override void Dispose(bool Disposing)
        {
            if (Disposing && (Components != null))
            {
                Components.Dispose();
            }
            base.Dispose(Disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNumBase));
            PnlHeader = new Panel();
            LblSubtitle = new Label();
            LblAppTitle = new Label();
            PnlCard = new Panel();
            LbStatus = new Label();
            BtnSwap = new Button();
            BtnClear = new Button();
            BtnConvert = new Button();
            TxtOutput = new TextBox();
            LblOutput = new Label();
            TxtInput = new TextBox();
            LblInput = new Label();
            BtnTo16 = new Button();
            BtnTo10 = new Button();
            BtnTo8 = new Button();
            BtnTo2 = new Button();
            LblToBase = new Label();
            BtnFrom16 = new Button();
            BtnFrom10 = new Button();
            BtnFrom8 = new Button();
            BtnFrom2 = new Button();
            LblFromBase = new Label();
            ToolTip1 = new ToolTip(components);
            PnlHeader.SuspendLayout();
            PnlCard.SuspendLayout();
            SuspendLayout();
            // 
            // PnlHeader
            // 
            PnlHeader.Controls.Add(LblSubtitle);
            PnlHeader.Controls.Add(LblAppTitle);
            PnlHeader.Dock = DockStyle.Top;
            PnlHeader.Location = new Point(0, 0);
            PnlHeader.Name = "PnlHeader";
            PnlHeader.Size = new Size(700, 80);
            PnlHeader.TabIndex = 0;
            // 
            // LblSubtitle
            // 
            LblSubtitle.Anchor = AnchorStyles.Top;
            LblSubtitle.Font = new Font("Segoe UI", 9F);
            LblSubtitle.Location = new Point(73, 48);
            LblSubtitle.Name = "LblSubtitle";
            LblSubtitle.Size = new Size(555, 30);
            LblSubtitle.TabIndex = 1;
            LblSubtitle.Text = "Convert numbers between Binary, Octal, Decimal and Hexadecimal";
            LblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblAppTitle
            // 
            LblAppTitle.Anchor = AnchorStyles.Top;
            LblAppTitle.AutoSize = true;
            LblAppTitle.Font = new Font("Alegreya", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblAppTitle.ForeColor = Color.FromArgb(0, 0, 64);
            LblAppTitle.Location = new Point(200, 8);
            LblAppTitle.Name = "LblAppTitle";
            LblAppTitle.Size = new Size(300, 41);
            LblAppTitle.TabIndex = 0;
            LblAppTitle.Text = "Number Base Converter";
            LblAppTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PnlCard
            // 
            PnlCard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PnlCard.BorderStyle = BorderStyle.FixedSingle;
            PnlCard.Controls.Add(LbStatus);
            PnlCard.Controls.Add(BtnSwap);
            PnlCard.Controls.Add(BtnClear);
            PnlCard.Controls.Add(BtnConvert);
            PnlCard.Controls.Add(TxtOutput);
            PnlCard.Controls.Add(LblOutput);
            PnlCard.Controls.Add(TxtInput);
            PnlCard.Controls.Add(LblInput);
            PnlCard.Controls.Add(BtnTo16);
            PnlCard.Controls.Add(BtnTo10);
            PnlCard.Controls.Add(BtnTo8);
            PnlCard.Controls.Add(BtnTo2);
            PnlCard.Controls.Add(LblToBase);
            PnlCard.Controls.Add(BtnFrom16);
            PnlCard.Controls.Add(BtnFrom10);
            PnlCard.Controls.Add(BtnFrom8);
            PnlCard.Controls.Add(BtnFrom2);
            PnlCard.Controls.Add(LblFromBase);
            PnlCard.Location = new Point(15, 96);
            PnlCard.Name = "PnlCard";
            PnlCard.Size = new Size(670, 420);
            PnlCard.TabIndex = 1;
            // 
            // LbStatus
            // 
            LbStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LbStatus.Font = new Font("Segoe UI", 8.5F);
            LbStatus.Location = new Point(16, 356);
            LbStatus.Name = "LbStatus";
            LbStatus.Size = new Size(628, 47);
            LbStatus.TabIndex = 17;
            LbStatus.Text = "Enter a value to convert";
            // 
            // BtnSwap
            // 
            BtnSwap.Anchor = AnchorStyles.None;
            BtnSwap.Cursor = Cursors.Hand;
            BtnSwap.Location = new Point(500, 305);
            BtnSwap.Name = "BtnSwap";
            BtnSwap.Size = new Size(144, 40);
            BtnSwap.TabIndex = 16;
            BtnSwap.Text = "⇄  Swap";
            BtnSwap.Click += BtnSwap_Click;
            // 
            // BtnClear
            // 
            BtnClear.Anchor = AnchorStyles.None;
            BtnClear.Cursor = Cursors.Hand;
            BtnClear.Location = new Point(344, 305);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(148, 40);
            BtnClear.TabIndex = 15;
            BtnClear.Text = "Clear";
            BtnClear.Click += BtnClear_Click;
            // 
            // BtnConvert
            // 
            BtnConvert.Anchor = AnchorStyles.None;
            BtnConvert.Cursor = Cursors.Hand;
            BtnConvert.Location = new Point(16, 305);
            BtnConvert.Name = "BtnConvert";
            BtnConvert.Size = new Size(320, 40);
            BtnConvert.TabIndex = 14;
            BtnConvert.Text = "Convert";
            BtnConvert.Click += BtnConvert_Click;
            // 
            // TxtOutput
            // 
            TxtOutput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtOutput.Font = new Font("Consolas", 13F);
            TxtOutput.Location = new Point(16, 259);
            TxtOutput.Name = "TxtOutput";
            TxtOutput.ReadOnly = true;
            TxtOutput.Size = new Size(628, 38);
            TxtOutput.TabIndex = 13;
            // 
            // LblOutput
            // 
            LblOutput.Anchor = AnchorStyles.Left;
            LblOutput.Font = new Font("Segoe UI", 9F);
            LblOutput.Location = new Point(16, 229);
            LblOutput.Name = "LblOutput";
            LblOutput.Size = new Size(100, 20);
            LblOutput.TabIndex = 12;
            LblOutput.Text = "Result";
            // 
            // TxtInput
            // 
            TxtInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtInput.Font = new Font("Consolas", 13F);
            TxtInput.Location = new Point(16, 187);
            TxtInput.Name = "TxtInput";
            TxtInput.Size = new Size(628, 38);
            TxtInput.TabIndex = 11;
            TxtInput.TextChanged += TxtInput_TextChanged;
            // 
            // LblInput
            // 
            LblInput.Anchor = AnchorStyles.Left;
            LblInput.AutoSize = true;
            LblInput.Font = new Font("Segoe UI", 9F);
            LblInput.Location = new Point(16, 154);
            LblInput.Name = "LblInput";
            LblInput.Size = new Size(101, 25);
            LblInput.TabIndex = 10;
            LblInput.Text = "Input Value";
            // 
            // BtnTo16
            // 
            BtnTo16.Anchor = AnchorStyles.None;
            BtnTo16.Location = new Point(454, 111);
            BtnTo16.Name = "BtnTo16";
            BtnTo16.Size = new Size(190, 34);
            BtnTo16.TabIndex = 9;
            BtnTo16.Text = "Hexadecimal (16)";
            // 
            // BtnTo10
            // 
            BtnTo10.Anchor = AnchorStyles.None;
            BtnTo10.Location = new Point(308, 111);
            BtnTo10.Name = "BtnTo10";
            BtnTo10.Size = new Size(138, 34);
            BtnTo10.TabIndex = 8;
            BtnTo10.Text = "Decimal (10)";
            // 
            // BtnTo8
            // 
            BtnTo8.Anchor = AnchorStyles.None;
            BtnTo8.Location = new Point(162, 111);
            BtnTo8.Name = "BtnTo8";
            BtnTo8.Size = new Size(138, 34);
            BtnTo8.TabIndex = 7;
            BtnTo8.Text = "Octal (8)";
            // 
            // BtnTo2
            // 
            BtnTo2.Anchor = AnchorStyles.None;
            BtnTo2.Location = new Point(16, 111);
            BtnTo2.Name = "BtnTo2";
            BtnTo2.Size = new Size(138, 34);
            BtnTo2.TabIndex = 6;
            BtnTo2.Text = "Binary (2)";
            // 
            // LblToBase
            // 
            LblToBase.Anchor = AnchorStyles.Left;
            LblToBase.Font = new Font("Segoe UI", 9F);
            LblToBase.Location = new Point(16, 83);
            LblToBase.Name = "LblToBase";
            LblToBase.Size = new Size(90, 20);
            LblToBase.TabIndex = 5;
            LblToBase.Text = "To Base";
            // 
            // BtnFrom16
            // 
            BtnFrom16.Anchor = AnchorStyles.None;
            BtnFrom16.Location = new Point(454, 37);
            BtnFrom16.Name = "BtnFrom16";
            BtnFrom16.Size = new Size(190, 34);
            BtnFrom16.TabIndex = 4;
            BtnFrom16.Text = "Hexadecimal (16)";
            // 
            // BtnFrom10
            // 
            BtnFrom10.Anchor = AnchorStyles.None;
            BtnFrom10.Location = new Point(308, 37);
            BtnFrom10.Name = "BtnFrom10";
            BtnFrom10.Size = new Size(138, 34);
            BtnFrom10.TabIndex = 3;
            BtnFrom10.Text = "Decimal (10)";
            // 
            // BtnFrom8
            // 
            BtnFrom8.Anchor = AnchorStyles.None;
            BtnFrom8.Location = new Point(162, 37);
            BtnFrom8.Name = "BtnFrom8";
            BtnFrom8.Size = new Size(138, 34);
            BtnFrom8.TabIndex = 2;
            BtnFrom8.Text = "Octal (8)";
            // 
            // BtnFrom2
            // 
            BtnFrom2.Anchor = AnchorStyles.None;
            BtnFrom2.Location = new Point(16, 37);
            BtnFrom2.Name = "BtnFrom2";
            BtnFrom2.Size = new Size(138, 34);
            BtnFrom2.TabIndex = 1;
            BtnFrom2.Text = "Binary (2)";
            // 
            // LblFromBase
            // 
            LblFromBase.Anchor = AnchorStyles.Left;
            LblFromBase.Font = new Font("Segoe UI", 9F);
            LblFromBase.Location = new Point(16, 9);
            LblFromBase.Name = "LblFromBase";
            LblFromBase.Size = new Size(90, 20);
            LblFromBase.TabIndex = 0;
            LblFromBase.Text = "From Base";
            // 
            // FormNumBase
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(700, 544);
            Controls.Add(PnlCard);
            Controls.Add(PnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormNumBase";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Number Base Converter";
            PnlHeader.ResumeLayout(false);
            PnlHeader.PerformLayout();
            PnlCard.ResumeLayout(false);
            PnlCard.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel   PnlHeader;
        private System.Windows.Forms.Label   LblAppTitle;
        private System.Windows.Forms.Label   LblSubtitle;
        private System.Windows.Forms.Panel   PnlCard;
        private System.Windows.Forms.Label   LblFromBase;
        private System.Windows.Forms.Button  BtnFrom2;
        private System.Windows.Forms.Button  BtnFrom8;
        private System.Windows.Forms.Button  BtnFrom10;
        private System.Windows.Forms.Button  BtnFrom16;
        private System.Windows.Forms.Label   LblToBase;
        private System.Windows.Forms.Button  BtnTo2;
        private System.Windows.Forms.Button  BtnTo8;
        private System.Windows.Forms.Button  BtnTo10;
        private System.Windows.Forms.Button  BtnTo16;
        private System.Windows.Forms.Label   LblInput;
        private System.Windows.Forms.TextBox TxtInput;
        private System.Windows.Forms.Label   LblOutput;
        private System.Windows.Forms.TextBox TxtOutput;
        private System.Windows.Forms.Button  BtnConvert;
        private System.Windows.Forms.Button  BtnClear;
        private System.Windows.Forms.Button  BtnSwap;
        private ToolTip ToolTip1;
        private System.ComponentModel.IContainer components;
        public Label LbStatus;
    }
}
