using System;
using System.Drawing;
using System.Windows.Forms;

namespace KalaRintikTea.Helpers
{
    public class InputDialog : Form
    {
        private TextBox _txtInput = new();
        public string InputValue => _txtInput.Text;

        public InputDialog(string prompt, string judul, string nilaiAwal = "")
        {
            this.Text            = judul;
            this.Size            = new Size(440, 210);
            this.StartPosition   = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox     = false;
            this.BackColor       = UIHelper.LatarKrem;

            var lbl = new Label { Text = prompt, Location = new Point(20, 20), AutoSize = true, Font = new Font("Segoe UI", 10.5f) };
            _txtInput = new TextBox { Text = nilaiAwal, Location = new Point(20, 52), Size = new Size(380, 30), Font = new Font("Segoe UI", 11f) };

            var btnOk = UIHelper.BuatTombol("OK", UIHelper.HijauUtama, Color.White, 110, 38);
            btnOk.Location        = new Point(20, 102);
            btnOk.DialogResult    = DialogResult.OK;
            this.AcceptButton     = btnOk;

            var btnCancel = UIHelper.BuatTombol("Batal", Color.FromArgb(130, 130, 130), Color.White, 110, 38);
            btnCancel.Location     = new Point(140, 102);
            btnCancel.DialogResult = DialogResult.Cancel;
            this.CancelButton      = btnCancel;

            this.Controls.AddRange(new Control[] { lbl, _txtInput, btnOk, btnCancel });
        }
    }
}
