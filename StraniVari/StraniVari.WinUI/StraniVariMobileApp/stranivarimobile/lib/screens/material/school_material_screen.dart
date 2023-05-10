import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

import '../../providers/event_notifications_provider.dart';
import '../../providers/school_material_provider.dart';

class SchoolMaterialScreen extends StatefulWidget {
  static const String schoolmaterialrouteName = '/schoolMaterial';
  const SchoolMaterialScreen({Key? key}) : super(key: key);

  @override
  State<SchoolMaterialScreen> createState() => _SchoolMaterialScreenState();
}

class _SchoolMaterialScreenState extends State<SchoolMaterialScreen> {
  SchoolMaterialProvider? _schoolmaterialProvider = null;
  dynamic data = {};
  @override
  void initState() {
    super.initState();
    _schoolmaterialProvider = context.read<SchoolMaterialProvider>();
    loadData();
  }

  Future loadData() async {
    var tmpData = await _schoolmaterialProvider?.get(null);
    setState(() {
      data = tmpData;
    });
  }

  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(
          title: Text("Material for school"),
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
                                  child: Text("Name",
                                      style: TextStyle(fontSize: 14)))),
                          DataColumn(
                              label: Container(
                                  alignment: Alignment.center,
                                  child: Text("Quantity",
                                      style: TextStyle(fontSize: 14)))),
                        ],
                        rows: _buildSchoolMaterialList(),
                      ),
                    ),
                  ]),
                ))));
  }

  _buildSchoolMaterialList() {
    if (data.length == 0) {
      return [
        DataRow(cells: [
          // DataCell(Text("Loading...")),
          // DataCell(Text("Loading...")),
          DataCell(Text("No data...")),
          DataCell(Text("No data...")),
        ])
      ];
    }

    List<DataRow> list = data
        .map((x) => DataRow(
              cells: [
                // DataCell(Text(x["id"]?.toString() ?? "0")),
                DataCell(Text(x["materialName"] ?? "",
                    style: TextStyle(fontSize: 14))),
                DataCell(Text(x["quantity"].toString() ?? "",
                    style: TextStyle(fontSize: 14))),
              ],
            ))
        .toList()
        .cast<DataRow>();
    return list;
  }
}
