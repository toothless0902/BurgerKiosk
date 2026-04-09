namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            rdoBulgogiBurger.Checked = false;
            rdoCheeseBurger.Checked = false;
            rdoChickenBurger.Checked = false;
            this.ActiveControl = lblAppName;
        }
        
        private void btnOrder_Click(object sender, EventArgs e)
        {
            

            int totalCost = 0;
            lstOrder.Items.Clear();
            lblTotalCost.ForeColor = Color.Blue;
            if (rdoCheeseBurger.Checked)
            {
                totalCost += 5000;
                lstOrder.Items.Add("치즈버거 5,000원");
            }
            else if (rdoBulgogiBurger.Checked)
            {
                totalCost += 4000;
                lstOrder.Items.Add("불고기 버거 4,000원");
            }
            else if (rdoChickenBurger.Checked)
            {
                totalCost += 3000;
                lstOrder.Items.Add("치킨 버거 3,000원");
            }
            if (chkPotato.Checked)
            {
                totalCost += 3500;
                lstOrder.Items.Add("감자튀김3,500원");
            }
            if (chkCola.Checked)
            {
                totalCost += 2500;
                lstOrder.Items.Add("콜라 2,500원");
            }
            if (chkCheese.Checked)
            {
                totalCost += 1500;
                lstOrder.Items.Add("치즈 추가 1,500원");
            }
            if (chkSauce.Checked)
            {
                totalCost += 500;
                lstOrder.Items.Add("소스 추가 500원");
            }

            lblTotalCost.Text = "총 금액 : " + totalCost.ToString("N0") + "원";


        }


        private void btnInit_Click(object sender, EventArgs e)
        {
            rdoCheeseBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;
            chkPotato.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;
            lstOrder.Items.Clear();
            lblTotalCost.Text = "총 금액 : ";

        }
    }
}
