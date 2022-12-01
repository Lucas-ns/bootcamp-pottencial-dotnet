// See https://aka.ms/new-console-template for more information

using ExemploExplorando.Models;
using Newtonsoft.Json;


string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}" +
                      $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
}





























// DateTime dataAtual = DateTime.Now;

// List<Venda> listaVendas = new List<Venda>();


// Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
// Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", serializado);


// Console.WriteLine(serializado);


























// int numero = 15;
// bool ehPar = false;

// // IF ternario
// ehPar = numero % 2 == 0;
// Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "ímpar"));


// if (numero % 2 == 0)
// {
//     Console.WriteLine($"O número {numero} é par");
// }
// else
// {
//     Console.WriteLine($"O número {numero} é ímpar");
// }





















// Pessoa p1 = new Pessoa("Lucas", "Silva");

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");



















// LeituraArquivo arquivo = new LeituraArquivo();
// var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/leituraArquivo.txt");

// if (sucesso) {
//     //Console.WriteLine("Quantidade de linhas do arquivo: " + quantidadeLinhas);
//     foreach (string linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else {
//     Console.WriteLine("Não foi possível ler o arquivo");
// }
























// (int Id, string Nome, string Sobrenome) tupla = (1, "Lucas", "Silva");

// // ValueTuple<int, string, string> outroExemploTupla = (1, "Lucas", "Silva");
// // var outroExemploTuplaCreate = Tuple.Create(1, "Lucas", "Silva");

// Console.WriteLine($"Id: {tupla.Id}");
// Console.WriteLine($"Nome: {tupla.Nome}");
// Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");




























// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");
// estados.Add("BA", "Bahia");
// estados.Add("MG", "Minas Gerais");

// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// Console.WriteLine("-------------------");

// estados.Remove("BA");
// estados["SP"] = "São Paulo - valor alterado";

// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }


// string chave = "BA2";
// Console.WriteLine("Verificando o elemento");

// if(estados.ContainsKey(chave)){
//     Console.WriteLine($"Valor existente: {chave}");
// }
// else {
//     Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
// }





















// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo {pilha.Pop()}");
// pilha.Push(20);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }





























// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach(int item in fila) {
//     Console.WriteLine(item);
// }

// fila.Dequeue();

// Console.WriteLine($"Removendo o elemento {fila.Dequeue()}");

// foreach(int item in fila) {
//     Console.WriteLine(item);
// }

















// new ExemploExcecao().Metodo1();








// Pessoa p1 = new Pessoa(nome: "Lucas", sobrenome: "do Nascimento Silva");
// Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Neves");


// Curso c = new Curso();
// c.Nome = "TI";
// c.Alunos = new List<Pessoa>();

// c.AdicionarAluno(p1);
// c.AdicionarAluno(p2);
// c.ListarAlunos();
