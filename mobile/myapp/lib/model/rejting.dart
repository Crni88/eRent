import 'package:json_annotation/json_annotation.dart';

part 'rejting.g.dart';

@JsonSerializable()
class Rejting {
  int? rejting1;
  String? komentar;
  String? nekretnina;
  String? imePrezime;

  Rejting();

  factory Rejting.fromJson(Map<String, dynamic> json) =>
      _$RejtingFromJson(json);

  /// Connect the generated [_$ProductToJson] function to the `toJson` method.
  Map<String, dynamic> toJson() => _$RejtingToJson(this);
}
