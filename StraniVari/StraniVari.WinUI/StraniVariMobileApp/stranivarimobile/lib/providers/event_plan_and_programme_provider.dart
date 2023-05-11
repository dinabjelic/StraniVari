import 'dart:convert';
import 'dart:io';
import 'package:flutter/cupertino.dart';
import 'package:http/io_client.dart';
import 'package:stranivarimobile/helpers/token.dart';
import 'package:stranivarimobile/main.dart';

import '../screens/events/events_list_screen.dart';
import 'base_provider.dart';

class EventPlanAndProgrameProvider with ChangeNotifier {
  HttpClient client = new HttpClient();
  IOClient? http;
  EventPlanAndProgrameProvider() {
    client.badCertificateCallback = (cert, host, port) => true;
    http = IOClient(client);
  }

  Future<dynamic> get(dynamic searchObject) async {
    var token = await TokenGetter.token;
    if (token == null) {
      throw Exception("Token not found");
    }
     var url = Uri.parse("${BaseProvider.baseUrl}/PlanAndProgramme/planAndProgramme?id="+ IdGetter.Id.toString());
    
    var response = await http!.get(url, headers: {
      "Authorization": "Bearer $token",
    });

    if (response.statusCode < 400) {
      var data = jsonDecode(response.body);
      return data;
    } else {
      throw Exception("User not allowed");
    }
  }
}