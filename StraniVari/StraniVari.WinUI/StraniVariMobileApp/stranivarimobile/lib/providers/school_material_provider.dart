import 'dart:convert';
import 'dart:io';
import 'package:flutter/cupertino.dart';
import 'package:http/io_client.dart';
import 'package:stranivarimobile/helpers/token.dart';
import 'package:stranivarimobile/main.dart';
import 'package:stranivarimobile/screens/events/events_list_screen.dart';

import '../screens/schools/event_schools_list_screen.dart';
import 'base_provider.dart';

class SchoolMaterialProvider with ChangeNotifier {
  HttpClient client = new HttpClient();
  IOClient? http;
  SchoolMaterialProvider() {
    client.badCertificateCallback = (cert, host, port) => true;
    http = IOClient(client);
  }

  Future<dynamic> get(dynamic searchObject) async {
    var token = await TokenGetter.token;
    if (token == null) {
      throw Exception("Token not found");
    }

    var url = Uri.parse("${BaseProvider.baseUrl}/SchoolMaterials/get?id="+ SchoolIdGetter.Id.toString());

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