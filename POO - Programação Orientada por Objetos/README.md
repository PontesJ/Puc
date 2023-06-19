# Exercícios

## Exercício 01

Sua equipe de desenvolvimento foi alocada para participar de um Sistema de Gerenciamento de Biblioteca, trabalhando no planejamento, modelagem e implementação de um TAD que represente os Livros no sistema.
A Estrutura de dados inicialmente é:

As funções que devem ser exportadas pela interface TAD são:

a) Criar Livro que recebe por parâmetro o título, autor, gênero e ano de publicação e retorna um objeto do tipo Livro.<br>

b) Quatro funções de manutenção básicas de registros do TAD livros:<br>
Obter Autor, Título, Gênero e Ano.<br>

c) Duas funções para verificar a Estilo literário, sendo que estás deverão receber um Objeto do Tipo Livro e retornar um Boleano com o resultado, sendo:<br>
Modernismo de 1930 a 1945 e Barroco de 1601 a 1768.

Deverá ser escrito o TAD com todos os elementos, seguindo o modelo visto em aula, seguindo boas práticas de nomenclatura e padrão CamelCase.

**<a href="./Aula 02 - TADLivro">Resolução</a>**

---

## Exercício 02

1\) De acordo com seus conhecimentos sobre aplicações bancárias (ou de seus consultores) em nossa aplicação bancária, onde pode ser utilizado o relacionamento de Agregação por composição? Justifique:

2\) Modele este relacionamento de acordo com os modelos vistos em sala de aula: (dica de ferramenta ArgoUML, baixe e instale e use sem moderação é free).

3\) Implemente este relacionamento e proponha um caso de teste em C#. 

**<a href="./Aula 04 - Aplicação Bancária">Resolução</a>**

---

## Exercício 03

1\) O objetivo deste exercício é utilizar os conceitos de herança e polimorfismo para calcular o Imposto de Renda de uma coleção de contribuintes, que podem ser pessoas físicas ou pessoas jurídicas. O cálculo do IR deve ser feito da seguinte maneira:

Pessoa Jurídica: O imposto deve corresponder a 10% da renda bruta da empresa.

Pessoa Física: O imposto deve ser calculado de acordo com a tabela:

| Renda Bruta | Alíquota | Parcela a Deduzir |
|-------------|----------|-------------------|
| R\$ 0,00 a R$ 1.400,00 | 0% | R$ 0,00 |
| R\$ 1.400,01 a R$ 2.100,00 | 10% | R$ 100,00 |
| R\$ 2.100,01 a R$ 2.800,00 | 15% | R$ 270,00 |
| R\$ 2.800,01 a R$ 3.600,00 | 25% | R$ 500,00 |
| R\$ 3.600,01 ou mais | 30% | R$ 700,00 |

As classes a seguir devem ser usadas conjuntamente com este enunciado. Elas contêm parte do código necessário à implementação deste exercício. Você terá que completá- las nos pontos indicados, de acordo com os objetivos do exercício. Crie um pacote que contenha as classes, além de um pacote de teste com uma classe Questao1, que por sua vez terá um método estático para acionar os devidos testes.

**Exemplo da Classe PFisica:**

```
public class PFisica : Contribuinte {
    protected String cpf;

    public Pfisica(String n,double r,String c) {
        // inicialização das varáveis de instância
    }
    public double calcImposto() {
        // Cálculo do imposto
    }
}
```

**Exemplo da Classe PJuridica:**

```
public class PJuridica : Contribuinte {
    protected String cnpj;

    public Pjuridica(String n,double r,String c) {
        //inicialização das varáveis de instância
    }
    public double calcImposto(){
        //Cálculo do imposto
    }
}
```

**Exemplo da Classe Contribuinte:**

```
public abstract class Contribuinte {
    protected String nome;
    protected double rendaBrt;

    public static Contribuinte [] listaContr(){

        Contribuinte []lst=new Contribuinte[6];

        lst[0]=new PFisica("Joao Santos",3000.00,"11111");
        lst[1]=new PJuridica("Lojas AA",150000.00,"10055");
        lst[2]=new PFisica("Maria Soares",5000.00,"22222");
        lst[3]=new PJuridica("Supermercados B",2000000.00,"10066");
        lst[4]=new PFisica("Carla Maia",1500.00,"33333");
        lst[5]=new PJuridica("Posto XX",500000.00,"10077");
        return lst;
    }

    public String getNome(){
        return nome;
    }
    abstract public double calcImposto();
}
```

