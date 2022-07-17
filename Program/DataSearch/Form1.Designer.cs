namespace DataSearch
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.база_данныхDataSet = new DataSearch.База_данныхDataSet();
            this.данныеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.данныеTableAdapter = new DataSearch.База_данныхDataSetTableAdapters.ДанныеTableAdapter();
            this.tableAdapterManager = new DataSearch.База_данныхDataSetTableAdapters.TableAdapterManager();
            this.данныеDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоИмениToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоФамилииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоПочтеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоПаролюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоНомеруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.база_данныхDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.данныеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.данныеDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // база_данныхDataSet
            // 
            this.база_данныхDataSet.DataSetName = "База_данныхDataSet";
            this.база_данныхDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // данныеBindingSource
            // 
            this.данныеBindingSource.DataMember = "Данные";
            this.данныеBindingSource.DataSource = this.база_данныхDataSet;
            // 
            // данныеTableAdapter
            // 
            this.данныеTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = DataSearch.База_данныхDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДанныеTableAdapter = this.данныеTableAdapter;
            // 
            // данныеDataGridView
            // 
            this.данныеDataGridView.AutoGenerateColumns = false;
            this.данныеDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.данныеDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.данныеDataGridView.DataSource = this.данныеBindingSource;
            this.данныеDataGridView.Location = new System.Drawing.Point(0, 27);
            this.данныеDataGridView.Name = "данныеDataGridView";
            this.данныеDataGridView.Size = new System.Drawing.Size(648, 343);
            this.данныеDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Имя";
            this.dataGridViewTextBoxColumn2.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Фамилия";
            this.dataGridViewTextBoxColumn3.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Почта";
            this.dataGridViewTextBoxColumn4.HeaderText = "Почта";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Пароль";
            this.dataGridViewTextBoxColumn5.HeaderText = "Пароль";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn6.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(645, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискПоИмениToolStripMenuItem,
            this.поискПоФамилииToolStripMenuItem,
            this.поискПоПочтеToolStripMenuItem,
            this.поискПоПаролюToolStripMenuItem,
            this.поискПоНомеруToolStripMenuItem});
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // поискПоИмениToolStripMenuItem
            // 
            this.поискПоИмениToolStripMenuItem.Name = "поискПоИмениToolStripMenuItem";
            this.поискПоИмениToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.поискПоИмениToolStripMenuItem.Text = "Поиск по имени";
            this.поискПоИмениToolStripMenuItem.Click += new System.EventHandler(this.поискПоИмениToolStripMenuItem_Click);
            // 
            // поискПоФамилииToolStripMenuItem
            // 
            this.поискПоФамилииToolStripMenuItem.Name = "поискПоФамилииToolStripMenuItem";
            this.поискПоФамилииToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.поискПоФамилииToolStripMenuItem.Text = "Поиск по фамилии";
            this.поискПоФамилииToolStripMenuItem.Click += new System.EventHandler(this.поискПоФамилииToolStripMenuItem_Click);
            // 
            // поискПоПочтеToolStripMenuItem
            // 
            this.поискПоПочтеToolStripMenuItem.Name = "поискПоПочтеToolStripMenuItem";
            this.поискПоПочтеToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.поискПоПочтеToolStripMenuItem.Text = "Поиск по почте";
            this.поискПоПочтеToolStripMenuItem.Click += new System.EventHandler(this.поискПоПочтеToolStripMenuItem_Click);
            // 
            // поискПоПаролюToolStripMenuItem
            // 
            this.поискПоПаролюToolStripMenuItem.Name = "поискПоПаролюToolStripMenuItem";
            this.поискПоПаролюToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.поискПоПаролюToolStripMenuItem.Text = "Поиск по паролю";
            this.поискПоПаролюToolStripMenuItem.Click += new System.EventHandler(this.поискПоПаролюToolStripMenuItem_Click);
            // 
            // поискПоНомеруToolStripMenuItem
            // 
            this.поискПоНомеруToolStripMenuItem.Name = "поискПоНомеруToolStripMenuItem";
            this.поискПоНомеруToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.поискПоНомеруToolStripMenuItem.Text = "Поиск по номеру";
            this.поискПоНомеруToolStripMenuItem.Click += new System.EventHandler(this.поискПоНомеруToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem1});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // оПрограммеToolStripMenuItem1
            // 
            this.оПрограммеToolStripMenuItem1.Name = "оПрограммеToolStripMenuItem1";
            this.оПрограммеToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.оПрограммеToolStripMenuItem1.Text = "О программе";
            this.оПрограммеToolStripMenuItem1.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Обновить данные";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(462, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Добавить данные";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 445);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.данныеDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поисковая система";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.база_данныхDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.данныеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.данныеDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private База_данныхDataSet база_данныхDataSet;
        private System.Windows.Forms.BindingSource данныеBindingSource;
        private База_данныхDataSetTableAdapters.ДанныеTableAdapter данныеTableAdapter;
        private База_данныхDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView данныеDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискПоИмениToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискПоФамилииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискПоПочтеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискПоПаролюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискПоНомеруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

