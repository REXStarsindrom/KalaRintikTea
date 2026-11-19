using System;
using System.Drawing;
using System.Windows.Forms;
using KalaRintikTea.Helpers;
using KalaRintikTea.Models;
using KalaRintikTea.Models.Enums;

namespace KalaRintikTea.Forms
{
    public abstract class BaseForm : Form
    {
        public BaseForm()
        {
            SetFormDefaults();
        }

        protected virtual void SetFormDefaults()
        {
            this.Font = new Font("Segoe UI", 9.5f, FontStyle.Regular);
            this.BackColor = UIHelper.LatarKrem;
            this.ForeColor = UIHelper.TeksUtama;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1200, 800);
            this.MinimumSize = new Size(1024, 700);
            this.Text = "Kala Rintik Tea";

            try
            {
                string icoPath = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Resources", "logo.ico");
                if (System.IO.File.Exists(icoPath))
                {
                    this.Icon = new Icon(icoPath);
                }
            }
            catch
            {
                // Ignore icon loading errors if any
            }
        }

        public void ShowError(string message, string title = "Peringatan")
        {
            MessageBox.Show(this, message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void ShowInfo(string message, string title = "Informasi")
        {
            MessageBox.Show(this, message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool Confirm(string message, string title = "Konfirmasi")
        {
            return MessageBox.Show(this, message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        public bool RequireRole(Role role)
        {
            try
            {
                SessionManager.Instance.RequireRole(role);
                return true;
            }
            catch (Exception ex)
            {
                ShowError(ex.Message, "Akses Ditolak");
                OpenForm(new FormLogin());
                return false;
            }
        }

        protected void OpenForm(Form newForm)
        {
            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.Show();
            this.Close();
        }

        protected void NavigateTo(Form currentForm, Form targetForm)
        {
            targetForm.StartPosition = FormStartPosition.Manual;
            targetForm.Location = currentForm.Location;
            targetForm.Size = currentForm.Size;
            targetForm.WindowState = currentForm.WindowState;
            targetForm.Show();
            currentForm.Hide();
            targetForm.FormClosed += (s, e) =>
            {
                if (!currentForm.IsDisposed)
                    currentForm.Close();
            };
        }
    }
}
