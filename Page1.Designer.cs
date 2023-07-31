namespace WjSqlite
{
	partial class Page1
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

		#region Wisej Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.txtConnectionString = new Wisej.Web.TextBox();
            this.txtDebug = new Wisej.Web.TextBox();
            this.btnAddPerson = new Wisej.Web.Button();
            this.SuspendLayout();
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.LabelText = "Connection String";
            this.txtConnectionString.Location = new System.Drawing.Point(70, 37);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(311, 50);
            this.txtConnectionString.TabIndex = 0;
            // 
            // txtDebug
            // 
            this.txtDebug.LabelText = "Debug";
            this.txtDebug.Location = new System.Drawing.Point(74, 111);
            this.txtDebug.Multiline = true;
            this.txtDebug.Name = "txtDebug";
            this.txtDebug.Size = new System.Drawing.Size(306, 458);
            this.txtDebug.TabIndex = 1;
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(80, 588);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(251, 46);
            this.btnAddPerson.TabIndex = 2;
            this.btnAddPerson.Text = "Add Person";
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.txtDebug);
            this.Controls.Add(this.txtConnectionString);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(2496, 1399);
            this.Text = "Page1";
            this.Load += new System.EventHandler(this.Page1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private Wisej.Web.TextBox txtConnectionString;
        private Wisej.Web.TextBox txtDebug;
        private Wisej.Web.Button btnAddPerson;
    }
}

