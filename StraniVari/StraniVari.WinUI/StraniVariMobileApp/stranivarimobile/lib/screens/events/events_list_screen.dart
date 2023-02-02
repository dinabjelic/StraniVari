import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:stranivarimobile/providers/event_provider.dart';
import 'package:flutter/src/material/data_table.dart';

class EventListScreen extends StatefulWidget {
  static const String routeName = '/events';
  const EventListScreen({super.key});

  @override
  State<EventListScreen> createState() => _EventListScreenState();
}

class _EventListScreenState extends State<EventListScreen> {
  EventProvider? _eventProvider = null;
  dynamic data = {};

  @override
  void initState() {
    //instanciranje elementara radimo u initState metodi
    //TODO Implement initState
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
    print("called build $data");
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
              DataColumn(label: Text("Name")),
              DataColumn(label: Text("StraniVariTheme")),
              DataColumn(label: Text("StartDate")),
              DataColumn(label: Text("EndDate"))
            ],
            rows: _buildEventsList(),
          ),
        ),
      ]),
    )));
  }

  List<DataRow> _buildEventsList() {
    if (data.length == 0) {
      return [
        DataRow(cells: [
          DataCell(Text("Loading...")),
          DataCell(Text("")),
          DataCell(Text("")),
          DataCell(Text(""))
        ])
      ];
    }

    List<DataRow> list = data
        .map((x) => DataRow(
              cells: [
                DataCell(Text(x["name"] ?? "")),
                DataCell(Text(x["straniVariTheme"] ?? "")),
                DataCell(Text(x["startDate"] ?? "")),
                DataCell(Text(x["endDate"] ?? "")),
              ],
            ))
        .toList()
        .cast<DataRow>();

    return list;
  }
}

// Widget build(BuildContext context) {
//     print("called build $data");
//     return Scaffold(
//       body: Center(child: Text(data.toString())),
//     );
//   }
//print("called build $data");
