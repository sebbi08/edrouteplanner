﻿namespace EDRoutePlanner
{
	partial class StationControl
	{
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Komponenten-Designer generierter Code

		/// <summary> 
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.lblStationName = new System.Windows.Forms.Label();
			this.lblSystemName = new System.Windows.Forms.Label();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.btnInsertDestination = new System.Windows.Forms.Button();
			this.btnEvaluateOptions = new System.Windows.Forms.Button();
			this.btnAddTransaction = new System.Windows.Forms.Button();
			this.btnDelTransaction = new System.Windows.Forms.Button();
			this.btnDelDestination = new System.Windows.Forms.Button();
			this.btnEditDestination = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblStationName
			// 
			this.lblStationName.AutoSize = true;
			this.lblStationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStationName.Location = new System.Drawing.Point(41, 16);
			this.lblStationName.Name = "lblStationName";
			this.lblStationName.Size = new System.Drawing.Size(134, 24);
			this.lblStationName.TabIndex = 1;
			this.lblStationName.Text = "Station Name";
			// 
			// lblSystemName
			// 
			this.lblSystemName.AutoSize = true;
			this.lblSystemName.Location = new System.Drawing.Point(41, 3);
			this.lblSystemName.Name = "lblSystemName";
			this.lblSystemName.Size = new System.Drawing.Size(72, 13);
			this.lblSystemName.TabIndex = 2;
			this.lblSystemName.Text = "System Name";
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listView1.Location = new System.Drawing.Point(44, 43);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(451, 85);
			this.listView1.TabIndex = 3;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Commodity";
			this.columnHeader1.Width = 120;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Amount";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Profit per Unit";
			this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Profit";
			this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btnInsertDestination
			// 
			this.btnInsertDestination.Image = global::EDRoutePlanner.Properties.Resources.flag;
			this.btnInsertDestination.Location = new System.Drawing.Point(3, 104);
			this.btnInsertDestination.Name = "btnInsertDestination";
			this.btnInsertDestination.Size = new System.Drawing.Size(35, 23);
			this.btnInsertDestination.TabIndex = 8;
			this.toolTip1.SetToolTip(this.btnInsertDestination, "Insert a new destination after this one");
			this.btnInsertDestination.UseVisualStyleBackColor = true;
			this.btnInsertDestination.Click += new System.EventHandler(this.btnInsertDestination_Click);
			// 
			// btnEvaluateOptions
			// 
			this.btnEvaluateOptions.Image = global::EDRoutePlanner.Properties.Resources.compass;
			this.btnEvaluateOptions.Location = new System.Drawing.Point(3, 134);
			this.btnEvaluateOptions.Name = "btnEvaluateOptions";
			this.btnEvaluateOptions.Size = new System.Drawing.Size(35, 23);
			this.btnEvaluateOptions.TabIndex = 7;
			this.toolTip1.SetToolTip(this.btnEvaluateOptions, "Evaluate Options");
			this.btnEvaluateOptions.UseVisualStyleBackColor = true;
			this.btnEvaluateOptions.Click += new System.EventHandler(this.btnEvaluateOptions_Click);
			// 
			// btnAddTransaction
			// 
			this.btnAddTransaction.Image = global::EDRoutePlanner.Properties.Resources.insert_row;
			this.btnAddTransaction.Location = new System.Drawing.Point(44, 134);
			this.btnAddTransaction.Name = "btnAddTransaction";
			this.btnAddTransaction.Size = new System.Drawing.Size(35, 23);
			this.btnAddTransaction.TabIndex = 6;
			this.toolTip1.SetToolTip(this.btnAddTransaction, "Insert Transaction");
			this.btnAddTransaction.UseVisualStyleBackColor = true;
			this.btnAddTransaction.Click += new System.EventHandler(this.btnAddTransaction_Click);
			// 
			// btnDelTransaction
			// 
			this.btnDelTransaction.Image = global::EDRoutePlanner.Properties.Resources.delete_row;
			this.btnDelTransaction.Location = new System.Drawing.Point(85, 134);
			this.btnDelTransaction.Name = "btnDelTransaction";
			this.btnDelTransaction.Size = new System.Drawing.Size(35, 23);
			this.btnDelTransaction.TabIndex = 5;
			this.toolTip1.SetToolTip(this.btnDelTransaction, "Remove selected Transaction");
			this.btnDelTransaction.UseVisualStyleBackColor = true;
			this.btnDelTransaction.Click += new System.EventHandler(this.btnDelTransaction_Click);
			// 
			// btnDelDestination
			// 
			this.btnDelDestination.Image = global::EDRoutePlanner.Properties.Resources.denied;
			this.btnDelDestination.Location = new System.Drawing.Point(3, 46);
			this.btnDelDestination.Name = "btnDelDestination";
			this.btnDelDestination.Size = new System.Drawing.Size(35, 23);
			this.btnDelDestination.TabIndex = 4;
			this.toolTip1.SetToolTip(this.btnDelDestination, "Remove this destination");
			this.btnDelDestination.UseVisualStyleBackColor = true;
			this.btnDelDestination.Click += new System.EventHandler(this.btnDelDestination_Click);
			// 
			// btnEditDestination
			// 
			this.btnEditDestination.Image = global::EDRoutePlanner.Properties.Resources.pencil;
			this.btnEditDestination.Location = new System.Drawing.Point(3, 75);
			this.btnEditDestination.Name = "btnEditDestination";
			this.btnEditDestination.Size = new System.Drawing.Size(35, 23);
			this.btnEditDestination.TabIndex = 9;
			this.toolTip1.SetToolTip(this.btnEditDestination, "Change this destination");
			this.btnEditDestination.UseVisualStyleBackColor = true;
			this.btnEditDestination.Click += new System.EventHandler(this.btnEditDestination_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::EDRoutePlanner.Properties.Resources.station;
			this.pictureBox1.Location = new System.Drawing.Point(3, 8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(32, 32);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// StationControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnEditDestination);
			this.Controls.Add(this.btnInsertDestination);
			this.Controls.Add(this.btnEvaluateOptions);
			this.Controls.Add(this.btnAddTransaction);
			this.Controls.Add(this.btnDelTransaction);
			this.Controls.Add(this.btnDelDestination);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.lblSystemName);
			this.Controls.Add(this.lblStationName);
			this.Controls.Add(this.pictureBox1);
			this.Name = "StationControl";
			this.Size = new System.Drawing.Size(498, 162);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblStationName;
		private System.Windows.Forms.Label lblSystemName;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.Button btnDelDestination;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button btnDelTransaction;
		private System.Windows.Forms.Button btnAddTransaction;
		private System.Windows.Forms.Button btnEvaluateOptions;
		private System.Windows.Forms.Button btnInsertDestination;
		private System.Windows.Forms.Button btnEditDestination;
	}
}