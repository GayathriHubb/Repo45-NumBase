using System;
using System.Drawing;
using System.Windows.Forms;

namespace NumberBaseConverter
{
    public partial class FormNumBase : Form
    {
        private int SelectedFromBase = 10;
        private int SelectedToBase   = 2;

        public FormNumBase()
        {
            InitializeComponent();
            ApplyTheme();
            WireBaseButtons();
        }

        private void ApplyTheme()
        {
            BackColor = ThemeColors.Background;

            PnlHeader.BackColor   = ThemeColors.Surface;
            LblAppTitle.ForeColor = ThemeColors.Accent;
            LblSubtitle.ForeColor = ThemeColors.TextSecondary;

            PnlCard.BackColor     = ThemeColors.SurfaceCard;

            LblFromBase.ForeColor = ThemeColors.TextSecondary;
            LblToBase.ForeColor   = ThemeColors.TextSecondary;
            LblInput.ForeColor    = ThemeColors.TextSecondary;
            LblOutput.ForeColor   = ThemeColors.TextSecondary;

            TxtInput.BackColor    = ThemeColors.Surface;
            TxtInput.ForeColor    = ThemeColors.TextPrimary;
            TxtInput.BorderStyle  = BorderStyle.FixedSingle;

            TxtOutput.BackColor   = ThemeColors.Surface;
            TxtOutput.ForeColor   = ThemeColors.Accent;
            TxtOutput.BorderStyle = BorderStyle.FixedSingle;

            LbStatus.ForeColor   = ThemeColors.TextSecondary;

            StyleBaseButton(BtnFrom2,  "Binary (2)");
            StyleBaseButton(BtnFrom8,  "Octal (8)");
            StyleBaseButton(BtnFrom10, "Decimal (10)");
            StyleBaseButton(BtnFrom16, "Hex (16)");

            StyleBaseButton(BtnTo2,    "Binary (2)");
            StyleBaseButton(BtnTo8,    "Octal (8)");
            StyleBaseButton(BtnTo10,   "Decimal (10)");
            StyleBaseButton(BtnTo16,   "Hex (16)");

            StyleConvertButton(BtnConvert);
            StyleSecondaryButton(BtnClear);
            StyleSecondaryButton(BtnSwap);

            SetActiveFromBase(BtnFrom10);
            SetActiveToBase(BtnTo2);
        }

        private void StyleBaseButton(Button Btn, string Text)
        {
            Btn.Text                        = Text;
            Btn.FlatStyle                   = FlatStyle.Flat;
            Btn.FlatAppearance.BorderColor  = ThemeColors.BorderColor;
            Btn.FlatAppearance.BorderSize   = 1;
            Btn.BackColor                   = ThemeColors.Surface;
            Btn.ForeColor                   = ThemeColors.TextSecondary;
            Btn.Cursor                      = Cursors.Hand;
            Btn.Font                        = new Font("Segoe UI", 8.5f);
        }

        private void StyleConvertButton(Button Btn)
        {
            Btn.FlatStyle                   = FlatStyle.Flat;
            Btn.FlatAppearance.BorderSize   = 0;
            Btn.BackColor                   = ThemeColors.Accent;
            Btn.ForeColor                   = ThemeColors.Surface;
            Btn.Cursor                      = Cursors.Hand;
            Btn.Font                        = new Font("Segoe UI Semibold", 10f);
        }

        private void StyleSecondaryButton(Button Btn)
        {
            Btn.FlatStyle                        = FlatStyle.Flat;
            Btn.FlatAppearance.BorderColor       = ThemeColors.BorderColor;
            Btn.FlatAppearance.BorderSize        = 1;
            Btn.BackColor                        = ThemeColors.Surface;
            Btn.ForeColor                        = ThemeColors.TextSecondary;
            Btn.Cursor                           = Cursors.Hand;
            Btn.Font                             = new Font("Segoe UI", 9f);
        }

        private void WireBaseButtons()
        {
            BtnFrom2.Click  += BtnFrom_Click;
            BtnFrom8.Click  += BtnFrom_Click;
            BtnFrom10.Click += BtnFrom_Click;
            BtnFrom16.Click += BtnFrom_Click;

            BtnTo2.Click    += BtnTo_Click;
            BtnTo8.Click    += BtnTo_Click;
            BtnTo10.Click   += BtnTo_Click;
            BtnTo16.Click   += BtnTo_Click;
        }

