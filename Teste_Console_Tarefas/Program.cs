using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        List<Task> tarefas = new List<Task>();

        for (int i = 1; i <= 10; i++)
        {
            int taskId = i;
            tarefas.Add(ProcessTaskAsync(taskId));
        }

        await Task.WhenAll(tarefas);

        Console.WriteLine("Fim da execução das tarefas");
    }

    static async Task ProcessTaskAsync(int taskId)
    {
        Random random = new Random();
        int delay = random.Next(1000, 5001); 

        await Task.Delay(delay);

        Console.WriteLine($"Tarefa {taskId} processada em {delay / 1000.0} segundos.");
    }
}