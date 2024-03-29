import 'package:json_annotation/json_annotation.dart';

part 'nekretnina_tagovi.g.dart';

@JsonSerializable()
class NekretninaTagovi {
  int? ntId;
  int? nekretninaId;
  int? tagID;
  bool? isActive;
  NekretninaTagovi();

  factory NekretninaTagovi.fromJson(Map<String, dynamic> json) =>
      _$NekretninaTagoviFromJson(json);

  get id => null;

  Map<String, dynamic> toJson() => _$NekretninaTagoviToJson(this);
}
