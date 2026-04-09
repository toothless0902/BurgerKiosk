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
            this.CancelButton = btnInit;
            this.AcceptButton = btnOrder; 
        }

        
        private void UpdateOrderInfo()
        {
            int totalCost = 0;
            lstOrder.Items.Clear();

            
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
            else
            {
                
                lblTotalCost.Text = "메뉴를 선택하세요.";
                lblTotalCost.ForeColor = Color.Red;
                return;
            }

           
            lblTotalCost.ForeColor = Color.Blue; 
            if (chkPotato.Checked) { totalCost += 3500; lstOrder.Items.Add("감자튀김 3,500원"); }
            if (chkCola.Checked) { totalCost += 2500; lstOrder.Items.Add("콜라 2,500원"); }
            if (chkCheese.Checked) { totalCost += 1500; lstOrder.Items.Add("치즈 추가 1,500원"); }
            if (chkSauce.Checked) { totalCost += 500; lstOrder.Items.Add("소스 추가 500원"); }

            
            lblTotalCost.Text = "총 금액 : " + totalCost.ToString("N0") + "원";
        }

        
        private void MenuOption_Changed(object sender, EventArgs e)
        {
            UpdateOrderInfo();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            
            if (rdoBulgogiBurger.Checked || rdoCheeseBurger.Checked || rdoChickenBurger.Checked)
            {
                MessageBox.Show(lblTotalCost.Text + " 주문이 완료되었습니다!");
            }
            else
            {
                UpdateOrderInfo(); 
            }
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
            lblTotalCost.ForeColor = Color.Black;
        }

        // Track current indices inside groups so arrow keys can navigate without moving tab focus.
        private int menuIndex = 0;
        private int optionIndex = 0;

        private void grpMenu_Enter(object? sender, EventArgs e)
        {
            if (rdoBulgogiBurger.Checked) menuIndex = 0;
            else if (rdoChickenBurger.Checked) menuIndex = 1;
            else if (rdoCheeseBurger.Checked) menuIndex = 2;
            else menuIndex = 0;
        }

        private void grpOption_Enter(object? sender, EventArgs e)
        {
            // start at first option
            optionIndex = 0;
        }

        private void grpMenu_KeyDown(object? sender, KeyEventArgs e)
        {
            // 0: Bulgogi, 1: Chicken, 2: Cheese
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Right)
            {
                menuIndex = (menuIndex + 1) % 3;
                SetMenuByIndex(menuIndex);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Left)
            {
                menuIndex = (menuIndex - 1 + 3) % 3;
                SetMenuByIndex(menuIndex);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Enter)
            {
                SetMenuByIndex(menuIndex);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void grpOption_KeyDown(object? sender, KeyEventArgs e)
        {
            Control[] items = new Control[] { chkPotato, chkCola, chkCheese, chkSauce };

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Right)
            {
                optionIndex = (optionIndex + 1) % items.Length;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Left)
            {
                optionIndex = (optionIndex - 1 + items.Length) % items.Length;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Enter)
            {
                var cb = items[optionIndex] as CheckBox;
                if (cb != null) cb.Checked = !cb.Checked;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void SetMenuByIndex(int idx)
        {
            switch (idx)
            {
                case 0:
                    rdoBulgogiBurger.Checked = true;
                    break;
                case 1:
                    rdoChickenBurger.Checked = true;
                    break;
                case 2:
                    rdoCheeseBurger.Checked = true;
                    break;
            }
            UpdateOrderInfo();
        }
    }
}