import 'package:flutter/material.dart';

class StarRating extends StatefulWidget {
  final int starCount;
  final double rating;
  final Color color;
  final double size;
  final Function(double) onRatingUpdate;

  const StarRating({super.key, 
    this.starCount = 5,
    this.rating = 0.0,
    required this.color,
    this.size = 55.0,
    required this.onRatingUpdate,
  });

  @override
  _StarRatingState createState() => _StarRatingState();
}

class _StarRatingState extends State<StarRating> {
  late double _currentRating;

  @override
  void initState() {
    super.initState();
    _currentRating = widget.rating;
  }

  Widget _buildStar(int index) {
    IconData iconData = Icons.star;
    Color color = widget.color;

    if (index >= _currentRating) {
      iconData = Icons.star_border;
      color = color.withOpacity(0.5);
    }

    return GestureDetector(
      onTap: () {
        setState(() {
          _currentRating = index + 1.0;
        });
        widget.onRatingUpdate(_currentRating);
      },
      child: Icon(
        iconData,
        color: color,
        size: widget.size,
      ),
    );
  }

  @override
  Widget build(BuildContext context) {
    return Row(
      mainAxisSize: MainAxisSize.min,
      children: List.generate(widget.starCount, (index) => _buildStar(index)),
    );
  }
}
