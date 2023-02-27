import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:stranivarimobile/providers/event_plan_and_programme_provider.dart';
import 'package:intl/intl.dart';

class EventPlanAndProgrammeScreen extends StatefulWidget {
  static const String eventplandandprogrammerouteName =
      '/eventPlanAndProgramme';
  const EventPlanAndProgrammeScreen({Key? key}) : super(key: key);

  @override
  State<EventPlanAndProgrammeScreen> createState() =>
      _EventPlanAndProgrammeScreenState();
}

class _EventPlanAndProgrammeScreenState
    extends State<EventPlanAndProgrammeScreen> {
  EventPlanAndProgrameProvider? _eventPlanAndProgrameProvider = null;
  dynamic data = {};
  @override
  void initState() {
    super.initState();
    _eventPlanAndProgrameProvider =
        context.read<EventPlanAndProgrameProvider>();
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
        appBar: AppBar(
          title: Text("Plan and programme"),
          backgroundColor: Color.fromARGB(255, 209, 179, 171),
        ),
        body: SafeArea(
            child: Container(
                decoration: BoxDecoration(
                  image: DecorationImage(
                    image: AssetImage("assets/images/beige.png"),
                    fit: BoxFit.cover,
                    // fit:BoxFit.fill,
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
                                  child: Text("Start date",
                                      style: TextStyle(fontSize: 14)))),
                          DataColumn(
                              label: Container(
                                  alignment: Alignment.center,
                                  child: Text("End date",
                                      style: TextStyle(fontSize: 14)))),
                          DataColumn(
                              label: Container(
                                  alignment: Alignment.center,
                                  child: Text("Activities",
                                      style: TextStyle(fontSize: 14)))),
                        ],
                        rows: _buildPlanAndProgrammeList(),
                      ),
                    ),
                  ]),
                ))));
  }

  List<DataRow> _buildPlanAndProgrammeList() {
    if (data.length == 0) {
      return [
        DataRow(cells: [
          // DataCell(Text("Loading...")),
          DataCell(Text("No data...")),
          DataCell(Text("No data...")),
          DataCell(Text("No data...")),
        ])
      ];
    }

    List<DataRow> list = data
        .map((x) => DataRow(
              cells: [
                // DataCell(Text(x["id"]?.toString() ?? "0")),

                DataCell(
                  Text(
                    DateFormat('dd/MM/yyyy hh:mm a')
                        .format(DateTime.parse(x["startDate"])),
                    style: TextStyle(fontSize: 14),
                  ),
                ),
                DataCell(
                  Text(
                    DateFormat('dd/MM/yyyy hh:mm a')
                        .format(DateTime.parse(x["endDate"])),
                    style: TextStyle(fontSize: 14),
                  ),
                ),
                DataCell(
                    Text(x["activity"] ?? "",
                        style: TextStyle(fontSize: 14))
                        ),
              ],
            ))
        .toList()
        .cast<DataRow>();
    return list;
  }
}
