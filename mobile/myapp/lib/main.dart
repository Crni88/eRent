import 'package:firebase_core/firebase_core.dart';
import 'package:firebase_messaging/firebase_messaging.dart';
import 'package:flutter/foundation.dart';
import 'package:flutter/material.dart';
import 'package:flutter_stripe/flutter_stripe.dart';
import 'package:myapp/components/spacer.dart';
import 'package:myapp/model/korisnik.dart';
import 'package:myapp/providers/nekretnina_provider.dart';
import 'package:myapp/providers/nekretnine_provider.dart';
import 'package:myapp/providers/user_provider.dart';
import 'package:myapp/screens/customer/register_customer_screen.dart';
import 'package:myapp/screens/fitpasos/fitpasos_screen.dart';
import 'package:myapp/screens/nekretnine/nekretnine_screen.dart';
import 'package:myapp/utils/util.dart';
import 'package:provider/provider.dart';
import 'package:shared_preferences/shared_preferences.dart';

import '.env';

Future<void> main() async {
  WidgetsFlutterBinding.ensureInitialized();
  //await Firebase.initializeApp();

  Stripe.publishableKey = const String.fromEnvironment("stripePublishableKey",
      defaultValue: stripePublishableKey);
  Stripe.merchantIdentifier = 'eRent';
  await Stripe.instance.applySettings();

  await Firebase.initializeApp(
      options: const FirebaseOptions(
    apiKey: "AIzaSyAMAqdDG8mNPDEDlK5yPCquBJhkZJ-B814",
    appId: "1:467666186963:web:bb8bc6014f2ea34432da26",
    messagingSenderId: "467666186963",
    projectId: "erent-8244f",
  ));
  FirebaseMessaging messaging = FirebaseMessaging.instance;
  NotificationSettings settings = await messaging.requestPermission(
    alert: true,
    announcement: false,
    badge: true,
    carPlay: false,
    criticalAlert: false,
    provisional: false,
    sound: true,
  );

  if (kDebugMode) {
    print('User granted permission: ${settings.authorizationStatus}');
  }
  FirebaseMessaging.onMessage.listen((RemoteMessage message) {
    if (kDebugMode) {
      print('Got a message whilst in the foreground!');
      print('Message data: ${message.data}');
    }

    if (message.notification != null) {
      print('Message also contained a notification: ${message.notification}');
    }
  });
  Future<void> _firebaseMessagingBackgroundHandler(
      RemoteMessage message) async {
    // If you're going to use other Firebase services in the background, such as Firestore,
    // make sure you call `initializeApp` before using other Firebase services.
    await Firebase.initializeApp();

    print("Handling a background message: ${message.messageId}");
  }

  // void main() {
  //   runApp(MyApp());
  // }

  final FirebaseMessaging firebaseMessaging = FirebaseMessaging.instance;
  // Request permission to receive notifications (required on iOS)
  await firebaseMessaging.requestPermission();
  // Get the token for this device
  String? token = await firebaseMessaging.getToken();
  print('FCM Device Token: $token');
  SharedPreferences prefs = await SharedPreferences.getInstance();
  await prefs.setString('fcmToken', token!);

  runApp(MultiProvider(providers: [
    ChangeNotifierProvider(create: (_) => NekretnineProvider()),
    ChangeNotifierProvider(
      create: (_) => UserProvider(),
    ),
    ChangeNotifierProvider(create: (_) => NekretninaProvider())
  ], child: const MyApp()));
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});
  // This widget is the root of your application.
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Flutter Demo',
      // onGenerateRoute: ((settings) {
      //   if (settings.name == NekretnineListScreen.routeName) {
      //     return MaterialPageRoute(
      //         builder: ((context) => const NekretnineListScreen()));
      //   }
      //   if (settings.name == SingleNekretninaScreen.routeName) {
      //     return MaterialPageRoute(
      //         builder: ((context) => SingleNekretninaScreen(
      //               arguments: null,
      //             )));
      //   }
      //   return null;
      // }),
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
  TextEditingController usernameController = TextEditingController();
  TextEditingController passwordController = TextEditingController();

  late UserProvider userProvider;
  @override
  Widget build(BuildContext context) {
    userProvider = Provider.of<UserProvider>(context);
    return Scaffold(
        body: Container(
      decoration: BoxDecoration(
          borderRadius: BorderRadius.circular(5), color: Colors.blueAccent),
      child: Column(
        mainAxisAlignment: MainAxisAlignment.center,
        crossAxisAlignment: CrossAxisAlignment.center,
        children: [
          Container(
            margin: const EdgeInsets.only(top: 23),
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
            height: 300,
            child: Column(
                mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                children: [
                  TextField(
                    controller: usernameController,
                    decoration: const InputDecoration(
                      hintText: "Username",
                      hintStyle:
                          TextStyle(fontSize: 20.0, color: Colors.blueAccent),
                    ),
                  ),
                  TextField(
                    controller: passwordController,
                    obscureText: true,
                    enableSuggestions: false,
                    autocorrect: false,
                    decoration: const InputDecoration(
                      hintText: "Password",
                      hintStyle: TextStyle(
                        fontSize: 20.0,
                        color: Colors.blueAccent,
                      ),
                    ),
                  ),
                  Container(
                    height: 50,
                    margin: const EdgeInsets.fromLTRB(40, 0, 40, 0),
                    decoration: BoxDecoration(
                      borderRadius: BorderRadius.circular(10),
                      gradient: const LinearGradient(colors: [
                        Color.fromRGBO(143, 148, 251, 1),
                        Color.fromRGBO(143, 148, 251, .6)
                      ]),
                    ),
                    child: InkWell(
                      onTap: () async {
                        try {
                          Authorization.username = usernameController.text;
                          Authorization.password = passwordController.text;

                          List<Korisnik> list = await userProvider.get();
                          Korisnik korisnik = list.firstWhere((element) =>
                              element.username == usernameController.text);
                          SharedPreferences prefs =
                              await SharedPreferences.getInstance();
                          await prefs.setString(
                              'korisnikId', korisnik.korisnikId!.toString());
                          await prefs.setString(
                              'korisnikEmail', korisnik.email!.toString());
                          await prefs.setString('korisnikImePrezime',
                              "${korisnik.korsnikIme!} ${korisnik.korisnikPrezime!}");

                          Navigator.push(
                            context,
                            MaterialPageRoute(
                                builder: (context) => const FitPasosScreen()),
                          );
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
                      },
                      child: const Center(child: Text("Login")),
                    ),
                  ),
                  const MySpacer(),
                  InkWell(
                    onTap: () async {
                      Navigator.push(
                        context,
                        MaterialPageRoute(
                            builder: (context) => RegisterScreen()),
                      );
                    },
                    child: const Center(child: Text("Register")),
                  ),
                ]),
          ),
        ],
      ),
    ));
  }
}
