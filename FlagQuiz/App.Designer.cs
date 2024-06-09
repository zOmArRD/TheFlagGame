/*
 * Created by zOmArRD using Rider by JetBrains
 *
 * Date: 09/06/2004
 */
namespace FlagQuiz
{
    partial class App
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
            groupBox1 = new GroupBox();
            flagBox = new PictureBox();
            label1 = new Label();
            comboBoxCountries = new ComboBox();
            resultTextBox = new TextBox();
            submitBtn = new Button();
            scoreTextBox = new TextBox();
            nextBtn = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)flagBox).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(flagBox);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(15, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10);
            groupBox1.Size = new Size(313, 181);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Flag";
            // 
            // flagBox
            // 
            flagBox.Dock = DockStyle.Fill;
            flagBox.Image = Properties.Resources.Dominican_Republic;
            flagBox.Location = new Point(10, 26);
            flagBox.Name = "flagBox";
            flagBox.Size = new Size(293, 145);
            flagBox.SizeMode = PictureBoxSizeMode.StretchImage;
            flagBox.TabIndex = 1;
            flagBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(367, 49);
            label1.Name = "label1";
            label1.Size = new Size(114, 21);
            label1.TabIndex = 1;
            label1.Text = "Select Country:";
            // 
            // comboBoxCountries
            // 
            comboBoxCountries.FormattingEnabled = true;
            comboBoxCountries.Location = new Point(367, 73);
            comboBoxCountries.Name = "comboBoxCountries";
            comboBoxCountries.Size = new Size(154, 23);
            comboBoxCountries.TabIndex = 2;
            // 
            // resultTextBox
            // 
            resultTextBox.Font = new Font("Segoe UI", 12F);
            resultTextBox.Location = new Point(367, 114);
            resultTextBox.Name = "resultTextBox";
            resultTextBox.ReadOnly = true;
            resultTextBox.Size = new Size(154, 29);
            resultTextBox.TabIndex = 3;
            resultTextBox.Text = "Correct!";
            resultTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // submitBtn
            // 
            submitBtn.Font = new Font("Segoe UI", 12F);
            submitBtn.Location = new Point(562, 40);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(131, 45);
            submitBtn.TabIndex = 4;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.MouseClick += OnSubmit;
            // 
            // scoreTextBox
            // 
            scoreTextBox.Font = new Font("Segoe UI", 12F);
            scoreTextBox.Location = new Point(367, 167);
            scoreTextBox.Name = "scoreTextBox";
            scoreTextBox.ReadOnly = true;
            scoreTextBox.Size = new Size(326, 29);
            scoreTextBox.TabIndex = 6;
            scoreTextBox.Text = "Excelent";
            scoreTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // nextBtn
            // 
            nextBtn.Font = new Font("Segoe UI", 12F);
            nextBtn.Location = new Point(562, 98);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(131, 45);
            nextBtn.TabIndex = 7;
            nextBtn.Text = "Next";
            nextBtn.UseVisualStyleBackColor = true;
            nextBtn.MouseClick += OnNext;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 211);
            Controls.Add(nextBtn);
            Controls.Add(scoreTextBox);
            Controls.Add(submitBtn);
            Controls.Add(resultTextBox);
            Controls.Add(comboBoxCountries);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MaximumSize = new Size(733, 250);
            MinimumSize = new Size(733, 250);
            Name = "App";
            Padding = new Padding(15);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)flagBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox flagBox;
        private Label label1;
        private ComboBox comboBoxCountries;
        private TextBox resultTextBox;
        private Button submitBtn;
        private TextBox scoreTextBox;
        private Button nextBtn;
    }
}