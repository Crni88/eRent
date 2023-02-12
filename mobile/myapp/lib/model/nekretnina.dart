import 'dart:ffi';
import 'dart:typed_data';

import 'package:json_annotation/json_annotation.dart';

part 'nekretnina.g.dart';

@JsonSerializable()
class Nekretnina {
  late int? nekretninaId;
  late String? nazivNekretnine;
  late int? cijena;
  late int? brojSoba;
  late String? grad;
  late String? slika;
  late bool izdvojena;
  late String? opis;

  Nekretnina();

  factory Nekretnina.fromJson(Map<String, dynamic> json) =>
      _$NekretninaFromJson(json);

  /// Connect the generated [_$ProductToJson] function to the `toJson` method.
  Map<String, dynamic> toJson() => _$NekretninaToJson(this);
}
