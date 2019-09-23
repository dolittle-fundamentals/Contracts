// GENERATED CODE -- DO NOT EDIT!

// package: dolittle.services.management
// file: Services/management/bound_services.proto

import * as Services_management_bound_services_pb from "../../Services/management/bound_services_pb";
import * as grpc from "grpc";

interface IBoundServicesService extends grpc.ServiceDefinition<grpc.UntypedServiceImplementation> {
  getForServiceType: grpc.MethodDefinition<Services_management_bound_services_pb.ServiceType, Services_management_bound_services_pb.Services>;
}

export const BoundServicesService: IBoundServicesService;

export class BoundServicesClient extends grpc.Client {
  constructor(address: string, credentials: grpc.ChannelCredentials, options?: object);
  getForServiceType(argument: Services_management_bound_services_pb.ServiceType, callback: grpc.requestCallback<Services_management_bound_services_pb.Services>): grpc.ClientUnaryCall;
  getForServiceType(argument: Services_management_bound_services_pb.ServiceType, metadataOrOptions: grpc.Metadata | grpc.CallOptions | null, callback: grpc.requestCallback<Services_management_bound_services_pb.Services>): grpc.ClientUnaryCall;
  getForServiceType(argument: Services_management_bound_services_pb.ServiceType, metadata: grpc.Metadata | null, options: grpc.CallOptions | null, callback: grpc.requestCallback<Services_management_bound_services_pb.Services>): grpc.ClientUnaryCall;
}
