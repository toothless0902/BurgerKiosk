namespace BurgerKiosk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblAppName = new Label();
            rdoCheeseBurger = new RadioButton();
            picBulgogi = new PictureBox();
            rdoBulgogiBurger = new RadioButton();
            rdoChickenBurger = new RadioButton();
            grpMenu = new GroupBox();
            picCheese = new PictureBox();
            picChicken = new PictureBox();
            grpOption = new GroupBox();
            chkSauce = new CheckBox();
            chkCheese = new CheckBox();
            chkCola = new CheckBox();
            chkPotato = new CheckBox();
            groupOrder = new GroupBox();
            lblTotalCost = new Label();
            lstOrder = new ListBox();
            btnOrder = new Button();
            btnInit = new Button();
            ((System.ComponentModel.ISupportInitialize)picBulgogi).BeginInit();
            grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCheese).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picChicken).BeginInit();
            grpOption.SuspendLayout();
            groupOrder.SuspendLayout();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("한컴 울주 천전리 각석체", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblAppName.ForeColor = Color.Blue;
            lblAppName.Location = new Point(12, 9);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(665, 85);
            lblAppName.TabIndex = 1;
            lblAppName.Text = "버거 주문 키오스크";
            // 
            // rdoCheeseBurger
            // 
            rdoCheeseBurger.AutoSize = true;
            rdoCheeseBurger.Font = new Font("맑은 고딕", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 129);
            rdoCheeseBurger.ForeColor = Color.Black;
            rdoCheeseBurger.Location = new Point(6, 501);
            rdoCheeseBurger.Name = "rdoCheeseBurger";
            rdoCheeseBurger.Size = new Size(214, 54);
            rdoCheeseBurger.TabIndex = 2;
            rdoCheeseBurger.TabStop = false;
            rdoCheeseBurger.Text = "치즈 버거";
            rdoCheeseBurger.UseVisualStyleBackColor = true;
            rdoCheeseBurger.CheckedChanged += MenuOption_Changed;
            // 
            // picBulgogi
            // 
            picBulgogi.Image = (Image)resources.GetObject("picBulgogi.Image");
            picBulgogi.Location = new Point(282, 110);
            picBulgogi.Name = "picBulgogi";
            picBulgogi.Size = new Size(200, 153);
            picBulgogi.SizeMode = PictureBoxSizeMode.Zoom;
            picBulgogi.TabIndex = 4;
            picBulgogi.TabStop = false;
            // 
            // rdoBulgogiBurger
            // 
            rdoBulgogiBurger.AutoSize = true;
            rdoBulgogiBurger.Font = new Font("맑은 고딕", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 129);
            rdoBulgogiBurger.ForeColor = Color.Black;
            rdoBulgogiBurger.Location = new Point(6, 149);
            rdoBulgogiBurger.Name = "rdoBulgogiBurger";
            rdoBulgogiBurger.Size = new Size(251, 54);
            rdoBulgogiBurger.TabIndex = 0;
            rdoBulgogiBurger.TabStop = false;
            rdoBulgogiBurger.Text = "불고기 버거";
            rdoBulgogiBurger.UseVisualStyleBackColor = true;
            rdoBulgogiBurger.CheckedChanged += MenuOption_Changed;
            // 
            // rdoChickenBurger
            // 
            rdoChickenBurger.AutoSize = true;
            rdoChickenBurger.Font = new Font("맑은 고딕", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 129);
            rdoChickenBurger.ForeColor = Color.Black;
            rdoChickenBurger.Location = new Point(6, 325);
            rdoChickenBurger.Name = "rdoChickenBurger";
            rdoChickenBurger.Size = new Size(214, 54);
            rdoChickenBurger.TabIndex = 1;
            rdoChickenBurger.TabStop = false;
            rdoChickenBurger.Text = "치킨 버거";
            rdoChickenBurger.UseVisualStyleBackColor = true;
            rdoChickenBurger.CheckedChanged += MenuOption_Changed;
            // 
            // grpMenu
            // 
            grpMenu.Controls.Add(picCheese);
            grpMenu.Controls.Add(picChicken);
            grpMenu.Controls.Add(rdoCheeseBurger);
            grpMenu.Controls.Add(rdoBulgogiBurger);
            grpMenu.Controls.Add(picBulgogi);
            grpMenu.Controls.Add(rdoChickenBurger);
            grpMenu.Font = new Font("한컴 울주 천전리 각석체", 16.1249981F, FontStyle.Regular, GraphicsUnit.Point, 129);
            grpMenu.ForeColor = Color.Red;
            grpMenu.Location = new Point(12, 163);
            grpMenu.Name = "grpMenu";
            grpMenu.Size = new Size(490, 654);
            grpMenu.TabIndex = 0;
            // Make the group box itself focusable so Tab lands on the group box.
            grpMenu.TabStop = true;
            grpMenu.KeyDown += grpMenu_KeyDown;
            grpMenu.Enter += grpMenu_Enter;
            grpMenu.Text = "메뉴 선택";
            // 
            // picCheese
            // 
            picCheese.Image = (Image)resources.GetObject("picCheese.Image");
            picCheese.Location = new Point(282, 450);
            picCheese.Name = "picCheese";
            picCheese.Size = new Size(200, 153);
            picCheese.SizeMode = PictureBoxSizeMode.Zoom;
            picCheese.TabIndex = 8;
            picCheese.TabStop = false;
            // 
            // picChicken
            // 
            picChicken.Image = (Image)resources.GetObject("picChicken.Image");
            picChicken.Location = new Point(282, 280);
            picChicken.Name = "picChicken";
            picChicken.Size = new Size(200, 153);
            picChicken.SizeMode = PictureBoxSizeMode.Zoom;
            picChicken.TabIndex = 7;
            picChicken.TabStop = false;
            // 
            // grpOption
            // 
            grpOption.Controls.Add(chkSauce);
            grpOption.Controls.Add(chkCheese);
            grpOption.Controls.Add(chkCola);
            grpOption.Controls.Add(chkPotato);
            grpOption.Font = new Font("한컴 울주 천전리 각석체", 16.1249981F, FontStyle.Regular, GraphicsUnit.Point, 129);
            grpOption.ForeColor = Color.Red;
            grpOption.Location = new Point(536, 163);
            grpOption.Name = "grpOption";
            grpOption.Size = new Size(347, 470);
            grpOption.TabIndex = 1;
            // Make the group box itself focusable so Tab lands on the group box.
            grpOption.TabStop = true;
            grpOption.KeyDown += grpOption_KeyDown;
            grpOption.Enter += grpOption_Enter;
            grpOption.Text = "추가 옵션";
            // 
            // chkSauce
            // 
            chkSauce.AutoSize = true;
            chkSauce.Font = new Font("맑은 고딕", 13.875F, FontStyle.Bold);
            chkSauce.ForeColor = Color.Black;
            chkSauce.Location = new Point(16, 358);
            chkSauce.Name = "chkSauce";
            chkSauce.Size = new Size(215, 54);
            chkSauce.TabIndex = 3;
            chkSauce.TabStop = false;
            chkSauce.Text = "소스 추가";
            chkSauce.UseVisualStyleBackColor = true;
            chkSauce.CheckedChanged += MenuOption_Changed;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.Font = new Font("맑은 고딕", 13.875F, FontStyle.Bold);
            chkCheese.ForeColor = Color.Black;
            chkCheese.Location = new Point(16, 283);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(215, 54);
            chkCheese.TabIndex = 2;
            chkCheese.TabStop = false;
            chkCheese.Text = "치즈 추가";
            chkCheese.UseVisualStyleBackColor = true;
            chkCheese.CheckedChanged += MenuOption_Changed;
            // 
            // chkCola
            // 
            chkCola.AutoSize = true;
            chkCola.Font = new Font("맑은 고딕", 13.875F, FontStyle.Bold);
            chkCola.ForeColor = Color.Black;
            chkCola.Location = new Point(16, 208);
            chkCola.Name = "chkCola";
            chkCola.Size = new Size(128, 54);
            chkCola.TabIndex = 1;
            chkCola.TabStop = false;
            chkCola.Text = "콜라";
            chkCola.UseVisualStyleBackColor = true;
            chkCola.CheckedChanged += MenuOption_Changed;
            // 
            // chkPotato
            // 
            chkPotato.AutoSize = true;
            chkPotato.Font = new Font("맑은 고딕", 13.875F, FontStyle.Bold);
            chkPotato.ForeColor = Color.Black;
            chkPotato.Location = new Point(16, 133);
            chkPotato.Name = "chkPotato";
            chkPotato.Size = new Size(202, 54);
            chkPotato.TabIndex = 0;
            chkPotato.TabStop = false;
            chkPotato.Text = "감자튀김";
            chkPotato.UseVisualStyleBackColor = true;
            chkPotato.CheckedChanged += MenuOption_Changed;
            // 
            // groupOrder
            // 
            groupOrder.Controls.Add(lblTotalCost);
            groupOrder.Controls.Add(lstOrder);
            groupOrder.Font = new Font("한컴 울주 천전리 각석체", 16.1249981F, FontStyle.Regular, GraphicsUnit.Point, 129);
            groupOrder.ForeColor = Color.Red;
            groupOrder.Location = new Point(913, 163);
            groupOrder.Name = "groupOrder";
            groupOrder.Size = new Size(551, 555);
            groupOrder.TabIndex = 4;
            groupOrder.TabStop = false;
            groupOrder.Text = "주문 내역";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Font = new Font("한컴 울주 천전리 각석체", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblTotalCost.ForeColor = Color.Blue;
            lblTotalCost.Location = new Point(6, 485);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(219, 54);
            lblTotalCost.TabIndex = 1;
            lblTotalCost.Text = "총 금액 : ";
            // 
            // lstOrder
            // 
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(6, 110);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(539, 347);
            lstOrder.TabIndex = 0;
            lstOrder.TabStop = false;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.Green;
            btnOrder.Font = new Font("한컴 울주 천전리 각석체", 17.9999981F);
            btnOrder.ForeColor = Color.Transparent;
            btnOrder.Location = new Point(913, 724);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(315, 93);
            btnOrder.TabIndex = 2;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnInit
            // 
            btnInit.BackColor = Color.Red;
            btnInit.Font = new Font("한컴 울주 천전리 각석체", 17.9999981F);
            btnInit.ForeColor = Color.Transparent;
            btnInit.Location = new Point(1252, 721);
            btnInit.Name = "btnInit";
            btnInit.Size = new Size(212, 96);
            btnInit.TabIndex = 3;
            btnInit.Text = "초기화";
            btnInit.UseVisualStyleBackColor = false;
            btnInit.Click += btnInit_Click;
            // 
            // Form1
            // 
            AcceptButton = btnOrder;
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1476, 881);
            Controls.Add(btnInit);
            Controls.Add(btnOrder);
            Controls.Add(groupOrder);
            Controls.Add(grpOption);
            Controls.Add(grpMenu);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "BurgerKiosk v1.0";
            ((System.ComponentModel.ISupportInitialize)picBulgogi).EndInit();
            grpMenu.ResumeLayout(false);
            grpMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCheese).EndInit();
            ((System.ComponentModel.ISupportInitialize)picChicken).EndInit();
            grpOption.ResumeLayout(false);
            grpOption.PerformLayout();
            groupOrder.ResumeLayout(false);
            groupOrder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private RadioButton rdoCheeseBurger;
        private PictureBox picBulgogi;
        private RadioButton rdoBulgogiBurger;
        private RadioButton rdoChickenBurger;
        private GroupBox grpMenu;
        private GroupBox grpOption;
        private CheckBox chkPotato;
        private CheckBox chkSauce;
        private CheckBox chkCheese;
        private CheckBox chkCola;
        private GroupBox groupOrder;
        private PictureBox picCheese;
        private PictureBox picChicken;
        private ListBox lstOrder;
        private Label lblTotalCost;
        private Button btnOrder;
        private Button btnInit;
    }
}
