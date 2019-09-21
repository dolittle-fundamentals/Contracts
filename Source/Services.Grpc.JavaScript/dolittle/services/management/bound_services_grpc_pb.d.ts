// GENERATED CODE -- DO NOT EDIT!

// package: dolittle.services.management
// file: dolittle/services/management/bound_services.proto

import * as dolittle_services_management_bound_services_pb from "../../../dolittle/services/management/bound_services_pb";
import * as grpc from "grpc";

interface IBoundServicesService extends grpc.ServiceDefinition<grpc.UntypedServiceImplementation> {
  getForServiceType: grpc.MethodDefinition<dolittle_services_management_bound_services_pb.ServiceType, dolittle_services_management_bound_services_pb.Services>;
}

export const BoundServicesService: IBoundServicesService;

export class BoundServicesClient extends grpc.Client {
  constructor(address: string, credentials: grpc.ChannelCredentials, options?: object);
  getForServiceType(argument: dolittle_services_management_bound_services_pb.ServiceType, callback: grpc.requestCallback<dolittle_services_management_bound_services_pb.Services>): grpc.ClientUnaryCall;
  getForServiceType(argument: dolittle_services_management_bound_services_pb.ServiceType, metadataOrOptions: grpc.Metadata | grpc.CallOptions | null, callback: grpc.requestCallback<dolittle_services_management_bound_services_pb.Services>): grpc.ClientUnaryCall;
  getForServiceType(argument: dolittle_services_management_bound_services_pb.ServiceType, metadata: grpc.Metadata | null, options: grpc.CallOptions | null, callback: grpc.requestCallback<dolittle_services_management_bound_services_pb.Services>): grpc.ClientUnaryCall;
}
