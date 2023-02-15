import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

import '../../providers/event_schools_provider.dart';

class EventSchoolScreen extends StatefulWidget{
 static const String eventschoolrouteName = '/eventSchools';
 const EventSchoolScreen({Key? key}) : super(key: key);

  @override
  State<EventSchoolScreen> createState() => _EventSchoolScreenState();
}

class _EventSchoolScreenState extends State<EventSchoolScreen> {
  EventSchoolsProvider? _eventSchoolsProvider = null;
  dynamic data = {};
@override


    void initState() {
    super.initState();
    _eventSchoolsProvider = context.read<EventSchoolsProvider>();
     loadData();   
  }

   Future loadData() async {
    var tmpData = await _eventSchoolsProvider?.get(null);
    setState(() {
      data = tmpData;
    });
  }

  @override
  Widget build(BuildContext context) {
  return Scaffold(
     appBar: AppBar(title: 
       Text("Schools"),
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
          child: DataTable(
            columnSpacing: 12,
            horizontalMargin: 12,
            columns: [
              // DataColumn(label: Text("Id")),
              DataColumn(label: Text("Name")),
              DataColumn(label: Text("Adress")),
              DataColumn(label: Text("City")),
              DataColumn(label: Text("Number of children")), 
            ],
            rows: _buildSchoolsList(),
          ),
        ),
      ]),
    ))));
  }
List<DataRow> _buildSchoolsList() {
  if (data.length == 0) {
      return [
        DataRow(cells: [
          // DataCell(Text("Loading...")),
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
                DataCell(Text(x["schoolName"] ?? "")),
                DataCell(Text(x["schoolAddress"] ?? "")),
                DataCell(Text(x["schoolCity"] ?? "")),
                DataCell(Text(x["numberOfChildren"].toString() ?? "0")),
              ],
            ))
        .toList()
        .cast<DataRow>();
    return list;
}
}
