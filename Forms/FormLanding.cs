using System;
using System.Windows.Forms;

namespace KalaRintikTea.Forms
{
    public partial class FormLanding : BaseForm
    {
        public FormLanding()
        {
            InitializeComponent();
            btnMasuk.Click += BtnMasuk_Click;
            btnDaftar.Click += BtnDaftar_Click;
        }

        private void BtnMasuk_Click(object? sender, EventArgs e)
        {
            NavigateTo(this, new FormLogin());
        }

        private void BtnDaftar_Click(object? sender, EventArgs e)
        {
            NavigateTo(this, new FormRegister());
        }
    }
}
