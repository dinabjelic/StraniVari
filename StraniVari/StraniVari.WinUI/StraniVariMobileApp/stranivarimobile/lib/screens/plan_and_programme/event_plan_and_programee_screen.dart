import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:stranivarimobile/providers/event_plan_and_programme_provider.dart';

class EventPlanAndProgrammeScreen extends StatefulWidget{
 static const String eventplandandprogrammerouteName = '/eventPlanAndProgramme';
 const EventPlanAndProgrammeScreen({Key? key}) : super(key: key);

  @override
  State<EventPlanAndProgrammeScreen> createState() => _EventPlanAndProgrammeScreenState();
}

class _EventPlanAndProgrammeScreenState extends State<EventPlanAndProgrammeScreen> {
  EventPlanAndProgrameProvider? _eventPlanAndProgrameProvider=null; 
  dynamic data = {};
@override


void initState() {
    super.initState();
    _eventPlanAndProgrameProvider = context.read<EventPlanAndProgrameProvider>();
     loadData();   
  }

   Future loadData() async {
    var tmpData = await _eventPlanAndProgrameProvider?.get(null);
    setState(() {
      data = tmpData;
    });
  }


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
              DataColumn(label: Text("Id")),
              DataColumn(label: Text("Start date")),
              DataColumn(label: Text("End date")),
              DataColumn(label: Text("Activities")),
            ],
            rows: _buildPlanAndProgrammeList(),
          ),
        ),
      ]),
    )));
  }
  
  List<DataRow> _buildPlanAndProgrammeList() {

if (data.length == 0) {
      return [
        DataRow(cells: [
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
                DataCell(Text(x["startDate"] ?? "")),
                DataCell(Text(x["endDate"] ?? "")),
                DataCell(Text(x["activity"] ?? "")),
              ],
            ))
        .toList()
        .cast<DataRow>();
    return list;



  }
}

