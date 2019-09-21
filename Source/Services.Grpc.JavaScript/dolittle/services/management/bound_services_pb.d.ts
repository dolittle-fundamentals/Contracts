// package: dolittle.services.management
// file: dolittle/services/management/bound_services.proto

import * as jspb from "google-protobuf";

export class GetBindingsRequest extends jspb.Message {
  serializeBinary(): Uint8Array;
  toObject(includeInstance?: boolean): GetBindingsRequest.AsObject;
  static toObject(includeInstance: boolean, msg: GetBindingsRequest): GetBindingsRequest.AsObject;
  static extensions: {[key: number]: jspb.ExtensionFieldInfo<jspb.Message>};
  static extensionsBinary: {[key: number]: jspb.ExtensionFieldBinaryInfo<jspb.Message>};
  static serializeBinaryToWriter(message: GetBindingsRequest, writer: jspb.BinaryWriter): void;
  static deserializeBinary(bytes: Uint8Array): GetBindingsRequest;
  static deserializeBinaryFromReader(message: GetBindingsRequest, reader: jspb.BinaryReader): GetBindingsRequest;
}

export namespace GetBindingsRequest {
  export type AsObject = {
  }
}

export class ServiceType extends jspb.Message {
  getName(): string;
  setName(value: string): void;

  serializeBinary(): Uint8Array;
  toObject(includeInstance?: boolean): ServiceType.AsObject;
  static toObject(includeInstance: boolean, msg: ServiceType): ServiceType.AsObject;
  static extensions: {[key: number]: jspb.ExtensionFieldInfo<jspb.Message>};
  static extensionsBinary: {[key: number]: jspb.ExtensionFieldBinaryInfo<jspb.Message>};
  static serializeBinaryToWriter(message: ServiceType, writer: jspb.BinaryWriter): void;
  static deserializeBinary(bytes: Uint8Array): ServiceType;
  static deserializeBinaryFromReader(message: ServiceType, reader: jspb.BinaryReader): ServiceType;
}

export namespace ServiceType {
  export type AsObject = {
    name: string,
  }
}

export class Service extends jspb.Message {
  getName(): string;
  setName(value: string): void;

  serializeBinary(): Uint8Array;
  toObject(includeInstance?: boolean): Service.AsObject;
  static toObject(includeInstance: boolean, msg: Service): Service.AsObject;
  static extensions: {[key: number]: jspb.ExtensionFieldInfo<jspb.Message>};
  static extensionsBinary: {[key: number]: jspb.ExtensionFieldBinaryInfo<jspb.Message>};
  static serializeBinaryToWriter(message: Service, writer: jspb.BinaryWriter): void;
  static deserializeBinary(bytes: Uint8Array): Service;
  static deserializeBinaryFromReader(message: Service, reader: jspb.BinaryReader): Service;
}

export namespace Service {
  export type AsObject = {
    name: string,
  }
}

export class Services extends jspb.Message {
  clearBoundservicesList(): void;
  getBoundservicesList(): Array<Service>;
  setBoundservicesList(value: Array<Service>): void;
  addBoundservices(value?: Service, index?: number): Service;

  serializeBinary(): Uint8Array;
  toObject(includeInstance?: boolean): Services.AsObject;
  static toObject(includeInstance: boolean, msg: Services): Services.AsObject;
  static extensions: {[key: number]: jspb.ExtensionFieldInfo<jspb.Message>};
  static extensionsBinary: {[key: number]: jspb.ExtensionFieldBinaryInfo<jspb.Message>};
  static serializeBinaryToWriter(message: Services, writer: jspb.BinaryWriter): void;
  static deserializeBinary(bytes: Uint8Array): Services;
  static deserializeBinaryFromReader(message: Services, reader: jspb.BinaryReader): Services;
}

export namespace Services {
  export type AsObject = {
    boundservicesList: Array<Service.AsObject>,
  }
}

