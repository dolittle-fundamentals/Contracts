// package: dolittle
// file: system/guid.proto

import * as jspb from "google-protobuf";

export class guid extends jspb.Message {
  getValue(): Uint8Array | string;
  getValue_asU8(): Uint8Array;
  getValue_asB64(): string;
  setValue(value: Uint8Array | string): void;

  serializeBinary(): Uint8Array;
  toObject(includeInstance?: boolean): guid.AsObject;
  static toObject(includeInstance: boolean, msg: guid): guid.AsObject;
  static extensions: {[key: number]: jspb.ExtensionFieldInfo<jspb.Message>};
  static extensionsBinary: {[key: number]: jspb.ExtensionFieldBinaryInfo<jspb.Message>};
  static serializeBinaryToWriter(message: guid, writer: jspb.BinaryWriter): void;
  static deserializeBinary(bytes: Uint8Array): guid;
  static deserializeBinaryFromReader(message: guid, reader: jspb.BinaryReader): guid;
}

export namespace guid {
  export type AsObject = {
    value: Uint8Array | string,
  }
}

