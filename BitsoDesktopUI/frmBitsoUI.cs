using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BitsoConnectorLibrary;

namespace BitsoDesktopUI
{
    public partial class frmBitsoUI : Form
    {
        BitsoAPIConnector _apiConnector;
        CurrencyPair _selectedCurrency;

        public frmBitsoUI(string key, string secret)
        {
            InitializeComponent();
           
            _apiConnector = new BitsoAPIConnector(key, secret);   
        }

        private void timerCalls_Tick(object sender, EventArgs e)
        {
            this.Text = string.Format("Bitso UI : Llamadas a API -> {0} El contador de llamadas a la API se reinicia cada 5 minutos", 
            _apiConnector.CallsCounter.ToString());
        }

        private void timerUI_Tick(object sender, EventArgs e)
        {
            Ticker tickerInfo = null;
            try
            {
                tickerInfo = _apiConnector.GetTickerInfo(_selectedCurrency);
            }
            catch (Exception ex)
            {
                ShowException(ex);
                
            }
            
            
            lblAsk.Text = "Ask : " + tickerInfo.ask;
            lblBid.Text = "Bid : " + tickerInfo.bid;
            lblLast.Text = "Last : " + tickerInfo.last;
            lblHigh.Text = "High : " + tickerInfo.high;
            lblLow.Text = "Low : " + tickerInfo.low;
            lblVolume.Text = "Volume : " + Convert.ToDecimal(tickerInfo.volume).ToString("0.000000");
           
        }

        private void timerBalances_Tick(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedIndex > 0)
            {
                LlenarBalances();
            }
        }

        private void LlenarBalances()
        {
            List<Balance> AccountBalancesList = _apiConnector.GetAccountBalances();

            Balance balanceMXN = AccountBalancesList.FirstOrDefault(x => x.currency == "mxn");

            lblLibreMXN.Text = balanceMXN.available;
            lblOrdenesMXN.Text = balanceMXN.locked;
            lblTotalMXN.Text = balanceMXN.total;

            string major = _selectedCurrency.ToString().Split('_')[0].ToUpper();

            Balance balanceCRP = AccountBalancesList.FirstOrDefault(x => x.currency == major.ToLower());

            lblLibreCRP.Text = balanceCRP.available;
            lblOrdenesCRP.Text = balanceCRP.locked;
            lblTotalCRP.Text = balanceCRP.total;

            gpCRP.Text = major;
        }

        private void timerOrders_Tick(object sender, EventArgs e)
        {
            if(cmbTipo.SelectedIndex > 0)
            {
                List<OpenOrder> OpenOrdersList = _apiConnector.GetOpenOrders(_selectedCurrency);
                LlenarOrdenes(OpenOrdersList);
            }
            
        }

        private void frmBitsoUI_Load(object sender, EventArgs e)
        {
            dgvOrdenes.AutoGenerateColumns = false;
            cmbMercado.DataSource = Enum.GetValues(typeof(CurrencyPair));
            cmbMercado.SelectedIndex = 0;
            cmbTipo.SelectedIndex = 0;
            timerCalls.Start();
            timerUI.Start();
            timerOrders.Start();
            timerBalances.Start();
        }

        private void cmbMercado_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse<CurrencyPair>(cmbMercado.SelectedValue.ToString(), out _selectedCurrency);
            _apiConnector._currency = _selectedCurrency;
            timerUI_Tick(sender, e);

            cmbTipo.SelectedIndex = 0;

            try
            {
                List<OpenOrder> OpenOrdersList = _apiConnector.GetOpenOrders(_selectedCurrency);
                LlenarOrdenes(OpenOrdersList);
                LlenarBalances();
            }
            catch (Exception ex)
            {
                ShowException(ex);
                frmAuth formAuth = new frmAuth();
                formAuth.Show();
                this.Close();
            }
            
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool enable = cmbTipo.SelectedIndex > 0;
            rbMajor.Enabled = enable;
            rbMinor.Enabled = enable;
            txtMonto.Enabled = enable;
            txtPrecio.Enabled = enable;
            btnOrdenar.Enabled = enable;
            lblMonto.Enabled = enable;
            lblPrecio.Enabled = enable;
            lblTotal.Enabled = enable;
            txtTotal.Enabled = enable;

