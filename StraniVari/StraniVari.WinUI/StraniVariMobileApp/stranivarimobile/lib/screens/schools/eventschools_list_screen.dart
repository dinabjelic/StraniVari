import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

import '../../providers/eventschools_provider.dart';

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

    //  NEKIid = ModalRoute.of(context)!.settings.arguments as int;
       

    return Scaffold(
       body: Center(child: Text("test")));

  }
}