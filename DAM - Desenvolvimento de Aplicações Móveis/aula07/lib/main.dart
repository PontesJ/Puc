import 'package:aula07/lista.dart';
import 'package:flutter/material.dart';
import 'login.dart';

void main() {
  runApp(MaterialApp(
    home: LoginPage(),
    initialRoute: '/',
    routes: {
      '/login': (context) => LoginPage(),
      '/list': (context) => ListPage(),
    },
  ));
}