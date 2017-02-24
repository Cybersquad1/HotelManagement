namespace Assignment
{
    partial class Order
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
            this.btnRoomSer = new System.Windows.Forms.Button();
            this.btnBar = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRoomSer
            // 
            this.btnRoomSer.Location = new System.Drawing.Point(12, 12);
            this.btnRoomSer.Name = "btnRoomSer";
            this.btnRoomSer.Size = new System.Drawing.Size(124, 23);
            this.btnRoomSer.TabIndex = 0;
            this.btnRoomSer.Text = "Room Service";
            this.btnRoomSer.UseVisualStyleBackColor = true;
            this.btnRoomSer.Click += new System.EventHandler(this.btnRoomSer_Click);
            // 
            // btnBar
            // 
            this.btnBar.Location = new System.Drawing.Point(142, 12);
            this.btnBar.Name = "btnBar";
            this.btnBar.Size = new System.Drawing.Size(124, 23);
            this.btnBar.TabIndex = 1;
            this.btnBar.Text = "Bar";
            this.btnBar.UseVisualStyleBackColor = true;
            this.btnBar.Click += new System.EventHandler(this.btnBar_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(12, 76);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(254, 23);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(12, 47);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(254, 23);
            this.btnTest.TabIndex = 3;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 111);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnBar);
            this.Controls.Add(this.btnRoomSer);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRoomSer;
        private System.Windows.Forms.Button btnBar;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnTest;
    }
}