import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

import '../../providers/event_notifications_provider.dart';

class EventNotificationsScreen extends StatefulWidget{
 static const String eventnotificationsrouteName = '/eventNotifications';
 const EventNotificationsScreen({Key? key}) : super(key: key);

  @override
  State<EventNotificationsScreen> createState() => _EventNotificationsScreenState();
}

class _EventNotificationsScreenState extends State<EventNotificationsScreen> {
  EventNotificationsProvider? _eventNotificationsProvider=null; 
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
        body: SafeArea(
            child: SingleChildScrollView(
              scrollDirection: Axis.horizontal,
      child: Column(children: [
        SizedBox(height: 50),
        Container(
          height: 200,
          child: DataTable(
            columnSpacing: 12,
            horizontalMargin: 12,
            columns: [
              // DataColumn(label: Text("Id")),
              DataColumn(label: Text("Theme")),
              DataColumn(label: Text("Place")),
              DataColumn(label: Text("Adress")),
              DataColumn(label: Text("City")),
              DataColumn(label: Text("Date")),
            ],
            rows: _buildNotificationsList(),
          ),
        ),
      ]),
    )));
  }
  List<DataRow> _buildNotificationsList() {
     if (data.length == 0) {
      return [
        DataRow(cells: [
          // DataCell(Text("Loading...")),
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
                // DataCell(Text(x["schoolId"]?.toString() ?? "0")),
                DataCell(Text(x["meetingTheme"] ?? "")),
                DataCell(Text(x["meetingPlace"] ?? "")),
                DataCell(Text(x["address"] ?? "")),
                DataCell(Text(x["city"] ?? "")),
                DataCell(Text(x["meetingDate"] ?? "")),
              ],
            ))
        .toList()
        .cast<DataRow>();
    return list;
  }
  }
  
