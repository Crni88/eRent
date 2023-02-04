import 'dart:ffi';

import 'package:flutter/material.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  // This widget is the root of your application.
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Flutter Demo',
      theme: ThemeData(
        primarySwatch: Colors.blue,
      ),
      home: const MyHomePage(title: 'Test Hot Reload-a'),
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
  @override
  Widget build(BuildContext context) {
    return Scaffold(
        body: Container(
      decoration: BoxDecoration(
          borderRadius: BorderRadius.circular(5), color: Colors.blueAccent),
      child: Column(
        mainAxisAlignment: MainAxisAlignment.center,
        crossAxisAlignment: CrossAxisAlignment.center,
        children: [
          Container(
            margin: const EdgeInsets.only(top: 100),
            width: 400,
            child: const Center(
              child: Text(
                "Login",
                style: TextStyle(
                    color: Colors.white,
                    fontSize: 32,
                    fontWeight: FontWeight.bold),
              ),
            ),
          ),
          Container(
            margin: const EdgeInsets.all(20),
            padding: const EdgeInsets.all(50),
            decoration: BoxDecoration(
                borderRadius: BorderRadius.circular(5), color: Colors.white),
            height: 350,
            child: Column(
                mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                children: const [
                  TextField(
                    decoration: InputDecoration(
                      hintText: "Username",
                      hintStyle:
                          TextStyle(fontSize: 20.0, color: Colors.blueAccent),
                    ),
                  ),
                  TextField(
                    decoration: InputDecoration(
                      hintText: "Password",
                      hintStyle:
                          TextStyle(fontSize: 20.0, color: Colors.blueAccent),
                    ),
                  ),
                  Padding(
                    padding: EdgeInsets.symmetric(horizontal: 50),
                    child: OutlinedButton(
                      onPressed: null,
                      child: Text(
                        "Login",
                        style: TextStyle(
                            color: Colors.blueAccent,
                            fontSize: 22,
                            fontWeight: FontWeight.w500),
                      ),
                    ),
                  )
                ]),
          ),
        ],
      ),
    ));
  }
}
