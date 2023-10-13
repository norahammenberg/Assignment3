namespace Assignment3
{
    partial class MainForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            bmiResult = new Label();
            weightResult = new Label();
            label11 = new Label();
            radioButtonMetric = new RadioButton();
            radioButtonImperial = new RadioButton();
            textName = new TextBox();
            textWeight = new TextBox();
            textHeightRight = new TextBox();
            textHeightLeft = new TextBox();
            buttonCalc = new Button();
            label12 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(56, 31);
            label1.Name = "label1";
            label1.Size = new Size(152, 28);
            label1.TabIndex = 0;
            label1.Text = "BMI Calculator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(56, 87);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(56, 124);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 2;
            label3.Text = "Height:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(56, 158);
            label4.Name = "label4";
            label4.Size = new Size(62, 21);
            label4.TabIndex = 3;
            label4.Text = "Weight:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(502, 87);
            label5.Name = "label5";
            label5.Size = new Size(49, 21);
            label5.TabIndex = 4;
            label5.Text = "Units:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(56, 274);
            label6.Name = "label6";
            label6.Size = new Size(83, 21);
            label6.TabIndex = 5;
            label6.Text = "Result for";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(56, 313);
            label7.Name = "label7";
            label7.Size = new Size(37, 21);
            label7.TabIndex = 6;
            label7.Text = "BMI";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(56, 349);
            label8.Name = "label8";
            label8.Size = new Size(123, 21);
            label8.TabIndex = 7;
            label8.Text = "Weight category";
            // 
            // bmiResult
            // 
            bmiResult.AutoSize = true;
            bmiResult.BorderStyle = BorderStyle.Fixed3D;
            bmiResult.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bmiResult.Location = new Point(406, 313);
            bmiResult.Name = "bmiResult";
            bmiResult.Size = new Size(51, 23);
            bmiResult.TabIndex = 8;
            bmiResult.Text = "result";
            // 
            // weightResult
            // 
            weightResult.AutoSize = true;
            weightResult.BorderStyle = BorderStyle.Fixed3D;
            weightResult.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            weightResult.Location = new Point(406, 349);
            weightResult.Name = "weightResult";
            weightResult.Size = new Size(51, 23);
            weightResult.TabIndex = 9;
            weightResult.Text = "result";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label11.Location = new Point(56, 418);
            label11.Name = "label11";
            label11.Size = new Size(206, 15);
            label11.TabIndex = 10;
            label11.Text = "Normal BMI is between 12.50 and 24.9";
            // 
            // radioButtonMetric
            // 
            radioButtonMetric.AutoSize = true;
            radioButtonMetric.Location = new Point(502, 127);
            radioButtonMetric.Name = "radioButtonMetric";
            radioButtonMetric.Size = new Size(106, 19);
            radioButtonMetric.TabIndex = 11;
            radioButtonMetric.TabStop = true;
            radioButtonMetric.Text = "Metric (kg, cm)";
            radioButtonMetric.UseVisualStyleBackColor = true;
            // 
            // radioButtonImperial
            // 
            radioButtonImperial.AutoSize = true;
            radioButtonImperial.Location = new Point(502, 161);
            radioButtonImperial.Name = "radioButtonImperial";
            radioButtonImperial.Size = new Size(108, 19);
            radioButtonImperial.TabIndex = 12;
            radioButtonImperial.TabStop = true;
            radioButtonImperial.Text = "Imperial (ft, lbs)";
            radioButtonImperial.UseVisualStyleBackColor = true;
            // 
            // textName
            // 
            textName.Location = new Point(186, 85);
            textName.Name = "textName";
            textName.Size = new Size(272, 23);
            textName.TabIndex = 13;
            // 
            // textWeight
            // 
            textWeight.Location = new Point(386, 156);
            textWeight.Name = "textWeight";
            textWeight.Size = new Size(72, 23);
            textWeight.TabIndex = 14;
            // 
            // textHeightRight
            // 
            textHeightRight.Location = new Point(386, 122);
            textHeightRight.Name = "textHeightRight";
            textHeightRight.Size = new Size(72, 23);
            textHeightRight.TabIndex = 15;
            // 
            // textHeightLeft
            // 
            textHeightLeft.Location = new Point(308, 122);
            textHeightLeft.Name = "textHeightLeft";
            textHeightLeft.Size = new Size(72, 23);
            textHeightLeft.TabIndex = 16;
            // 
            // buttonCalc
            // 
            buttonCalc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCalc.Location = new Point(308, 210);
            buttonCalc.Name = "buttonCalc";
            buttonCalc.Size = new Size(150, 30);
            buttonCalc.TabIndex = 17;
            buttonCalc.Text = "Calculate you BMI";
            buttonCalc.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label12.Location = new Point(56, 446);
            label12.Name = "label12";
            label12.Size = new Size(271, 15);
            label12.TabIndex = 18;
            label12.Text = "Normal weight should be between 116 and 157 lbs";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 498);
            Controls.Add(label12);
            Controls.Add(buttonCalc);
            Controls.Add(textHeightLeft);
            Controls.Add(textHeightRight);
            Controls.Add(textWeight);
            Controls.Add(textName);
            Controls.Add(radioButtonImperial);
            Controls.Add(radioButtonMetric);
            Controls.Add(label11);
            Controls.Add(weightResult);
            Controls.Add(bmiResult);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label bmiResult;
        private Label weightResult;
        private Label label11;
        private RadioButton radioButtonMetric;
        private RadioButton radioButtonImperial;
        private TextBox textName;
        private TextBox textWeight;
        private TextBox textHeightRight;
        private TextBox textHeightLeft;
        private Button buttonCalc;
        private Label label12;
    }
}