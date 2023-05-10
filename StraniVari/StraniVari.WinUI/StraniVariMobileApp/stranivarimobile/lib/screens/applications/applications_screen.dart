import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import 'package:provider/provider.dart';
import 'package:stranivarimobile/providers/applications_provider.dart';
import 'package:stranivarimobile/providers/send_application_provider.dart';
import '../../providers/games_provider.dart';

class ApplicationScreen extends StatefulWidget {
  static const String applicationRouteName = '/applications';
  const ApplicationScreen({Key? key}) : super(key: key);

  @override
  State<ApplicationScreen> createState() => _ApplicationScreenState();
}

class _ApplicationScreenState extends State<ApplicationScreen> {
  ApplicationProvider? _applicationProvider = null;
  dynamic data = {};
  // List<dynamic> data = [];
  @override
  void initState() {
    super.initState();
    _applicationProvider = context.read<ApplicationProvider>();
    loadData();
  }

  Future loadData() async {
    var tmpData = await _applicationProvider?.get(null);
    setState(() {
      data = tmpData;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(
          title: Text("Applications"),
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
                          // DataColumn(
                          //     label: Container(
                          //         alignment: Alignment.center,
                          //         child: Text("Id",
                          //             style: TextStyle(fontSize: 14)))),
                          DataColumn(
                              label: Container(
                                  alignment: Alignment.center,
                                  child: Text("Trip place",
                                      style: TextStyle(fontSize: 14)))),
                          DataColumn(
                              label: Container(
                                  alignment: Alignment.center,
                                  child: Text("Date and time",
                                      style: TextStyle(fontSize: 14)))),
                                       DataColumn(
                              label: Container(
                                  alignment: Alignment.center,
                                  child: Text("Status",
                                      style: TextStyle(fontSize: 14)))),
                        ],
                        rows: _loadApplications(),
                      ),
                    ),
                  ]),
                ))));
  }

  List<DataRow> _loadApplications() {
  if (data.isEmpty) {
    return [
      DataRow(cells: [
        DataCell(Text("No data...")),
        DataCell(Text("No data...")),
        DataCell(Text("No data...")),
      ])
    ];
  }

  return [
    DataRow(
      cells: [
        DataCell(
          Text(data["place"] ?? "", style: TextStyle(fontSize: 14)),
        ),
         DataCell(
                  Text(
                    DateFormat('dd/MM/yyyy hh:mm a')
                        .format(DateTime.parse(data["tripDateTime"] ?? "")),
                    style: TextStyle(fontSize: 14),
                  ),
                ),
                DataCell(
          Text(data["status"] ?? "", style: TextStyle(fontSize: 14)),
        ),
      ],
    ),
  ];
}

}

