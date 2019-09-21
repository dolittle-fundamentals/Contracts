// package: system
// file: system/value.proto

import * as jspb from "google-protobuf";
import * as system_object_pb from "../system/object_pb";

export class Value extends jspb.Message {
  hasObjectValue(): boolean;
  clearObjectValue(): void;
  getObjectValue(): system_object_pb.Object | undefined;
  setObjectValue(value?: system_object_pb.Object): void;

  hasListValue(): boolean;
  clearListValue(): void;
  getListValue(): ArrayValue | undefined;
  setListValue(value?: ArrayValue): void;

  hasDictionaryValue(): boolean;
  clearDictionaryValue(): void;
  getDictionaryValue(): DictionaryValue | undefined;
  setDictionaryValue(value?: DictionaryValue): void;

  getKindCase(): Value.KindCase;
  serializeBinary(): Uint8Array;
  toObject(includeInstance?: boolean): Value.AsObject;
  static toObject(includeInstance: boolean, msg: Value): Value.AsObject;
  static extensions: {[key: number]: jspb.ExtensionFieldInfo<jspb.Message>};
  static extensionsBinary: {[key: number]: jspb.ExtensionFieldBinaryInfo<jspb.Message>};
  static serializeBinaryToWriter(message: Value, writer: jspb.BinaryWriter): void;
  static deserializeBinary(bytes: Uint8Array): Value;
  static deserializeBinaryFromReader(message: Value, reader: jspb.BinaryReader): Value;
}

export namespace Value {
  export type AsObject = {
    objectValue?: system_object_pb.Object.AsObject,
    listValue?: ArrayValue.AsObject,
    dictionaryValue?: DictionaryValue.AsObject,
  }

  export enum KindCase {
    KIND_NOT_SET = 0,
    OBJECT_VALUE = 1,
    LIST_VALUE = 2,
    DICTIONARY_VALUE = 3,
  }
}

export class ArrayValue extends jspb.Message {
  clearValuesList(): void;
  getValuesList(): Array<Value>;
  setValuesList(value: Array<Value>): void;
  addValues(value?: Value, index?: number): Value;

  serializeBinary(): Uint8Array;
  toObject(includeInstance?: boolean): ArrayValue.AsObject;
  static toObject(includeInstance: boolean, msg: ArrayValue): ArrayValue.AsObject;
  static extensions: {[key: number]: jspb.ExtensionFieldInfo<jspb.Message>};
  static extensionsBinary: {[key: number]: jspb.ExtensionFieldBinaryInfo<jspb.Message>};
  static serializeBinaryToWriter(message: ArrayValue, writer: jspb.BinaryWriter): void;
  static deserializeBinary(bytes: Uint8Array): ArrayValue;
  static deserializeBinaryFromReader(message: ArrayValue, reader: jspb.BinaryReader): ArrayValue;
}

export namespace ArrayValue {
  export type AsObject = {
    valuesList: Array<Value.AsObject>,
  }
}

export class DictionaryValue extends jspb.Message {
  getObjectMap(): jspb.Map<string, Value>;
  clearObjectMap(): void;
  serializeBinary(): Uint8Array;
  toObject(includeInstance?: boolean): DictionaryValue.AsObject;
  static toObject(includeInstance: boolean, msg: DictionaryValue): DictionaryValue.AsObject;
  static extensions: {[key: number]: jspb.ExtensionFieldInfo<jspb.Message>};
  static extensionsBinary: {[key: number]: jspb.ExtensionFieldBinaryInfo<jspb.Message>};
  static serializeBinaryToWriter(message: DictionaryValue, writer: jspb.BinaryWriter): void;
  static deserializeBinary(bytes: Uint8Array): DictionaryValue;
  static deserializeBinaryFromReader(message: DictionaryValue, reader: jspb.BinaryReader): DictionaryValue;
}

export namespace DictionaryValue {
  export type AsObject = {
    objectMap: Array<[string, Value.AsObject]>,
  }
}

