using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCuentas_Unidad1_
{
    public partial class FormNuevoMovimiento : Form
    {
        ClassMovimientosAux cuentasNuevoMovimiento;
        ClassMovimientos guardarNuevoMovimiento;

        public FormNuevoMovimiento()
        {
            InitializeComponent();
        }

        private void FormNuevoMovimiento_Load(object sender, EventArgs e)
        {
            guardarNuevoMovimiento = new ClassMovimientos();

            ClassCuentasAC.listaActivosCorrientes.Clear();
            ClassCuentasANC.listaActivosNoCorrientes.Clear();
            ClassCuentasPC.listaPasivosCorrientes.Clear();
            ClassCuentasPNC.listaPasivosNoCorrientes.Clear();
            ClassMovimientos.listaMovimientos.Clear();

            ClassCuentasAC.leerJson();
            ClassCuentasANC.leerJson();
            ClassCuentasPC.leerJson();
            ClassCuentasPNC.leerJson();
            ClassMovimientos.leerJson();

            foreach (var x in ClassCuentasAC.listaActivosCorrientes)
            {
                CBoxInDebe.Items.Add(x.nombre);
                CBoxInHaber.Items.Add(x.nombre);
            }
            foreach (var x in ClassCuentasANC.listaActivosNoCorrientes)
            {
                CBoxInDebe.Items.Add(x.nombre);
                CBoxInHaber.Items.Add(x.nombre);
            }
            foreach (var x in ClassCuentasPC.listaPasivosCorrientes)
            {
                CBoxInDebe.Items.Add(x.nombre);
                CBoxInHaber.Items.Add(x.nombre);
            }
            foreach (var x in ClassCuentasPNC.listaPasivosNoCorrientes)
            {
                CBoxInDebe.Items.Add(x.nombre);
                CBoxInHaber.Items.Add(x.nombre);
            }

            TBoxInMontoDebe.Enabled = true;
            TBoxInMontoHaber.Enabled = true;
        }

        private void BtnGuardarNuevaCuenta_Click(object sender, EventArgs e)
        {
            string nombreCuentaNueva = TBoxNombreCuentaNueva.Text.ToString();

            if (CBoxNewTipoCuenta.SelectedIndex == 0)
            {
                ClassCuentasAC cuenta = new ClassCuentasAC();
                cuenta.nombre = nombreCuentaNueva;
                ClassCuentasAC.listaActivosCorrientes.Add(cuenta);
                ClassCuentasAC.guardarenJson();
            }
            else if (CBoxNewTipoCuenta.SelectedIndex == 1)
            {
                ClassCuentasANC cuenta = new ClassCuentasANC();
                cuenta.nombre = nombreCuentaNueva;
                ClassCuentasANC.listaActivosNoCorrientes.Add(cuenta);
                ClassCuentasANC.guardarenJson();
            }
            if (CBoxNewTipoCuenta.SelectedIndex == 2)
            {
                ClassCuentasPC cuenta = new ClassCuentasPC();
                cuenta.nombre = nombreCuentaNueva;
                ClassCuentasPC.listaPasivosCorrientes.Add(cuenta);
                ClassCuentasPC.guardarenJson();
            }
            if (CBoxNewTipoCuenta.SelectedIndex == 3)
            {
                ClassCuentasPNC cuenta = new ClassCuentasPNC();
                cuenta.nombre = nombreCuentaNueva;
                ClassCuentasPNC.listaPasivosNoCorrientes.Add(cuenta);
                ClassCuentasPNC.guardarenJson();
            }
            CBoxNewTipoCuenta.Visible = false;
            TBoxNombreCuentaNueva.Visible = false;
            BtnGuardarNuevaCuenta.Visible = false;

        }

        private void BtnGuardarDebe_Click(object sender, EventArgs e)
        {
            string cuentaSelect = CBoxInDebe.Text;
            ClassCuentasAC cuentaUsadaAC = ClassCuentasAC.listaActivosCorrientes.Find(x => x.nombre == cuentaSelect);
            if (cuentaUsadaAC != null)
                cuentaUsadaAC.saldo += Convert.ToDouble(TBoxInMontoDebe.Text);
            ClassCuentasAC.guardarenJson();

            ClassCuentasANC cuentaUsadaANC = ClassCuentasANC.listaActivosNoCorrientes.Find(x => x.nombre == cuentaSelect);
            if (cuentaUsadaANC != null)
                cuentaUsadaANC.saldo += Convert.ToDouble(TBoxInMontoDebe.Text);
            ClassCuentasANC.guardarenJson();

            ClassCuentasPC cuentaUsadaPC = ClassCuentasPC.listaPasivosCorrientes.Find(x => x.nombre == cuentaSelect);
            if (cuentaUsadaPC != null)
                cuentaUsadaPC.saldo += Convert.ToDouble(TBoxInMontoDebe.Text);
            ClassCuentasPC.guardarenJson();

            ClassCuentasPNC cuentaUsadaPNC = ClassCuentasPNC.listaPasivosNoCorrientes.Find(x => x.nombre == cuentaSelect);
            if (cuentaUsadaPNC != null)
                cuentaUsadaPNC.saldo += Convert.ToDouble(TBoxInMontoDebe.Text);
            ClassCuentasPNC.guardarenJson();

            cuentasNuevoMovimiento = new ClassMovimientosAux();
            cuentasNuevoMovimiento.Cuenta = CBoxInDebe.Text.ToString();
            cuentasNuevoMovimiento.Debe = Convert.ToDouble(TBoxInMontoDebe.Text.ToString());
            guardarNuevoMovimiento.listaCuentasInvolucradas.Add(cuentasNuevoMovimiento);

        }

        private void BtnGuardarHaber_Click(object sender, EventArgs e)
        {
            string cuentaSelect = CBoxInHaber.Text;
            ClassCuentasAC cuentaUsadaAC = ClassCuentasAC.listaActivosCorrientes.Find(x => x.nombre == cuentaSelect);
            if (cuentaUsadaAC != null)
                cuentaUsadaAC.saldo -= Convert.ToDouble(TBoxInMontoHaber.Text);
            ClassCuentasAC.guardarenJson();

            ClassCuentasANC cuentaUsadaANC = ClassCuentasANC.listaActivosNoCorrientes.Find(x => x.nombre == cuentaSelect);
            if (cuentaUsadaANC != null)
                cuentaUsadaANC.saldo -= Convert.ToDouble(TBoxInMontoHaber.Text);
            ClassCuentasANC.guardarenJson();

            ClassCuentasPC cuentaUsadaPC = ClassCuentasPC.listaPasivosCorrientes.Find(x => x.nombre == cuentaSelect);
            if (cuentaUsadaPC != null)
                cuentaUsadaPC.saldo -= Convert.ToDouble(TBoxInMontoHaber.Text);
            ClassCuentasPC.guardarenJson();

            ClassCuentasPNC cuentaUsadaPNC = ClassCuentasPNC.listaPasivosNoCorrientes.Find(x => x.nombre == cuentaSelect);
            if (cuentaUsadaPNC != null)
                cuentaUsadaPNC.saldo -= Convert.ToDouble(TBoxInMontoHaber.Text);
            ClassCuentasPNC.guardarenJson();

            cuentasNuevoMovimiento = new ClassMovimientosAux();
            cuentasNuevoMovimiento.Cuenta = CBoxInDebe.Text.ToString();
            cuentasNuevoMovimiento.Haber = Convert.ToDouble(TBoxInMontoHaber.Text.ToString());
            guardarNuevoMovimiento.listaCuentasInvolucradas.Add(cuentasNuevoMovimiento);



        }

        private void BtnFinMovimiento_Click(object sender, EventArgs e)
        {
            ClassMovimientos.listaMovimientos.Add(guardarNuevoMovimiento);
            ClassMovimientos.guardarenJson();
            TBoxInMontoDebe.Enabled = false;
            TBoxInMontoHaber.Enabled = false;
            CBoxInDebe.Enabled = false;
            CBoxInHaber.Enabled = false;
        }

        private void BtnNuevaCuenta_Click(object sender, EventArgs e)
        {
            CBoxNewTipoCuenta.Visible = true;
            TBoxNombreCuentaNueva.Visible = true;
            BtnGuardarNuevaCuenta.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            guardarNuevoMovimiento=new ClassMovimientos();
            TBoxInMontoDebe.Clear();
            TBoxInMontoHaber.Clear();
            CBoxInDebe.SelectedItem = null;
            CBoxInHaber.SelectedItem = null;
            TBoxInMontoDebe.Enabled = true;
            TBoxInMontoHaber.Enabled = true;
            CBoxInDebe.Enabled = true;
            CBoxInHaber.Enabled = true;
        }
    }
}
