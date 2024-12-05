import 'package:flutter/material.dart';

class Cadastro extends StatefulWidget {
  const Cadastro({super.key});

  @override
  CadastroState createState() => CadastroState();
}

class CadastroState extends State<Cadastro> {
  bool _isObscure = true; // Controla se a senha está visível ou oculta
  String? selecionado = "m";
  bool gmail = false;
  bool zap = false;

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text(
          "Cadastro",
          style: TextStyle(color: Colors.white),
        ),
        backgroundColor: const Color.fromARGB(255, 0, 136, 255),
        iconTheme: const IconThemeData(color: Colors.white),
      ),
      body: ListView(
        children: <Widget>[
          const Padding(
            padding:
                EdgeInsets.fromLTRB(32, 16, 32, 8), // Ajuste de espaçamento
            child: TextField(
              keyboardType: TextInputType.text,
              decoration: InputDecoration(
                labelText: 'Nome',
                labelStyle: TextStyle(color: Color.fromARGB(255, 74, 74, 74)),
                enabledBorder: OutlineInputBorder(
                    borderSide:
                        BorderSide(color: Color.fromARGB(255, 74, 74, 74))),
                focusedBorder: OutlineInputBorder(
                    borderSide: BorderSide(
                        color: Color.fromARGB(255, 74, 74, 74), width: 2.0)),
              ),
              style:
                  TextStyle(color: Color.fromARGB(255, 0, 0, 0), fontSize: 20),
              maxLength: 20,
            ),
          ),
          const Padding(
            padding: EdgeInsets.fromLTRB(32, 8, 32, 8), // Ajuste de espaçamento
            child: TextField(
              keyboardType: TextInputType.datetime,
              decoration: InputDecoration(
                labelText: 'Data de Nascimento',
                labelStyle: TextStyle(color: Color.fromARGB(255, 74, 74, 74)),
                enabledBorder: OutlineInputBorder(
                    borderSide:
                        BorderSide(color: Color.fromARGB(255, 74, 74, 74))),
                focusedBorder: OutlineInputBorder(
                    borderSide: BorderSide(
                        color: Color.fromARGB(255, 74, 74, 74), width: 2.0)),
              ),
              style:
                  TextStyle(color: Color.fromARGB(255, 0, 0, 0), fontSize: 20),
              maxLength: 10,
            ),
          ),
          const Padding(
            padding: EdgeInsets.fromLTRB(32, 8, 32, 8), // Ajuste de espaçamento
            child: TextField(
              keyboardType: TextInputType.emailAddress,
              decoration: InputDecoration(
                labelText: 'E-mail',
                labelStyle: TextStyle(color: Color.fromARGB(255, 74, 74, 74)),
                enabledBorder: OutlineInputBorder(
                    borderSide:
                        BorderSide(color: Color.fromARGB(255, 74, 74, 74))),
                focusedBorder: OutlineInputBorder(
                    borderSide: BorderSide(
                        color: Color.fromARGB(255, 74, 74, 74), width: 2.0)),
              ),
            ),
          ),
          Padding(
            padding: const EdgeInsets.fromLTRB(
                32, 8, 32, 8), // Ajuste de espaçamento
            child: TextField(
              keyboardType: TextInputType.text,
              decoration: InputDecoration(
                labelText: "Senha:",
                labelStyle:
                    const TextStyle(color: Color.fromARGB(255, 74, 74, 74)),
                enabledBorder: const OutlineInputBorder(
                    borderSide:
                        BorderSide(color: Color.fromARGB(255, 74, 74, 74))),
                focusedBorder: const OutlineInputBorder(
                    borderSide: BorderSide(
                        color: Color.fromARGB(255, 74, 74, 74), width: 2.0)),
                suffixIcon: IconButton(
                  icon: Icon(
                    _isObscure ? Icons.visibility_off : Icons.visibility,
                  ),
                  onPressed: () {
                    setState(() {
                      _isObscure =
                          !_isObscure; // Alterna a visibilidade da senha
                    });
                  },
                ),
              ),
              obscureText: _isObscure, // Define se a senha é visível ou oculta
              maxLength: 20,
            ),
          ),
          Padding(
            padding: const EdgeInsets.fromLTRB(
                32, 8, 32, 8), // Ajuste de espaçamento
            child: Row(
              children: <Widget>[
                const Text("Gênero:"),
                const SizedBox(width: 30),
                const Text("Masculino"),
                Radio(
                  value: "m",
                  groupValue: selecionado,
                  onChanged: (String? escolha) {
                    setState(() {
                      selecionado = escolha!;
                    });
                  },
                  activeColor:
                      const Color.fromARGB(255, 0, 136, 255), // Cor dos botões
                ),
                const Text("Feminino"),
                Radio(
                  value: "f",
                  groupValue: selecionado,
                  onChanged: (String? escolha) {
                    setState(() {
                      selecionado = escolha!;
                    });
                  },
                  activeColor:
                      const Color.fromARGB(255, 0, 136, 255), // Cor dos botões
                ),
              ],
            ),
          ),
          const Padding(
              padding:
                  EdgeInsets.fromLTRB(32, 16, 32, 8), // Ajuste de espaçamento
              child: Text("Notificações:")),
          Padding(
              padding: const EdgeInsets.fromLTRB(
                  32, 8, 32, 8), // Ajuste de espaçamento
              child: Column(
                children: [
                  SwitchListTile(
                    title: const Text("Gmail"),
                    value: gmail,
                    onChanged: (bool valor) {
                      setState(() {
                        gmail = valor;
                      });
                    },
                    activeTrackColor:
                        const Color.fromARGB(255, 0, 136, 255), // Cor do botão
                  ),
                  SwitchListTile(
                    title: const Text("WhatsApp"),
                    value: zap,
                    onChanged: (bool valor) {
                      setState(() {
                        zap = valor;
                      });
                    },
                    activeTrackColor:
                        const Color.fromARGB(255, 0, 136, 255), // Cor do botão
                  ),
                ],
              )),
          Padding(
            padding: const EdgeInsets.fromLTRB(
                32, 8, 32, 8), // Ajuste de espaçamento
            child: ElevatedButton(
              onPressed: () {},
              style: ElevatedButton.styleFrom(
                backgroundColor: const Color.fromARGB(255, 0, 136, 255),
                shape: RoundedRectangleBorder(
                    borderRadius: BorderRadius.circular(5)),
              ),
              child: const Text('Cadastrar',
                  style: TextStyle(fontSize: 20, color: Colors.white)),
            ),
          ),
        ],
      ),
    );
  }
}
