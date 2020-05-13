// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.Iot.Hub.Service.Models;

namespace Azure.Iot.Hub.Service
{
    /// <summary> The Twin service client. </summary>
    public partial class TwinClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal TwinRestClient RestClient { get; }
        /// <summary> Initializes a new instance of TwinClient for mocking. </summary>
        protected TwinClient()
        {
        }
        /// <summary> Initializes a new instance of TwinClient. </summary>
        internal TwinClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string host = "https://fully-qualified-iothubname.azure-devices.net", string apiVersion = "2020-03-13")
        {
            RestClient = new TwinRestClient(clientDiagnostics, pipeline, host, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets a device twin. See https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-device-twins for more information. For IoT Hub VNET related features(https://docs.microsoft.com/en-us/azure/iot-hub/virtual-network-support) please use API version &apos;2020-03-13&apos;.These features are currently in general availability in the East US, West US 2, and Southcentral US regions only. We are actively working to expand the availability of these features to all regions by end of month May. For rest of the APIs please continue using API version &apos;2019-10-01&apos;. </summary>
        /// <param name="id"> Device ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TwinData>> GetDeviceTwinAsync(string id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TwinClient.GetDeviceTwin");
            scope.Start();
            try
            {
                return await RestClient.GetDeviceTwinAsync(id, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a device twin. See https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-device-twins for more information. For IoT Hub VNET related features(https://docs.microsoft.com/en-us/azure/iot-hub/virtual-network-support) please use API version &apos;2020-03-13&apos;.These features are currently in general availability in the East US, West US 2, and Southcentral US regions only. We are actively working to expand the availability of these features to all regions by end of month May. For rest of the APIs please continue using API version &apos;2019-10-01&apos;. </summary>
        /// <param name="id"> Device ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TwinData> GetDeviceTwin(string id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TwinClient.GetDeviceTwin");
            scope.Start();
            try
            {
                return RestClient.GetDeviceTwin(id, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Replaces a device twin. See https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-device-twins for more information. For IoT Hub VNET related features(https://docs.microsoft.com/en-us/azure/iot-hub/virtual-network-support) please use API version &apos;2020-03-13&apos;.These features are currently in general availability in the East US, West US 2, and Southcentral US regions only. We are actively working to expand the availability of these features to all regions by end of month May. For rest of the APIs please continue using API version &apos;2019-10-01&apos;. </summary>
        /// <param name="id"> Device ID. </param>
        /// <param name="deviceTwinInfo"> Device twin info. </param>
        /// <param name="ifMatch"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TwinData>> ReplaceDeviceTwinAsync(string id, TwinData deviceTwinInfo, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TwinClient.ReplaceDeviceTwin");
            scope.Start();
            try
            {
                return await RestClient.ReplaceDeviceTwinAsync(id, deviceTwinInfo, ifMatch, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Replaces a device twin. See https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-device-twins for more information. For IoT Hub VNET related features(https://docs.microsoft.com/en-us/azure/iot-hub/virtual-network-support) please use API version &apos;2020-03-13&apos;.These features are currently in general availability in the East US, West US 2, and Southcentral US regions only. We are actively working to expand the availability of these features to all regions by end of month May. For rest of the APIs please continue using API version &apos;2019-10-01&apos;. </summary>
        /// <param name="id"> Device ID. </param>
        /// <param name="deviceTwinInfo"> Device twin info. </param>
        /// <param name="ifMatch"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TwinData> ReplaceDeviceTwin(string id, TwinData deviceTwinInfo, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TwinClient.ReplaceDeviceTwin");
            scope.Start();
            try
            {
                return RestClient.ReplaceDeviceTwin(id, deviceTwinInfo, ifMatch, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates a device twin. See https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-device-twins for more information. For IoT Hub VNET related features(https://docs.microsoft.com/en-us/azure/iot-hub/virtual-network-support) please use API version &apos;2020-03-13&apos;.These features are currently in general availability in the East US, West US 2, and Southcentral US regions only. We are actively working to expand the availability of these features to all regions by end of month May. For rest of the APIs please continue using API version &apos;2019-10-01&apos;. </summary>
        /// <param name="id"> Device ID. </param>
        /// <param name="deviceTwinInfo"> Device twin info. </param>
        /// <param name="ifMatch"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TwinData>> UpdateDeviceTwinAsync(string id, TwinData deviceTwinInfo, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TwinClient.UpdateDeviceTwin");
            scope.Start();
            try
            {
                return await RestClient.UpdateDeviceTwinAsync(id, deviceTwinInfo, ifMatch, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates a device twin. See https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-device-twins for more information. For IoT Hub VNET related features(https://docs.microsoft.com/en-us/azure/iot-hub/virtual-network-support) please use API version &apos;2020-03-13&apos;.These features are currently in general availability in the East US, West US 2, and Southcentral US regions only. We are actively working to expand the availability of these features to all regions by end of month May. For rest of the APIs please continue using API version &apos;2019-10-01&apos;. </summary>
        /// <param name="id"> Device ID. </param>
        /// <param name="deviceTwinInfo"> Device twin info. </param>
        /// <param name="ifMatch"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TwinData> UpdateDeviceTwin(string id, TwinData deviceTwinInfo, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TwinClient.UpdateDeviceTwin");
            scope.Start();
            try
            {
                return RestClient.UpdateDeviceTwin(id, deviceTwinInfo, ifMatch, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a module twin. See https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-device-twins for more information. For IoT Hub VNET related features(https://docs.microsoft.com/en-us/azure/iot-hub/virtual-network-support) please use API version &apos;2020-03-13&apos;.These features are currently in general availability in the East US, West US 2, and Southcentral US regions only. We are actively working to expand the availability of these features to all regions by end of month May. For rest of the APIs please continue using API version &apos;2019-10-01&apos;. </summary>
        /// <param name="id"> Device ID. </param>
        /// <param name="mid"> Module ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TwinData>> GetModuleTwinAsync(string id, string mid, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TwinClient.GetModuleTwin");
            scope.Start();
            try
            {
                return await RestClient.GetModuleTwinAsync(id, mid, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a module twin. See https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-device-twins for more information. For IoT Hub VNET related features(https://docs.microsoft.com/en-us/azure/iot-hub/virtual-network-support) please use API version &apos;2020-03-13&apos;.These features are currently in general availability in the East US, West US 2, and Southcentral US regions only. We are actively working to expand the availability of these features to all regions by end of month May. For rest of the APIs please continue using API version &apos;2019-10-01&apos;. </summary>
        /// <param name="id"> Device ID. </param>
        /// <param name="mid"> Module ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TwinData> GetModuleTwin(string id, string mid, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TwinClient.GetModuleTwin");
            scope.Start();
            try
            {
                return RestClient.GetModuleTwin(id, mid, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Replaces a module twin. See https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-device-twins for more information. For IoT Hub VNET related features(https://docs.microsoft.com/en-us/azure/iot-hub/virtual-network-support) please use API version &apos;2020-03-13&apos;.These features are currently in general availability in the East US, West US 2, and Southcentral US regions only. We are actively working to expand the availability of these features to all regions by end of month May. For rest of the APIs please continue using API version &apos;2019-10-01&apos;. </summary>
        /// <param name="id"> Device ID. </param>
        /// <param name="mid"> Module ID. </param>
        /// <param name="deviceTwinInfo"> Device twin info. </param>
        /// <param name="ifMatch"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TwinData>> ReplaceModuleTwinAsync(string id, string mid, TwinData deviceTwinInfo, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TwinClient.ReplaceModuleTwin");
            scope.Start();
            try
            {
                return await RestClient.ReplaceModuleTwinAsync(id, mid, deviceTwinInfo, ifMatch, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Replaces a module twin. See https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-device-twins for more information. For IoT Hub VNET related features(https://docs.microsoft.com/en-us/azure/iot-hub/virtual-network-support) please use API version &apos;2020-03-13&apos;.These features are currently in general availability in the East US, West US 2, and Southcentral US regions only. We are actively working to expand the availability of these features to all regions by end of month May. For rest of the APIs please continue using API version &apos;2019-10-01&apos;. </summary>
        /// <param name="id"> Device ID. </param>
        /// <param name="mid"> Module ID. </param>
        /// <param name="deviceTwinInfo"> Device twin info. </param>
        /// <param name="ifMatch"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TwinData> ReplaceModuleTwin(string id, string mid, TwinData deviceTwinInfo, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TwinClient.ReplaceModuleTwin");
            scope.Start();
            try
            {
                return RestClient.ReplaceModuleTwin(id, mid, deviceTwinInfo, ifMatch, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates a module twin. See https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-device-twins for more information. For IoT Hub VNET related features(https://docs.microsoft.com/en-us/azure/iot-hub/virtual-network-support) please use API version &apos;2020-03-13&apos;.These features are currently in general availability in the East US, West US 2, and Southcentral US regions only. We are actively working to expand the availability of these features to all regions by end of month May. For rest of the APIs please continue using API version &apos;2019-10-01&apos;. </summary>
        /// <param name="id"> Device ID. </param>
        /// <param name="mid"> Module ID. </param>
        /// <param name="deviceTwinInfo"> Device twin information. </param>
        /// <param name="ifMatch"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TwinData>> UpdateModuleTwinAsync(string id, string mid, TwinData deviceTwinInfo, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TwinClient.UpdateModuleTwin");
            scope.Start();
            try
            {
                return await RestClient.UpdateModuleTwinAsync(id, mid, deviceTwinInfo, ifMatch, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates a module twin. See https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-device-twins for more information. For IoT Hub VNET related features(https://docs.microsoft.com/en-us/azure/iot-hub/virtual-network-support) please use API version &apos;2020-03-13&apos;.These features are currently in general availability in the East US, West US 2, and Southcentral US regions only. We are actively working to expand the availability of these features to all regions by end of month May. For rest of the APIs please continue using API version &apos;2019-10-01&apos;. </summary>
        /// <param name="id"> Device ID. </param>
        /// <param name="mid"> Module ID. </param>
        /// <param name="deviceTwinInfo"> Device twin information. </param>
        /// <param name="ifMatch"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TwinData> UpdateModuleTwin(string id, string mid, TwinData deviceTwinInfo, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TwinClient.UpdateModuleTwin");
            scope.Start();
            try
            {
                return RestClient.UpdateModuleTwin(id, mid, deviceTwinInfo, ifMatch, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}