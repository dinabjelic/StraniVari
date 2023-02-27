import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import 'package:provider/provider.dart';

import '../../providers/event_notifications_provider.dart';

class EventNotificationsScreen extends StatefulWidget {
  static const String eventnotificationsrouteName = '/eventNotifications';
  const EventNotificationsScreen({Key? key}) : super(key: key);

  @override
  State<EventNotificationsScreen> createState() =>
      _EventNotificationsScreenState();
}

class _EventNotificationsScreenState extends State<EventNotificationsScreen> {
  EventNotificationsProvider? _eventNotificationsProvider = null;
  dynamic data = {};
  @override
  void initState() {
    super.initState();
    _eventNotificationsProvider = context.read<EventNotificationsProvider>();
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
                                  child: Text("Theme",
                                      style: TextStyle(fontSize: 14)))),
                          DataColumn(
                              label: Container(
                                  alignment: Alignment.center,
                                  child: Text("Place",
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
                                  child: Text("Date",
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
                    Text(x["meetingTheme"] ?? "",
                        style: TextStyle(fontSize: 14))),
                DataCell(
                    Text(x["meetingPlace"] ?? "",
                        style: TextStyle(fontSize: 14))),
                DataCell(Text(x["address"] ?? "",
                        style: TextStyle(fontSize: 14))),
                DataCell(
                        Text(x["city"] ?? "", style: TextStyle(fontSize: 14))),
                DataCell(
                  Text(
                    DateFormat('dd/MM/yyyy')
                        .format(DateTime.parse(x["meetingDate"])),
                    style: TextStyle(fontSize: 14),
                  ),
                ),
              ],
            ))
        .toList()
        .cast<DataRow>();
    return list;
  }
}
