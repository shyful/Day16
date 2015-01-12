namespace EmployeeInfoAppUsingLayer
{
    partial class MainUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.editAndFindbutton = new System.Windows.Forms.Button();
            this.designationButton = new System.Windows.Forms.Button();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.editAndFindbutton);
            this.groupBox1.Controls.Add(this.designationButton);
            this.groupBox1.Controls.Add(this.addEmployeeButton);
            this.groupBox1.Location = new System.Drawing.Point(28, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 145);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee";
            // 
            // editAndFindbutton
            // 
            this.editAndFindbutton.Location = new System.Drawing.Point(256, 54);
            this.editAndFindbutton.Name = "editAndFindbutton";
            this.editAndFindbutton.Size = new System.Drawing.Size(113, 47);
            this.editAndFindbutton.TabIndex = 2;
            this.editAndFindbutton.Text = "Find & Edit";
            this.editAndFindbutton.UseVisualStyleBackColor = true;
            this.editAndFindbutton.Click += new System.EventHandler(this.editAndFindbutton_Click);
            // 
            // designationButton
            // 
            this.designationButton.Location = new System.Drawing.Point(142, 54);
            this.designationButton.Name = "designationButton";
            this.designationButton.Size = new System.Drawing.Size(95, 47);
            this.designationButton.TabIndex = 1;
            this.designationButton.Text = "Add Designation";
            this.designationButton.UseVisualStyleBackColor = true;
            this.designationButton.Click += new System.EventHandler(this.designationButton_Click);
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Location = new System.Drawing.Point(22, 54);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(100, 47);
            this.addEmployeeButton.TabIndex = 0;
            this.addEmployeeButton.Text = "Add Employee";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 181);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainUI";
            this.Text = "MainUI";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button editAndFindbutton;
        private System.Windows.Forms.Button designationButton;
        private System.Windows.Forms.Button addEmployeeButton;
    }
}

