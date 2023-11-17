using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome: "Carlos", sobrenome: "Silva");
Pessoa p2 = new Pessoa(nome: "Michele", sobrenome: "Pereira");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