**Exemplo do Método estático de testes:**

```
public static void Questao1 (string[] args){
    Contribuinte []lst;

    // obtenha a lista de contribuintes
    lst= ;

    Console.WriteLine("NOME IMPOSTO\n");
    Console.WriteLine("==================== =======\n\n");

    // coloque aqui o comando for
    {
        // Console.WriteLine a seguir deve exibir o nome e o
        // imposto que o contribuinte irá pagar

        Console.WriteLine(" ");
    }
}
```

**Questão teórica:** Identifique onde foi utilizado o Polimorfismo no exercício e classifique de acordo com os tipos: Universal (Paramétrico ou Inclusão) e Ad Hoc (Coerção ou Sobrecarga), Justifique.

**<a href="./Aula%2008%20-%20Polimorfismo%2C%20Classes%20abstratas/exercicio01">Resolução</a>**

**Resposta da questão teórica:** O polimorfismo foi utilizado no método "calcImposto()". O tipo de polimorfismo utilizado foi Universal Inclusão, já que, a superclasse "Contribuinte" possui o método "calcImposto()" com o modificador abstract e as subclasses "PFisca" e "PJuridica" possuem o mesmo método, porém com o modificador override.

<hr>

2\) Faça um cópia do esquema de classes anterior, adaptando namespace e classes para Questao2. Crie um nível de especialização das classes acima, sendo uma chamada Autonomo (AUT) outra MicroEmpIndividual (MEI). Da classe PessoaJuridica, crie as classes filhas, FirmaIndividual (FI), MicroEmpresa (ME) , EmpresaPequenoPorte (EPP).

a\) Crie método abstratos mostrarSigla nas classes PessoaFisica e PessoaJuridica e reescreva todos eles nas classes filhas, de maneira que cada objeto possa mostrar a Sigla da sua natureza de estabelecimento.

b\) É necessário saber qual a empresa destaque de cada um dos seguimentos. Para isso na classe de testes estática, crie um vetor ou uma lista que seja capaz de adicionar um elemento apenas de cada uma das subclasses (tipos de estabelecimentos). Deverá ser testada está condição, caso um subtipo que já se encontre no listaDestaque, já tenha sido adicionada, deverá retornar uma mensagem informado que o tipo de estabelecimento já foi adicionado.

c\) Crie um método que seja capaz de ordenar a lista pelo valor do valor retornado pela função de calculo do imposto.

**<a href="./Aula%2008%20-%20Polimorfismo%2C%20Classes%20abstratas/exercicio02">Resolução</a>**

---

## Exercício 04

Desenvolva uma aplicação em modo GUI (Windows Form) para um sistema de Figuras Geométricas, utilizando os conceitos de herança, classes abstratas e classes seladas, se julgar necessário pode ser utilizado interface, crie pacotes de forma padronizada, encapsulamento e níveis de proteção necessários.

A aplicação deverá conter:

a\) Uma classe base chamada Forma como uma classe Abstrata e uma classe Derivada com para cada forma especifica: Quadrado, Octágono, Pentágono, Retângulo, Triangulo, Circulo e Hexágono.<br>
b\) Implemente um métodos Abstratos na classe Base que deverão ser implementados de acordo com sua forma para CalcularArea, CalcularPerimetro()<br>
c\) Crie também um método virtual mostrar que deverá ser sobrescrito e por sua vez ser rescrito em todas as classes derivadas mostrando uma figura geométrica que apresente além dos resultados obtidos pelas classes da letra b, a imagem da figura.<br>
d\) Crie um Windows Form criativo e intuitivo para apresentar os resultados.

**<a href="./Aula%2009%20-%20Classes%20e%20M%C3%A9todos%20Selados/FormasGeometricas">Resolução</a>**

---

## Exercício 05

