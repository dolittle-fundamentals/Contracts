// package: dolittle.dependencyinversion
// file: DependencyInversion/management/container.proto

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

export class Binding extends jspb.Message {
  getService(): string;
  setService(value: string): void;

  getStrategy(): string;
  setStrategy(value: string): void;

  getStrategydata(): string;
  setStrategydata(value: string): void;

  getScope(): string;
  setScope(value: string): void;

  serializeBinary(): Uint8Array;
  toObject(includeInstance?: boolean): Binding.AsObject;
  static toObject(includeInstance: boolean, msg: Binding): Binding.AsObject;
  static extensions: {[key: number]: jspb.ExtensionFieldInfo<jspb.Message>};
  static extensionsBinary: {[key: number]: jspb.ExtensionFieldBinaryInfo<jspb.Message>};
  static serializeBinaryToWriter(message: Binding, writer: jspb.BinaryWriter): void;
  static deserializeBinary(bytes: Uint8Array): Binding;
  static deserializeBinaryFromReader(message: Binding, reader: jspb.BinaryReader): Binding;
}

export namespace Binding {
  export type AsObject = {
    service: string,
    strategy: string,
    strategydata: string,
    scope: string,
  }
}

export class Bindings extends jspb.Message {
  clearBindingsList(): void;
  getBindingsList(): Array<Binding>;
  setBindingsList(value: Array<Binding>): void;
  addBindings(value?: Binding, index?: number): Binding;

  serializeBinary(): Uint8Array;
  toObject(includeInstance?: boolean): Bindings.AsObject;
  static toObject(includeInstance: boolean, msg: Bindings): Bindings.AsObject;
  static extensions: {[key: number]: jspb.ExtensionFieldInfo<jspb.Message>};
  static extensionsBinary: {[key: number]: jspb.ExtensionFieldBinaryInfo<jspb.Message>};
  static serializeBinaryToWriter(message: Bindings, writer: jspb.BinaryWriter): void;
  static deserializeBinary(bytes: Uint8Array): Bindings;
  static deserializeBinaryFromReader(message: Bindings, reader: jspb.BinaryReader): Bindings;
}

export namespace Bindings {
  export type AsObject = {
    bindingsList: Array<Binding.AsObject>,
  }
}

