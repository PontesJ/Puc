import 'package:flutter/material.dart';
import 'dart:convert';
import 'package:http/http.dart' as http;

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  @override
  Widget build(BuildContext context) {
    return const MaterialApp(
      debugShowCheckedModeBanner: false,
      home: ImageGenerator(),
    );
  }
}

class ImageGenerator extends StatefulWidget {
  const ImageGenerator({super.key});

  @override
  _ImageGeneratorState createState() => _ImageGeneratorState();
}

class _ImageGeneratorState extends State<ImageGenerator> {
  String? _imageUrl;

  Future<void> _fetchImage() async {
    const url =
        "https://db.ygoprodeck.com/api/v7/cardinfo.php?num=1&offset=0&sort=random&cachebust";
    try {
      final response = await http.get(Uri.parse(url));
      if (response.statusCode == 200) {
        final data = json.decode(response.body);
        final imageUrl = data['data'][0]['card_images'][0]['image_url'];

        // Adicionando proxy CORS
        final proxiedUrl = "https://corsproxy.io/?$imageUrl";

        setState(() {
          _imageUrl = proxiedUrl;
        });
      } else {
        _showError("Erro ao buscar imagem: Código ${response.statusCode}");
      }
    } catch (e) {
      _showError("Erro ao buscar imagem: $e");
    }
  }

  void _showError(String message) {
    ScaffoldMessenger.of(context).showSnackBar(
      SnackBar(
        content: Text(message),
        backgroundColor: Colors.red,
      ),
    );
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Gerador de Cartas de Yu-Gi-Oh!', style: TextStyle(color: Colors.white)),
        backgroundColor: Colors.blue,
        
      ),
      body: Column(
        mainAxisAlignment: MainAxisAlignment.center,
        children: [
          Expanded(
            child: Center(
              child: _imageUrl == null
                  ? const Text(
                      "Imagem aparecerá aqui",
                      style: TextStyle(fontSize: 18, color: Colors.grey),
                    )
                  : Padding(
                      padding: const EdgeInsets.all(
                          64.0), // Margem ao redor da imagem
                      child: Image.network(
                        _imageUrl!,
                        loadingBuilder: (context, child, loadingProgress) {
                          if (loadingProgress == null) return child;
                          return Center(
                            child: CircularProgressIndicator(
                              value: loadingProgress.expectedTotalBytes != null
                                  ? loadingProgress.cumulativeBytesLoaded /
                                      loadingProgress.expectedTotalBytes!
                                  : null,
                            ),
                          );
                        },
                        errorBuilder: (context, error, stackTrace) {
                          return const Text(
                            "Erro ao carregar imagem",
                            style: TextStyle(color: Colors.red),
                          );
                        },
                      ),
                    ),
            ),
          ),
          Padding(
            padding: const EdgeInsets.all(16.0),
            child: SizedBox(
              width: double.infinity,
              child: ElevatedButton(
                onPressed: _fetchImage,
                style: ElevatedButton.styleFrom(
                  foregroundColor: Colors.white,
                  backgroundColor: Colors.blue,
                  padding: const EdgeInsets.symmetric(vertical: 16.0),
                  shape: const RoundedRectangleBorder(
                    borderRadius: BorderRadius.zero,
                  )
                ),
                child: const Text("Gerar"),
              ),
            ),
          ),
        ],
      ),
    );
  }
}
