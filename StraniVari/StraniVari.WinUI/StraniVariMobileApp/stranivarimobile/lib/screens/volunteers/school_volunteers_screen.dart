import 'package:flutter/material.dart';
import 'package:flutter/src/widgets/container.dart';
import 'package:flutter/src/widgets/framework.dart';
import 'package:provider/provider.dart';
import 'package:stranivarimobile/providers/school_volunteers_provider.dart';

class SchoolVolunteersScreen extends StatefulWidget {
  static const String schoolvolunteersroutename = '/schoolVolunteers';
  const SchoolVolunteersScreen({Key? key}) : super(key: key);

  @override
  State<SchoolVolunteersScreen> createState() => _SchoolVolunteersScreenState();
}

class _SchoolVolunteersScreenState extends State<SchoolVolunteersScreen> {
  SchoolVolunteersProvider? _eventNotificationsProvider = null;
  dynamic data = {};
  @override
  void initState() {
    super.initState();
    _eventNotificationsProvider = context.read<SchoolVolunteersProvider>();
    loadData();
  }

  Future loadData() async {
    var tmpData = await _eventNotificationsProvider?.get(null);
    setState(() {
      data = tmpData;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(
          title: Text("Notifications"),
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
                    // SizedBox(height: 50),
                    Container(
                      height: 200,
                      width: 450,
                      child: DataTable(
                        columnSpacing: 12,
                        horizontalMargin: 12,
                        columns: [
                          // DataColumn(label: Text("Id")),
                          DataColumn(
                              label: Container(
                                  alignment: Alignment.center,
                                  child: Text("First name",
                                      style: TextStyle(fontSize: 14)))),
                          DataColumn(
                              label: Container(
                                  alignment: Alignment.center,
                                  child: Text("Last name",
                                      style: TextStyle(fontSize: 14)))),
                          DataColumn(
                              label: Container(
                                  alignment: Alignment.center,
                                  child: Text("Adress",
                                      style: TextStyle(fontSize: 14)))),
                          DataColumn(
                              label: Container(
                                  alignment: Alignment.center,
                                  child: Text("City",
                                      style: TextStyle(fontSize: 14)))),
                          DataColumn(
                              label: Container(
                                  alignment: Alignment.center,
                                  child: Text("Transport needed",
                                      style: TextStyle(fontSize: 14)))),
                        ],
                        rows: _buildNotificationsList(),
                      ),
                    ),
                  ]),
                ))));
  }

  List<DataRow> _buildNotificationsList() {
    if (data.length == 0) {
      return [
        DataRow(cells: [
          // DataCell(Text("Loading...")),
          DataCell(Text("No data...")),
          DataCell(Text("No data...")),
          DataCell(Text("No data...")),
          DataCell(Text("No data...")),
          DataCell(Text("No data...")),
        ])
      ];
    }

    List<DataRow> list = data
        .map((x) => DataRow(
              cells: [
                // DataCell(Text(x["schoolId"]?.toString() ?? "0")),
                DataCell(
                    Text(x["firstName"] ?? "", style: TextStyle(fontSize: 14))),
                DataCell(
                    Text(x["lastName"] ?? "", style: TextStyle(fontSize: 14))),
                DataCell(
                    Text(x["address"] ?? "", style: TextStyle(fontSize: 14))),
                DataCell(Text(x["city"] ?? "", style: TextStyle(fontSize: 14))),
                DataCell(Text(
                    bool.fromEnvironment("transportNeeded",
                            defaultValue: x["transportNeeded"] ?? false)
                        ? "Yes"
                        : "No",
                    style: TextStyle(fontSize: 14)))
              ],
            ))
        .toList()
        .cast<DataRow>();
    return list;
  }
}
