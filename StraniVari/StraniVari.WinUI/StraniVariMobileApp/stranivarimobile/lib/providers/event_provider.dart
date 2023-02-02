import 'dart:convert';
import 'dart:io';

import 'package:flutter/cupertino.dart';
import 'package:http/io_client.dart';

class EventProvider with ChangeNotifier{

 HttpClient client = new HttpClient();
  IOClient? http;
  EventProvider(){
    client.badCertificateCallback=(cert, host, port) => true; 
    http = IOClient(client);
  }

  Future<dynamic> get(dynamic searchObject) async{
    var url = Uri.parse("https://localhost:7241/api/Event");
       
    var token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwicm9sZSI6IkFkbWluaXN0cmF0b3IiLCJuYmYiOjE2NzUyODM1OTYsImV4cCI6MTY3NTg4ODM5NiwiaWF0IjoxNjc1MjgzNTk2fQ.gWkMelQqqwEHn_1OwE4ZMoyoKogvt3a7syIJe6qQbZ8";

    String oAuth = "Bearer ${base64Encode(utf8.encode('$token'))}"; 

    var headers = {
      // "Content-Type": "application/json", 
      "Authorization": oAuth
    };


    var response = await http!.get(url, headers: headers);

    if(response.statusCode < 400)
    {
      var data = jsonDecode(response.body);
      return data;
       
    }else{
      throw Exception("User not allowed");
    }

  }
}

