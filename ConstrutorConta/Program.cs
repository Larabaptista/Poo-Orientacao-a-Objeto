// função Main()
using ConstrutorConta;

Conta c1 = new Conta();//construtor padrão //iniciar variaveis da classe
c1.MostrarAtributos();


Conta c2 = new Conta(235); // um argumento (parametro) argumento - chamar o nome dos valores
c2.MostrarAtributos();


Conta c3 = new Conta(1,50); // dois argumentos
c3.MostrarAtributos();


Conta c4 = new Conta(2,100,"Ana");
c4.MostrarAtributos();

Console.WriteLine("Quantidade de instâncias: " + Conta.Contador);

// instanciuar é o new conta(); é chamar uma variavel dentro da classe