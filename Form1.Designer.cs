namespace vetej
{
    partial class Form1
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
            this.button7 = new System.Windows.Forms.Button();
            this.comboBoxAnimal = new System.Windows.Forms.ComboBox();
            this.comboBoxBall = new System.Windows.Forms.ComboBox();
            this.comboBoxFood = new System.Windows.Forms.ComboBox();
            this.PlayAnimalBtn = new System.Windows.Forms.Button();
            this.SimulateBtn = new System.Windows.Forms.Button();
            this.AnimalListBtn = new System.Windows.Forms.Button();
            this.BallListBtn = new System.Windows.Forms.Button();
            this.FoodListBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SaveToTxtBtn = new System.Windows.Forms.Button();
            this.CheckBollBtn = new System.Windows.Forms.Button();
            this.FeedAnimalBtn = new System.Windows.Forms.Button();
            this.SimulateFeedBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.AccessibleName = "ShutDownBtn";
            this.button7.Location = new System.Drawing.Point(185, 416);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(128, 79);
            this.button7.TabIndex = 8;
            this.button7.Text = "Close";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // comboBoxAnimal
            // 
            this.comboBoxAnimal.FormattingEnabled = true;
            this.comboBoxAnimal.Location = new System.Drawing.Point(364, 247);
            this.comboBoxAnimal.Name = "comboBoxAnimal";
            this.comboBoxAnimal.Size = new System.Drawing.Size(121, 24);
            this.comboBoxAnimal.TabIndex = 12;
            this.comboBoxAnimal.SelectedIndexChanged += new System.EventHandler(this.comboBoxAnimal_SelectedIndexChanged);
            // 
            // comboBoxBall
            // 
            this.comboBoxBall.FormattingEnabled = true;
            this.comboBoxBall.Location = new System.Drawing.Point(501, 247);
            this.comboBoxBall.Name = "comboBoxBall";
            this.comboBoxBall.Size = new System.Drawing.Size(121, 24);
            this.comboBoxBall.TabIndex = 13;
            // 
            // comboBoxFood
            // 
            this.comboBoxFood.FormattingEnabled = true;
            this.comboBoxFood.Location = new System.Drawing.Point(649, 247);
            this.comboBoxFood.Name = "comboBoxFood";
            this.comboBoxFood.Size = new System.Drawing.Size(121, 24);
            this.comboBoxFood.TabIndex = 14;
            // 
            // PlayAnimalBtn
            // 
            this.PlayAnimalBtn.AccessibleName = "PlayAnimalBtn";
            this.PlayAnimalBtn.Location = new System.Drawing.Point(185, 275);
            this.PlayAnimalBtn.Name = "PlayAnimalBtn";
            this.PlayAnimalBtn.Size = new System.Drawing.Size(128, 79);
            this.PlayAnimalBtn.TabIndex = 15;
            this.PlayAnimalBtn.Text = "Play Animal";
            this.PlayAnimalBtn.UseVisualStyleBackColor = true;
            this.PlayAnimalBtn.Click += new System.EventHandler(this.PlayAnimalBtn_Click);
            // 
            // SimulateBtn
            // 
            this.SimulateBtn.AccessibleName = "SimulateBtn";
            this.SimulateBtn.Location = new System.Drawing.Point(364, 294);
            this.SimulateBtn.Name = "SimulateBtn";
            this.SimulateBtn.Size = new System.Drawing.Size(406, 79);
            this.SimulateBtn.TabIndex = 17;
            this.SimulateBtn.Text = "Simulate Play";
            this.SimulateBtn.UseVisualStyleBackColor = true;
            this.SimulateBtn.Click += new System.EventHandler(this.SimulateBtn_Click);
            // 
            // AnimalListBtn
            // 
            this.AnimalListBtn.AccessibleName = "AnimalListBtn";
            this.AnimalListBtn.Location = new System.Drawing.Point(12, 12);
            this.AnimalListBtn.Name = "AnimalListBtn";
            this.AnimalListBtn.Size = new System.Drawing.Size(128, 79);
            this.AnimalListBtn.TabIndex = 18;
            this.AnimalListBtn.Text = "Animal List";
            this.AnimalListBtn.UseVisualStyleBackColor = true;
            this.AnimalListBtn.Click += new System.EventHandler(this.AnimalListBtn_Click);
            // 
            // BallListBtn
            // 
            this.BallListBtn.AccessibleName = "BallListBtn";
            this.BallListBtn.Location = new System.Drawing.Point(12, 141);
            this.BallListBtn.Name = "BallListBtn";
            this.BallListBtn.Size = new System.Drawing.Size(128, 79);
            this.BallListBtn.TabIndex = 19;
            this.BallListBtn.Text = "Ball List";
            this.BallListBtn.UseVisualStyleBackColor = true;
            this.BallListBtn.Click += new System.EventHandler(this.BallListBtn_Click);
            // 
            // FoodListBtn
            // 
            this.FoodListBtn.AccessibleName = "FoodListBtn";
            this.FoodListBtn.Location = new System.Drawing.Point(185, 141);
            this.FoodListBtn.Name = "FoodListBtn";
            this.FoodListBtn.Size = new System.Drawing.Size(128, 79);
            this.FoodListBtn.TabIndex = 20;
            this.FoodListBtn.Text = "Food List";
            this.FoodListBtn.UseVisualStyleBackColor = true;
            this.FoodListBtn.Click += new System.EventHandler(this.FoodListBtn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(374, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(396, 208);
            this.richTextBox1.TabIndex = 21;
            this.richTextBox1.Text = "";
            // 
            // SaveToTxtBtn
            // 
            this.SaveToTxtBtn.AccessibleName = "SaveToTxtBtn";
            this.SaveToTxtBtn.Location = new System.Drawing.Point(12, 416);
            this.SaveToTxtBtn.Name = "SaveToTxtBtn";
            this.SaveToTxtBtn.Size = new System.Drawing.Size(128, 79);
            this.SaveToTxtBtn.TabIndex = 22;
            this.SaveToTxtBtn.Text = "Save To Text File";
            this.SaveToTxtBtn.UseVisualStyleBackColor = true;
            this.SaveToTxtBtn.Click += new System.EventHandler(this.SaveToTxtBtn_Click);
            // 
            // CheckBollBtn
            // 
            this.CheckBollBtn.AccessibleName = "CheckBollBtn";
            this.CheckBollBtn.Location = new System.Drawing.Point(185, 12);
            this.CheckBollBtn.Name = "CheckBollBtn";
            this.CheckBollBtn.Size = new System.Drawing.Size(128, 79);
            this.CheckBollBtn.TabIndex = 23;
            this.CheckBollBtn.Text = "Check Ball Quality";
            this.CheckBollBtn.UseVisualStyleBackColor = true;
            this.CheckBollBtn.Click += new System.EventHandler(this.CheckBollBtn_Click);
            // 
            // FeedAnimalBtn
            // 
            this.FeedAnimalBtn.AccessibleName = "FeedAnimalBtn";
            this.FeedAnimalBtn.Location = new System.Drawing.Point(12, 275);
            this.FeedAnimalBtn.Name = "FeedAnimalBtn";
            this.FeedAnimalBtn.Size = new System.Drawing.Size(128, 79);
            this.FeedAnimalBtn.TabIndex = 24;
            this.FeedAnimalBtn.Text = "Feed Animal";
            this.FeedAnimalBtn.UseVisualStyleBackColor = true;
            this.FeedAnimalBtn.Click += new System.EventHandler(this.FeedAnimalBtn_Click_1);
            // 
            // SimulateFeedBtn
            // 
            this.SimulateFeedBtn.AccessibleName = "SimulateFeed";
            this.SimulateFeedBtn.Location = new System.Drawing.Point(364, 396);
            this.SimulateFeedBtn.Name = "SimulateFeedBtn";
            this.SimulateFeedBtn.Size = new System.Drawing.Size(406, 79);
            this.SimulateFeedBtn.TabIndex = 25;
            this.SimulateFeedBtn.Text = "Simulate Feed";
            this.SimulateFeedBtn.UseVisualStyleBackColor = true;
            this.SimulateFeedBtn.Click += new System.EventHandler(this.SimulateFeedBtn_Click);
            // 
            // Form1
            // 
            this.AccessibleName = "TextBox";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.SimulateFeedBtn);
            this.Controls.Add(this.FeedAnimalBtn);
            this.Controls.Add(this.CheckBollBtn);
            this.Controls.Add(this.SaveToTxtBtn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.FoodListBtn);
            this.Controls.Add(this.BallListBtn);
            this.Controls.Add(this.AnimalListBtn);
            this.Controls.Add(this.SimulateBtn);
            this.Controls.Add(this.PlayAnimalBtn);
            this.Controls.Add(this.comboBoxFood);
            this.Controls.Add(this.comboBoxBall);
            this.Controls.Add(this.comboBoxAnimal);
            this.Controls.Add(this.button7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox comboBoxAnimal;
        private System.Windows.Forms.ComboBox comboBoxBall;
        private System.Windows.Forms.ComboBox comboBoxFood;
        private System.Windows.Forms.Button PlayAnimalBtn;
        private System.Windows.Forms.Button SimulateBtn;
        private System.Windows.Forms.Button AnimalListBtn;
        private System.Windows.Forms.Button BallListBtn;
        private System.Windows.Forms.Button FoodListBtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button SaveToTxtBtn;
        private System.Windows.Forms.Button CheckBollBtn;
        private System.Windows.Forms.Button FeedAnimalBtn;
        private System.Windows.Forms.Button SimulateFeedBtn;
    }
}

