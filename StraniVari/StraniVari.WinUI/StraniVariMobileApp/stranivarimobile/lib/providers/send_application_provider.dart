import 'dart:convert';
import 'dart:io';
import 'package:flutter/cupertino.dart';
import 'package:http/io_client.dart';
import 'package:stranivarimobile/helpers/token.dart';
import 'package:stranivarimobile/main.dart';
import 'package:stranivarimobile/screens/events/events_list_screen.dart';

import '../screens/applications/applications_screen.dart';
import '../screens/schools/event_schools_list_screen.dart';
import 'base_provider.dart';

class SendApplicationProvider with ChangeNotifier {
  HttpClient client = new HttpClient();
  IOClient? http;
  SendApplicationProvider() {
    client.badCertificateCallback = (cert, host, port) => true;
    http = IOClient(client);
  }

  Future sendApplication(int id)async {

    var url = Uri.parse("${BaseProvider.baseUrl}/VolunteerTrip?id=$id");

    var token = await TokenGetter.token;
    if (token == null) {
      throw Exception("Token not found");
    }
    
    var response = await http!.post(url, headers: {
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