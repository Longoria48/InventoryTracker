namespace FINALPROJECT_inventory_
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            usernameTB = new TextBox();
            passwordTB = new TextBox();
            loginBtn = new Button();
            msgLabel = new Label();
            create = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(229, 128);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(232, 173);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // usernameTB
            // 
            usernameTB.Location = new Point(314, 125);
            usernameTB.Name = "usernameTB";
            usernameTB.Size = new Size(149, 23);
            usernameTB.TabIndex = 2;
            // 
            // passwordTB
            // 
            passwordTB.Location = new Point(314, 170);
            passwordTB.Name = "passwordTB";
            passwordTB.Size = new Size(149, 23);
            passwordTB.TabIndex = 3;
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(388, 208);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(75, 23);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // msgLabel
            // 
            msgLabel.AutoSize = true;
            msgLabel.Location = new Point(314, 98);
            msgLabel.Name = "msgLabel";
            msgLabel.Size = new Size(0, 15);
            msgLabel.TabIndex = 5;
            // 
            // create
            // 
            create.Location = new Point(12, 378);
            create.Name = "create";
            create.Size = new Size(75, 23);
            create.TabIndex = 6;
            create.Text = "Create";
            create.UseVisualStyleBackColor = false;
            create.Visible = false;
            create.Click += create_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(692, 413);
            Controls.Add(create);
            Controls.Add(msgLabel);
            Controls.Add(loginBtn);
            Controls.Add(passwordTB);
            Controls.Add(usernameTB);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox usernameTB;
        private TextBox passwordTB;
        private Button loginBtn;
        private Label msgLabel;
        private Button create;
    }
}