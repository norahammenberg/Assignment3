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
            height = new Label();
            weight = new Label();
            label5 = new Label();
            resultText = new Label();
            label7 = new Label();
            label8 = new Label();
            bmiResult = new Label();
            weightResult = new Label();
            label11 = new Label();
            textName = new TextBox();
            textWeight = new TextBox();
            inche = new TextBox();
            buttonCalc = new Button();
            label12 = new Label();
            groupBox = new GroupBox();
            radioButtonFT = new RadioButton();
            radioButtonKG = new RadioButton();
            feetCm = new TextBox();
            groupBox.SuspendLayout();
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
            // height
            // 
            height.AutoSize = true;
            height.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            height.Location = new Point(56, 124);
            height.Name = "height";
            height.Size = new Size(59, 21);
            height.TabIndex = 2;
            height.Text = "Height:";
            // 
            // weight
            // 
            weight.AutoSize = true;
            weight.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            weight.Location = new Point(56, 158);
            weight.Name = "weight";
            weight.Size = new Size(62, 21);
            weight.TabIndex = 3;
            weight.Text = "Weight:";
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
            // resultText
            // 
            resultText.AutoSize = true;
            resultText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            resultText.Location = new Point(56, 274);
            resultText.Name = "resultText";
            resultText.Size = new Size(83, 21);
            resultText.TabIndex = 5;
            resultText.Text = "Result for";
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
            // textName
            // 
            textName.Location = new Point(186, 85);
            textName.Name = "textName";
            textName.Size = new Size(272, 23);
            textName.TabIndex = 13;
            // 
            // textWeight
            // 
            textWeight.Location = new Point(326, 156);
            textWeight.Name = "textWeight";
            textWeight.Size = new Size(132, 23);
            textWeight.TabIndex = 14;
            // 
            // inche
            // 
            inche.Location = new Point(406, 122);
            inche.Name = "inche";
            inche.Size = new Size(52, 23);
            inche.TabIndex = 15;
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
            buttonCalc.Click += buttonCalc_Click;
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
            // groupBox
            // 
            groupBox.BackColor = SystemColors.Control;
            groupBox.Controls.Add(radioButtonFT);
            groupBox.Controls.Add(radioButtonKG);
            groupBox.ForeColor = SystemColors.ActiveCaptionText;
            groupBox.Location = new Point(502, 111);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(200, 100);
            groupBox.TabIndex = 19;
            groupBox.TabStop = false;
            // 
            // radioButtonFT
            // 
            radioButtonFT.AutoSize = true;
            radioButtonFT.Location = new Point(6, 47);
            radioButtonFT.Name = "radioButtonFT";
            radioButtonFT.Size = new Size(108, 19);
            radioButtonFT.TabIndex = 13;
            radioButtonFT.TabStop = true;
            radioButtonFT.Text = "Imperial (ft, lbs)";
            radioButtonFT.UseVisualStyleBackColor = true;
            radioButtonFT.CheckedChanged += radioButtonFT_CheckedChanged;
            // 
            // radioButtonKG
            // 
            radioButtonKG.AutoSize = true;
            radioButtonKG.Location = new Point(6, 22);
            radioButtonKG.Name = "radioButtonKG";
            radioButtonKG.Size = new Size(106, 19);
            radioButtonKG.TabIndex = 12;
            radioButtonKG.TabStop = true;
            radioButtonKG.Text = "Metric (kg, cm)";
            radioButtonKG.UseVisualStyleBackColor = true;
            radioButtonKG.CheckedChanged += radioButtonKG_CheckedChanged;
            // 
            // feetCm
            // 
            feetCm.Location = new Point(326, 122);
            feetCm.Name = "feetCm";
            feetCm.Size = new Size(74, 23);
            feetCm.TabIndex = 20;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 498);
            Controls.Add(feetCm);
            Controls.Add(groupBox);
            Controls.Add(label12);
            Controls.Add(buttonCalc);
            Controls.Add(inche);
            Controls.Add(textWeight);
            Controls.Add(textName);
            Controls.Add(label11);
            Controls.Add(weightResult);
            Controls.Add(bmiResult);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(resultText);
            Controls.Add(label5);
            Controls.Add(weight);
            Controls.Add(height);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BMI Calculator by Nora Hammenberg";
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label height;
        private Label weight;
        private Label label5;
        private Label resultText;
        private Label label7;
        private Label label8;
        private Label bmiResult;
        private Label weightResult;
        private Label label11;
        private TextBox textName;
        private TextBox textWeight;
        private TextBox inche;
        private Button buttonCalc;
        private Label label12;
        private GroupBox groupBox;
        private RadioButton radioButtonFT;
        private RadioButton radioButtonKG;
        private TextBox feetCm;
    }
}