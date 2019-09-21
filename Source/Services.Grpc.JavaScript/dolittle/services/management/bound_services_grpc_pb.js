// GENERATED CODE -- DO NOT EDIT!

// Original file comments:
// ---------------------------------------------------------------------------------------------
//  Copyright (c) Dolittle. All rights reserved.
//  Licensed under the MIT License. See LICENSE in the project root for license information.
// --------------------------------------------------------------------------------------------
'use strict';
var grpc = require('grpc');
var dolittle_services_management_bound_services_pb = require('../../../dolittle/services/management/bound_services_pb.js');

function serialize_dolittle_services_management_ServiceType(arg) {
  if (!(arg instanceof dolittle_services_management_bound_services_pb.ServiceType)) {
    throw new Error('Expected argument of type dolittle.services.management.ServiceType');
  }
  return Buffer.from(arg.serializeBinary());
}

function deserialize_dolittle_services_management_ServiceType(buffer_arg) {
  return dolittle_services_management_bound_services_pb.ServiceType.deserializeBinary(new Uint8Array(buffer_arg));
}

function serialize_dolittle_services_management_Services(arg) {
  if (!(arg instanceof dolittle_services_management_bound_services_pb.Services)) {
    throw new Error('Expected argument of type dolittle.services.management.Services');
  }
  return Buffer.from(arg.serializeBinary());
}

function deserialize_dolittle_services_management_Services(buffer_arg) {
  return dolittle_services_management_bound_services_pb.Services.deserializeBinary(new Uint8Array(buffer_arg));
}


// Represents all the bound gRPC services in the system
var BoundServicesService = exports.BoundServicesService = {
  getForServiceType: {
    path: '/dolittle.services.management.BoundServices/GetForServiceType',
    requestStream: false,
    responseStream: false,
    requestType: dolittle_services_management_bound_services_pb.ServiceType,
    responseType: dolittle_services_management_bound_services_pb.Services,
    requestSerialize: serialize_dolittle_services_management_ServiceType,
    requestDeserialize: deserialize_dolittle_services_management_ServiceType,
    responseSerialize: serialize_dolittle_services_management_Services,
    responseDeserialize: deserialize_dolittle_services_management_Services,
  },
};

exports.BoundServicesClient = grpc.makeGenericClientConstructor(BoundServicesService);
