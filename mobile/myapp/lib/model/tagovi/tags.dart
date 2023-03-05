import 'package:json_annotation/json_annotation.dart';

part 'tags.g.dart';

@JsonSerializable()
class Tags {
  int? tagId;
  String? tagName;

  Tags();

  factory Tags.fromJson(Map<String, dynamic> json) => _$TagsFromJson(json);

  /// Connect the generated [_$ProductToJson] function to the `toJson` method.
  Map<String, dynamic> toJson() => _$TagsToJson(this);
}
