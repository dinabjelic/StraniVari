import 'dart:async';
import 'dart:convert';
import 'dart:io';
import 'package:dio/dio.dart';
import 'package:flutter/material.dart';
import 'package:http/io_client.dart';
import 'package:provider/provider.dart';
import 'package:stranivarimobile/providers/applications_provider.dart';
import 'package:stranivarimobile/providers/base_provider.dart';
import 'package:stranivarimobile/providers/event_notifications_provider.dart';
import 'package:stranivarimobile/providers/event_plan_and_programme_provider.dart';
import 'package:stranivarimobile/providers/event_provider.dart';
import 'package:stranivarimobile/providers/event_schools_provider.dart';
import 'package:stranivarimobile/providers/games_provider.dart';
import 'package:stranivarimobile/providers/school_material_provider.dart';
import 'package:stranivarimobile/providers/school_volunteers_provider.dart';
import 'package:stranivarimobile/providers/send_application_provider.dart';
import 'package:stranivarimobile/screens/applications/applications_screen.dart';
import 'package:stranivarimobile/screens/events/events_list_screen.dart';
import 'package:stranivarimobile/screens/games/games_screen.dart';
import 'package:stranivarimobile/screens/material/school_material_screen.dart';
import 'package:stranivarimobile/screens/notifications/event_notifications_screen.dart';
import 'package:stranivarimobile/screens/plan_and_programme/event_plan_and_programee_screen.dart';
import 'package:stranivarimobile/screens/schools/event_schools_list_screen.dart';
import 'package:http/http.dart' as http;
import 'package:stranivarimobile/screens/volunteers/school_volunteers_screen.dart';

void main() => runApp(MultiProvider(
      providers: [
        ChangeNotifierProvider(create: (_) => EventProvider()),
        ChangeNotifierProvider(create: (_) => EventSchoolsProvider()),
        ChangeNotifierProvider(create: (_) => EventNotificationsProvider()),
        ChangeNotifierProvider(create: (_) => EventPlanAndProgrameProvider()),
        ChangeNotifierProvider(create: (_) => SchoolMaterialProvider()),
        ChangeNotifierProvider(create: (_) => SchoolVolunteersProvider()),
        ChangeNotifierProvider(create: (_) => GamesProvider()),
        ChangeNotifierProvider(create: (_) => ApplicationProvider()),
        ChangeNotifierProvider(create: (_) => SendApplicationProvider()),
      ],
      child: MaterialApp(
        debugShowCheckedModeBanner: true,
        home: HomePage(),
        routes: {
          EventListScreen.routeName: (context) => EventListScreen(),
          EventSchoolScreen.eventschoolrouteName: (context) =>
              EventSchoolScreen(),
          EventNotificationsScreen.eventnotificationsrouteName: (context) =>
              EventNotificationsScreen(),
          EventPlanAndProgrammeScreen.eventplandandprogrammerouteName:
              (context) => EventPlanAndProgrammeScreen(),
          SchoolMaterialScreen.schoolmaterialrouteName: (context) =>
              SchoolMaterialScreen(),
          SchoolVolunteersScreen.schoolvolunteersroutename: (context) =>
              SchoolVolunteersScreen(),
          GamesScreen.gamesrouteName: (context) => GamesScreen(),
          ApplicationScreen.applicationRouteName: (context) =>
              ApplicationScreen(),
        },
        onGenerateRoute: (settings) {},
      ),
    ));

final style = TextStyle(fontSize: 62, fontWeight: FontWeight.bold);

