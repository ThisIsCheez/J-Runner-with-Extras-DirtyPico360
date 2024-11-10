using System;
using System.Collections;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace JRunner.Forms
{
    public partial class CPUKeyGenGUI : Form
    {
        public CPUKeyGenGUI()
        {
            InitializeComponent();
        }

        private void txtGenKey_TextChanged(object sender, EventArgs e)
        {
            if (txtGenKey.TextLength > 0) btnInsertKey.Enabled = true;
            else btnInsertKey.Enabled = false;
        }

        private void btnGenKey_Click(object sender, EventArgs e)
        {
            if ((ModifierKeys & Keys.Shift) == Keys.Shift) txtGenKey.Text = variables.superDevKey;
            else txtGenKey.Text = CpuKeyGen.GenerateKey();
        }

        private void btnInsertKey_Click(object sender, EventArgs e)
        {
            MainForm.mainForm.updateCpuKeyText(txtGenKey.Text);
            this.Close();
        }
    }
}
