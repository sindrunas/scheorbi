using System;
using System.Configuration;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArduinoDriver;
using ArduinoDriver.SerialProtocol;
using ArduinoUploader.Hardware;

namespace Scheorbi
{
    public partial class MainForm : Form
    {
        private static string _puertoCom;
        private static int _tiempoApertura;
        private static bool _relayUno;
        private static bool _relayDos;
        private KeyHandler ghk;

        public MainForm()
        {
            InitializeComponent();
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            ShowInTaskbar = false;

            _puertoCom = ConfigurationManager.AppSettings["puerto"];
            _tiempoApertura = int.Parse(ConfigurationManager.AppSettings["tiempoApertura"]);
            _relayUno = bool.Parse(ConfigurationManager.AppSettings["relayUnoActivado"]);
            _relayDos = bool.Parse(ConfigurationManager.AppSettings["relayDosActivado"]);
            var tecla = ConfigurationManager.AppSettings["teclaTimbre"];
            ghk = new KeyHandler(KeyHandler.StringToKey(tecla), this);
            ghk.Register();

            lblTeclaHolder.Text = $"{tecla}";
            lblSegundosHolder.Text = $"{_tiempoApertura} segs";
        }

        private bool allowVisible;
        private bool allowClose;
        private bool relayWorking;

        protected override void SetVisibleCore(bool value)
        {
            if (!allowVisible)
            {
                value = false;
                if (!this.IsHandleCreated) CreateHandle();
            }
            base.SetVisibleCore(value);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!allowClose)
            {
                this.Hide();
                e.Cancel = true;
            }
            base.OnFormClosing(e);
        }

        private void btnTimbre_Click(object sender, EventArgs e)
        {
            if (!relayWorking)
            {
                ActivarRelay();
            }
        }

        private void ActivarRelay()
        {
            Invoke(new MethodInvoker(delegate
            {
                btnTimbre.Enabled = false;
            }));

            relayWorking = true;
            try
            {
                using (var driver = new ArduinoDriver.ArduinoDriver(ArduinoModel.NanoR3, _puertoCom, true))
                {

                    if (_relayUno) driver.Send(new PinModeRequest(2, PinMode.Output));
                    if (_relayDos) driver.Send(new PinModeRequest(3, PinMode.Output));
                    if (_relayUno) driver.Send(new DigitalWriteRequest(2, DigitalValue.Low));
                    if (_relayDos) driver.Send(new DigitalWriteRequest(3, DigitalValue.Low));
                    Thread.Sleep(_tiempoApertura * 1000);
                    if (_relayUno) driver.Send(new DigitalWriteRequest(2, DigitalValue.High));
                    if (_relayDos) driver.Send(new DigitalWriteRequest(3, DigitalValue.High));
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"No se detectó un Schoerbi-device conectado al puerto {_puertoCom}", @"Error de comunicación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            relayWorking = false;

            Invoke(new MethodInvoker(delegate {
                btnTimbre.Enabled = true;
            }));
        }
        
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Constants.WM_HOTKEY_MSG_ID && !relayWorking)
            {
                new Task(ActivarRelay).Start();
            }

            base.WndProc(ref m);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allowClose = true;
            Application.Exit();
        }

        private void verVentanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allowVisible = true;
            Show();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            allowVisible = true;
            Show();
        }
    }
}