class HomePage extends StatelessWidget {
  final usernameController = TextEditingController();
  final passwordController = TextEditingController();
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: SingleChildScrollView(
        child: Column(
          children: [
            Container(
              height: 730,
              decoration: BoxDecoration(
                  image: DecorationImage(
                      image: AssetImage("assets/images/white.png"),
                      fit: BoxFit.cover)),
              child: Stack(children: [
                Positioned(
                  top: 170,
                  left: 70,
                  child: Center(
                      child: Text(
                    "STRANI VARI",
                    style: TextStyle(
                        color: Colors.black,
                        fontSize: 25,
                        fontFamily: 'NothingYouCouldDo-Regular',
                        fontWeight: FontWeight.bold),
                  )),
                ),
                Padding(
                    padding:
                        EdgeInsets.symmetric(horizontal: 40, vertical: 250),
                    child: Container(
                      child: Column(children: [
                        Container(
                          padding: EdgeInsets.symmetric(horizontal: 10),
                          decoration: BoxDecoration(
                              color: Colors.white,
                              border: Border(
                                  bottom: BorderSide(color: Colors.grey))),
                          child: TextField(
                              controller: usernameController,
                              decoration: InputDecoration(
                                  border: InputBorder.none,
                                  hintText: "Username",
                                  hintStyle: TextStyle(
                                      fontSize: 12, color: Colors.grey))),
                        ),
                        Container(
                          padding: EdgeInsets.symmetric(horizontal: 10),
                          decoration: BoxDecoration(
                              color: Colors.white,
                              border: Border(
                                  bottom: BorderSide(color: Colors.grey))),
                          child: TextField(
                            controller: passwordController,
                            decoration: InputDecoration(
                                border: InputBorder.none,
                                hintText: "Password",
                                hintStyle: TextStyle(
                                    fontSize: 12, color: Colors.grey)),
                            obscureText: true,
                          ),
                        ),
                        Container(
                          height: 40,
                          margin: EdgeInsets.fromLTRB(2, 10, 2, 10),
                          decoration: BoxDecoration(
                              borderRadius: BorderRadius.circular(5),
                              gradient: LinearGradient(colors: [
                                Color.fromARGB(255, 220, 170, 157),
                                Color.fromARGB(255, 217, 215, 208)
                              ])),
                          child: InkWell(
                            onTap: () {
                              login(context, usernameController.text,
                                  passwordController.text);
                            },
                            child: Center(child: Text("Login")),
                          ),
                        )
                      ]),
                    ))
              ]),
            ),
          ],
        ),
      ),
    );
  }

  Future<GetUserResponse> login(
      BuildContext context, String username, String password) async {
    try {
      final ioc = new HttpClient();
      ioc.badCertificateCallback =
          (X509Certificate cert, String host, int port) => true;
      final http = new IOClient(ioc);

      final response = await http.post(
          Uri.parse("${BaseProvider.baseUrl}/Autentication/login"),
          headers: {'Content-Type': 'application/json'},
          body: jsonEncode({"Username": username, "Password": password}));

      if (response.statusCode == 401) {
        throw Exception('Invalid credentials');
      }
      if (response.statusCode != 200) {
        throw Exception('Failed to login');
      }
      // final finalData = GetUserResponse.fromJson(response.body);
      final finalData = GetUserResponse.fromJson(jsonDecode(response.body));
      TokenGetter.token = finalData.token;
      Navigator.pushNamed(context, EventListScreen.routeName,
          arguments: finalData);
      return finalData;
    } catch (e) {
      showDialog(
          context: context,
          builder: (BuildContext context) => AlertDialog(
                title: Text("Error"),
                content: Text(e.toString()),
                actions: [
                  TextButton(
                    child: Text("Ok"),
                    onPressed: () => Navigator.pop(context),
                  )
                ],
              ));
      return new Future<GetUserResponse>.value(
          new GetUserResponse(username: '', token: ''));
    }
  }
}

class GetUserResponse {
  final String username;
  final String token;

  GetUserResponse({required this.username, required this.token});

  factory GetUserResponse.fromJson(Map<String, dynamic> json) {
    return GetUserResponse(
      username: json['username'],
      token: json['token'],
    );
  }
}

class TokenGetter {
  static String token = "";
}
