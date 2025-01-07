namespace Wakey
{
    partial class Timer
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Timer));
            this.tlp_main = new Wakey.RoundedTableLayoutPanel();
            this.tlp_img = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_timer = new Wakey.RoundedLabel();
            this.lbl_state = new System.Windows.Forms.Label();
            this.roundedTopTableLayoutPanel1 = new Wakey.RoundedTableLayoutPanel();
            this.tlp_settings = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_active = new Wakey.RoundedLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_r_r = new Wakey.RoundedLabel();
            this.btn_r_l = new Wakey.RoundedLabel();
            this.lbl_r = new Wakey.RoundedLabel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_s_r = new Wakey.RoundedLabel();
            this.btn_s_l = new Wakey.RoundedLabel();
            this.lbl_s = new Wakey.RoundedLabel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_pause = new Wakey.RoundedLabel();
            this.btn_restart = new Wakey.RoundedLabel();
            this.roundedLabel2 = new Wakey.RoundedLabel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_close = new Wakey.RoundedLabel();
            this.tlp_main.SuspendLayout();
            this.tlp_img.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.roundedTopTableLayoutPanel1.SuspendLayout();
            this.tlp_settings.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_main
            // 
            this.tlp_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.tlp_main.ColumnCount = 1;
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_main.Controls.Add(this.tlp_img, 0, 0);
            this.tlp_main.Controls.Add(this.roundedTopTableLayoutPanel1, 0, 1);
            this.tlp_main.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tlp_main.CornerRadius = 15;
            this.tlp_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_main.Location = new System.Drawing.Point(2, 2);
            this.tlp_main.Margin = new System.Windows.Forms.Padding(2);
            this.tlp_main.Name = "tlp_main";
            this.tlp_main.RoundTopOnly = false;
            this.tlp_main.RowCount = 3;
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.76471F));
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.26471F));
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.60294F));
            this.tlp_main.Size = new System.Drawing.Size(227, 269);
            this.tlp_main.TabIndex = 0;
            // 
            // tlp_img
            // 
            this.tlp_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tlp_img.ColumnCount = 2;
            this.tlp_img.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlp_img.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlp_img.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tlp_img.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_img.Location = new System.Drawing.Point(0, 0);
            this.tlp_img.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_img.Name = "tlp_img";
            this.tlp_img.RowCount = 1;
            this.tlp_img.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_img.Size = new System.Drawing.Size(227, 99);
            this.tlp_img.TabIndex = 1;
            this.tlp_img.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MovableForm_MouseDown);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.lbl_timer, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbl_state, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(90, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.66102F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.33898F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(137, 99);
            this.tableLayoutPanel3.TabIndex = 0;
            this.tableLayoutPanel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MovableForm_MouseDown);
            // 
            // lbl_timer
            // 
            this.lbl_timer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_timer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lbl_timer.BorderRadius = 10;
            this.lbl_timer.Font = new System.Drawing.Font("Unispace", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_timer.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_timer.ForeText = "--:--";
            this.lbl_timer.Location = new System.Drawing.Point(8, 37);
            this.lbl_timer.Margin = new System.Windows.Forms.Padding(8);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(121, 54);
            this.lbl_timer.TabIndex = 3;
            this.lbl_timer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MovableForm_MouseDown);
            // 
            // lbl_state
            // 
            this.lbl_state.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_state.Font = new System.Drawing.Font("Unispace", 10F);
            this.lbl_state.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_state.Location = new System.Drawing.Point(0, 0);
            this.lbl_state.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(137, 29);
            this.lbl_state.TabIndex = 4;
            this.lbl_state.Text = " :";
            this.lbl_state.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lbl_state.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MovableForm_MouseDown);
            // 
            // roundedTopTableLayoutPanel1
            // 
            this.roundedTopTableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.roundedTopTableLayoutPanel1.ColumnCount = 1;
            this.roundedTopTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.roundedTopTableLayoutPanel1.Controls.Add(this.tlp_settings, 0, 0);
            this.roundedTopTableLayoutPanel1.CornerRadius = 20;
            this.roundedTopTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedTopTableLayoutPanel1.Location = new System.Drawing.Point(0, 99);
            this.roundedTopTableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.roundedTopTableLayoutPanel1.Name = "roundedTopTableLayoutPanel1";
            this.roundedTopTableLayoutPanel1.RoundTopOnly = true;
            this.roundedTopTableLayoutPanel1.RowCount = 1;
            this.roundedTopTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.roundedTopTableLayoutPanel1.Size = new System.Drawing.Size(227, 133);
            this.roundedTopTableLayoutPanel1.TabIndex = 1;
            // 
            // tlp_settings
            // 
            this.tlp_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tlp_settings.ColumnCount = 1;
            this.tlp_settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_settings.Controls.Add(this.tableLayoutPanel9, 0, 3);
            this.tlp_settings.Controls.Add(this.tableLayoutPanel6, 0, 2);
            this.tlp_settings.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tlp_settings.Controls.Add(this.tableLayoutPanel8, 0, 0);
            this.tlp_settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_settings.Location = new System.Drawing.Point(1, 1);
            this.tlp_settings.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_settings.Name = "tlp_settings";
            this.tlp_settings.RowCount = 4;
            this.tlp_settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.78788F));
            this.tlp_settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this.tlp_settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.31579F));
            this.tlp_settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
            this.tlp_settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_settings.Size = new System.Drawing.Size(225, 131);
            this.tlp_settings.TabIndex = 0;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel10, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 102);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(225, 29);
            this.tableLayoutPanel9.TabIndex = 3;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 3;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel10.Controls.Add(this.Btn_active, 1, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(90, 0);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(135, 29);
            this.tableLayoutPanel10.TabIndex = 7;
            // 
            // Btn_active
            // 
            this.Btn_active.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.Btn_active.BorderRadius = 5;
            this.Btn_active.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_active.Font = new System.Drawing.Font("Unispace", 8F);
            this.Btn_active.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_active.ForeText = "True";
            this.Btn_active.Location = new System.Drawing.Point(33, 2);
            this.Btn_active.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.Btn_active.Name = "Btn_active";
            this.Btn_active.Size = new System.Drawing.Size(67, 25);
            this.Btn_active.TabIndex = 6;
            this.Btn_active.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_active.Click += new System.EventHandler(this.Btn_active_Click);
            this.Btn_active.MouseEnter += new System.EventHandler(this.Btn_Close_MouseEnter);
            this.Btn_active.MouseLeave += new System.EventHandler(this.Btn_Close_MouseLeave);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Unispace", 8F);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(10, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Style:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel6.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 68);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(225, 34);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Unispace", 8F);
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(10, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 34);
            this.label6.TabIndex = 5;
            this.label6.Text = "Rest:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.Controls.Add(this.btn_r_r, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.btn_r_l, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.lbl_r, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(90, 0);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(135, 34);
            this.tableLayoutPanel7.TabIndex = 6;
            // 
            // btn_r_r
            // 
            this.btn_r_r.BackColor = System.Drawing.Color.Transparent;
            this.btn_r_r.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_r_r.BorderRadius = 5;
            this.btn_r_r.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_r_r.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.btn_r_r.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_r_r.ForeText = ">";
            this.btn_r_r.Location = new System.Drawing.Point(105, 3);
            this.btn_r_r.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_r_r.Name = "btn_r_r";
            this.btn_r_r.Size = new System.Drawing.Size(25, 28);
            this.btn_r_r.TabIndex = 2;
            this.btn_r_r.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_r_r.Click += new System.EventHandler(this.Btn_r_r_Click);
            this.btn_r_r.MouseEnter += new System.EventHandler(this.Btn_Arrows_MouseEnter);
            this.btn_r_r.MouseLeave += new System.EventHandler(this.Btn_Arrows_MouseLeave);
            // 
            // btn_r_l
            // 
            this.btn_r_l.BackColor = System.Drawing.Color.Transparent;
            this.btn_r_l.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_r_l.BorderRadius = 5;
            this.btn_r_l.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_r_l.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.btn_r_l.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_r_l.ForeText = "<";
            this.btn_r_l.Location = new System.Drawing.Point(5, 3);
            this.btn_r_l.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_r_l.Name = "btn_r_l";
            this.btn_r_l.Size = new System.Drawing.Size(23, 28);
            this.btn_r_l.TabIndex = 5;
            this.btn_r_l.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_r_l.Click += new System.EventHandler(this.Btn_r_l_Click);
            this.btn_r_l.MouseEnter += new System.EventHandler(this.Btn_Arrows_MouseEnter);
            this.btn_r_l.MouseLeave += new System.EventHandler(this.Btn_Arrows_MouseLeave);
            // 
            // lbl_r
            // 
            this.lbl_r.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lbl_r.BorderRadius = 3;
            this.lbl_r.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_r.Font = new System.Drawing.Font("Unispace", 10F);
            this.lbl_r.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_r.ForeText = "10";
            this.lbl_r.Location = new System.Drawing.Point(36, 3);
            this.lbl_r.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_r.Name = "lbl_r";
            this.lbl_r.Size = new System.Drawing.Size(61, 28);
            this.lbl_r.TabIndex = 3;
            this.lbl_r.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 38);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(225, 30);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Unispace", 8F);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(10, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Study:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Controls.Add(this.btn_s_r, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.btn_s_l, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lbl_s, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(90, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(135, 30);
            this.tableLayoutPanel5.TabIndex = 6;
            // 
            // btn_s_r
            // 
            this.btn_s_r.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_s_r.BorderRadius = 5;
            this.btn_s_r.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_s_r.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.btn_s_r.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_s_r.ForeText = ">";
            this.btn_s_r.Location = new System.Drawing.Point(105, 3);
            this.btn_s_r.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_s_r.Name = "btn_s_r";
            this.btn_s_r.Size = new System.Drawing.Size(25, 24);
            this.btn_s_r.TabIndex = 2;
            this.btn_s_r.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_s_r.Click += new System.EventHandler(this.Btn_s_r_Click);
            this.btn_s_r.MouseEnter += new System.EventHandler(this.Btn_Arrows_MouseEnter);
            this.btn_s_r.MouseLeave += new System.EventHandler(this.Btn_Arrows_MouseLeave);
            // 
            // btn_s_l
            // 
            this.btn_s_l.BackColor = System.Drawing.Color.Transparent;
            this.btn_s_l.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_s_l.BorderRadius = 5;
            this.btn_s_l.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_s_l.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.btn_s_l.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_s_l.ForeText = "<";
            this.btn_s_l.Location = new System.Drawing.Point(5, 3);
            this.btn_s_l.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_s_l.Name = "btn_s_l";
            this.btn_s_l.Size = new System.Drawing.Size(23, 24);
            this.btn_s_l.TabIndex = 4;
            this.btn_s_l.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_s_l.Click += new System.EventHandler(this.Btn_s_l_Click);
            this.btn_s_l.MouseEnter += new System.EventHandler(this.Btn_Arrows_MouseEnter);
            this.btn_s_l.MouseLeave += new System.EventHandler(this.Btn_Arrows_MouseLeave);
            // 
            // lbl_s
            // 
            this.lbl_s.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lbl_s.BorderRadius = 3;
            this.lbl_s.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_s.Font = new System.Drawing.Font("Unispace", 10F);
            this.lbl_s.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_s.ForeText = "20";
            this.lbl_s.Location = new System.Drawing.Point(36, 3);
            this.lbl_s.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_s.Name = "lbl_s";
            this.lbl_s.Size = new System.Drawing.Size(61, 24);
            this.lbl_s.TabIndex = 3;
            this.lbl_s.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel8.Controls.Add(this.Btn_pause, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.btn_restart, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.roundedLabel2, 2, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(225, 38);
            this.tableLayoutPanel8.TabIndex = 2;
            // 
            // Btn_pause
            // 
            this.Btn_pause.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.Btn_pause.BorderRadius = 5;
            this.Btn_pause.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_pause.Font = new System.Drawing.Font("Unispace", 10F);
            this.Btn_pause.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_pause.ForeText = "Play";
            this.Btn_pause.Location = new System.Drawing.Point(70, 3);
            this.Btn_pause.Margin = new System.Windows.Forms.Padding(3);
            this.Btn_pause.Name = "Btn_pause";
            this.Btn_pause.Size = new System.Drawing.Size(84, 32);
            this.Btn_pause.TabIndex = 5;
            this.Btn_pause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_pause.Click += new System.EventHandler(this.Btn_pause_Click);
            this.Btn_pause.MouseEnter += new System.EventHandler(this.Btn_Play_MouseEnter);
            this.Btn_pause.MouseLeave += new System.EventHandler(this.Btn_Play_MouseLeave);
            // 
            // btn_restart
            // 
            this.btn_restart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btn_restart.BorderRadius = 5;
            this.btn_restart.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_restart.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restart.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_restart.ForeText = "⟳";
            this.btn_restart.Location = new System.Drawing.Point(37, 5);
            this.btn_restart.Margin = new System.Windows.Forms.Padding(15, 5, 5, 5);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(25, 28);
            this.btn_restart.TabIndex = 3;
            this.btn_restart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_restart.Click += new System.EventHandler(this.Btn_Start_Click);
            this.btn_restart.MouseEnter += new System.EventHandler(this.Btn_Close_MouseEnter);
            this.btn_restart.MouseLeave += new System.EventHandler(this.Btn_Close_MouseLeave);
            // 
            // roundedLabel2
            // 
            this.roundedLabel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.roundedLabel2.BorderRadius = 5;
            this.roundedLabel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.roundedLabel2.Font = new System.Drawing.Font("Unispace", 8F);
            this.roundedLabel2.ForeColor = System.Drawing.Color.Gainsboro;
            this.roundedLabel2.ForeText = "✖";
            this.roundedLabel2.Location = new System.Drawing.Point(162, 5);
            this.roundedLabel2.Margin = new System.Windows.Forms.Padding(5, 5, 15, 5);
            this.roundedLabel2.Name = "roundedLabel2";
            this.roundedLabel2.Size = new System.Drawing.Size(25, 28);
            this.roundedLabel2.TabIndex = 4;
            this.roundedLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.roundedLabel2.Click += new System.EventHandler(this.Btn_Stop_Click);
            this.roundedLabel2.MouseEnter += new System.EventHandler(this.Btn_Close_MouseEnter);
            this.roundedLabel2.MouseLeave += new System.EventHandler(this.Btn_Close_MouseLeave);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btn_close, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 232);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(227, 37);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btn_close.BorderRadius = 5;
            this.btn_close.Font = new System.Drawing.Font("Unispace", 8F);
            this.btn_close.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_close.ForeText = "Chiudi";
            this.btn_close.Location = new System.Drawing.Point(15, 7);
            this.btn_close.Margin = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(197, 23);
            this.btn_close.TabIndex = 2;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            this.btn_close.MouseEnter += new System.EventHandler(this.Btn_Close_MouseEnter);
            this.btn_close.MouseLeave += new System.EventHandler(this.Btn_Close_MouseLeave);
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(232, 274);
            this.ControlBox = false;
            this.Controls.Add(this.tlp_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Timer";
            this.Padding = new System.Windows.Forms.Padding(2, 2, 3, 3);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Deactivate += new System.EventHandler(this.StripMenu_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StripMenu_FormClosing);
            this.tlp_main.ResumeLayout(false);
            this.tlp_img.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.roundedTopTableLayoutPanel1.ResumeLayout(false);
            this.tlp_settings.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedTableLayoutPanel tlp_main;
        private System.Windows.Forms.TableLayoutPanel tlp_settings;
        private System.Windows.Forms.TableLayoutPanel tlp_img;
        private RoundedLabel btn_close;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private RoundedLabel lbl_timer;
        private System.Windows.Forms.Label lbl_state;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private RoundedLabel lbl_s;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private RoundedLabel lbl_r;
        private RoundedTableLayoutPanel roundedTopTableLayoutPanel1;
        private RoundedLabel btn_s_l;
        private RoundedLabel btn_r_r;
        private RoundedLabel btn_s_r;
        private RoundedLabel btn_r_l;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private RoundedLabel roundedLabel2;
        private RoundedLabel btn_restart;
        private RoundedLabel Btn_pause;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private RoundedLabel Btn_active;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
    }
}
