using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;

namespace CRUDTesteUnitario
{
  public partial class Form1 : Form
  {
    public string arquivoJson = Environment.CurrentDirectory;
    public JsonCrud jscrud = new JsonCrud();
    public Form1()
    {
      InitializeComponent();
      arquivoJson = arquivoJson.Replace("\\bin\\Debug", "");
      arquivoJson = arquivoJson + "\\Dados\\Pessoas.json";
      ExibirDados();
    }

    private void ExibirDados()
    {
      try
      {
        DataTable dt = new DataTable();
        List<Pessoa> pessoasList = JsonCrud.LerArquivoJson(arquivoJson);
        dt.Columns.Add("Nome");
        dt.Columns.Add("Ano Nascimento");
        dt.Columns.Add("Idade");
        dt.Columns.Add("Email");
        dt.Columns.Add("CPF");
        foreach (var item in pessoasList)
        {
          var row = dt.NewRow();

          row["Nome"] = item.nome;
          row["Ano Nascimento"] = item.anoNascimento.ToShortDateString();
          row["Idade"] = item.idade;
          row["Email"] = item.email;
          row["CPF"] = item.CPF;
          dt.Rows.Add(row);
        }
        dataGridViewPessoas.DataSource = dt;
      }
      catch
      {
        throw;
      }
    }

    private void buttonCriar_Click(object sender, EventArgs e)
    {
      Pessoa pessoa = new Pessoa()
      {
        nome = textBoxName.Text,
        anoNascimento = dateTimePickerDtNascimento.Value,
        idade = CalculaIdade(dateTimePickerDtNascimento.Value),
        email = textBoxEmail.Text,
        CPF = textBoxCPF.Text
      };

      textBoxName.Focus();

      jscrud.AdicionarPessoa(pessoa, arquivoJson);
      ExibirDados();
    }

    private void buttonRemover_Click(object sender, EventArgs e)
    {
      Pessoa pessoa = new Pessoa()
      {
        nome = textBoxName.Text,
        anoNascimento = dateTimePickerDtNascimento.Value,
        email = textBoxEmail.Text,
        CPF = textBoxCPF.Text
      };
      jscrud.DeletarPessoa(pessoa, arquivoJson);
      ExibirDados();
    }

    private void buttonAtualizar_Click(object sender, EventArgs e)
    {
      Pessoa pessoa = new Pessoa()
      {
        nome = textBoxName.Text,
        anoNascimento = dateTimePickerDtNascimento.Value,
        idade = CalculaIdade(dateTimePickerDtNascimento.Value),
        email = textBoxEmail.Text,
        CPF = textBoxCPF.Text
      };
      jscrud.AtualizarPessoa(pessoa, arquivoJson);
      ExibirDados();
    }

    private void dataGridViewPessoas_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      try
      {
        textBoxName.Text = dataGridViewPessoas.Rows[e.RowIndex].Cells[0].Value.ToString();
        dateTimePickerDtNascimento.Text = dataGridViewPessoas.Rows[e.RowIndex].Cells[1].Value.ToString();
        textBoxEmail.Text = dataGridViewPessoas.Rows[e.RowIndex].Cells[3].Value.ToString();
        textBoxCPF.Text = dataGridViewPessoas.Rows[e.RowIndex].Cells[4].Value.ToString();
      }
      catch { }
    }

    private void buttonNovo_Click(object sender, EventArgs e)
    {
      textBoxName.Text = "";
      dateTimePickerDtNascimento.Text = "";
      textBoxEmail.Text = "";
      textBoxCPF.Text = "";
    }

    private int CalculaIdade(DateTime dtNascimento)
    {
      DateTime? now = null;
      int idade;

      now = ((now == null) ? DateTime.Now : now);
      try
      {
        int YearsOld = (now.Value.Year - dtNascimento.Year);

        if (now.Value.Month < dtNascimento.Month || (now.Value.Month == dtNascimento.Month && now.Value.Day < dtNascimento.Day))
        {
          YearsOld--;
        }

        return (YearsOld < 0) ? 0 : YearsOld;
      }
      catch
      {
        return 0;
      }
    }

    private bool ValidaEmail(string email)
    {

      Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

      if (rg.IsMatch(email))
        return true;
      else
        return false;
    }

    private void textBoxEmail_Leave(object sender, EventArgs e)
    {
      if (!ValidaEmail(textBoxEmail.Text))
      {
        MessageBoxResult result = MessageBox.Show("E-mail Inválido", "Erro");
      }
    }
  }
}
