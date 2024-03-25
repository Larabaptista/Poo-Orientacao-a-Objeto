using AgregacaoConta;

Endereco end = new Endereco("Rua x", 75, "pp"); // o cliente no momento da classe a gente incluiu um atirbuto novo que é endereco , instancia o objeto e pode fazer a agregacao

Cliente cli = new Cliente("Ana", "1111", "1111", "111"); // vai no atributo ender receber o end
cli.Ender = end; //agregando o endereco no cliente (cli)    CLI.ENDER - ATRIBUTO   END - OBJETO

// tudo q ta do lado esquerdo é tipo, e tipo é classe
// 

Conta c1 = new Conta ();
c1.Numero = 1;
c1.Titular = cli; //agregando o cliente a conta c1
c1.Saldo=100;
