import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

import '../../providers/games_provider.dart';

class GamesScreen extends StatefulWidget {
  static const String gamesrouteName = '/games';

  const GamesScreen({Key? key}) : super(key: key);

  @override
  State<GamesScreen> createState() => _GamesScreenState();
}

class _GamesScreenState extends State<GamesScreen> {
  GamesProvider? _schoolmaterialProvider = null;
  dynamic data = {};
  // List<dynamic> data = [];
  @override
  void initState() {
    super.initState();
    _schoolmaterialProvider = context.read<GamesProvider>();
    loadData();
  }

  Future loadData() async {
    var tmpData = await _schoolmaterialProvider?.get(null);
    setState(() {
      data = tmpData;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(
          title: Text("Games"),
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
                                  child: Text("Game details",
                                      style: TextStyle(fontSize: 14)))),
                        ],
                        rows: _loadGames(),
                      ),
                    ),
                  ]),
                ))));
  }

  List<DataRow> _loadGames() {
    if (data.length == 0) {
      return [
        DataRow(cells: [
          DataCell(Text("No data...")),
        ])
      ];
    }
    List<DataRow> list = data
        .map((x) => DataRow(
              cells: [
                // DataCell(Text(x["id"]?.toString() ?? "0")),
                DataCell(Text(x["name"] ?? "", style: TextStyle(fontSize: 14))),
              ],
            ))
        .toList()
        .cast<DataRow>();
    return list;
  }
}
