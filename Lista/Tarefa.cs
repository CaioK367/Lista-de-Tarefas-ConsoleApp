using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    internal class Tarefa
    {
        public string Nome { get; set; }

        public string? Descricao { get; set; }
        public bool Concluida { get; set; }

        public Tarefa() { }


        public Tarefa(string nome, string descricao, bool concluida)
        {
            Nome = nome;
            Descricao = descricao;
            Concluida = concluida;
        }

        public Tarefa(string nome, bool concluida)
        {
            Nome = nome;
            Concluida = concluida;
        }

        List<Tarefa> tarefas = new List<Tarefa>();

        public void AdicionarTarefa()
        {
            Console.Clear();
            Console.Write("Qual a tarefa? : ");
            string nome = Console.ReadLine();

            while (nome == "")
            {

                if (nome == "")
                {
                    Console.WriteLine("O nome da tarefa não pode ser vazio!!");
                    Console.Write("Qual a tarefa? : ");
                    nome = Console.ReadLine();
                }
            }

            Console.Write("Descrição da tarefa: ");
            string descricao = Console.ReadLine();

            try 
            { 
                tarefas.Add(new Tarefa(nome, descricao, false));
                Console.WriteLine("Tarefa Adicionada com Sucesso!");
                Console.Write("");
                Thread.Sleep(2000);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
            Console.Clear();

        }

        public void RemoverTarefa()
        {
            

            if (tarefas.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("Nenhuma tarefa adicionada");
                Thread.Sleep(3000);
                Console.Clear();
            }
            else
            {
                foreach (var tarefa in tarefas)
                {
                    Exibir();
                }
                Console.WriteLine("Qual tarefa deseja remover?");
                int index = int.Parse(Console.ReadLine());

                try
                {
                    tarefas.RemoveAt(index);
                    Console.WriteLine("Tarefa removida com sucesso!");
                    Thread.Sleep(2000);
                    Console.WriteLine("");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
        public void Exibir()
        {
            Console.Clear();

            if (tarefas.Count == 0)
            {
                Console.WriteLine("Não foi adicionada nenhuma tarefa!");
                Thread.Sleep(2000);
            }
            else
            {
                for (int i = 0; i < tarefas.Count; i++)
                {
                    var tarefa = tarefas[i];
                    Console.WriteLine($"{i} - {tarefa.Nome} - {tarefa.Descricao} - {tarefa.Concluida}");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

        }

        
    }
}
