import 'package:flutter/cupertino.dart';
import 'package:flutter/foundation.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:stranivarimobile/main.dart';
import 'package:stranivarimobile/providers/event_provider.dart';
import 'package:flutter/src/material/data_table.dart';
import 'package:stranivarimobile/helpers/token.dart';


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
  final GetUserResponse finalData = ModalRoute.of(context)!.settings.arguments as GetUserResponse;
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
              DataColumn(label: Text("Id")),
              DataColumn(label: Text("Name")),
              DataColumn(label: Text("StraniVariTheme")),
              DataColumn(label: Text("StartDate")),
              DataColumn(label: Text("EndDate")), 
              DataColumn(label: Text("Action")),
              DataColumn(label: Text("Action")), 
              DataColumn(label: Text("Action")), 
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
                DataCell(Text(x["id"]?.toString() ?? "0")),
                DataCell(Text(x["name"] ?? "")),
                DataCell(Text(x["straniVariTheme"] ?? "")),
                DataCell(Text(x["startDate"] ?? "")),
                DataCell(Text(x["endDate"] ?? "")),
                DataCell(TextButton(
                  child: 
                    Text("Schools", 
                    style: TextStyle(color: Colors.black)), 
                    onPressed:(){
                      // var id = x["id"];
                      IdGetter.Id = x["id"];
                      Navigator.pushNamed(context, EventListScreen.eventSchoolrouteName, arguments: IdGetter.Id);
                    }, 
                )), 
                 DataCell(TextButton(
                  child: 
                    Text("Notifications", 
                    style: TextStyle(color: Colors.black)), 
                    onPressed:(){
                    }, 
                )), 
                 DataCell(TextButton(
                  child: 
                    Text("Plan and Programme", 
                    style: TextStyle(color: Colors.black)), 
                    onPressed:(){
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
  static int Id =0;
}


















// Widget build(BuildContext context) {
//     print("called build $data");
//     return Scaffold(
//       body: Center(child: Text(data.toString())),
//     );
//   }
//print("called build $data");
