using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using BackpackProblem;

[assembly: InternalsVisibleTo("BackpackProblem")]

namespace WinFormsApp_Backpack_problem
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
            Number_of_items = new TextBox();
            Capacity = new TextBox();
            Seed = new TextBox();
            run_button = new Button();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            Instance = new RichTextBox();
            Results = new RichTextBox();
            SuspendLayout();
            // 
            // Number_of_items
            // 
            Number_of_items.Location = new Point(22, 34);
            Number_of_items.Name = "Number_of_items";
            Number_of_items.Size = new Size(190, 27);
            Number_of_items.TabIndex = 2;
            // 
            // Capacity
            // 
            Capacity.Location = new Point(22, 164);
            Capacity.Name = "Capacity";
            Capacity.Size = new Size(190, 27);
            Capacity.TabIndex = 3;
            // 
            // Seed
            // 
            Seed.Location = new Point(22, 100);
            Seed.Name = "Seed";
            Seed.Size = new Size(190, 27);
            Seed.TabIndex = 4;
            Seed.TextChanged += textBox5_TextChanged;
            // 
            // run_button
            // 
            run_button.Location = new Point(22, 213);
            run_button.Name = "run_button";
            run_button.Size = new Size(118, 29);
            run_button.TabIndex = 5;
            run_button.Text = "RUN";
            run_button.UseVisualStyleBackColor = true;
            run_button.Click += Run_button_1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(187, 213);
            label2.Name = "label2";
            label2.Size = new Size(133, 31);
            label2.TabIndex = 7;
            label2.Text = "Results";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(497, 18);
            label3.Name = "label3";
            label3.Size = new Size(150, 31);
            label3.TabIndex = 8;
            label3.Text = "Instance";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(22, 11);
            label1.Name = "label1";
            label1.Size = new Size(174, 20);
            label1.TabIndex = 9;
            label1.Text = "Number of items";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Courier New", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(22, 141);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 10;
            label4.Text = "Capacity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Courier New", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label5.Location = new Point(22, 77);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 11;
            label5.Text = "Seed";
            // 
            // Instance
            // 
            Instance.Location = new Point(387, 77);
            Instance.Name = "Instance";
            Instance.Size = new Size(269, 552);
            Instance.TabIndex = 12;
            Instance.Text = "";
            // 
            // Results
            // 
            Results.Location = new Point(22, 267);
            Results.Name = "Results";
            Results.Size = new Size(298, 362);
            Results.TabIndex = 13;
            Results.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(682, 653);
            Controls.Add(Results);
            Controls.Add(Instance);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(run_button);
            Controls.Add(Seed);
            Controls.Add(Capacity);
            Controls.Add(Number_of_items);
            Name = "Form1";
            Text = "Backpack Problem GUI";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Number_of_items;
        private TextBox Capacity;
        private TextBox Seed;
        private Button run_button;
        private Label label2;
        private Label label3;
        private Label label1;
        private Label label4;
        private Label label5;
        private RichTextBox Instance;
        private RichTextBox Results;
    }
}
