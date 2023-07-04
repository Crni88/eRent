import 'package:flutter/material.dart';
import 'package:myapp/main.dart';
import 'package:myapp/providers/user_provider.dart';

class RegisterScreen extends StatelessWidget {
  final TextEditingController korisnikImeController = TextEditingController();
  final TextEditingController korisnikPrezimeController =
      TextEditingController();
  final TextEditingController passwordController = TextEditingController();
  final TextEditingController confirmPasswordController =
      TextEditingController();
  final TextEditingController emailController = TextEditingController();
  final TextEditingController usernameController = TextEditingController();
  UserProvider userProvider = UserProvider();
  RegisterScreen({super.key});

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Registration'),
      ),
      body: SingleChildScrollView(
        child: Padding(
          padding: const EdgeInsets.all(16.0),
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.stretch,
            children: [
              TextField(
                controller: korisnikImeController,
                decoration: const InputDecoration(
                  labelText: 'Ime',
                ),
              ),
              const SizedBox(height: 16.0),
              TextField(
                controller: korisnikPrezimeController,
                decoration: const InputDecoration(
                  labelText: 'Prezime',
                ),
              ),
              const SizedBox(height: 16.0),
              TextField(
                controller: usernameController,
                decoration: const InputDecoration(
                  labelText: 'Korisnicko Ime',
                ),
              ),
              const SizedBox(height: 16.0),
              TextField(
                controller: passwordController,
                obscureText: true,
                decoration: const InputDecoration(
                  labelText: 'Šifra',
                ),
              ),
              const SizedBox(height: 16.0),
              TextField(
                controller: confirmPasswordController,
                obscureText: true,
                decoration: const InputDecoration(
                  labelText: 'Potvrdi Šifru',
                ),
              ),
              const SizedBox(height: 16.0),
              TextField(
                controller: emailController,
                keyboardType: TextInputType.emailAddress,
                decoration: const InputDecoration(
                  labelText: 'Email',
                ),
              ),
              const SizedBox(height: 16.0),
              ElevatedButton(
                onPressed: () async {
                  // Perform registration logic here
                  //String confirmPassword = confirmPasswordController.text;

                  if (!checkEmpty()) {
                    showDialog(
                        context: context,
                        builder: (BuildContext context) => AlertDialog(
                              title: const Text("Error"),
                              content:
                                  const Text("Sva polja su obavezna za unos."),
                              actions: [
                                TextButton(
                                  child: const Text("Ok"),
                                  onPressed: () => Navigator.pop(context),
                                )
                              ],
                            ));
                  } else if (!passwordMatched()) {
                    showDialog(
                        context: context,
                        builder: (BuildContext context) => AlertDialog(
                              title: const Text("Error"),
                              content: const Text("Unesene šifre nisu iste."),
                              actions: [
                                TextButton(
                                  child: const Text("Ok"),
                                  onPressed: () => Navigator.pop(context),
                                )
                              ],
                            ));
                  } else if (!isEmail()) {
                    showDialog(
                        context: context,
                        builder: (BuildContext context) => AlertDialog(
                              title: const Text("Error"),
                              content:
                                  const Text("Email nije u tačnom formatu!"),
                              actions: [
                                TextButton(
                                  child: const Text("Ok"),
                                  onPressed: () => Navigator.pop(context),
                                )
                              ],
                            ));
                  } else {
                    var korisnik = {
                      "korsnikIme": korisnikImeController.text,
                      "korisnikPrezime": korisnikPrezimeController.text,
                      "email": emailController.text,
                      "username": usernameController.text,
                      "uloga": "Korisnik",
                      "rejting": 0,
                      "password": passwordController.text,
                      "isActive": true,
                    };
                    try {
                      var tempData = await userProvider.insert(korisnik);
                      showDialog(
                          context: context,
                          builder: (context) {
                            Future.delayed(const Duration(seconds: 5), () {
                              Navigator.of(context).pop(true);
                              Navigator.push(
                                context,
                                MaterialPageRoute(
                                    builder: (context) => const MyApp()),
                              );
                            });
                            return const AlertDialog(
                              title: Text('Registracija uspješna!'),
                            );
                          });
                    } catch (e) {
                      showDialog(
                          context: context,
                          builder: (BuildContext context) => AlertDialog(
                                title: const Text("Error"),
                                content: Text(e.toString()),
                                actions: [
                                  TextButton(
                                    child: const Text("Ok"),
                                    onPressed: () => Navigator.pop(context),
                                  )
                                ],
                              ));
                    }
                  }
                  // Add your logic to handle registration, validation, etc.
                },
                child: const Text('Register'),
              ),
            ],
          ),
        ),
      ),
    );
  }

  bool checkEmpty() {
    String korisnikIme = korisnikImeController.text;
    String korisnikPrezime = korisnikPrezimeController.text;
    String username = usernameController.text;
    String password = passwordController.text;
    String confirmPassword = confirmPasswordController.text;
    String email = emailController.text;

    if (korisnikIme.isEmpty ||
        korisnikPrezime.isEmpty ||
        username.isEmpty ||
        password.isEmpty ||
        confirmPassword.isEmpty ||
        email.isEmpty) {
      return false;
    }
    return true;
  }

  bool passwordMatched() {
    if (passwordController.text != confirmPasswordController.text) {
      return false;
    }
    return true;
  }

  bool isEmail() {
    RegExp emailPattern = RegExp(
        r'^[\w-]+(\.[\w-]+)*@[a-zA-Z0-9]+(\.[a-zA-Z0-9]+)*(\.[a-zA-Z]{2,})$');
    if (!emailPattern.hasMatch(emailController.text)) {
      return false;
    }
    return true;
  }
}
