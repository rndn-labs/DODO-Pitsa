using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DODO_Pitsa.Modules;
namespace DODO_Pitsa
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            Methods Methods = new Methods();
            GenForms GenForms = new GenForms();
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            Methods.GlobalVars.arr[Methods.GlobalVars.uid].login = reg_login.Text;
            Methods.GlobalVars.arr[Methods.GlobalVars.uid].pass = reg_pass.Text;
            Methods.GlobalVars.arr[Methods.GlobalVars.uid].name = fio.Text;
            Methods.GlobalVars.arr[Methods.GlobalVars.uid].addr = reg_addr.Text;
            Methods.GlobalVars.arr[Methods.GlobalVars.uid].phone = reg_tel.Text;

            Methods.GlobalVars.arr[Methods.GlobalVars.uid].u_id = Methods.GlobalVars.uid;
            Methods.GlobalVars.uid++;
            this.Visible = false;
            MessageBox.Show("Регистрация завершена", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

        }
    }
}
