import 'package:flutter/material.dart';

class Cadastro extends StatefulWidget {
  @override
  _CadastroState createState() => _CadastroState();
}

class _CadastroState extends State<Cadastro> {
  bool _isObscure = true; // Controla se a senha está visível ou oculta
  String? selecionado = "m";
  bool gmail = false;
  bool zap = false;

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text("Cadastro"),
      ),
      body: ListView(
        children: <Widget>[
          const Padding(
            padding: EdgeInsets.all(32),
            child: TextField(
              keyboardType: TextInputType.text,
              decoration: InputDecoration(
                labelText: "Nome:",
              ),
              maxLength: 20,
            ),
          ),
          const Padding(
            padding: EdgeInsets.all(32),
            child: TextField(
              keyboardType: TextInputType.datetime,
              decoration: InputDecoration(
                labelText: "Data de nascimento:",
              ),
              maxLength: 10,
            ),
          ),
          const Padding(
            padding: EdgeInsets.all(32),
            child: TextField(
              keyboardType: TextInputType.emailAddress,
              decoration: InputDecoration(
                labelText: "Email:",
              ),
            ),
          ),
          Padding(
            padding: const EdgeInsets.all(32),
            child: TextField(
              keyboardType: TextInputType.text,
              decoration: InputDecoration(
                labelText: "Senha:",
                suffixIcon: IconButton(
                  icon: Icon(
                    _isObscure ? Icons.visibility_off : Icons.visibility,
                  ),
                  onPressed: () {
                    setState(() {
                      _isObscure = !_isObscure; // Alterna a visibilidade da senha
                    });
                  },
                ),
              ),
              obscureText: _isObscure, // Define se a senha é visível ou oculta
              maxLength: 20,
            ),
          ),
          Padding(
            padding: const EdgeInsets.all(32),
            child: Row(
              children: <Widget>[
                const Text("Gênero:"),
                const SizedBox(width: 30),
                const Text("Masculino"),
                Radio(
                  value: "m",
                  groupValue: selecionado,
                  onChanged: (String? escolha){
                    setState(() {
                      selecionado = escolha!;
                    });
                  },
                ),
                const Text("Feminino"),
                Radio(
                  value: "f",
                  groupValue: selecionado,
                  onChanged: (String? escolha){
                    setState(() {
                      selecionado = escolha!;
                    });
                  },
                ),
              ],
            ),
          ),
          const Padding(
            padding: EdgeInsets.all(32),
            child: Text("Notificações:")
          ),
          Padding(
            padding: EdgeInsets.all(32),
            child: Column(
              children: [
                SwitchListTile(
                  title: Text("Gmail"),
                  value: gmail,
                  onChanged: (bool valor){
                    setState(() {
                      gmail = valor;
                    });
                  },
                ),
                SwitchListTile(
                  title: Text("WhatsApp"),
                  value: zap,
                  onChanged: (bool valor){
                    setState(() {
                      zap = valor;
                    });
                  },
                ),
              ],
            )
          ),
          Padding(
            padding: const EdgeInsets.all(32),
            child: ElevatedButton(
              onPressed: () {
                // Ação do botão
              },
              child: const Text("Cadastrar"),
            ),
          ),
        ],
      ),
    );
  }
}
