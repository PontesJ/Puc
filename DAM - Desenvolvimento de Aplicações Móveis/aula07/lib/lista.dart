import 'package:flutter/material.dart';

class ListPage extends StatelessWidget {

  ListPage({super.key});

  List _itens = [];

  void _carregarItens()
  {
    _itens = [];
    for(int i=0; i <= 20; i++){
      Map<String, dynamic> item = {};
      item["titulo"] = "Titulo $i da lista";
      item ["descricao"]="Descrição $i da lista";
      _itens.add(item);
    }
  }

  @override
  Widget build(BuildContext context) {
    _carregarItens();
    String? valor = ModalRoute.of(context)?.settings.arguments as String;
    return Scaffold(
      appBar: AppBar(
        title: Text(
          "Lista - Bem vindo(a), $valor",
          style: const TextStyle(color: Colors.white),
        ),
        backgroundColor: const Color.fromARGB(255, 0, 136, 255),
        iconTheme: const IconThemeData(color: Colors.white),
      ),
      body: Container(
        padding: const EdgeInsets.all(20),
        child: ListView.builder(
            itemCount: _itens.length,
            itemBuilder: (context, indice) {
              return ListTile(
                onTap: () {
                  showDialog(context: context, builder: (context) {
                    return AlertDialog(
                      title: const Text("Alerta"),
                      content: Text("Você clicou no item $indice"),
                      actions: <Widget>[
                        TextButton(
                          child: const Text("Cancelar"),
                          onPressed: () {
                            Navigator.pop(context);
                          },
                        ),
                        TextButton(
                          child: const Text("OK"),
                          onPressed: () {
                            Navigator.pop(context);
                          },
                        )
                      ],
                    );
                  });
                },
                title: Text(indice.toString()),
                subtitle: const Text("Subtitulo"),
              );
            }),
      ),
    );
  }
}
