// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DependencyInversion/Management/container.proto
// </auto-generated>
// Original file comments:
// ---------------------------------------------------------------------------------------------
//  Copyright (c) Dolittle. All rights reserved.
//  Licensed under the MIT License. See LICENSE in the project root for license information.
// --------------------------------------------------------------------------------------------
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Dolittle.DependencyInversion.Management {
  /// <summary>
  /// Represents the IoC container
  /// </summary>
  public static partial class Container
  {
    static readonly string __ServiceName = "dolittle.dependencyinversion.Container";

    static readonly grpc::Marshaller<global::Dolittle.DependencyInversion.Management.GetBindingsRequest> __Marshaller_dolittle_dependencyinversion_GetBindingsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Dolittle.DependencyInversion.Management.GetBindingsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Dolittle.DependencyInversion.Management.Bindings> __Marshaller_dolittle_dependencyinversion_Bindings = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Dolittle.DependencyInversion.Management.Bindings.Parser.ParseFrom);

    static readonly grpc::Method<global::Dolittle.DependencyInversion.Management.GetBindingsRequest, global::Dolittle.DependencyInversion.Management.Bindings> __Method_GetBindings = new grpc::Method<global::Dolittle.DependencyInversion.Management.GetBindingsRequest, global::Dolittle.DependencyInversion.Management.Bindings>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetBindings",
        __Marshaller_dolittle_dependencyinversion_GetBindingsRequest,
        __Marshaller_dolittle_dependencyinversion_Bindings);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Dolittle.DependencyInversion.Management.ContainerReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Container</summary>
    [grpc::BindServiceMethod(typeof(Container), "BindService")]
    public abstract partial class ContainerBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Dolittle.DependencyInversion.Management.Bindings> GetBindings(global::Dolittle.DependencyInversion.Management.GetBindingsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Container</summary>
    public partial class ContainerClient : grpc::ClientBase<ContainerClient>
    {
      /// <summary>Creates a new client for Container</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ContainerClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Container that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ContainerClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ContainerClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ContainerClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Dolittle.DependencyInversion.Management.Bindings GetBindings(global::Dolittle.DependencyInversion.Management.GetBindingsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetBindings(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Dolittle.DependencyInversion.Management.Bindings GetBindings(global::Dolittle.DependencyInversion.Management.GetBindingsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetBindings, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Dolittle.DependencyInversion.Management.Bindings> GetBindingsAsync(global::Dolittle.DependencyInversion.Management.GetBindingsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetBindingsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Dolittle.DependencyInversion.Management.Bindings> GetBindingsAsync(global::Dolittle.DependencyInversion.Management.GetBindingsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetBindings, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ContainerClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ContainerClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ContainerBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetBindings, serviceImpl.GetBindings).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ContainerBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetBindings, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Dolittle.DependencyInversion.Management.GetBindingsRequest, global::Dolittle.DependencyInversion.Management.Bindings>(serviceImpl.GetBindings));
    }

  }
}
#endregion