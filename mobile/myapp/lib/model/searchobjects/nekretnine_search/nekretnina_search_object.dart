import 'package:json_annotation/json_annotation.dart';

part "nekretnina_search_object.g.dart";

@JsonSerializable()
class Nekretnina_search_object {
  late String? NameFTS;
  late int? CijenaMin;
  late int? CijenaMax;
  late int? BrojSoba;

  Nekretnina_search_object();

  factory Nekretnina_search_object.fromJson(Map<String, dynamic> json) =>
      _$Nekretnina_search_objectFromJson(json);

  /// Connect the generated [_$ProductToJson] function to the `toJson` method.
  Map<String, dynamic> toJson() => _$Nekretnina_search_objectToJson(this);
}
