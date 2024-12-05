import 'package:flutter/material.dart';
import 'login.dart';
import 'info.dart';

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
        primarySwatch: Colors.blue,
      ),
      home: const HomeScreen(),
    );
  }
}

class HomeScreen extends StatefulWidget {
  const HomeScreen({super.key});

  @override
  HomeScreenState createState() => HomeScreenState();
}

class HomeScreenState extends State<HomeScreen> {
  int _currentIndex = 1;
  String titulo = "";

  final List<Widget> _screens = [
    const LoginPage(),
    const HomePage(),
    const AboutPage(),
  ];

  @override
  Widget build(BuildContext context) {
    switch (_currentIndex) {
      case 0:
        titulo = "Login";
        break;
      case 1:
        titulo = "Home";
        break;
      case 2:
        titulo = "About";
        break;
    }
    return Scaffold(
      appBar: AppBar(
        title: Text(
          titulo,
          style: const TextStyle(color: Colors.white),
        ),
        backgroundColor: const Color.fromARGB(255, 0, 136, 255),
        iconTheme: const IconThemeData(color: Colors.white),
      ),
      body: _screens[_currentIndex],
      bottomNavigationBar: BottomNavigationBar(
        currentIndex: _currentIndex,
        items: const <BottomNavigationBarItem>[
          BottomNavigationBarItem(icon: Icon(Icons.person), label: 'Login'),
          BottomNavigationBarItem(icon: Icon(Icons.home), label: 'Home'),
          BottomNavigationBarItem(icon: Icon(Icons.info), label: 'About'),
        ],
        onTap: (index) {
          setState(() {
            _currentIndex = index;
          });
        },
        selectedItemColor: const Color.fromARGB(255, 0, 136, 255),
        unselectedItemColor: Colors.grey,
      ),
    );
  }
}

class HomePage extends StatelessWidget {
  const HomePage({super.key});

  @override
  Widget build(BuildContext context) {
    return const Center(
      child: Text(
        'Home Page',
        style: TextStyle(fontSize: 24),
      ),
    );
  }
}
