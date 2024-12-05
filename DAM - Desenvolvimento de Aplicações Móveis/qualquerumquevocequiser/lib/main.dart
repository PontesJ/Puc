import 'package:flutter/material.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Flutter Demo',
      theme: ThemeData(
        colorScheme: ColorScheme.fromSeed(
            seedColor: const Color.fromARGB(255, 20, 206, 166)),
        useMaterial3: true,
      ),
      home: const MyHomePage(title: 'Tela Inicial'),
    );
  }
}

class MyHomePage extends StatefulWidget {
  const MyHomePage({super.key, required this.title});

  final String title;

  @override
  State<MyHomePage> createState() => _MyHomePageState();
}

class _MyHomePageState extends State<MyHomePage> {
  int _counter = 0;
  int _counter2 = 0; // Cria mais um contador

  void _incrementCounter() {
    setState(() {
      _counter++;
    });
  }

  // Cria um método para incrementar o contador 2
  void _incrementCounter2() {
    setState(() {
      _counter2++;
    });
  }

  @override
  Widget build(BuildContext context) {
    var soma = _counter + _counter2; // Adiciona a soma dos contadores
    var multiplicacao = _counter * _counter2; // Adiciona a multiplicação dos contadores

    return Scaffold( 
      appBar: AppBar(
        backgroundColor: Theme.of(context).colorScheme.inversePrimary, 
        title: Text(widget.title),
      ),
      body: Center(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children: <Widget>[
            Text(
              'Botão 1:', // Exibe o texto
              style: Theme.of(context).textTheme.headlineLarge, // Altera o estilo do texto
            ),
            Text(
              '$_counter', // Recebe o valor do contador 1
              style: Theme.of(context).textTheme.headlineMedium, // Altera o estilo do texto
            ),
            Text(
              'Botão 2:', // Exibe o texto
              style: Theme.of(context).textTheme.headlineLarge, // Altera o estilo do texto
            ),
            Text(
              '$_counter2', // Recebe o valor do contador 2
              style: Theme.of(context).textTheme.headlineMedium, // Altera o estilo do texto
            ),
            Text(
              'Soma: $soma', // Exibe a soma dos contadores
              style: Theme.of(context).textTheme.headlineMedium, // Altera o estilo do texto
            ),
            Text(
              'Multiplicação: $multiplicacao', // Exibe a multiplicação dos contadores
              style: Theme.of(context).textTheme.headlineMedium, // Altera o estilo do texto
            )
          ],
        ),
      ),
      floatingActionButton: Row( // Adiciona um botão ao lado do outro
        mainAxisAlignment: MainAxisAlignment.center, // Centraliza os botões
        children: <Widget>[ // Adiciona os botões
          FloatingActionButton( // Botão 1
            onPressed: _incrementCounter, // Chama o método para incrementar o contador 1
            tooltip: 'Increment 1', // Exibe uma mensagem ao passar o mouse sobre o botão
            child: const Icon(Icons.add), // Adiciona um ícone ao botão
          ),
          FloatingActionButton( // Botão 2
            onPressed: _incrementCounter2, // Chama o método para incrementar o contador 2
            tooltip: 'Increment 2', // Exibe uma mensagem ao passar o mouse sobre o botão
            child: const Icon(Icons.add), // Adiciona um ícone ao botão
          ),
        ],
      ),
    );
  }
}