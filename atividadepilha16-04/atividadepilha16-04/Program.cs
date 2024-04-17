var pilha = new Stack<int>();

pilha.Push(1);
pilha.Push(2);
pilha.Push(4);
pilha.Push(3);
pilha.Push(8);
pilha.Push(5);

pilha.Pop();
var ultimoItem = pilha.Peek();

for (int i = 0; i < pilha.Count; i++)
{
    Console.WriteLine($"Linha {i} - [{pilha.ElementAt(i)}]");
}


var pilha = new Stack<int>();
pilha.Enqueue(1);
pilha.Enqueue(2);
pilha.Enqueue(8);
pilha.Enqueue(5);

pilha.Dequeue();

pilha.Push();
pilha.Pop();
pilha.Peek();

Console.WriteLine("Imprimindo ENTRADA");
for  (int i = 0; i < pilha.Count;i++)
{
    Console.WriteLine($"Linha {i} - [{pilha.ElementAt(i)}]");
}