// GENERATED CODE -- DO NOT EDIT!

// package: dolittle.dependencyinversion
// file: DependencyInversion/management/container.proto

import * as DependencyInversion_management_container_pb from "../../DependencyInversion/management/container_pb";
import * as grpc from "grpc";

interface IContainerService extends grpc.ServiceDefinition<grpc.UntypedServiceImplementation> {
  getBindings: grpc.MethodDefinition<DependencyInversion_management_container_pb.GetBindingsRequest, DependencyInversion_management_container_pb.Bindings>;
}

export const ContainerService: IContainerService;

export class ContainerClient extends grpc.Client {
  constructor(address: string, credentials: grpc.ChannelCredentials, options?: object);
  getBindings(argument: DependencyInversion_management_container_pb.GetBindingsRequest, callback: grpc.requestCallback<DependencyInversion_management_container_pb.Bindings>): grpc.ClientUnaryCall;
  getBindings(argument: DependencyInversion_management_container_pb.GetBindingsRequest, metadataOrOptions: grpc.Metadata | grpc.CallOptions | null, callback: grpc.requestCallback<DependencyInversion_management_container_pb.Bindings>): grpc.ClientUnaryCall;
  getBindings(argument: DependencyInversion_management_container_pb.GetBindingsRequest, metadata: grpc.Metadata | null, options: grpc.CallOptions | null, callback: grpc.requestCallback<DependencyInversion_management_container_pb.Bindings>): grpc.ClientUnaryCall;
}
