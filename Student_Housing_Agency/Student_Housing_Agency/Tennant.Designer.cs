
namespace Student_Housing_Agency
{
    partial class Tennant
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogOut = new System.Windows.Forms.Button();
            this.tcTennant = new System.Windows.Forms.TabControl();
            this.tpTennantInfo = new System.Windows.Forms.TabPage();
            this.btnEditTennantProfile = new System.Windows.Forms.Button();
            this.tbViewPassword = new System.Windows.Forms.TextBox();
            this.tbViewUsername = new System.Windows.Forms.TextBox();
            this.tbViewRoomNo = new System.Windows.Forms.TextBox();
            this.tbViewPhoneNo = new System.Windows.Forms.TextBox();
            this.tbViewBirthDate = new System.Windows.Forms.TextBox();
            this.tbViewLastName = new System.Windows.Forms.TextBox();
            this.tbViewName = new System.Windows.Forms.TextBox();
            this.lblViewPassword = new System.Windows.Forms.Label();
            this.lblViewUsername = new System.Windows.Forms.Label();
            this.lblViewRoomNo = new System.Windows.Forms.Label();
            this.lblViewPhoneNo = new System.Windows.Forms.Label();
            this.lblViewBirthDate = new System.Windows.Forms.Label();
            this.lblViewLastName = new System.Windows.Forms.Label();
            this.lblViewName = new System.Windows.Forms.Label();
            this.tpRules = new System.Windows.Forms.TabPage();
            this.lbTennantViewRules = new System.Windows.Forms.ListBox();
            this.tpAnnouncment = new System.Windows.Forms.TabPage();
            this.btnTennantMakeAnnouncment = new System.Windows.Forms.Button();
            this.lbTennantAnnouncment = new System.Windows.Forms.ListBox();
            this.tpComplain = new System.Windows.Forms.TabPage();
            this.btnMakeComplain = new System.Windows.Forms.Button();
            this.btnViewTheSelectedComplain = new System.Windows.Forms.Button();
            this.lbComplains = new System.Windows.Forms.ListBox();
            this.tpTask = new System.Windows.Forms.TabPage();
            this.btnCompleteTask = new System.Windows.Forms.Button();
            this.lbViewTasks = new System.Windows.Forms.ListBox();
            this.tpShoppingList = new System.Windows.Forms.TabPage();
            this.numItemCost = new System.Windows.Forms.NumericUpDown();
            this.tbItemName = new System.Windows.Forms.TextBox();
            this.lblItemCost = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.lblShoppingList = new System.Windows.Forms.Label();
            this.lbShoppingList = new System.Windows.Forms.ListBox();
            this.tpAgreements = new System.Windows.Forms.TabPage();
            this.btnRemoveAgreement = new System.Windows.Forms.Button();
            this.btnCreateAgreement = new System.Windows.Forms.Button();
            this.lbAllAgreements = new System.Windows.Forms.ListBox();
            this.lblAllAgreements = new System.Windows.Forms.Label();
            this.tcTennant.SuspendLayout();
            this.tpTennantInfo.SuspendLayout();
            this.tpRules.SuspendLayout();
            this.tpAnnouncment.SuspendLayout();
            this.tpComplain.SuspendLayout();
            this.tpTask.SuspendLayout();
            this.tpShoppingList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numItemCost)).BeginInit();
            this.tpAgreements.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(363, 396);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 42);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // tcTennant
            // 
            this.tcTennant.Controls.Add(this.tpTennantInfo);
            this.tcTennant.Controls.Add(this.tpRules);
            this.tcTennant.Controls.Add(this.tpAnnouncment);
            this.tcTennant.Controls.Add(this.tpComplain);
            this.tcTennant.Controls.Add(this.tpTask);
            this.tcTennant.Controls.Add(this.tpShoppingList);
            this.tcTennant.Controls.Add(this.tpAgreements);
            this.tcTennant.Location = new System.Drawing.Point(12, 12);
            this.tcTennant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcTennant.Name = "tcTennant";
            this.tcTennant.SelectedIndex = 0;
            this.tcTennant.Size = new System.Drawing.Size(776, 378);
            this.tcTennant.TabIndex = 3;
            // 
            // tpTennantInfo
            // 
            this.tpTennantInfo.Controls.Add(this.btnEditTennantProfile);
            this.tpTennantInfo.Controls.Add(this.tbViewPassword);
            this.tpTennantInfo.Controls.Add(this.tbViewUsername);
            this.tpTennantInfo.Controls.Add(this.tbViewRoomNo);
            this.tpTennantInfo.Controls.Add(this.tbViewPhoneNo);
            this.tpTennantInfo.Controls.Add(this.tbViewBirthDate);
            this.tpTennantInfo.Controls.Add(this.tbViewLastName);
            this.tpTennantInfo.Controls.Add(this.tbViewName);
            this.tpTennantInfo.Controls.Add(this.lblViewPassword);
            this.tpTennantInfo.Controls.Add(this.lblViewUsername);
            this.tpTennantInfo.Controls.Add(this.lblViewRoomNo);
            this.tpTennantInfo.Controls.Add(this.lblViewPhoneNo);
            this.tpTennantInfo.Controls.Add(this.lblViewBirthDate);
            this.tpTennantInfo.Controls.Add(this.lblViewLastName);
            this.tpTennantInfo.Controls.Add(this.lblViewName);
            this.tpTennantInfo.Location = new System.Drawing.Point(4, 25);
            this.tpTennantInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpTennantInfo.Name = "tpTennantInfo";
            this.tpTennantInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpTennantInfo.Size = new System.Drawing.Size(768, 349);
            this.tpTennantInfo.TabIndex = 0;
            this.tpTennantInfo.Text = "Tenant Info";
            this.tpTennantInfo.UseVisualStyleBackColor = true;
            // 
            // btnEditTennantProfile
            // 
            this.btnEditTennantProfile.Location = new System.Drawing.Point(495, 138);
            this.btnEditTennantProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditTennantProfile.Name = "btnEditTennantProfile";
            this.btnEditTennantProfile.Size = new System.Drawing.Size(165, 50);
            this.btnEditTennantProfile.TabIndex = 52;
            this.btnEditTennantProfile.Text = "Edit Profile";
            this.btnEditTennantProfile.UseVisualStyleBackColor = true;
            this.btnEditTennantProfile.Click += new System.EventHandler(this.btnEditTennantProfile_Click);
            // 
            // tbViewPassword
            // 
            this.tbViewPassword.Location = new System.Drawing.Point(181, 245);
            this.tbViewPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbViewPassword.Name = "tbViewPassword";
            this.tbViewPassword.ReadOnly = true;
            this.tbViewPassword.Size = new System.Drawing.Size(231, 22);
            this.tbViewPassword.TabIndex = 50;
            // 
            // tbViewUsername
            // 
            this.tbViewUsername.Location = new System.Drawing.Point(181, 209);
            this.tbViewUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbViewUsername.Name = "tbViewUsername";
            this.tbViewUsername.ReadOnly = true;
            this.tbViewUsername.Size = new System.Drawing.Size(231, 22);
            this.tbViewUsername.TabIndex = 49;
            // 
            // tbViewRoomNo
            // 
            this.tbViewRoomNo.Location = new System.Drawing.Point(181, 178);
            this.tbViewRoomNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbViewRoomNo.Name = "tbViewRoomNo";
            this.tbViewRoomNo.ReadOnly = true;
            this.tbViewRoomNo.Size = new System.Drawing.Size(231, 22);
            this.tbViewRoomNo.TabIndex = 48;
            // 
            // tbViewPhoneNo
            // 
            this.tbViewPhoneNo.Location = new System.Drawing.Point(181, 138);
            this.tbViewPhoneNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbViewPhoneNo.Name = "tbViewPhoneNo";
            this.tbViewPhoneNo.ReadOnly = true;
            this.tbViewPhoneNo.Size = new System.Drawing.Size(231, 22);
            this.tbViewPhoneNo.TabIndex = 47;
            // 
            // tbViewBirthDate
            // 
            this.tbViewBirthDate.Location = new System.Drawing.Point(181, 96);
            this.tbViewBirthDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbViewBirthDate.Name = "tbViewBirthDate";
            this.tbViewBirthDate.ReadOnly = true;
            this.tbViewBirthDate.Size = new System.Drawing.Size(231, 22);
            this.tbViewBirthDate.TabIndex = 46;
            // 
            // tbViewLastName
            // 
            this.tbViewLastName.Location = new System.Drawing.Point(181, 64);
            this.tbViewLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbViewLastName.Name = "tbViewLastName";
            this.tbViewLastName.ReadOnly = true;
            this.tbViewLastName.Size = new System.Drawing.Size(231, 22);
            this.tbViewLastName.TabIndex = 45;
            // 
            // tbViewName
            // 
            this.tbViewName.Location = new System.Drawing.Point(181, 30);
            this.tbViewName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbViewName.Name = "tbViewName";
            this.tbViewName.ReadOnly = true;
            this.tbViewName.Size = new System.Drawing.Size(231, 22);
            this.tbViewName.TabIndex = 44;
            // 
            // lblViewPassword
            // 
            this.lblViewPassword.AutoSize = true;
            this.lblViewPassword.Location = new System.Drawing.Point(19, 249);
            this.lblViewPassword.Name = "lblViewPassword";
            this.lblViewPassword.Size = new System.Drawing.Size(73, 17);
            this.lblViewPassword.TabIndex = 43;
            this.lblViewPassword.Text = "Password:";
            // 
            // lblViewUsername
            // 
            this.lblViewUsername.AutoSize = true;
            this.lblViewUsername.Location = new System.Drawing.Point(19, 213);
            this.lblViewUsername.Name = "lblViewUsername";
            this.lblViewUsername.Size = new System.Drawing.Size(77, 17);
            this.lblViewUsername.TabIndex = 42;
            this.lblViewUsername.Text = "Username:";
            // 
            // lblViewRoomNo
            // 
            this.lblViewRoomNo.AutoSize = true;
            this.lblViewRoomNo.Location = new System.Drawing.Point(19, 182);
            this.lblViewRoomNo.Name = "lblViewRoomNo";
            this.lblViewRoomNo.Size = new System.Drawing.Size(103, 17);
            this.lblViewRoomNo.TabIndex = 41;
            this.lblViewRoomNo.Text = "Room Number:";
            // 
            // lblViewPhoneNo
            // 
            this.lblViewPhoneNo.AutoSize = true;
            this.lblViewPhoneNo.Location = new System.Drawing.Point(19, 142);
            this.lblViewPhoneNo.Name = "lblViewPhoneNo";
            this.lblViewPhoneNo.Size = new System.Drawing.Size(107, 17);
            this.lblViewPhoneNo.TabIndex = 39;
            this.lblViewPhoneNo.Text = "Phone Number:";
            // 
            // lblViewBirthDate
            // 
            this.lblViewBirthDate.AutoSize = true;
            this.lblViewBirthDate.Location = new System.Drawing.Point(19, 100);
            this.lblViewBirthDate.Name = "lblViewBirthDate";
            this.lblViewBirthDate.Size = new System.Drawing.Size(91, 17);
            this.lblViewBirthDate.TabIndex = 38;
            this.lblViewBirthDate.Text = "Date of Birth:";
            // 
            // lblViewLastName
            // 
            this.lblViewLastName.AutoSize = true;
            this.lblViewLastName.Location = new System.Drawing.Point(19, 68);
            this.lblViewLastName.Name = "lblViewLastName";
            this.lblViewLastName.Size = new System.Drawing.Size(80, 17);
            this.lblViewLastName.TabIndex = 37;
            this.lblViewLastName.Text = "Last Name:";
            // 
            // lblViewName
            // 
            this.lblViewName.AutoSize = true;
            this.lblViewName.Location = new System.Drawing.Point(19, 33);
            this.lblViewName.Name = "lblViewName";
            this.lblViewName.Size = new System.Drawing.Size(84, 17);
            this.lblViewName.TabIndex = 36;
            this.lblViewName.Text = "First Name: ";
            // 
            // tpRules
            // 
            this.tpRules.Controls.Add(this.lbTennantViewRules);
            this.tpRules.Location = new System.Drawing.Point(4, 25);
            this.tpRules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpRules.Name = "tpRules";
            this.tpRules.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpRules.Size = new System.Drawing.Size(768, 349);
            this.tpRules.TabIndex = 1;
            this.tpRules.Text = "House Rules";
            this.tpRules.UseVisualStyleBackColor = true;
            // 
            // lbTennantViewRules
            // 
            this.lbTennantViewRules.FormattingEnabled = true;
            this.lbTennantViewRules.ItemHeight = 16;
            this.lbTennantViewRules.Location = new System.Drawing.Point(15, 30);
            this.lbTennantViewRules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbTennantViewRules.Name = "lbTennantViewRules";
            this.lbTennantViewRules.Size = new System.Drawing.Size(733, 292);
            this.lbTennantViewRules.TabIndex = 0;
            // 
            // tpAnnouncment
            // 
            this.tpAnnouncment.Controls.Add(this.btnTennantMakeAnnouncment);
            this.tpAnnouncment.Controls.Add(this.lbTennantAnnouncment);
            this.tpAnnouncment.Location = new System.Drawing.Point(4, 25);
            this.tpAnnouncment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpAnnouncment.Name = "tpAnnouncment";
            this.tpAnnouncment.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpAnnouncment.Size = new System.Drawing.Size(768, 349);
            this.tpAnnouncment.TabIndex = 2;
            this.tpAnnouncment.Text = "Announcment";
            this.tpAnnouncment.UseVisualStyleBackColor = true;
            // 
            // btnTennantMakeAnnouncment
            // 
            this.btnTennantMakeAnnouncment.Location = new System.Drawing.Point(289, 273);
            this.btnTennantMakeAnnouncment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTennantMakeAnnouncment.Name = "btnTennantMakeAnnouncment";
            this.btnTennantMakeAnnouncment.Size = new System.Drawing.Size(195, 55);
            this.btnTennantMakeAnnouncment.TabIndex = 4;
            this.btnTennantMakeAnnouncment.Text = "Make Announcment";
            this.btnTennantMakeAnnouncment.UseVisualStyleBackColor = true;
            this.btnTennantMakeAnnouncment.Click += new System.EventHandler(this.btnTennantMakeAnnouncment_Click);
            // 
            // lbTennantAnnouncment
            // 
            this.lbTennantAnnouncment.FormattingEnabled = true;
            this.lbTennantAnnouncment.ItemHeight = 16;
            this.lbTennantAnnouncment.Location = new System.Drawing.Point(5, 23);
            this.lbTennantAnnouncment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbTennantAnnouncment.Name = "lbTennantAnnouncment";
            this.lbTennantAnnouncment.Size = new System.Drawing.Size(756, 228);
            this.lbTennantAnnouncment.TabIndex = 3;
            // 
            // tpComplain
            // 
            this.tpComplain.Controls.Add(this.btnMakeComplain);
            this.tpComplain.Controls.Add(this.btnViewTheSelectedComplain);
            this.tpComplain.Controls.Add(this.lbComplains);
            this.tpComplain.Location = new System.Drawing.Point(4, 25);
            this.tpComplain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpComplain.Name = "tpComplain";
            this.tpComplain.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpComplain.Size = new System.Drawing.Size(768, 349);
            this.tpComplain.TabIndex = 3;
            this.tpComplain.Text = "Complaints";
            this.tpComplain.UseVisualStyleBackColor = true;
            // 
            // btnMakeComplain
            // 
            this.btnMakeComplain.Location = new System.Drawing.Point(259, 248);
            this.btnMakeComplain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMakeComplain.Name = "btnMakeComplain";
            this.btnMakeComplain.Size = new System.Drawing.Size(249, 38);
            this.btnMakeComplain.TabIndex = 4;
            this.btnMakeComplain.Text = "Make Complain";
            this.btnMakeComplain.UseVisualStyleBackColor = true;
            this.btnMakeComplain.Click += new System.EventHandler(this.btnMakeComplain_Click);
            // 
            // btnViewTheSelectedComplain
            // 
            this.btnViewTheSelectedComplain.Location = new System.Drawing.Point(259, 292);
            this.btnViewTheSelectedComplain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewTheSelectedComplain.Name = "btnViewTheSelectedComplain";
            this.btnViewTheSelectedComplain.Size = new System.Drawing.Size(249, 38);
            this.btnViewTheSelectedComplain.TabIndex = 3;
            this.btnViewTheSelectedComplain.Text = "View the Selected Complain";
            this.btnViewTheSelectedComplain.UseVisualStyleBackColor = true;
            this.btnViewTheSelectedComplain.Click += new System.EventHandler(this.btnViewTheSelectedComplain_Click);
            // 
            // lbComplains
            // 
            this.lbComplains.FormattingEnabled = true;
            this.lbComplains.ItemHeight = 16;
            this.lbComplains.Location = new System.Drawing.Point(5, 16);
            this.lbComplains.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbComplains.Name = "lbComplains";
            this.lbComplains.Size = new System.Drawing.Size(756, 228);
            this.lbComplains.TabIndex = 2;
            // 
            // tpTask
            // 
            this.tpTask.Controls.Add(this.btnCompleteTask);
            this.tpTask.Controls.Add(this.lbViewTasks);
            this.tpTask.Location = new System.Drawing.Point(4, 25);
            this.tpTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpTask.Name = "tpTask";
            this.tpTask.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpTask.Size = new System.Drawing.Size(768, 349);
            this.tpTask.TabIndex = 4;
            this.tpTask.Text = "Task";
            this.tpTask.UseVisualStyleBackColor = true;
            // 
            // btnCompleteTask
            // 
            this.btnCompleteTask.Location = new System.Drawing.Point(619, 294);
            this.btnCompleteTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCompleteTask.Name = "btnCompleteTask";
            this.btnCompleteTask.Size = new System.Drawing.Size(141, 42);
            this.btnCompleteTask.TabIndex = 3;
            this.btnCompleteTask.Text = "Complete Task";
            this.btnCompleteTask.UseVisualStyleBackColor = true;
            this.btnCompleteTask.Click += new System.EventHandler(this.btnCompleteTask_Click);
            // 
            // lbViewTasks
            // 
            this.lbViewTasks.FormattingEnabled = true;
            this.lbViewTasks.ItemHeight = 16;
            this.lbViewTasks.Location = new System.Drawing.Point(5, 28);
            this.lbViewTasks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbViewTasks.Name = "lbViewTasks";
            this.lbViewTasks.Size = new System.Drawing.Size(756, 260);
            this.lbViewTasks.TabIndex = 0;
            // 
            // tpShoppingList
            // 
            this.tpShoppingList.Controls.Add(this.numItemCost);
            this.tpShoppingList.Controls.Add(this.tbItemName);
            this.tpShoppingList.Controls.Add(this.lblItemCost);
            this.tpShoppingList.Controls.Add(this.lblItemName);
            this.tpShoppingList.Controls.Add(this.btnRemoveItem);
            this.tpShoppingList.Controls.Add(this.btnAddItem);
            this.tpShoppingList.Controls.Add(this.lblShoppingList);
            this.tpShoppingList.Controls.Add(this.lbShoppingList);
            this.tpShoppingList.Location = new System.Drawing.Point(4, 25);
            this.tpShoppingList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpShoppingList.Name = "tpShoppingList";
            this.tpShoppingList.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpShoppingList.Size = new System.Drawing.Size(768, 349);
            this.tpShoppingList.TabIndex = 5;
            this.tpShoppingList.Text = "Shopping List";
            this.tpShoppingList.UseVisualStyleBackColor = true;
            // 
            // numItemCost
            // 
            this.numItemCost.DecimalPlaces = 2;
            this.numItemCost.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numItemCost.Location = new System.Drawing.Point(167, 122);
            this.numItemCost.Margin = new System.Windows.Forms.Padding(4);
            this.numItemCost.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numItemCost.Name = "numItemCost";
            this.numItemCost.Size = new System.Drawing.Size(133, 22);
            this.numItemCost.TabIndex = 7;
            // 
            // tbItemName
            // 
            this.tbItemName.Location = new System.Drawing.Point(167, 63);
            this.tbItemName.Margin = new System.Windows.Forms.Padding(4);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.Size = new System.Drawing.Size(132, 22);
            this.tbItemName.TabIndex = 6;
            // 
            // lblItemCost
            // 
            this.lblItemCost.AutoSize = true;
            this.lblItemCost.Location = new System.Drawing.Point(69, 124);
            this.lblItemCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemCost.Name = "lblItemCost";
            this.lblItemCost.Size = new System.Drawing.Size(68, 17);
            this.lblItemCost.TabIndex = 5;
            this.lblItemCost.Text = "Item cost:";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(69, 66);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(77, 17);
            this.lblItemName.TabIndex = 4;
            this.lblItemName.Text = "Item name:";
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(608, 267);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(112, 33);
            this.btnRemoveItem.TabIndex = 3;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(69, 267);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(93, 33);
            this.btnAddItem.TabIndex = 2;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // lblShoppingList
            // 
            this.lblShoppingList.AutoSize = true;
            this.lblShoppingList.Location = new System.Drawing.Point(412, 44);
            this.lblShoppingList.Name = "lblShoppingList";
            this.lblShoppingList.Size = new System.Drawing.Size(98, 17);
            this.lblShoppingList.TabIndex = 1;
            this.lblShoppingList.Text = "Shopping List:";
            // 
            // lbShoppingList
            // 
            this.lbShoppingList.FormattingEnabled = true;
            this.lbShoppingList.ItemHeight = 16;
            this.lbShoppingList.Location = new System.Drawing.Point(416, 63);
            this.lbShoppingList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbShoppingList.Name = "lbShoppingList";
            this.lbShoppingList.Size = new System.Drawing.Size(303, 180);
            this.lbShoppingList.TabIndex = 0;
            // 
            // tpAgreements
            // 
            this.tpAgreements.Controls.Add(this.btnRemoveAgreement);
            this.tpAgreements.Controls.Add(this.btnCreateAgreement);
            this.tpAgreements.Controls.Add(this.lbAllAgreements);
            this.tpAgreements.Controls.Add(this.lblAllAgreements);
            this.tpAgreements.Location = new System.Drawing.Point(4, 25);
            this.tpAgreements.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpAgreements.Name = "tpAgreements";
            this.tpAgreements.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpAgreements.Size = new System.Drawing.Size(768, 349);
            this.tpAgreements.TabIndex = 6;
            this.tpAgreements.Text = "Agreements";
            this.tpAgreements.UseVisualStyleBackColor = true;
            // 
            // btnRemoveAgreement
            // 
            this.btnRemoveAgreement.Location = new System.Drawing.Point(477, 290);
            this.btnRemoveAgreement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveAgreement.Name = "btnRemoveAgreement";
            this.btnRemoveAgreement.Size = new System.Drawing.Size(144, 32);
            this.btnRemoveAgreement.TabIndex = 3;
            this.btnRemoveAgreement.Text = "Remove Agreement";
            this.btnRemoveAgreement.UseVisualStyleBackColor = true;
            this.btnRemoveAgreement.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCreateAgreement
            // 
            this.btnCreateAgreement.Location = new System.Drawing.Point(119, 290);
            this.btnCreateAgreement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateAgreement.Name = "btnCreateAgreement";
            this.btnCreateAgreement.Size = new System.Drawing.Size(139, 32);
            this.btnCreateAgreement.TabIndex = 2;
            this.btnCreateAgreement.Text = "Create Agreement";
            this.btnCreateAgreement.UseVisualStyleBackColor = true;
            this.btnCreateAgreement.Click += new System.EventHandler(this.btnCreateAgreement_Click);
            // 
            // lbAllAgreements
            // 
            this.lbAllAgreements.FormattingEnabled = true;
            this.lbAllAgreements.ItemHeight = 16;
            this.lbAllAgreements.Location = new System.Drawing.Point(27, 78);
            this.lbAllAgreements.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbAllAgreements.Name = "lbAllAgreements";
            this.lbAllAgreements.Size = new System.Drawing.Size(716, 180);
            this.lbAllAgreements.TabIndex = 1;
            // 
            // lblAllAgreements
            // 
            this.lblAllAgreements.AutoSize = true;
            this.lblAllAgreements.Location = new System.Drawing.Point(24, 42);
            this.lblAllAgreements.Name = "lblAllAgreements";
            this.lblAllAgreements.Size = new System.Drawing.Size(107, 17);
            this.lblAllAgreements.TabIndex = 0;
            this.lblAllAgreements.Text = "All Agreements:";
            // 
            // Tennant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcTennant);
            this.Controls.Add(this.btnLogOut);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Tennant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tennant";
            this.Load += new System.EventHandler(this.Tennant_Load);
            this.tcTennant.ResumeLayout(false);
            this.tpTennantInfo.ResumeLayout(false);
            this.tpTennantInfo.PerformLayout();
            this.tpRules.ResumeLayout(false);
            this.tpAnnouncment.ResumeLayout(false);
            this.tpComplain.ResumeLayout(false);
            this.tpTask.ResumeLayout(false);
            this.tpShoppingList.ResumeLayout(false);
            this.tpShoppingList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numItemCost)).EndInit();
            this.tpAgreements.ResumeLayout(false);
            this.tpAgreements.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.TabControl tcTennant;
        private System.Windows.Forms.TabPage tpTennantInfo;
        private System.Windows.Forms.TextBox tbViewPassword;
        private System.Windows.Forms.TextBox tbViewUsername;
        private System.Windows.Forms.TextBox tbViewRoomNo;
        private System.Windows.Forms.TextBox tbViewPhoneNo;
        private System.Windows.Forms.TextBox tbViewBirthDate;
        private System.Windows.Forms.TextBox tbViewLastName;
        private System.Windows.Forms.TextBox tbViewName;
        private System.Windows.Forms.Label lblViewPassword;
        private System.Windows.Forms.Label lblViewUsername;
        private System.Windows.Forms.Label lblViewRoomNo;
        private System.Windows.Forms.Label lblViewPhoneNo;
        private System.Windows.Forms.Label lblViewBirthDate;
        private System.Windows.Forms.Label lblViewLastName;
        private System.Windows.Forms.Label lblViewName;
        private System.Windows.Forms.Button btnEditTennantProfile;
        private System.Windows.Forms.TabPage tpRules;
        private System.Windows.Forms.ListBox lbTennantViewRules;
        private System.Windows.Forms.TabPage tpAnnouncment;
        private System.Windows.Forms.Button btnTennantMakeAnnouncment;
        private System.Windows.Forms.ListBox lbTennantAnnouncment;
        private System.Windows.Forms.TabPage tpComplain;
        private System.Windows.Forms.Button btnMakeComplain;
        private System.Windows.Forms.Button btnViewTheSelectedComplain;
        private System.Windows.Forms.ListBox lbComplains;
        private System.Windows.Forms.TabPage tpTask;
        private System.Windows.Forms.ListBox lbViewTasks;
        private System.Windows.Forms.TabPage tpShoppingList;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label lblShoppingList;
        private System.Windows.Forms.ListBox lbShoppingList;
        private System.Windows.Forms.TabPage tpAgreements;
        private System.Windows.Forms.Button btnCreateAgreement;
        private System.Windows.Forms.ListBox lbAllAgreements;
        private System.Windows.Forms.Label lblAllAgreements;
        private System.Windows.Forms.NumericUpDown numItemCost;
        private System.Windows.Forms.TextBox tbItemName;
        private System.Windows.Forms.Label lblItemCost;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Button btnRemoveAgreement;
        private System.Windows.Forms.Button btnCompleteTask;
    }
}