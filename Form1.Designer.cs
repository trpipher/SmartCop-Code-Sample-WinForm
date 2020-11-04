using System.Collections.Generic;

namespace SmartCop_Code_Sample_WinForm
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
            this.listDrinks = new System.Windows.Forms.ListView();
            this.lblDrinks = new System.Windows.Forms.Label();
            this.radioJuice = new System.Windows.Forms.RadioButton();
            this.radioSoda = new System.Windows.Forms.RadioButton();
            this.radioBeer = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.chkCarbonated = new System.Windows.Forms.CheckBox();
            this.lblExtra = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listDrinks
            // 
            this.listDrinks.HideSelection = false;
            this.listDrinks.Location = new System.Drawing.Point(12, 28);
            this.listDrinks.Name = "listDrinks";
            this.listDrinks.Size = new System.Drawing.Size(366, 220);
            this.listDrinks.TabIndex = 0;
            this.listDrinks.UseCompatibleStateImageBehavior = false;
            this.listDrinks.View = System.Windows.Forms.View.List;
            // 
            // lblDrinks
            // 
            this.lblDrinks.AutoSize = true;
            this.lblDrinks.Location = new System.Drawing.Point(13, 9);
            this.lblDrinks.Name = "lblDrinks";
            this.lblDrinks.Size = new System.Drawing.Size(37, 13);
            this.lblDrinks.TabIndex = 1;
            this.lblDrinks.Text = "Drinks";
            // 
            // radioJuice
            // 
            this.radioJuice.AutoSize = true;
            this.radioJuice.Location = new System.Drawing.Point(562, 28);
            this.radioJuice.Name = "radioJuice";
            this.radioJuice.Size = new System.Drawing.Size(50, 17);
            this.radioJuice.TabIndex = 2;
            this.radioJuice.TabStop = true;
            this.radioJuice.Text = "Juice";
            this.radioJuice.UseVisualStyleBackColor = true;
            this.radioJuice.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioSoda
            // 
            this.radioSoda.AutoSize = true;
            this.radioSoda.Location = new System.Drawing.Point(654, 28);
            this.radioSoda.Name = "radioSoda";
            this.radioSoda.Size = new System.Drawing.Size(50, 17);
            this.radioSoda.TabIndex = 3;
            this.radioSoda.TabStop = true;
            this.radioSoda.Text = "Soda";
            this.radioSoda.UseVisualStyleBackColor = true;
            this.radioSoda.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioBeer
            // 
            this.radioBeer.AutoSize = true;
            this.radioBeer.Location = new System.Drawing.Point(471, 28);
            this.radioBeer.Name = "radioBeer";
            this.radioBeer.Size = new System.Drawing.Size(47, 17);
            this.radioBeer.TabIndex = 4;
            this.radioBeer.TabStop = true;
            this.radioBeer.Text = "Beer";
            this.radioBeer.UseVisualStyleBackColor = true;
            this.radioBeer.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(471, 68);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(471, 52);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name";
            // 
            // txtOther
            // 
            this.txtOther.Location = new System.Drawing.Point(471, 107);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(100, 20);
            this.txtOther.TabIndex = 8;
            // 
            // chkCarbonated
            // 
            this.chkCarbonated.AutoSize = true;
            this.chkCarbonated.Location = new System.Drawing.Point(577, 70);
            this.chkCarbonated.Name = "chkCarbonated";
            this.chkCarbonated.Size = new System.Drawing.Size(81, 17);
            this.chkCarbonated.TabIndex = 10;
            this.chkCarbonated.Text = "Carbonated";
            this.chkCarbonated.UseVisualStyleBackColor = true;
            // 
            // lblExtra
            // 
            this.lblExtra.AutoSize = true;
            this.lblExtra.Location = new System.Drawing.Point(471, 91);
            this.lblExtra.Name = "lblExtra";
            this.lblExtra.Size = new System.Drawing.Size(33, 13);
            this.lblExtra.TabIndex = 11;
            this.lblExtra.Text = "Other";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(471, 159);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 258);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblExtra);
            this.Controls.Add(this.chkCarbonated);
            this.Controls.Add(this.txtOther);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.radioBeer);
            this.Controls.Add(this.radioSoda);
            this.Controls.Add(this.radioJuice);
            this.Controls.Add(this.lblDrinks);
            this.Controls.Add(this.listDrinks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listDrinks;
        private System.Windows.Forms.Label lblDrinks;
        private System.Windows.Forms.RadioButton radioJuice;
        private System.Windows.Forms.RadioButton radioSoda;
        private System.Windows.Forms.RadioButton radioBeer;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.CheckBox chkCarbonated;
        private System.Windows.Forms.Label lblExtra;
        private System.Windows.Forms.Button btnAdd;
    }
}

