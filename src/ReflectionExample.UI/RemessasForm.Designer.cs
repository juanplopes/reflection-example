namespace ReflectionExample.UI
{
    partial class RemessasForm
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
            this.components = new System.ComponentModel.Container();
            this.grid = new System.Windows.Forms.DataGridView();
            this.bancoOrigemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agenciaOrigemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contaOrigemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bancoDestinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agenciaDestinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contaDestinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remessas = new System.Windows.Forms.BindingSource(this.components);
            this.menu = new System.Windows.Forms.MenuStrip();
            this.arquivoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.novoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remessas)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.grid.AutoGenerateColumns = false;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bancoOrigemDataGridViewTextBoxColumn,
            this.agenciaOrigemDataGridViewTextBoxColumn,
            this.contaOrigemDataGridViewTextBoxColumn,
            this.bancoDestinoDataGridViewTextBoxColumn,
            this.agenciaDestinoDataGridViewTextBoxColumn,
            this.contaDestinoDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn});
            this.grid.DataSource = this.remessas;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 24);
            this.grid.Name = "dataGridView1";
            this.grid.Size = new System.Drawing.Size(597, 174);
            this.grid.TabIndex = 0;
            // 
            // bancoOrigemDataGridViewTextBoxColumn
            // 
            this.bancoOrigemDataGridViewTextBoxColumn.DataPropertyName = "BancoOrigem";
            this.bancoOrigemDataGridViewTextBoxColumn.HeaderText = "BancoOrigem";
            this.bancoOrigemDataGridViewTextBoxColumn.Name = "bancoOrigemDataGridViewTextBoxColumn";
            // 
            // agenciaOrigemDataGridViewTextBoxColumn
            // 
            this.agenciaOrigemDataGridViewTextBoxColumn.DataPropertyName = "AgenciaOrigem";
            this.agenciaOrigemDataGridViewTextBoxColumn.HeaderText = "AgenciaOrigem";
            this.agenciaOrigemDataGridViewTextBoxColumn.Name = "agenciaOrigemDataGridViewTextBoxColumn";
            // 
            // contaOrigemDataGridViewTextBoxColumn
            // 
            this.contaOrigemDataGridViewTextBoxColumn.DataPropertyName = "ContaOrigem";
            this.contaOrigemDataGridViewTextBoxColumn.HeaderText = "ContaOrigem";
            this.contaOrigemDataGridViewTextBoxColumn.Name = "contaOrigemDataGridViewTextBoxColumn";
            // 
            // bancoDestinoDataGridViewTextBoxColumn
            // 
            this.bancoDestinoDataGridViewTextBoxColumn.DataPropertyName = "BancoDestino";
            this.bancoDestinoDataGridViewTextBoxColumn.HeaderText = "BancoDestino";
            this.bancoDestinoDataGridViewTextBoxColumn.Name = "bancoDestinoDataGridViewTextBoxColumn";
            // 
            // agenciaDestinoDataGridViewTextBoxColumn
            // 
            this.agenciaDestinoDataGridViewTextBoxColumn.DataPropertyName = "AgenciaDestino";
            this.agenciaDestinoDataGridViewTextBoxColumn.HeaderText = "AgenciaDestino";
            this.agenciaDestinoDataGridViewTextBoxColumn.Name = "agenciaDestinoDataGridViewTextBoxColumn";
            // 
            // contaDestinoDataGridViewTextBoxColumn
            // 
            this.contaDestinoDataGridViewTextBoxColumn.DataPropertyName = "ContaDestino";
            this.contaDestinoDataGridViewTextBoxColumn.HeaderText = "ContaDestino";
            this.contaDestinoDataGridViewTextBoxColumn.Name = "contaDestinoDataGridViewTextBoxColumn";
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // remessas
            // 
            this.remessas.DataSource = typeof(ReflectionExample.UI.Remessa);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoMenu});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(597, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // arquivoMenu
            // 
            this.arquivoMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoMenu,
            this.abrirToolStripMenuItem,
            this.salvarMenu});
            this.arquivoMenu.Name = "arquivoMenu";
            this.arquivoMenu.Size = new System.Drawing.Size(61, 20);
            this.arquivoMenu.Text = "Arquivo";
            // 
            // novoMenu
            // 
            this.novoMenu.Name = "novoMenu";
            this.novoMenu.Size = new System.Drawing.Size(152, 22);
            this.novoMenu.Text = "Novo";
            this.novoMenu.Click += new System.EventHandler(this.novoMenu_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirMenu_Click);
            // 
            // salvarMenu
            // 
            this.salvarMenu.Name = "salvarMenu";
            this.salvarMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salvarMenu.Size = new System.Drawing.Size(152, 22);
            this.salvarMenu.Text = "Salvar";
            this.salvarMenu.Click += new System.EventHandler(this.salvarMenu_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // RemessasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 198);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "RemessasForm";
            this.Text = "novo";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remessas)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem arquivoMenu;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarMenu;
        private System.Windows.Forms.ToolStripMenuItem novoMenu;
        private System.Windows.Forms.BindingSource remessas;
        private System.Windows.Forms.DataGridViewTextBoxColumn bancoOrigemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agenciaOrigemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contaOrigemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bancoDestinoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agenciaDestinoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contaDestinoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.SaveFileDialog saveFile;
    }
}

