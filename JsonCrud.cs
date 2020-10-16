using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace CRUDTesteUnitario
{
  public class JsonCrud
  {
    //Adicionar Pessoa
    public void AdicionarPessoa(Pessoa pessoa, string arquivoJson)
    {
      var novaPessoaMembro = JsonConvert.SerializeObject(pessoa);

      try
      {
        var json = File.ReadAllText(arquivoJson);
        var jsonObj = JObject.Parse(json);
        var arrayExperiencias = jsonObj.GetValue("pessoas") as JArray;
        var novaPessoa = JObject.Parse(novaPessoaMembro);
        arrayExperiencias.Add(novaPessoa);

        jsonObj["pessoas"] = arrayExperiencias;
        string novoJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
        File.WriteAllText(arquivoJson, novoJsonResult);
      }
      catch (Exception ex)
      {
      }
    }

    //Deletar Pessoa
    public void DeletarPessoa(Pessoa pessoa, string arquivoJson)
    {
      var json = File.ReadAllText(arquivoJson);
      try
      {
        var jObject = JObject.Parse(json);
        JArray arrayExperiencias = (JArray)jObject["pessoas"];

        if (!string.IsNullOrEmpty(pessoa.CPF))
        {
          var nomePessoa = string.Empty;
          var PessoaADeletar = arrayExperiencias.FirstOrDefault(obj => obj["CPF"].Value<string>() == pessoa.CPF);

          arrayExperiencias.Remove(PessoaADeletar);

          string saida = Newtonsoft.Json.JsonConvert.SerializeObject(jObject, Newtonsoft.Json.Formatting.Indented);
          File.WriteAllText(arquivoJson, saida);
        }
        else
        {
        }
      }
      catch (Exception)
      {
        throw;
      }
    }

    //Atualizar Pessoa
    public void AtualizarPessoa(Pessoa pessoa, string arquivoJson)
    {
      string json = File.ReadAllText(arquivoJson);
      try
      {
        var jObject = JObject.Parse(json);
        JArray arrayPessoas = (JArray)jObject["pessoas"];

        if (!string.IsNullOrEmpty(pessoa.CPF))
        {
          foreach (var Pessoa in arrayPessoas.Where(obj => obj["CPF"].Value<string>() == pessoa.CPF))
          {
            Pessoa["nome"] = !string.IsNullOrEmpty(pessoa.nome) ? pessoa.nome : "";
            Pessoa["idade"] = pessoa.idade;
            Pessoa["email"] = !string.IsNullOrEmpty(pessoa.email) ? pessoa.email : "";
            Pessoa["anoNascimento"] = pessoa.anoNascimento;
          }

          jObject["pessoas"] = arrayPessoas;
          string saida = Newtonsoft.Json.JsonConvert.SerializeObject(jObject, Newtonsoft.Json.Formatting.Indented);
          File.WriteAllText(arquivoJson, saida);
        }
        else
        {
        }
      }
      catch (Exception ex)
      {
        //WriteLine("Erro de Atualização : " + ex.Message.ToString());
      }
    }

    public static List<Pessoa> LerArquivoJson(string arquivo)
    {
      List<Pessoa> pessoasList = new List<Pessoa>();
      var json = File.ReadAllText(arquivo);
      try
      {
        var jObject = JObject.Parse(json);
        if (jObject != null)
        {
          JArray arrayPessoas = (JArray)jObject["pessoas"];
          if (arrayPessoas != null)
          {
            foreach (var item in arrayPessoas)
            {
              pessoasList.Add(JsonConvert.DeserializeObject<Pessoa>(item.ToString()));
            }
          }
          return pessoasList;
        }
      }
      catch
      {
        return pessoasList;
      }
      return pessoasList;
    }
  }
}

