import 'dart:async';
import 'package:dio/dio.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:stranivarimobile/providers/event_notifications_provider.dart';
import 'package:stranivarimobile/providers/event_plan_and_programme_provider.dart';
import 'package:stranivarimobile/providers/event_provider.dart';
import 'package:stranivarimobile/providers/event_schools_provider.dart';
import 'package:stranivarimobile/screens/events/events_list_screen.dart';
import 'package:stranivarimobile/screens/notifications/event_notifications_screen.dart';
import 'package:stranivarimobile/screens/plan_and_programme/event_plan_and_programee_screen.dart';
import 'package:stranivarimobile/screens/schools/event_schools_list_screen.dart';

void main() => runApp(MultiProvider(
      providers: [
        ChangeNotifierProvider(create: (_) => EventProvider()),
        ChangeNotifierProvider(create: (_) => EventSchoolsProvider()),
        ChangeNotifierProvider(create: (_) => EventNotificationsProvider()),
        ChangeNotifierProvider(create: (_) => EventPlanAndProgrameProvider()),
        ],
      child: MaterialApp(
        debugShowCheckedModeBanner: true,
        home: HomePage(),
        routes: {
          EventListScreen.routeName: (context) => EventListScreen(),
          EventSchoolScreen.eventschoolrouteName:(context) => EventSchoolScreen(),
          EventNotificationsScreen.eventnotificationsrouteName:(context) => EventNotificationsScreen(),
          EventPlanAndProgrammeScreen.eventplandandprogrammerouteName:(context) => EventPlanAndProgrammeScreen(),
        },
        onGenerateRoute: (settings) {
          if (settings.name == EventListScreen.routeName) {
            return MaterialPageRoute(builder: ((context) => EventListScreen()));
          }
          else if(settings.name == EventSchoolScreen.eventschoolrouteName){
            return MaterialPageRoute(builder: ((context) => EventSchoolScreen()));
          }
           else if(settings.name == EventNotificationsScreen.eventnotificationsrouteName){
            return MaterialPageRoute(builder: ((context) => EventNotificationsScreen()));
          }
        },
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
              height: 450,
              decoration: BoxDecoration(
                  image: DecorationImage(
                      image: AssetImage("assets/images/white.png"),
                      fit: BoxFit.cover)),
              child: Stack(children: [
                Positioned(
                  top: 90,
                  left: 70,
                  child: Center(
                      child: Text(
                    "STRANI VARI",
                    style: TextStyle(
                        color: Colors.black,
                        fontSize: 20,
                        fontFamily: 'NothingYouCouldDo-Regular',
                        fontWeight: FontWeight.bold),
                  )),
                ),
                Padding(
                    padding:
                        EdgeInsets.symmetric(horizontal: 40, vertical: 150),
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
                                      fontSize: 10, color: Colors.grey))),
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
                                    fontSize: 10, color: Colors.grey)),
                          ),
                        ),
                        Container(
                          height: 40,
                          margin: EdgeInsets.fromLTRB(2, 10, 2, 0),
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
      Dio dio = Dio();
      Response response = await dio.post(
          "https://localhost:7241/api/Autentication/login",
          data: {"Username": username, "Password": password});
      if (response.statusCode == 401) {
        throw Exception('Invalid credentials');
      }
      if (response.statusCode != 200) {
        throw Exception('Failed to login');
      }
      var finalData = GetUserResponse.fromJson(response.data);
      TokenGetter.token = finalData.token;
      Navigator.pushNamed(context, EventListScreen.routeName,
          arguments: finalData);
      return finalData;
    } catch (e) {
      throw Exception('Failed to login');
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