Desenvolva uma aplicação com Windows Form que possua os seguintes requisitos:<br>
a\) Criar um cadastro de clientes com informações de nome e e-mail que deverão ser lidos no formulário.

b\) A aplicação deverá ler dois campos de entrada de dados e na ação de um botão de cadastro, salvar os dados em arquivo XML.

c\) A arquitetura do projeto deverá conter uma classe Cliente com as informações a serem salvas. E uma outra classe chamada ClientesDAO que deverá conter os operações de I/O no arquivo XML.

d\) Cria uma interface com algum componente que seja capaz de receber os dados lidos do arquivo XML e listá-los quando o formulário for carregado.

e\) É recomendável que sejam criados métodos de validação e tratamento de Exceção.

**<a href="./Aula%2010%20-%20Revis%C3%A3o%20GUI%20%2B%20Padr%C3%B5es%20e%20Tecnologias/Cadastro">Resolução</a>**

---

## Exercício 06

### Atividade: Simulador de Patos

Você foi contratado para fazer parte de uma equipe de desenvolvimento de um projeto de Simulador de Patos para um Jogo. Na ocasião, você precisa desenvolver um projeto conforme o Diagrama de Classes abaixo:

<img src="https://i.imgur.com/F17zcxZ.png" height="250">

Todos os requisitos informados, foram perfeitamente satisfeitos até que:

Surgiram novos requisitos em tempo de implementação de projeto onde surgiram vários tipos de patos que não podem voar, como patos de madeira, ferro. Além disso alguns patos não poderiam grasnar. Podemos dizer que apenas a utilização de herança não é capaz de resolver o problema. A interface é uma excelente estratégia para resolver este problema.

Passo 1\) Separar tudo o que é comportamento e que varia e colocar em interfaces, deixe apenas o que não varia na classe base.

<img src="https://i.imgur.com/BRWRUqj.png" height="250">

Passo 2\) Implemente as interfaces:

```
public interface IFlyable {
    void fly( );
}
```

```
public interface IQuackable {
    quack( );
}
```

Passo 3\) Implementando os comportamentos nas classes derivadas:

```
public class ReadHeadDuck : Duck, IFlyable, IQuackable {

    //métodos herdados de Duck

    public void fly() {
        Console.Write(“voar...”)
    }

    public void quack() {
        Console.Write(“quaaaa!!!!...”)
    }
}
```

Passo 4\) Modifique seu programa Simulador de Patos retirando todos os comportamentos que variam da classe Duck e os colocando em interfaces.<br>
Continue utilizando herança da Classe Duck para o que repete (ex: display) e faça a escrita dos métodos assinados nas interfaces

**<a href="./Aula%2011%20-%20Uso%20de%20Interfaces/Atividade6">Resolução</a>**

---

## Exercício 07

1\) Faça um programa que lê um valor inteiro e calcule se ele é um número primo, faça a sua validação através do tratamento de uma exceção. Caso não seja inteiro continuar pedindo a introdução do valor inteiro.

2\) Faça um programa que simule uma calculadora básica com as operações de soma, multiplicação, subtração, divisão e módulo (resto da divisão). Seu programa deve receber do usuário dois números e executar a operação selecionada pelo usuário. Faça a validação do funcionamento do seu programa usando tratamento de exceção.

3\) Escreva um programa para preencher valores de um vetor de inteiros com 10 posições. O usuário irá informar os valores a serem inseridos e suas respectivas posições no array. O programa deve tratar as exceções IndexOutOfRangeException quando for informada uma posição inexistente do vetor e FormatException quando o valor informado não for numero.

4\) Crie um programa que receba n números e some esses números enquanto a soma não for superior a 100. O programa deverá imprimir o valor somado (antes de atingir o número maior que 100) e deverá informar quantos números foram somados e qual a média. Refaça seu programa utilizando as seguintes regras:

a\) Utilize os tratamentos de exceção para lidar com a entrada de dados.

b\) Quando a soma for superior a 100, o programa deverá gerar uma exceção criada pelo programador com nome ExcecaoAcimaDeCem.

c\) Lance essa exceção, com o uso de throws.

**<a href="./Aula%2012%20-%20Tratamento%20de%20Exce%C3%A7%C3%B5es/Atividade7">Resolução</a>**