import 'package:flutter/material.dart';

class HomePage extends StatelessWidget {
  const HomePage({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Flutter Demo',
      home: Scaffold(
        appBar: AppBar(
          title: const Text(
            "Login",
            style: TextStyle(color: Colors.white),
          ),
          backgroundColor:
              const Color.fromARGB(255, 0, 136, 255),
          iconTheme: const IconThemeData(color: Colors.white),
        ),
        drawer: const Drawer(),
        body: Center(
          child: Padding(
            padding: const EdgeInsets.symmetric(horizontal: 16.0),
            child: Column(
              mainAxisAlignment: MainAxisAlignment.center,
              crossAxisAlignment: CrossAxisAlignment.stretch,
              children: [
                const TextField(
                  decoration: InputDecoration(
                    labelText: 'E-mail',
                    labelStyle: TextStyle(color: Color.fromARGB(255, 74, 74, 74)),
                    enabledBorder: OutlineInputBorder(borderSide: BorderSide( color: Color.fromARGB(255, 74, 74, 74))),
                    focusedBorder: OutlineInputBorder(borderSide: BorderSide(color: Color.fromARGB(255, 74, 74, 74), width: 2.0)),
                  ),
                  style: TextStyle(color: Color.fromARGB(255, 0, 0, 0), fontSize: 20),
                ),

                const SizedBox(height: 15),

                const TextField(
                  decoration: InputDecoration(
                    labelText: 'Password',
                    labelStyle: TextStyle(color: Color.fromARGB(255, 74, 74, 74)),
                    enabledBorder: OutlineInputBorder(borderSide: BorderSide(color: Color.fromARGB(255, 74, 74, 74))),
                    focusedBorder: OutlineInputBorder(borderSide: BorderSide(color: Color.fromARGB(255, 74, 74, 74), width: 2.0)),
                  ),
                  style: TextStyle(color: Color.fromARGB(255, 0, 0, 0), fontSize: 20),
                ),

                const SizedBox(height: 30),

                ElevatedButton(
                  onPressed: () {},
                  style: ElevatedButton.styleFrom(
                    backgroundColor: const Color.fromARGB(255, 0, 136, 255),
                    shape: RoundedRectangleBorder(borderRadius: BorderRadius.circular(5)),
                  ),
                  child: const Text('Enter', style: TextStyle(fontSize: 20, color: Colors.white)),
                ),

                const SizedBox(height: 30),

                Center(
                  child: RichText(
                    text: const TextSpan(
                      text: 'New here? ',
                      style: TextStyle(color: Colors.black),
                      children: <TextSpan>[
                        TextSpan(text: 'Create an account', style: TextStyle(color: Color.fromARGB(255, 0, 136, 255), decoration: TextDecoration.underline)),
                      ],
                    ),
                  ),
                ),
              ],
            ),
          ),
        ),
        bottomNavigationBar: BottomNavigationBar(
          items: const <BottomNavigationBarItem>[
            BottomNavigationBarItem(icon: Icon(Icons.home), label: 'Home'),
            BottomNavigationBarItem(icon: Icon(Icons.person), label: 'Login'),
          ],
        ),
      ),
    );
  }
}

void main() {
  runApp(const HomePage());
}
