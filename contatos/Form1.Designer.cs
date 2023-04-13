namespace contatos
{
    partial class AgendaContactos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label contatosIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgendaContactos));
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label empresaLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label clienteLabel;
            System.Windows.Forms.Label ultimo_ContactoLabel;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contatosDBDataSet = new contatos.ContatosDBDataSet();
            this.pessoasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoasTableAdapter = new contatos.ContatosDBDataSetTableAdapters.PessoasTableAdapter();
            this.tableAdapterManager = new contatos.ContatosDBDataSetTableAdapters.TableAdapterManager();
            this.pessoasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pessoasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.contatosIDTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.empresaTextBox = new System.Windows.Forms.TextBox();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.clienteCheckBox = new System.Windows.Forms.CheckBox();
            this.ultimo_ContactoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            contatosIDLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            empresaLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            clienteLabel = new System.Windows.Forms.Label();
            ultimo_ContactoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatosDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingNavigator)).BeginInit();
            this.pessoasBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // contatosIDLabel
            // 
            resources.ApplyResources(contatosIDLabel, "contatosIDLabel");
            contatosIDLabel.Name = "contatosIDLabel";
            // 
            // nomeLabel
            // 
            resources.ApplyResources(nomeLabel, "nomeLabel");
            nomeLabel.Name = "nomeLabel";
            // 
            // empresaLabel
            // 
            resources.ApplyResources(empresaLabel, "empresaLabel");
            empresaLabel.Name = "empresaLabel";
            // 
            // telefoneLabel
            // 
            resources.ApplyResources(telefoneLabel, "telefoneLabel");
            telefoneLabel.Name = "telefoneLabel";
            // 
            // emailLabel
            // 
            resources.ApplyResources(emailLabel, "emailLabel");
            emailLabel.Name = "emailLabel";
            // 
            // clienteLabel
            // 
            resources.ApplyResources(clienteLabel, "clienteLabel");
            clienteLabel.Name = "clienteLabel";
            // 
            // ultimo_ContactoLabel
            // 
            resources.ApplyResources(ultimo_ContactoLabel, "ultimo_ContactoLabel");
            ultimo_ContactoLabel.Name = "ultimo_ContactoLabel";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::contatos.Properties.Resources.Logo;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // contatosDBDataSet
            // 
            this.contatosDBDataSet.DataSetName = "ContatosDBDataSet";
            this.contatosDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pessoasBindingSource
            // 
            this.pessoasBindingSource.DataMember = "Pessoas";
            this.pessoasBindingSource.DataSource = this.contatosDBDataSet;
            // 
            // pessoasTableAdapter
            // 
            this.pessoasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PessoasTableAdapter = this.pessoasTableAdapter;
            this.tableAdapterManager.UpdateOrder = contatos.ContatosDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pessoasBindingNavigator
            // 
            resources.ApplyResources(this.pessoasBindingNavigator, "pessoasBindingNavigator");
            this.pessoasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pessoasBindingNavigator.BindingSource = this.pessoasBindingSource;
            this.pessoasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pessoasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pessoasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pessoasBindingNavigatorSaveItem});
            this.pessoasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pessoasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pessoasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pessoasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pessoasBindingNavigator.Name = "pessoasBindingNavigator";
            this.pessoasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            // 
            // bindingNavigatorAddNewItem
            // 
            resources.ApplyResources(this.bindingNavigatorAddNewItem, "bindingNavigatorAddNewItem");
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            // 
            // bindingNavigatorCountItem
            // 
            resources.ApplyResources(this.bindingNavigatorCountItem, "bindingNavigatorCountItem");
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            // 
            // bindingNavigatorDeleteItem
            // 
            resources.ApplyResources(this.bindingNavigatorDeleteItem, "bindingNavigatorDeleteItem");
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            resources.ApplyResources(this.bindingNavigatorMoveFirstItem, "bindingNavigatorMoveFirstItem");
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            resources.ApplyResources(this.bindingNavigatorMovePreviousItem, "bindingNavigatorMovePreviousItem");
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            // 
            // bindingNavigatorSeparator
            // 
            resources.ApplyResources(this.bindingNavigatorSeparator, "bindingNavigatorSeparator");
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            // 
            // bindingNavigatorPositionItem
            // 
            resources.ApplyResources(this.bindingNavigatorPositionItem, "bindingNavigatorPositionItem");
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            // 
            // bindingNavigatorSeparator1
            // 
            resources.ApplyResources(this.bindingNavigatorSeparator1, "bindingNavigatorSeparator1");
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            // 
            // bindingNavigatorMoveNextItem
            // 
            resources.ApplyResources(this.bindingNavigatorMoveNextItem, "bindingNavigatorMoveNextItem");
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            // 
            // bindingNavigatorMoveLastItem
            // 
            resources.ApplyResources(this.bindingNavigatorMoveLastItem, "bindingNavigatorMoveLastItem");
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            // 
            // bindingNavigatorSeparator2
            // 
            resources.ApplyResources(this.bindingNavigatorSeparator2, "bindingNavigatorSeparator2");
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            // 
            // pessoasBindingNavigatorSaveItem
            // 
            resources.ApplyResources(this.pessoasBindingNavigatorSaveItem, "pessoasBindingNavigatorSaveItem");
            this.pessoasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pessoasBindingNavigatorSaveItem.Name = "pessoasBindingNavigatorSaveItem";
            this.pessoasBindingNavigatorSaveItem.Click += new System.EventHandler(this.pessoasBindingNavigatorSaveItem_Click);
            // 
            // contatosIDTextBox
            // 
            resources.ApplyResources(this.contatosIDTextBox, "contatosIDTextBox");
            this.contatosIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoasBindingSource, "ContatosID", true));
            this.contatosIDTextBox.Name = "contatosIDTextBox";
            // 
            // nomeTextBox
            // 
            resources.ApplyResources(this.nomeTextBox, "nomeTextBox");
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoasBindingSource, "Nome", true));
            this.nomeTextBox.Name = "nomeTextBox";
            // 
            // empresaTextBox
            // 
            resources.ApplyResources(this.empresaTextBox, "empresaTextBox");
            this.empresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoasBindingSource, "Empresa", true));
            this.empresaTextBox.Name = "empresaTextBox";
            // 
            // telefoneTextBox
            // 
            resources.ApplyResources(this.telefoneTextBox, "telefoneTextBox");
            this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoasBindingSource, "Telefone", true));
            this.telefoneTextBox.Name = "telefoneTextBox";
            // 
            // emailTextBox
            // 
            resources.ApplyResources(this.emailTextBox, "emailTextBox");
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoasBindingSource, "Email", true));
            this.emailTextBox.Name = "emailTextBox";
            // 
            // clienteCheckBox
            // 
            resources.ApplyResources(this.clienteCheckBox, "clienteCheckBox");
            this.clienteCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.pessoasBindingSource, "Cliente", true));
            this.clienteCheckBox.Name = "clienteCheckBox";
            this.clienteCheckBox.UseVisualStyleBackColor = true;
            // 
            // ultimo_ContactoDateTimePicker
            // 
            resources.ApplyResources(this.ultimo_ContactoDateTimePicker, "ultimo_ContactoDateTimePicker");
            this.ultimo_ContactoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pessoasBindingSource, "Ultimo Contacto", true));
            this.ultimo_ContactoDateTimePicker.Name = "ultimo_ContactoDateTimePicker";
            // 
            // AgendaContactos
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(contatosIDLabel);
            this.Controls.Add(this.contatosIDTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(empresaLabel);
            this.Controls.Add(this.empresaTextBox);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(clienteLabel);
            this.Controls.Add(this.clienteCheckBox);
            this.Controls.Add(ultimo_ContactoLabel);
            this.Controls.Add(this.ultimo_ContactoDateTimePicker);
            this.Controls.Add(this.pessoasBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AgendaContactos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatosDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingNavigator)).EndInit();
            this.pessoasBindingNavigator.ResumeLayout(false);
            this.pessoasBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private ContatosDBDataSet contatosDBDataSet;
        private System.Windows.Forms.BindingSource pessoasBindingSource;
        private ContatosDBDataSetTableAdapters.PessoasTableAdapter pessoasTableAdapter;
        private ContatosDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pessoasBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pessoasBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox contatosIDTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox empresaTextBox;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.CheckBox clienteCheckBox;
        private System.Windows.Forms.DateTimePicker ultimo_ContactoDateTimePicker;
    }
}

