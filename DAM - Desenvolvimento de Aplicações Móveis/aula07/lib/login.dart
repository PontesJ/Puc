import 'package:flutter/material.dart';

class LoginPage extends StatelessWidget {
  LoginPage({super.key});

  final TextEditingController _controllerNome = TextEditingController();
  final TextEditingController _controllerEmail = TextEditingController();
  final TextEditingController _controllerPassword = TextEditingController();

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text(
          "Login",
          style: TextStyle(color: Colors.white),
        ),
        backgroundColor: const Color.fromARGB(255, 0, 136, 255),
        iconTheme: const IconThemeData(color: Colors.white),
      ),
      body: Center(
        child: Padding(
          padding: const EdgeInsets.symmetric(horizontal: 16.0),
          child: Column(
            mainAxisAlignment: MainAxisAlignment.center,
            crossAxisAlignment: CrossAxisAlignment.stretch,
            children: [
              TextField(
                decoration: const InputDecoration(
                  labelText: 'Nome',
                  labelStyle: TextStyle(color: Color.fromARGB(255, 74, 74, 74)),
                  enabledBorder: OutlineInputBorder(
                      borderSide:
                          BorderSide(color: Color.fromARGB(255, 74, 74, 74))),
                  focusedBorder: OutlineInputBorder(
                      borderSide: BorderSide(
                          color: Color.fromARGB(255, 74, 74, 74), width: 2.0)),
                ),
                controller: _controllerNome,
                style: const TextStyle(
                    color: Color.fromARGB(255, 0, 0, 0), fontSize: 20),
              ),
              const SizedBox(height: 15),
              TextField(
                decoration: const InputDecoration(
                  labelText: 'E-mail',
                  labelStyle: TextStyle(color: Color.fromARGB(255, 74, 74, 74)),
                  enabledBorder: OutlineInputBorder(
                      borderSide:
                          BorderSide(color: Color.fromARGB(255, 74, 74, 74))),
                  focusedBorder: OutlineInputBorder(
                      borderSide: BorderSide(
                          color: Color.fromARGB(255, 74, 74, 74), width: 2.0)),
                ),
                controller: _controllerEmail,
                style: const TextStyle(
                    color: Color.fromARGB(255, 0, 0, 0), fontSize: 20),
              ),
              const SizedBox(height: 15),
              TextField(
                decoration: const InputDecoration(
                  labelText: 'Password',
                  labelStyle: TextStyle(color: Color.fromARGB(255, 74, 74, 74)),
                  enabledBorder: OutlineInputBorder(
                      borderSide:
                          BorderSide(color: Color.fromARGB(255, 74, 74, 74))),
                  focusedBorder: OutlineInputBorder(
                      borderSide: BorderSide(
                          color: Color.fromARGB(255, 74, 74, 74), width: 2.0)),
                ),
                controller: _controllerPassword,
                style: const TextStyle(
                    color: Color.fromARGB(255, 0, 0, 0), fontSize: 20),
              ),
              const SizedBox(height: 30),
              ElevatedButton(
                onPressed: () {
                  if (_controllerEmail.text == "eumesmo@gmail.com" && _controllerPassword.text == "12345")
                  {
                    Navigator.of(context)
                      .pushNamed('/list', arguments: _controllerNome.text);
                  }
                  else
                  {
                    showDialog(context: context, builder: (context) {
                    return AlertDialog(
                      title: const Text("Dados inválidos"),
                      content: const Text("Usuário e/ou senha incorreto(a)"),
                      actions: <Widget>[
                        TextButton(
                          child: const Text("OK"),
                          onPressed: () {
                            Navigator.pop(context);
                          },
                        )
                      ],
                    );
                  });
                  }
                },
                style: ElevatedButton.styleFrom(
                  backgroundColor: const Color.fromARGB(255, 0, 136, 255),
                  shape: RoundedRectangleBorder(
                      borderRadius: BorderRadius.circular(5)),
                ),
                child: const Text('Enter',
                    style: TextStyle(fontSize: 20, color: Colors.white)),
              ),
              const SizedBox(height: 30),
              Center(
                child: GestureDetector(
                  child: RichText(
                    text: const TextSpan(
                      text: 'New here? ',
                      style: TextStyle(color: Colors.black),
                      children: <TextSpan>[
                        TextSpan(
                          text: 'Create an account',
                          style: TextStyle(
                            color: Color.fromARGB(255, 0, 136, 255),
                            decoration: TextDecoration.underline,
                          ),
                        ),
                      ],
                    ),
                  ),
                ),
              ),
            ],
          ),
        ),
      ),
    );
  }
}
