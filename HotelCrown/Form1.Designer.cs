
namespace HotelCrown
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiRooms = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFeatures = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiServices = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.lvReservation = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.room = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkInDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkOutDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkedIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkedOut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpCheckedIn = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCheckIn = new System.Windows.Forms.ComboBox();
            this.cbCheckOut = new System.Windows.Forms.ComboBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnNewReservation = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRooms,
            this.tsmiFeatures,
            this.tsmiServices,
            this.tsmiCustomers});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(996, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiRooms
            // 
            this.tsmiRooms.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tsmiRooms.Name = "tsmiRooms";
            this.tsmiRooms.Size = new System.Drawing.Size(95, 25);
            this.tsmiRooms.Text = "Rooms    |";
            // 
            // tsmiFeatures
            // 
            this.tsmiFeatures.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tsmiFeatures.Name = "tsmiFeatures";
            this.tsmiFeatures.Size = new System.Drawing.Size(107, 25);
            this.tsmiFeatures.Text = "Features    |";
            // 
            // tsmiServices
            // 
            this.tsmiServices.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tsmiServices.Name = "tsmiServices";
            this.tsmiServices.Size = new System.Drawing.Size(110, 25);
            this.tsmiServices.Text = "Services     |";
            // 
            // tsmiCustomers
            // 
            this.tsmiCustomers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tsmiCustomers.Name = "tsmiCustomers";
            this.tsmiCustomers.Size = new System.Drawing.Size(102, 25);
            this.tsmiCustomers.Text = "Customers";
            // 
            // lvReservation
            // 
            this.lvReservation.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvReservation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.room,
            this.checkInDate,
            this.checkOutDate,
            this.checkedIn,
            this.checkedOut,
            this.customers});
            this.lvReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvReservation.GridLines = true;
            this.lvReservation.HideSelection = false;
            this.lvReservation.HoverSelection = true;
            this.lvReservation.Location = new System.Drawing.Point(19, 85);
            this.lvReservation.Name = "lvReservation";
            this.lvReservation.Size = new System.Drawing.Size(938, 388);
            this.lvReservation.TabIndex = 1;
            this.lvReservation.UseCompatibleStateImageBehavior = false;
            this.lvReservation.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "Id";
            this.id.Width = 40;
            // 
            // room
            // 
            this.room.Text = "Room";
            this.room.Width = 84;
            // 
            // checkInDate
            // 
            this.checkInDate.Text = "Check-In Date";
            this.checkInDate.Width = 120;
            // 
            // checkOutDate
            // 
            this.checkOutDate.Text = "Check-Out Date";
            this.checkOutDate.Width = 130;
            // 
            // checkedIn
            // 
            this.checkedIn.Text = "Checked-In?";
            this.checkedIn.Width = 137;
            // 
            // checkedOut
            // 
            this.checkedOut.Text = "Checked-Out?";
            this.checkedOut.Width = 147;
            // 
            // customers
            // 
            this.customers.Text = "Customers";
            this.customers.Width = 276;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnNewReservation);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lvReservation);
            this.panel1.Location = new System.Drawing.Point(12, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 551);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reservations";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.tbSearch);
            this.panel2.Controls.Add(this.cbCheckOut);
            this.panel2.Controls.Add(this.cbCheckIn);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dtpCheckOut);
            this.panel2.Controls.Add(this.dtpCheckedIn);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(19, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(938, 46);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Filter By";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "To";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "From";
            // 
            // dtpCheckedIn
            // 
            this.dtpCheckedIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckedIn.Location = new System.Drawing.Point(179, 10);
            this.dtpCheckedIn.Name = "dtpCheckedIn";
            this.dtpCheckedIn.Size = new System.Drawing.Size(99, 26);
            this.dtpCheckedIn.TabIndex = 0;
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckOut.Location = new System.Drawing.Point(317, 11);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(99, 26);
            this.dtpCheckOut.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(452, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Checked In";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(573, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Checked Out";
            // 
            // cbCheckIn
            // 
            this.cbCheckIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbCheckIn.FormattingEnabled = true;
            this.cbCheckIn.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbCheckIn.Location = new System.Drawing.Point(456, 28);
            this.cbCheckIn.Name = "cbCheckIn";
            this.cbCheckIn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbCheckIn.Size = new System.Drawing.Size(86, 24);
            this.cbCheckIn.TabIndex = 2;
            // 
            // cbCheckOut
            // 
            this.cbCheckOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbCheckOut.FormattingEnabled = true;
            this.cbCheckOut.ItemHeight = 16;
            this.cbCheckOut.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbCheckOut.Location = new System.Drawing.Point(577, 27);
            this.cbCheckOut.Name = "cbCheckOut";
            this.cbCheckOut.Size = new System.Drawing.Size(98, 24);
            this.cbCheckOut.TabIndex = 3;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(695, 11);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(231, 26);
            this.tbSearch.TabIndex = 4;
            this.tbSearch.Text = "Search..";
            // 
            // btnNewReservation
            // 
            this.btnNewReservation.BackColor = System.Drawing.Color.SpringGreen;
            this.btnNewReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNewReservation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNewReservation.Location = new System.Drawing.Point(26, 489);
            this.btnNewReservation.Name = "btnNewReservation";
            this.btnNewReservation.Size = new System.Drawing.Size(226, 47);
            this.btnNewReservation.TabIndex = 0;
            this.btnNewReservation.Text = "NEW RESERVATION";
            this.btnNewReservation.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(547, 489);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(226, 47);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Gold;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(293, 489);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(226, 47);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 595);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Hotel Crown";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiRooms;
        private System.Windows.Forms.ToolStripMenuItem tsmiFeatures;
        private System.Windows.Forms.ToolStripMenuItem tsmiServices;
        private System.Windows.Forms.ToolStripMenuItem tsmiCustomers;
        private System.Windows.Forms.ListView lvReservation;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader room;
        private System.Windows.Forms.ColumnHeader checkInDate;
        private System.Windows.Forms.ColumnHeader checkOutDate;
        private System.Windows.Forms.ColumnHeader checkedIn;
        private System.Windows.Forms.ColumnHeader checkedOut;
        private System.Windows.Forms.ColumnHeader customers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewReservation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ComboBox cbCheckOut;
        private System.Windows.Forms.ComboBox cbCheckIn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.DateTimePicker dtpCheckedIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}

