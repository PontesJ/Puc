import 'dart:convert';
import 'package:flutter/material.dart';
import 'package:http/http.dart' as http;

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      debugShowCheckedModeBanner: false,
      home: ImageLoader(),
    );
  }
}

class ImageLoader extends StatefulWidget {
  @override
  _ImageLoaderState createState() => _ImageLoaderState();
}

class _ImageLoaderState extends State<ImageLoader> {
  String? imageUrl;

  Future<void> fetchRandomImage() async {
    final url = Uri.parse('https://db.ygoprodeck.com/api/v7/cardinfo.php?num=1&offset=0&sort=random&cachebust');
    try {
      final response = await http.get(url, headers: {'Accept': 'application/json'});
      if (response.statusCode == 200) {
        final data = jsonDecode(response.body);

        // Verificar o conteúdo retornado
        print('API Response: $data');

        // Garantir que os dados da imagem sejam válidos
        if (data['data'] != null &&
            data['data'][0]['card_images'] != null &&
            data['data'][0]['card_images'][0]['image_url'] != null) {
          setState(() {
            imageUrl = data['data'][0]['card_images'][0]['image_url'];
          });
        } else {
          throw Exception('Invalid image data');
        }
      } else {
        throw Exception('Failed to load image');
      }
    } catch (e) {
      setState(() {
        imageUrl = null;
      });
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(content: Text('Error loading image: $e')),
      );
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Random Card Loader'),
        centerTitle: true,
        backgroundColor: Colors.blue,
      ),
      body: Center(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children: [
            imageUrl != null
                ? Image.network(
                    imageUrl!,
                    errorBuilder: (context, error, stackTrace) {
                      return const Text('Failed to load image. Check your connection.');
                    },
                  )
                : const Text('Press the button to load an image'),
            const SizedBox(height: 20),
            ElevatedButton(
              onPressed: fetchRandomImage,
              style: ElevatedButton.styleFrom(
                foregroundColor: Colors.white,
                backgroundColor: Colors.blue,
              ),
              child: const Text('Load Random Card'),
            ),
          ],
        ),
      ),
    );
  }
}