        private void BtnFrom_Click(object Sender, EventArgs E)
        {
            SetActiveFromBase((Button)Sender);
            PerformConversion();
        }

        private void BtnTo_Click(object Sender, EventArgs E)
        {
            SetActiveToBase((Button)Sender);
            PerformConversion();
        }

        private void SetActiveFromBase(Button Active)
        {
            Button[] All = { BtnFrom2, BtnFrom8, BtnFrom10, BtnFrom16 };
            int[]    Bases = { 2, 8, 10, 16 };
            ActivateButton(Active, All, Bases, ref SelectedFromBase);
        }

        private void SetActiveToBase(Button Active)
        {
            Button[] All = { BtnTo2, BtnTo8, BtnTo10, BtnTo16 };
            int[]    Bases = { 2, 8, 10, 16 };
            ActivateButton(Active, All, Bases, ref SelectedToBase);
        }

        private static void ActivateButton(Button Active, Button[] All, int[] Bases, ref int Selected)
        {
            for (int I = 0; I < All.Length; I++)
            {
                if (All[I] == Active)
                {
                    All[I].BackColor                  = ThemeColors.Accent;
                    All[I].ForeColor                  = ThemeColors.Surface;
                    All[I].FlatAppearance.BorderColor = ThemeColors.Accent;
                    Selected                          = Bases[I];
                }
                else
                {
                    All[I].BackColor                  = ThemeColors.Surface;
                    All[I].ForeColor                  = ThemeColors.TextSecondary;
                    All[I].FlatAppearance.BorderColor = ThemeColors.BorderColor;
                }
            }
        }

        private void TxtInput_TextChanged(object Sender, EventArgs E)
        {
            PerformConversion();
        }

        private void BtnConvert_Click(object Sender, EventArgs E)
        {
            PerformConversion();
        }

        private void PerformConversion()
        {
            string Input = TxtInput.Text.Trim();

            if (string.IsNullOrWhiteSpace(Input))
            {
                TxtOutput.Text    = string.Empty;
                LbStatus.Text    = "Enter a value to convert..";
                LbStatus.ForeColor = ThemeColors.TextSecondary;
                return;
            }

            if (!ConversionService.IsValidInput(Input, SelectedFromBase))
            {
                TxtOutput.Text      = string.Empty;
                LbStatus.Text      = $"Invalid input for base {SelectedFromBase}";
                LbStatus.ForeColor = ThemeColors.Error;
                return;
            }

            try
            {
                string Result       = ConversionService.Convert(Input, SelectedFromBase, SelectedToBase);
                TxtOutput.Text      = Result;
                LbStatus.Text      = $"Converted from Base {SelectedFromBase} → Base {SelectedToBase}";
                LbStatus.ForeColor = ThemeColors.Success;
            }
            catch (Exception Ex)
            {
                LbStatus.Text      = $"Error: {Ex.Message}";
                LbStatus.ForeColor = ThemeColors.Error;
            }
        }

        private void BtnClear_Click(object Sender, EventArgs E)
        {
            TxtInput.Clear();
            TxtOutput.Clear();
            LbStatus.Text      = "Enter a value to convert..";
            LbStatus.ForeColor = ThemeColors.TextSecondary;
            TxtInput.Focus();
        }

        private void BtnSwap_Click(object Sender, EventArgs E)
        {
            int Temp       = SelectedFromBase;
            SelectedFromBase = SelectedToBase;
            SelectedToBase   = Temp;

            SetActiveFromBase(GetButtonForBase(SelectedFromBase, new[] { BtnFrom2, BtnFrom8, BtnFrom10, BtnFrom16 }, new[] { 2, 8, 10, 16 }));
            SetActiveToBase(GetButtonForBase(SelectedToBase,     new[] { BtnTo2,   BtnTo8,   BtnTo10,   BtnTo16   }, new[] { 2, 8, 10, 16 }));

            string Temp2   = TxtInput.Text;
            TxtInput.Text  = TxtOutput.Text;
            TxtOutput.Text = Temp2;

            PerformConversion();
        }

        private Button GetButtonForBase(int Base, Button[] Buttons, int[] Bases)
        {
            for (int I = 0; I < Bases.Length; I++)
            {
                if (Bases[I] == Base) { return Buttons[I]; }
            }
            return Buttons[0];
        }
    }
}
