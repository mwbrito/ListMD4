namespace ListMD4
{
    partial class FrmMain
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
            lblNomeSistemaTopo = new System.Windows.Forms.Label();
            cboAmbiente = new System.Windows.Forms.ComboBox();
            lblAmbiente = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnPesquisar = new System.Windows.Forms.Button();
            txtEndpoint = new System.Windows.Forms.TextBox();
            lblEndpoint = new System.Windows.Forms.Label();
            txtGrupo = new System.Windows.Forms.TextBox();
            lblDataId = new System.Windows.Forms.Label();
            tabControlListMD4 = new System.Windows.Forms.TabControl();
            tabPesquisar = new System.Windows.Forms.TabPage();
            tabResultado = new System.Windows.Forms.TabPage();
            treeViewEndpointsDataIds = new System.Windows.Forms.TreeView();
            button1 = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            tabControlListMD4.SuspendLayout();
            tabPesquisar.SuspendLayout();
            tabResultado.SuspendLayout();
            SuspendLayout();
            // 
            // lblNomeSistemaTopo
            // 
            lblNomeSistemaTopo.AutoSize = true;
            lblNomeSistemaTopo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblNomeSistemaTopo.Location = new System.Drawing.Point(22, 13);
            lblNomeSistemaTopo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblNomeSistemaTopo.Name = "lblNomeSistemaTopo";
            lblNomeSistemaTopo.Size = new System.Drawing.Size(83, 26);
            lblNomeSistemaTopo.TabIndex = 19;
            lblNomeSistemaTopo.Text = "ListMD4";
            // 
            // cboAmbiente
            // 
            cboAmbiente.FormattingEnabled = true;
            cboAmbiente.Location = new System.Drawing.Point(307, 13);
            cboAmbiente.Margin = new System.Windows.Forms.Padding(2);
            cboAmbiente.Name = "cboAmbiente";
            cboAmbiente.Size = new System.Drawing.Size(160, 23);
            cboAmbiente.TabIndex = 18;
            // 
            // lblAmbiente
            // 
            lblAmbiente.AutoSize = true;
            lblAmbiente.Location = new System.Drawing.Point(246, 15);
            lblAmbiente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblAmbiente.Name = "lblAmbiente";
            lblAmbiente.Size = new System.Drawing.Size(59, 15);
            lblAmbiente.TabIndex = 17;
            lblAmbiente.Text = "Ambiente";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnPesquisar);
            groupBox1.Controls.Add(txtEndpoint);
            groupBox1.Controls.Add(lblEndpoint);
            groupBox1.Controls.Add(txtGrupo);
            groupBox1.Controls.Add(lblDataId);
            groupBox1.Location = new System.Drawing.Point(14, 5);
            groupBox1.Margin = new System.Windows.Forms.Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(2);
            groupBox1.Size = new System.Drawing.Size(404, 179);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new System.Drawing.Point(83, 116);
            btnPesquisar.Margin = new System.Windows.Forms.Padding(2);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new System.Drawing.Size(288, 31);
            btnPesquisar.TabIndex = 12;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtEndpoint
            // 
            txtEndpoint.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            txtEndpoint.Location = new System.Drawing.Point(83, 28);
            txtEndpoint.Margin = new System.Windows.Forms.Padding(2);
            txtEndpoint.Name = "txtEndpoint";
            txtEndpoint.Size = new System.Drawing.Size(288, 23);
            txtEndpoint.TabIndex = 11;
            // 
            // lblEndpoint
            // 
            lblEndpoint.AutoSize = true;
            lblEndpoint.Location = new System.Drawing.Point(24, 31);
            lblEndpoint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblEndpoint.Name = "lblEndpoint";
            lblEndpoint.Size = new System.Drawing.Size(55, 15);
            lblEndpoint.TabIndex = 10;
            lblEndpoint.Text = "Endpoint";
            // 
            // txtGrupo
            // 
            txtGrupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            txtGrupo.Location = new System.Drawing.Point(83, 70);
            txtGrupo.Margin = new System.Windows.Forms.Padding(2);
            txtGrupo.Name = "txtGrupo";
            txtGrupo.Size = new System.Drawing.Size(288, 23);
            txtGrupo.TabIndex = 9;
            // 
            // lblDataId
            // 
            lblDataId.AutoSize = true;
            lblDataId.Location = new System.Drawing.Point(24, 73);
            lblDataId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblDataId.Name = "lblDataId";
            lblDataId.Size = new System.Drawing.Size(41, 15);
            lblDataId.TabIndex = 8;
            lblDataId.Text = "DataId";
            // 
            // tabControlListMD4
            // 
            tabControlListMD4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            tabControlListMD4.Controls.Add(tabPesquisar);
            tabControlListMD4.Controls.Add(tabResultado);
            tabControlListMD4.Location = new System.Drawing.Point(15, 71);
            tabControlListMD4.Name = "tabControlListMD4";
            tabControlListMD4.SelectedIndex = 0;
            tabControlListMD4.Size = new System.Drawing.Size(481, 340);
            tabControlListMD4.TabIndex = 21;
            // 
            // tabPesquisar
            // 
            tabPesquisar.Controls.Add(groupBox1);
            tabPesquisar.Location = new System.Drawing.Point(4, 24);
            tabPesquisar.Name = "tabPesquisar";
            tabPesquisar.Padding = new System.Windows.Forms.Padding(3);
            tabPesquisar.Size = new System.Drawing.Size(473, 312);
            tabPesquisar.TabIndex = 0;
            tabPesquisar.Text = "Pesquisar";
            tabPesquisar.UseVisualStyleBackColor = true;
            // 
            // tabResultado
            // 
            tabResultado.Controls.Add(treeViewEndpointsDataIds);
            tabResultado.Location = new System.Drawing.Point(4, 24);
            tabResultado.Name = "tabResultado";
            tabResultado.Padding = new System.Windows.Forms.Padding(3);
            tabResultado.Size = new System.Drawing.Size(473, 312);
            tabResultado.TabIndex = 1;
            tabResultado.Text = "Endpoints/DataIds";
            tabResultado.UseVisualStyleBackColor = true;
            // 
            // treeViewEndpointsDataIds
            // 
            treeViewEndpointsDataIds.Location = new System.Drawing.Point(19, 18);
            treeViewEndpointsDataIds.Name = "treeViewEndpointsDataIds";
            treeViewEndpointsDataIds.Size = new System.Drawing.Size(396, 534);
            treeViewEndpointsDataIds.TabIndex = 0;
            treeViewEndpointsDataIds.MouseDoubleClick += treeViewEndpointsDataIds_MouseDoubleClick;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(325, 52);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 22;
            button1.Text = "teste";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(481, 411);
            Controls.Add(button1);
            Controls.Add(tabControlListMD4);
            Controls.Add(lblNomeSistemaTopo);
            Controls.Add(cboAmbiente);
            Controls.Add(lblAmbiente);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximumSize = new System.Drawing.Size(497, 3000);
            MinimumSize = new System.Drawing.Size(497, 450);
            Name = "FrmMain";
            Text = "ListMD4";
            FormClosed += FrmMain_FormClosed;
            Load += Main_Load;
            Resize += FrmMain_Resize;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControlListMD4.ResumeLayout(false);
            tabPesquisar.ResumeLayout(false);
            tabResultado.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNomeSistemaTopo;
        private System.Windows.Forms.ComboBox cboAmbiente;
        private System.Windows.Forms.Label lblAmbiente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtEndpoint;
        private System.Windows.Forms.Label lblEndpoint;
        private System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.Label lblDataId;
        private System.Windows.Forms.TabControl tabControlListMD4;
        private System.Windows.Forms.TabPage tabPesquisar;
        private System.Windows.Forms.TabPage tabResultado;
        private System.Windows.Forms.TreeView treeViewEndpointsDataIds;
        private System.Windows.Forms.Button button1;
    }
}