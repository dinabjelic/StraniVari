import 'package:flutter/cupertino.dart';
import 'package:flutter/foundation.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import 'package:provider/provider.dart';
import 'package:stranivarimobile/main.dart';
import 'package:stranivarimobile/providers/event_plan_and_programme_provider.dart';
import 'package:stranivarimobile/providers/event_provider.dart';
import 'package:flutter/src/material/data_table.dart';
import 'package:stranivarimobile/helpers/token.dart';
import 'package:stranivarimobile/screens/games/games_screen.dart';
import 'package:stranivarimobile/screens/notifications/event_notifications_screen.dart';
import 'package:stranivarimobile/screens/plan_and_programme/event_plan_and_programee_screen.dart';

class EventListScreen extends StatefulWidget {
  static const String routeName = '/events';
  const EventListScreen({super.key});
  static const String eventSchoolrouteName = '/eventSchools';

  @override
  State<EventListScreen> createState() => _EventListScreenState();
}

class _EventListScreenState extends State<EventListScreen> {
  EventProvider? _eventProvider = null;
  dynamic data = {};

  void initState() {
    super.initState();
    _eventProvider = context.read<EventProvider>();
    loadData();
  }

  Future loadData() async {
    var tmpData = await _eventProvider?.get(null);
    setState(() {
      data = tmpData;
    });
  }

  @override
  Widget build(BuildContext context) {
    final GetUserResponse finalData =
        ModalRoute.of(context)!.settings.arguments as GetUserResponse;
    return Scaffold(
        appBar: AppBar(
          title: Text("Events"),
          backgroundColor: Color.fromARGB(255, 209, 179, 171),
        ),
        body: SafeArea(
            child: Container(
                decoration: BoxDecoration(
                  image: DecorationImage(
                    image: AssetImage("assets/images/beige.png"),
                    fit: BoxFit.cover,
                  ),
                ),
                child: SingleChildScrollView(
                  scrollDirection: Axis.horizontal,
                  child: Column(children: [
                    SizedBox(height: 5),
                  Container(
                          height: 40,
                          width: 100,
                          margin: EdgeInsets.fromLTRB(10, 0, 820, 0),
                          decoration: BoxDecoration(
                              borderRadius: BorderRadius.circular(2),
                              gradient: LinearGradient(colors: [
                                Color.fromARGB(255, 241, 195, 167),
                                Color.fromARGB(255, 217, 215, 208)
                              ])),
                          child: InkWell(
                            onTap: (){
                              Navigator.pushNamed(context, GamesScreen.gamesrouteName);
                            },
                            child: Center(child: Text("Games")),
                          ),
                        ),
                    Container(
                      child: DataTable(
                        columnSpacing: 40,
                        horizontalMargin: 20,
                        columns: [
                          // DataColumn(label: Text("Id")),
                          DataColumn(
                              label: Container(
                                  alignment: Alignment.center,
                                  child: Text("Name",
                                      style: TextStyle(fontSize: 14)))),
                          DataColumn(
                              label: Container(
                                  alignment: Alignment.centerRight,
                                  child: Text("Theme",
                                      style: TextStyle(fontSize: 14)))),
                          DataColumn(
                              label: Container(
                                  alignment: Alignment.center,
                                  child: Text("StartDate",
                                      style: TextStyle(fontSize: 14)))),
                          DataColumn(
                              label: Container(
                                  alignment: Alignment.centerRight,
                                  child: Text("EndDate",
                                      style: TextStyle(fontSize: 14)))),
                          DataColumn(
                              label: Container(
                                  alignment: Alignment.center,
                                  child: Text("Action",
                                      style: TextStyle(fontSize: 14)))),
                          DataColumn(
                              label: Container(
                                  alignment: Alignment.center,
                                  child: Text("Action",
                                      style: TextStyle(fontSize: 14)))),
                          DataColumn(
                              label: Container(
                                  alignment: Alignment.center,
                                  child: Text("Action",
                                      style: TextStyle(fontSize: 14)))),
                        ],
                        rows: _buildEventsList(),
                      ),
                    ),
                  ]),
                ))));
  }

  List<DataRow> _buildEventsList() {
    if (data.length == 0) {
      return [
        DataRow(cells: [
          // DataCell(Text("Loading...")),
          DataCell(Text("Loading...")),
          DataCell(Text("Loading...")),
          DataCell(Text("Loading...")),
          DataCell(Text("Loading...")),
          DataCell(Text("Loading...")),
          DataCell(Text("Loading...")),
          DataCell(Text("Loading...")),
        ])
      ];
    }

    List<DataRow> list = data
        .map((x) => DataRow(
              cells: [
                // DataCell(Text(x["id"]?.toString() ?? "0")),
                DataCell(Text(x["name"] ?? "", style: TextStyle(fontSize: 14))),
                DataCell(Text(x["straniVariTheme"] ?? "",
                    style: TextStyle(fontSize: 14))),
                DataCell(
                  Text(
                    DateFormat('dd/MM/yyyy')
                        .format(DateTime.parse(x["startDate"])),
                    style: TextStyle(fontSize: 14),
                  ),
                ),
                DataCell(
                  Text(
                    DateFormat('dd/MM/yyyy')
                        .format(DateTime.parse(x["endDate"])),
                    style: TextStyle(fontSize: 14),
                  ),
                ),
                DataCell(TextButton(
                  child: Text("Schools",
                      style: TextStyle(
                          color: Colors.black,
                          fontSize: 14,
                          fontWeight: FontWeight.bold)),
                  onPressed: () {
                    IdGetter.Id = x["id"];
                    Navigator.pushNamed(
                        context, EventListScreen.eventSchoolrouteName,
                        arguments: IdGetter.Id);
                  },
                )),
                DataCell(TextButton(
                  child: Text("Notifications",
                      style: TextStyle(
                          color: Colors.black,
                          fontSize: 14,
                          fontWeight: FontWeight.bold)),
                  onPressed: () {
                    IdGetter.Id = x["id"];
                    Navigator.pushNamed(context,
                        EventNotificationsScreen.eventnotificationsrouteName,
                        arguments: IdGetter.Id);
                  },
                )),
                DataCell(TextButton(
                  child: Text("Plan and Programme",
                      style: TextStyle(
                          color: Colors.black,
                          fontSize: 14,
                          fontWeight: FontWeight.bold)),
                  onPressed: () {
                    IdGetter.Id = x["id"];
                    Navigator.pushNamed(
                        context,
                        EventPlanAndProgrammeScreen
                            .eventplandandprogrammerouteName,
                        arguments: IdGetter.Id);
                  },
                ))
              ],
            ))
        .toList()
        .cast<DataRow>();
    return list;
  }
}

class IdGetter {
  static int Id = 0;
}


















// Widget build(BuildContext context) {
//     print("called build $data");
//     return Scaffold(
//       body: Center(child: Text(data.toString())),
//     );
//   }
//print("called build $data");
