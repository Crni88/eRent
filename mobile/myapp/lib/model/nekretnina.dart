import 'package:json_annotation/json_annotation.dart';

part 'nekretnina.g.dart';

@JsonSerializable()
class Nekretnina {
  int? nekretninaId;
  String? nazivNekretnine;
  int? cijena;
  int? brojSoba;
  String? grad;
  String? slika;
  bool? izdvojena;
  String? opis;
  int? brojkvadrata;

  Nekretnina();

  factory Nekretnina.fromJson(Map<String, dynamic> json) =>
      _$NekretninaFromJson(json);

  get id => null;

  /// Connect the generated [_$ProductToJson] function to the `toJson` method.
  Map<String, dynamic> toJson() => _$NekretninaToJson(this);
}