            txtTotal.Text = "";
            txtPrecio.Text = "";
            txtMonto.Text = "";
            lblTotal.Text = "Total ";
            if(enable)
            {
                string major = cmbMercado.SelectedValue.ToString().Split('_')[0].ToUpper();
                string minor = cmbMercado.SelectedValue.ToString().Split('_')[1].ToUpper();
                gpOperar.Text = cmbTipo.SelectedItem.ToString() + " " + major;

                rbMajor.Text = major;
                rbMinor.Text = minor;

                rbMajor.Checked = true;
            }
            else
            {
                gpOperar.Text = "";

                rbMajor.Text = "";
                rbMinor.Text = "";
            }
                
        }
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            string major = rbMajor.Checked ? txtMonto.Text : txtTotal.Text;
            string minor = null;//rbMinor.Checked ? txtMonto.Text : null;
            Order PlacedOrder = null;
            try
            {
                if (cmbTipo.SelectedItem.ToString() == "Comprar")
                {
                    PlacedOrder = _apiConnector.PlaceBuyOrder(major, minor, txtPrecio.Text);
                }
                else
                {
                    PlacedOrder = _apiConnector.PlaceSellOrder(major, minor, txtPrecio.Text);
                }

                List<OpenOrder> OpenOrdersList = _apiConnector.GetOpenOrders(_selectedCurrency);
                LlenarOrdenes(OpenOrdersList);
            }
            catch (Exception ex)
            {
                ShowException(ex);
            }
           
            
        }

        private void ShowException(Exception ex)
        {
            MessageBox.Show(ex.Message, "Bitso API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LlenarOrdenes(List<OpenOrder> OpenOrdersList)
        {
            dgvOrdenes.Rows.Clear();
            foreach (var order in OpenOrdersList)
            {
                dgvOrdenes.Rows.Add(
                    order.oid,
                    order.original_amount,
                    order.unfilled_amount,
                    order.original_value,
                    order.price,
                    order.side,
                    order.status,
                    order.type,
                    order.created_at,
                    order.updated_at,
                    ""
                    );
            }
        }
        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void txtMonto_TextChanged_1(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            decimal precio;
            decimal monto;
            Decimal.TryParse(txtPrecio.Text, out precio);
            Decimal.TryParse(txtMonto.Text, out monto);

            if (rbMajor.Checked)
            {
                txtTotal.Text = (monto * precio).ToString("0.00000000");
                lblTotal.Text = "Total " + rbMinor.Text;
            }
            else
            {
                if (precio > 0M)
                {
                    txtTotal.Text = (monto / precio).ToString("0.000000");
                    lblTotal.Text = "Total " + rbMajor.Text;
                }  
            }
        }

        private void gpOperar_Enter(object sender, EventArgs e)
        {

        }

        private void dgvOrdenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            //Eliminar
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 10)
            {
                string orderID = senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString();

                try
                {
                    CancelOrder cancelOrder = _apiConnector.CancelOrderByID(orderID);
                    Console.WriteLine("");
                }
                catch (Exception ex)
                {
                    ShowException(ex);
                }
            }
        }

        private void rbMajor_CheckedChanged(object sender, EventArgs e)
        {
            txtMonto.Text = "";
            txtPrecio.Text = "";
            txtTotal.Text = "";
            if (rbMajor.Checked)
            {
                lblTotal.Text = "Total " + rbMinor.Text;
            }
            else
            {
                lblTotal.Text = "Total " + rbMajor.Text;
            }
        }

        private void gpMXN_Enter(object sender, EventArgs e)
        {

        }

        private void frmBitsoUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
