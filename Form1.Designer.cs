namespace CRUDTesteUnitario
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.labelNome = new System.Windows.Forms.Label();
      this.labelAnoNascimento = new System.Windows.Forms.Label();
      this.labelEmail = new System.Windows.Forms.Label();
      this.textBoxName = new System.Windows.Forms.TextBox();
      this.textBoxEmail = new System.Windows.Forms.TextBox();
      this.dataGridViewPessoas = new System.Windows.Forms.DataGridView();
      this.buttonCriar = new System.Windows.Forms.Button();
      this.buttonAtualizar = new System.Windows.Forms.Button();
      this.buttonRemover = new System.Windows.Forms.Button();
      this.labelCPF = new System.Windows.Forms.Label();
      this.textBoxCPF = new System.Windows.Forms.TextBox();
      this.buttonNovo = new System.Windows.Forms.Button();
      this.dateTimePickerDtNascimento = new System.Windows.Forms.DateTimePicker();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPessoas)).BeginInit();
      this.SuspendLayout();
      // 
      // labelNome
      // 
      resources.ApplyResources(this.labelNome, "labelNome");
      this.labelNome.Name = "labelNome";
      // 
      // labelAnoNascimento
      // 
      resources.ApplyResources(this.labelAnoNascimento, "labelAnoNascimento");
      this.labelAnoNascimento.Name = "labelAnoNascimento";
      // 
      // labelEmail
      // 
      resources.ApplyResources(this.labelEmail, "labelEmail");
      this.labelEmail.Name = "labelEmail";
      // 
      // textBoxName
      // 
      resources.ApplyResources(this.textBoxName, "textBoxName");
      this.textBoxName.Name = "textBoxName";
      // 
      // textBoxEmail
      // 
      resources.ApplyResources(this.textBoxEmail, "textBoxEmail");
      this.textBoxEmail.Name = "textBoxEmail";
      this.textBoxEmail.Leave += new System.EventHandler(this.textBoxEmail_Leave);
      // 
      // dataGridViewPessoas
      // 
      this.dataGridViewPessoas.AllowUserToAddRows = false;
      this.dataGridViewPessoas.AllowUserToDeleteRows = false;
      this.dataGridViewPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      resources.ApplyResources(this.dataGridViewPessoas, "dataGridViewPessoas");
      this.dataGridViewPessoas.MultiSelect = false;
      this.dataGridViewPessoas.Name = "dataGridViewPessoas";
      this.dataGridViewPessoas.ReadOnly = true;
      this.dataGridViewPessoas.ShowEditingIcon = false;
      this.dataGridViewPessoas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPessoas_CellContentClick);
      // 
      // buttonCriar
      // 
      resources.ApplyResources(this.buttonCriar, "buttonCriar");
      this.buttonCriar.Name = "buttonCriar";
      this.buttonCriar.UseVisualStyleBackColor = true;
      this.buttonCriar.Click += new System.EventHandler(this.buttonCriar_Click);
      // 
      // buttonAtualizar
      // 
      resources.ApplyResources(this.buttonAtualizar, "buttonAtualizar");
      this.buttonAtualizar.Name = "buttonAtualizar";
      this.buttonAtualizar.UseVisualStyleBackColor = true;
      this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
      // 
      // buttonRemover
      // 
      resources.ApplyResources(this.buttonRemover, "buttonRemover");
      this.buttonRemover.Name = "buttonRemover";
      this.buttonRemover.UseVisualStyleBackColor = true;
      this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
      // 
      // labelCPF
      // 
      resources.ApplyResources(this.labelCPF, "labelCPF");
      this.labelCPF.Name = "labelCPF";
      // 
      // textBoxCPF
      // 
      resources.ApplyResources(this.textBoxCPF, "textBoxCPF");
      this.textBoxCPF.Name = "textBoxCPF";
      // 
      // buttonNovo
      // 
      resources.ApplyResources(this.buttonNovo, "buttonNovo");
      this.buttonNovo.Name = "buttonNovo";
      this.buttonNovo.UseVisualStyleBackColor = true;
      this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
      // 
      // dateTimePickerDtNascimento
      // 
      this.dateTimePickerDtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      resources.ApplyResources(this.dateTimePickerDtNascimento, "dateTimePickerDtNascimento");
      this.dateTimePickerDtNascimento.Name = "dateTimePickerDtNascimento";
      // 
      // Form1
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.dateTimePickerDtNascimento);
      this.Controls.Add(this.buttonNovo);
      this.Controls.Add(this.textBoxCPF);
      this.Controls.Add(this.labelCPF);
      this.Controls.Add(this.buttonRemover);
      this.Controls.Add(this.buttonAtualizar);
      this.Controls.Add(this.buttonCriar);
      this.Controls.Add(this.dataGridViewPessoas);
      this.Controls.Add(this.textBoxEmail);
      this.Controls.Add(this.textBoxName);
      this.Controls.Add(this.labelEmail);
      this.Controls.Add(this.labelAnoNascimento);
      this.Controls.Add(this.labelNome);
      this.Name = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPessoas)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelAnoNascimento;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.DataGridView dataGridViewPessoas;
        private System.Windows.Forms.Button buttonCriar;
        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.TextBox textBoxCPF;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.DateTimePicker dateTimePickerDtNascimento;
    }
}

