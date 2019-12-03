namespace MainLoginStudy
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("노드2");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("노드3");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("노드4");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Coffee", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("노드5");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("노드6");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("노드7");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("노드1", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            this.moneyTextBox = new System.Windows.Forms.TextBox();
            this.cntTextBox = new System.Windows.Forms.TextBox();
            this.labelCnt = new System.Windows.Forms.Label();
            this.labelWon = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.plusButton1 = new System.Windows.Forms.Button();
            this.plusButton2 = new System.Windows.Forms.Button();
            this.plusButton3 = new System.Windows.Forms.Button();
            this.plusButton4 = new System.Windows.Forms.Button();
            this.plusButton5 = new System.Windows.Forms.Button();
            this.plusButton6 = new System.Windows.Forms.Button();
            this.minusButton1 = new System.Windows.Forms.Button();
            this.minusButton2 = new System.Windows.Forms.Button();
            this.minusButton3 = new System.Windows.Forms.Button();
            this.minusButton4 = new System.Windows.Forms.Button();
            this.minusButton5 = new System.Windows.Forms.Button();
            this.minusButton6 = new System.Windows.Forms.Button();
            this.AllClearItem = new System.Windows.Forms.Button();
            this.Pay = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // moneyTextBox
            // 
            this.moneyTextBox.Location = new System.Drawing.Point(816, 563);
            this.moneyTextBox.Name = "moneyTextBox";
            this.moneyTextBox.Size = new System.Drawing.Size(182, 21);
            this.moneyTextBox.TabIndex = 0;
            // 
            // cntTextBox
            // 
            this.cntTextBox.Location = new System.Drawing.Point(703, 563);
            this.cntTextBox.Name = "cntTextBox";
            this.cntTextBox.Size = new System.Drawing.Size(60, 21);
            this.cntTextBox.TabIndex = 1;
            // 
            // labelCnt
            // 
            this.labelCnt.AutoSize = true;
            this.labelCnt.Location = new System.Drawing.Point(769, 572);
            this.labelCnt.Name = "labelCnt";
            this.labelCnt.Size = new System.Drawing.Size(17, 12);
            this.labelCnt.TabIndex = 2;
            this.labelCnt.Text = "개";
            // 
            // labelWon
            // 
            this.labelWon.AutoSize = true;
            this.labelWon.Location = new System.Drawing.Point(1004, 572);
            this.labelWon.Name = "labelWon";
            this.labelWon.Size = new System.Drawing.Size(29, 12);
            this.labelWon.TabIndex = 3;
            this.labelWon.Text = "Won";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::MainLoginStudy.Properties.Resources.Coffee6;
            this.pictureBox6.Location = new System.Drawing.Point(816, 202);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(162, 90);
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::MainLoginStudy.Properties.Resources.Coffee5;
            this.pictureBox5.Location = new System.Drawing.Point(592, 202);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(162, 90);
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::MainLoginStudy.Properties.Resources.Coffee4;
            this.pictureBox4.Location = new System.Drawing.Point(365, 202);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(162, 90);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MainLoginStudy.Properties.Resources.Coffee1;
            this.pictureBox3.Location = new System.Drawing.Point(365, 42);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(162, 90);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MainLoginStudy.Properties.Resources.Coffee2;
            this.pictureBox2.Location = new System.Drawing.Point(592, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(162, 90);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MainLoginStudy.Properties.Resources.Coffee3;
            this.pictureBox1.Location = new System.Drawing.Point(816, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 90);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // plusButton1
            // 
            this.plusButton1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.plusButton1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.plusButton1.Location = new System.Drawing.Point(365, 138);
            this.plusButton1.Name = "plusButton1";
            this.plusButton1.Size = new System.Drawing.Size(54, 38);
            this.plusButton1.TabIndex = 10;
            this.plusButton1.Text = "+";
            this.plusButton1.UseVisualStyleBackColor = true;
            this.plusButton1.Click += new System.EventHandler(this.PlusButton1_Click);
            // 
            // plusButton2
            // 
            this.plusButton2.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.plusButton2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.plusButton2.Location = new System.Drawing.Point(592, 138);
            this.plusButton2.Name = "plusButton2";
            this.plusButton2.Size = new System.Drawing.Size(54, 38);
            this.plusButton2.TabIndex = 11;
            this.plusButton2.Text = "+";
            this.plusButton2.UseVisualStyleBackColor = true;
            this.plusButton2.Click += new System.EventHandler(this.PlusButton2_Click);
            // 
            // plusButton3
            // 
            this.plusButton3.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.plusButton3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.plusButton3.Location = new System.Drawing.Point(816, 138);
            this.plusButton3.Name = "plusButton3";
            this.plusButton3.Size = new System.Drawing.Size(54, 38);
            this.plusButton3.TabIndex = 12;
            this.plusButton3.Text = "+";
            this.plusButton3.UseVisualStyleBackColor = true;
            this.plusButton3.Click += new System.EventHandler(this.PlusButton3_Click);
            // 
            // plusButton4
            // 
            this.plusButton4.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.plusButton4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.plusButton4.Location = new System.Drawing.Point(365, 298);
            this.plusButton4.Name = "plusButton4";
            this.plusButton4.Size = new System.Drawing.Size(54, 38);
            this.plusButton4.TabIndex = 13;
            this.plusButton4.Text = "+";
            this.plusButton4.UseVisualStyleBackColor = true;
            this.plusButton4.Click += new System.EventHandler(this.PlusButton4_Click);
            // 
            // plusButton5
            // 
            this.plusButton5.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.plusButton5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.plusButton5.Location = new System.Drawing.Point(592, 298);
            this.plusButton5.Name = "plusButton5";
            this.plusButton5.Size = new System.Drawing.Size(54, 38);
            this.plusButton5.TabIndex = 14;
            this.plusButton5.Text = "+";
            this.plusButton5.UseVisualStyleBackColor = true;
            this.plusButton5.Click += new System.EventHandler(this.PlusButton5_Click);
            // 
            // plusButton6
            // 
            this.plusButton6.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.plusButton6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.plusButton6.Location = new System.Drawing.Point(816, 298);
            this.plusButton6.Name = "plusButton6";
            this.plusButton6.Size = new System.Drawing.Size(54, 38);
            this.plusButton6.TabIndex = 15;
            this.plusButton6.Text = "+";
            this.plusButton6.UseVisualStyleBackColor = true;
            this.plusButton6.Click += new System.EventHandler(this.PlusButton6_Click);
            // 
            // minusButton1
            // 
            this.minusButton1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.minusButton1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.minusButton1.Location = new System.Drawing.Point(473, 138);
            this.minusButton1.Name = "minusButton1";
            this.minusButton1.Size = new System.Drawing.Size(54, 38);
            this.minusButton1.TabIndex = 16;
            this.minusButton1.Text = "-";
            this.minusButton1.UseVisualStyleBackColor = true;
            this.minusButton1.Click += new System.EventHandler(this.MinusButton1_Click);
            // 
            // minusButton2
            // 
            this.minusButton2.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.minusButton2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.minusButton2.Location = new System.Drawing.Point(700, 138);
            this.minusButton2.Name = "minusButton2";
            this.minusButton2.Size = new System.Drawing.Size(54, 38);
            this.minusButton2.TabIndex = 17;
            this.minusButton2.Text = "-";
            this.minusButton2.UseVisualStyleBackColor = true;
            this.minusButton2.Click += new System.EventHandler(this.MinusButton2_Click);
            // 
            // minusButton3
            // 
            this.minusButton3.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.minusButton3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.minusButton3.Location = new System.Drawing.Point(924, 138);
            this.minusButton3.Name = "minusButton3";
            this.minusButton3.Size = new System.Drawing.Size(54, 38);
            this.minusButton3.TabIndex = 18;
            this.minusButton3.Text = "-";
            this.minusButton3.UseVisualStyleBackColor = true;
            this.minusButton3.Click += new System.EventHandler(this.MinusButton3_Click);
            // 
            // minusButton4
            // 
            this.minusButton4.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.minusButton4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.minusButton4.Location = new System.Drawing.Point(473, 298);
            this.minusButton4.Name = "minusButton4";
            this.minusButton4.Size = new System.Drawing.Size(54, 38);
            this.minusButton4.TabIndex = 19;
            this.minusButton4.Text = "-";
            this.minusButton4.UseVisualStyleBackColor = true;
            this.minusButton4.Click += new System.EventHandler(this.MinusButton4_Click);
            // 
            // minusButton5
            // 
            this.minusButton5.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.minusButton5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.minusButton5.Location = new System.Drawing.Point(700, 298);
            this.minusButton5.Name = "minusButton5";
            this.minusButton5.Size = new System.Drawing.Size(54, 38);
            this.minusButton5.TabIndex = 20;
            this.minusButton5.Text = "-";
            this.minusButton5.UseVisualStyleBackColor = true;
            this.minusButton5.Click += new System.EventHandler(this.MinusButton5_Click);
            // 
            // minusButton6
            // 
            this.minusButton6.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.minusButton6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.minusButton6.Location = new System.Drawing.Point(924, 298);
            this.minusButton6.Name = "minusButton6";
            this.minusButton6.Size = new System.Drawing.Size(54, 38);
            this.minusButton6.TabIndex = 21;
            this.minusButton6.Text = "-";
            this.minusButton6.UseVisualStyleBackColor = true;
            this.minusButton6.Click += new System.EventHandler(this.MinusButton6_Click);
            // 
            // AllClearItem
            // 
            this.AllClearItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AllClearItem.Location = new System.Drawing.Point(365, 538);
            this.AllClearItem.Name = "AllClearItem";
            this.AllClearItem.Size = new System.Drawing.Size(107, 68);
            this.AllClearItem.TabIndex = 22;
            this.AllClearItem.Text = "AllClearItem";
            this.AllClearItem.UseVisualStyleBackColor = true;
            this.AllClearItem.Click += new System.EventHandler(this.AllClearItem_Click);
            // 
            // Pay
            // 
            this.Pay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Pay.Location = new System.Drawing.Point(492, 538);
            this.Pay.Name = "Pay";
            this.Pay.Size = new System.Drawing.Size(107, 68);
            this.Pay.TabIndex = 23;
            this.Pay.Text = "Pay";
            this.Pay.UseVisualStyleBackColor = true;
            this.Pay.Click += new System.EventHandler(this.Pay_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(43, 42);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "노드2";
            treeNode1.Text = "노드2";
            treeNode2.Name = "노드3";
            treeNode2.Text = "노드3";
            treeNode3.Name = "노드4";
            treeNode3.Text = "노드4";
            treeNode4.Name = "Coffee";
            treeNode4.Text = "Coffee";
            treeNode5.Name = "노드5";
            treeNode5.Text = "노드5";
            treeNode6.Name = "노드6";
            treeNode6.Text = "노드6";
            treeNode7.Name = "노드7";
            treeNode7.Text = "노드7";
            treeNode8.Name = "노드1";
            treeNode8.Text = "노드1";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8});
            this.treeView1.Size = new System.Drawing.Size(262, 433);
            this.treeView1.TabIndex = 24;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1071, 636);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.Pay);
            this.Controls.Add(this.AllClearItem);
            this.Controls.Add(this.minusButton6);
            this.Controls.Add(this.minusButton5);
            this.Controls.Add(this.minusButton4);
            this.Controls.Add(this.minusButton3);
            this.Controls.Add(this.minusButton2);
            this.Controls.Add(this.minusButton1);
            this.Controls.Add(this.plusButton6);
            this.Controls.Add(this.plusButton5);
            this.Controls.Add(this.plusButton4);
            this.Controls.Add(this.plusButton3);
            this.Controls.Add(this.plusButton2);
            this.Controls.Add(this.plusButton1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelWon);
            this.Controls.Add(this.labelCnt);
            this.Controls.Add(this.cntTextBox);
            this.Controls.Add(this.moneyTextBox);
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.Name = "MainForm";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox moneyTextBox;
        private System.Windows.Forms.TextBox cntTextBox;
        private System.Windows.Forms.Label labelCnt;
        private System.Windows.Forms.Label labelWon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button plusButton1;
        private System.Windows.Forms.Button plusButton2;
        private System.Windows.Forms.Button plusButton3;
        private System.Windows.Forms.Button plusButton4;
        private System.Windows.Forms.Button plusButton5;
        private System.Windows.Forms.Button plusButton6;
        private System.Windows.Forms.Button minusButton1;
        private System.Windows.Forms.Button minusButton2;
        private System.Windows.Forms.Button minusButton3;
        private System.Windows.Forms.Button minusButton4;
        private System.Windows.Forms.Button minusButton5;
        private System.Windows.Forms.Button minusButton6;
        private System.Windows.Forms.Button AllClearItem;
        private System.Windows.Forms.Button Pay;
        private System.Windows.Forms.TreeView treeView1;
    }
}

