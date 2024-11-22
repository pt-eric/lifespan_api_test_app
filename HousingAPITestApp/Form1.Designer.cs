namespace HousingAPITestApp
{
    partial class frmMain
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
            this.btnGenerateHeader = new System.Windows.Forms.Button();
            this.TableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSendRequest = new System.Windows.Forms.Button();
            this.RequestResponse = new System.Windows.Forms.SplitContainer();
            this.InputPanel = new System.Windows.Forms.Panel();
            this.txtContentLength = new System.Windows.Forms.TextBox();
            this.lblContent = new System.Windows.Forms.Label();
            this.btnRefreshTimeStamp = new System.Windows.Forms.Button();
            this.txtComponent = new System.Windows.Forms.TextBox();
            this.txtUPRN = new System.Windows.Forms.TextBox();
            this.txtTimestamp = new System.Windows.Forms.TextBox();
            this.lblUPRN = new System.Windows.Forms.Label();
            this.cmbEndPoint = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblComponent = new System.Windows.Forms.Label();
            this.lblTimestamp = new System.Windows.Forms.Label();
            this.txtSecret = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.lblAPISecret = new System.Windows.Forms.Label();
            this.lblAPIKey = new System.Windows.Forms.Label();
            this.cmbMethod = new System.Windows.Forms.ComboBox();
            this.lblMethod = new System.Windows.Forms.Label();
            this.cmbBaseURL = new System.Windows.Forms.ComboBox();
            this.lblURL = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OutputBox = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCopyToken = new System.Windows.Forms.Button();
            this.txtBearerToken = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBearerPrefix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TableLayout.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RequestResponse)).BeginInit();
            this.RequestResponse.Panel1.SuspendLayout();
            this.RequestResponse.Panel2.SuspendLayout();
            this.RequestResponse.SuspendLayout();
            this.InputPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerateHeader
            // 
            this.btnGenerateHeader.Location = new System.Drawing.Point(2, 2);
            this.btnGenerateHeader.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerateHeader.Name = "btnGenerateHeader";
            this.btnGenerateHeader.Size = new System.Drawing.Size(141, 24);
            this.btnGenerateHeader.TabIndex = 0;
            this.btnGenerateHeader.Text = "Generate Header";
            this.btnGenerateHeader.UseVisualStyleBackColor = true;
            this.btnGenerateHeader.Click += new System.EventHandler(this.btnGenerateHeader_Click);
            // 
            // TableLayout
            // 
            this.TableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayout.ColumnCount = 2;
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.TableLayout.Controls.Add(this.panel1, 1, 0);
            this.TableLayout.Controls.Add(this.RequestResponse, 0, 0);
            this.TableLayout.Location = new System.Drawing.Point(9, 10);
            this.TableLayout.Margin = new System.Windows.Forms.Padding(2);
            this.TableLayout.Name = "TableLayout";
            this.TableLayout.RowCount = 1;
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayout.Size = new System.Drawing.Size(760, 568);
            this.TableLayout.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGenerateHeader);
            this.panel1.Controls.Add(this.btnSendRequest);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(612, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 564);
            this.panel1.TabIndex = 2;
            // 
            // btnSendRequest
            // 
            this.btnSendRequest.Location = new System.Drawing.Point(2, 61);
            this.btnSendRequest.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendRequest.Name = "btnSendRequest";
            this.btnSendRequest.Size = new System.Drawing.Size(141, 24);
            this.btnSendRequest.TabIndex = 1;
            this.btnSendRequest.Text = "Send Request";
            this.btnSendRequest.UseVisualStyleBackColor = true;
            this.btnSendRequest.Click += new System.EventHandler(this.btnSendRequest_Click);
            // 
            // RequestResponse
            // 
            this.RequestResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RequestResponse.Location = new System.Drawing.Point(2, 2);
            this.RequestResponse.Margin = new System.Windows.Forms.Padding(2);
            this.RequestResponse.Name = "RequestResponse";
            this.RequestResponse.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // RequestResponse.Panel1
            // 
            this.RequestResponse.Panel1.Controls.Add(this.InputPanel);
            // 
            // RequestResponse.Panel2
            // 
            this.RequestResponse.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.RequestResponse.Size = new System.Drawing.Size(606, 564);
            this.RequestResponse.SplitterDistance = 246;
            this.RequestResponse.SplitterWidth = 3;
            this.RequestResponse.TabIndex = 3;
            // 
            // InputPanel
            // 
            this.InputPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputPanel.Controls.Add(this.txtContentLength);
            this.InputPanel.Controls.Add(this.lblContent);
            this.InputPanel.Controls.Add(this.btnRefreshTimeStamp);
            this.InputPanel.Controls.Add(this.txtComponent);
            this.InputPanel.Controls.Add(this.txtUPRN);
            this.InputPanel.Controls.Add(this.txtTimestamp);
            this.InputPanel.Controls.Add(this.lblUPRN);
            this.InputPanel.Controls.Add(this.cmbEndPoint);
            this.InputPanel.Controls.Add(this.label5);
            this.InputPanel.Controls.Add(this.lblComponent);
            this.InputPanel.Controls.Add(this.lblTimestamp);
            this.InputPanel.Controls.Add(this.txtSecret);
            this.InputPanel.Controls.Add(this.txtKey);
            this.InputPanel.Controls.Add(this.lblAPISecret);
            this.InputPanel.Controls.Add(this.lblAPIKey);
            this.InputPanel.Controls.Add(this.cmbMethod);
            this.InputPanel.Controls.Add(this.lblMethod);
            this.InputPanel.Controls.Add(this.cmbBaseURL);
            this.InputPanel.Controls.Add(this.lblURL);
            this.InputPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.InputPanel.Location = new System.Drawing.Point(2, 2);
            this.InputPanel.Margin = new System.Windows.Forms.Padding(2);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(601, 242);
            this.InputPanel.TabIndex = 0;
            // 
            // txtContentLength
            // 
            this.txtContentLength.Location = new System.Drawing.Point(82, 191);
            this.txtContentLength.Margin = new System.Windows.Forms.Padding(2);
            this.txtContentLength.MaxLength = 6;
            this.txtContentLength.Name = "txtContentLength";
            this.txtContentLength.Size = new System.Drawing.Size(96, 20);
            this.txtContentLength.TabIndex = 18;
            this.txtContentLength.Text = "0";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(2, 194);
            this.lblContent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(80, 13);
            this.lblContent.TabIndex = 17;
            this.lblContent.Text = "Content Length";
            // 
            // btnRefreshTimeStamp
            // 
            this.btnRefreshTimeStamp.Location = new System.Drawing.Point(182, 122);
            this.btnRefreshTimeStamp.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefreshTimeStamp.Name = "btnRefreshTimeStamp";
            this.btnRefreshTimeStamp.Size = new System.Drawing.Size(56, 20);
            this.btnRefreshTimeStamp.TabIndex = 16;
            this.btnRefreshTimeStamp.Text = "Now";
            this.btnRefreshTimeStamp.UseVisualStyleBackColor = true;
            this.btnRefreshTimeStamp.Click += new System.EventHandler(this.btnRefreshTimeStamp_Click);
            // 
            // txtComponent
            // 
            this.txtComponent.Location = new System.Drawing.Point(82, 145);
            this.txtComponent.Margin = new System.Windows.Forms.Padding(2);
            this.txtComponent.Name = "txtComponent";
            this.txtComponent.Size = new System.Drawing.Size(96, 20);
            this.txtComponent.TabIndex = 15;
            this.txtComponent.Text = "housing";
            // 
            // txtUPRN
            // 
            this.txtUPRN.Location = new System.Drawing.Point(82, 167);
            this.txtUPRN.Margin = new System.Windows.Forms.Padding(2);
            this.txtUPRN.Name = "txtUPRN";
            this.txtUPRN.Size = new System.Drawing.Size(96, 20);
            this.txtUPRN.TabIndex = 14;
            // 
            // txtTimestamp
            // 
            this.txtTimestamp.Location = new System.Drawing.Point(82, 122);
            this.txtTimestamp.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimestamp.Name = "txtTimestamp";
            this.txtTimestamp.Size = new System.Drawing.Size(96, 20);
            this.txtTimestamp.TabIndex = 13;
            // 
            // lblUPRN
            // 
            this.lblUPRN.AutoSize = true;
            this.lblUPRN.Location = new System.Drawing.Point(2, 170);
            this.lblUPRN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUPRN.Name = "lblUPRN";
            this.lblUPRN.Size = new System.Drawing.Size(38, 13);
            this.lblUPRN.TabIndex = 12;
            this.lblUPRN.Text = "UPRN";
            // 
            // cmbEndPoint
            // 
            this.cmbEndPoint.FormattingEnabled = true;
            this.cmbEndPoint.Items.AddRange(new object[] {
            "/public/properties",
            "/public/lookups/attributes",
            "/public/properties/{0}/asbestos",
            "/public/properties/{0}/attachments"});
            this.cmbEndPoint.Location = new System.Drawing.Point(82, 28);
            this.cmbEndPoint.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEndPoint.Name = "cmbEndPoint";
            this.cmbEndPoint.Size = new System.Drawing.Size(342, 21);
            this.cmbEndPoint.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "API Endpoint";
            // 
            // lblComponent
            // 
            this.lblComponent.AutoSize = true;
            this.lblComponent.Location = new System.Drawing.Point(2, 147);
            this.lblComponent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComponent.Name = "lblComponent";
            this.lblComponent.Size = new System.Drawing.Size(61, 13);
            this.lblComponent.TabIndex = 9;
            this.lblComponent.Text = "Component";
            // 
            // lblTimestamp
            // 
            this.lblTimestamp.AutoSize = true;
            this.lblTimestamp.Location = new System.Drawing.Point(2, 124);
            this.lblTimestamp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimestamp.Name = "lblTimestamp";
            this.lblTimestamp.Size = new System.Drawing.Size(63, 13);
            this.lblTimestamp.TabIndex = 8;
            this.lblTimestamp.Text = "Time Stamp";
            // 
            // txtSecret
            // 
            this.txtSecret.Location = new System.Drawing.Point(82, 99);
            this.txtSecret.Margin = new System.Windows.Forms.Padding(2);
            this.txtSecret.Name = "txtSecret";
            this.txtSecret.Size = new System.Drawing.Size(342, 20);
            this.txtSecret.TabIndex = 7;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(82, 76);
            this.txtKey.Margin = new System.Windows.Forms.Padding(2);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(342, 20);
            this.txtKey.TabIndex = 6;
            // 
            // lblAPISecret
            // 
            this.lblAPISecret.AutoSize = true;
            this.lblAPISecret.Location = new System.Drawing.Point(2, 102);
            this.lblAPISecret.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAPISecret.Name = "lblAPISecret";
            this.lblAPISecret.Size = new System.Drawing.Size(58, 13);
            this.lblAPISecret.TabIndex = 5;
            this.lblAPISecret.Text = "API Secret";
            // 
            // lblAPIKey
            // 
            this.lblAPIKey.AutoSize = true;
            this.lblAPIKey.Location = new System.Drawing.Point(2, 79);
            this.lblAPIKey.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAPIKey.Name = "lblAPIKey";
            this.lblAPIKey.Size = new System.Drawing.Size(45, 13);
            this.lblAPIKey.TabIndex = 4;
            this.lblAPIKey.Text = "API Key";
            // 
            // cmbMethod
            // 
            this.cmbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMethod.FormattingEnabled = true;
            this.cmbMethod.Items.AddRange(new object[] {
            "GET",
            "POST",
            "PUT",
            "DELETE"});
            this.cmbMethod.Location = new System.Drawing.Point(82, 52);
            this.cmbMethod.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMethod.Name = "cmbMethod";
            this.cmbMethod.Size = new System.Drawing.Size(92, 21);
            this.cmbMethod.TabIndex = 3;
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Location = new System.Drawing.Point(2, 54);
            this.lblMethod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(43, 13);
            this.lblMethod.TabIndex = 2;
            this.lblMethod.Text = "Method";
            // 
            // cmbBaseURL
            // 
            this.cmbBaseURL.FormattingEnabled = true;
            this.cmbBaseURL.Items.AddRange(new object[] {
            "https://www.pt-lifespan.com/api/uat/housing/v1.1/lh"});
            this.cmbBaseURL.Location = new System.Drawing.Point(82, 5);
            this.cmbBaseURL.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBaseURL.Name = "cmbBaseURL";
            this.cmbBaseURL.Size = new System.Drawing.Size(342, 21);
            this.cmbBaseURL.TabIndex = 1;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(2, 7);
            this.lblURL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(56, 13);
            this.lblURL.TabIndex = 0;
            this.lblURL.Text = "Base URL";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.OutputBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(606, 315);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // OutputBox
            // 
            this.OutputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputBox.Location = new System.Drawing.Point(2, 105);
            this.OutputBox.Margin = new System.Windows.Forms.Padding(2);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(602, 208);
            this.OutputBox.TabIndex = 1;
            this.OutputBox.Text = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCopyToken);
            this.panel2.Controls.Add(this.txtBearerToken);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtBearerPrefix);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 97);
            this.panel2.TabIndex = 2;
            // 
            // btnCopyToken
            // 
            this.btnCopyToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyToken.Location = new System.Drawing.Point(532, 30);
            this.btnCopyToken.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCopyToken.Name = "btnCopyToken";
            this.btnCopyToken.Size = new System.Drawing.Size(48, 26);
            this.btnCopyToken.TabIndex = 11;
            this.btnCopyToken.Text = "Copy";
            this.btnCopyToken.UseVisualStyleBackColor = true;
            this.btnCopyToken.Click += new System.EventHandler(this.btnCopyToken_Click);
            // 
            // txtBearerToken
            // 
            this.txtBearerToken.Location = new System.Drawing.Point(81, 30);
            this.txtBearerToken.Margin = new System.Windows.Forms.Padding(2);
            this.txtBearerToken.Multiline = true;
            this.txtBearerToken.Name = "txtBearerToken";
            this.txtBearerToken.ReadOnly = true;
            this.txtBearerToken.Size = new System.Drawing.Size(446, 53);
            this.txtBearerToken.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Bearer Token";
            // 
            // txtBearerPrefix
            // 
            this.txtBearerPrefix.Location = new System.Drawing.Point(81, 6);
            this.txtBearerPrefix.Margin = new System.Windows.Forms.Padding(2);
            this.txtBearerPrefix.Name = "txtBearerPrefix";
            this.txtBearerPrefix.ReadOnly = true;
            this.txtBearerPrefix.Size = new System.Drawing.Size(76, 20);
            this.txtBearerPrefix.TabIndex = 8;
            this.txtBearerPrefix.Text = "LSAPI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bearer Prefix";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 594);
            this.Controls.Add(this.TableLayout);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(619, 430);
            this.Name = "frmMain";
            this.Text = "Housing API Utility";
            this.TableLayout.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.RequestResponse.Panel1.ResumeLayout(false);
            this.RequestResponse.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RequestResponse)).EndInit();
            this.RequestResponse.ResumeLayout(false);
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateHeader;
        private System.Windows.Forms.TableLayoutPanel TableLayout;
        private System.Windows.Forms.Button btnSendRequest;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer RequestResponse;
        private System.Windows.Forms.Panel InputPanel;
        private System.Windows.Forms.ComboBox cmbBaseURL;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.ComboBox cmbMethod;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.TextBox txtSecret;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label lblAPISecret;
        private System.Windows.Forms.Label lblAPIKey;
        private System.Windows.Forms.TextBox txtComponent;
        private System.Windows.Forms.TextBox txtUPRN;
        private System.Windows.Forms.TextBox txtTimestamp;
        private System.Windows.Forms.Label lblUPRN;
        private System.Windows.Forms.ComboBox cmbEndPoint;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblComponent;
        private System.Windows.Forms.Label lblTimestamp;
        private System.Windows.Forms.Button btnRefreshTimeStamp;
        private System.Windows.Forms.TextBox txtContentLength;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox OutputBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBearerPrefix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCopyToken;
        private System.Windows.Forms.TextBox txtBearerToken;
        private System.Windows.Forms.Label label2;
    }
}

