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
            label1.Location = new Point(425, 273);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(126, 32);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(431, 369);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(116, 32);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // usernameTB
            // 
            usernameTB.Location = new Point(583, 267);
            usernameTB.Margin = new Padding(6);
            usernameTB.Name = "usernameTB";
            usernameTB.Size = new Size(273, 39);
            usernameTB.TabIndex = 2;
            // 
            // passwordTB
            // 
            passwordTB.Location = new Point(583, 363);
            passwordTB.Margin = new Padding(6);
            passwordTB.Name = "passwordTB";
            passwordTB.Size = new Size(273, 39);
            passwordTB.TabIndex = 3;
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(721, 444);
            loginBtn.Margin = new Padding(6);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(139, 49);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // msgLabel
            // 
            msgLabel.AutoSize = true;
            msgLabel.Location = new Point(583, 209);
            msgLabel.Margin = new Padding(6, 0, 6, 0);
            msgLabel.Name = "msgLabel";
            msgLabel.Size = new Size(0, 32);
            msgLabel.TabIndex = 5;
            // 
            // create
            // 
            create.Location = new Point(22, 885);
            create.Margin = new Padding(6);
            create.Name = "create";
            create.Size = new Size(139, 49);
            create.TabIndex = 6;
            create.Text = "Create";
            create.UseVisualStyleBackColor = false;
            create.Click += create_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1285, 960);
            Controls.Add(create);
            Controls.Add(msgLabel);
            Controls.Add(loginBtn);
            Controls.Add(passwordTB);
            Controls.Add(usernameTB);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(6);
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