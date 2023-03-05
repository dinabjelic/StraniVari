
import 'package:shared_preferences/shared_preferences.dart';
export './token.dart';

class TokenHelper {
static Future<void> storeToken(String token) async {
  final prefs = await SharedPreferences.getInstance();
  prefs.setString('token', token);
}

// Retrieving the token from local storage
static Future<String> getToken() async {
  final prefs = await SharedPreferences.getInstance();
  return prefs.getString('token') ?? "";
}
}