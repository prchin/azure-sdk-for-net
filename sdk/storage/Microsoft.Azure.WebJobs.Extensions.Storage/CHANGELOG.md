# Release History

## 5.2.0-beta.1 (Unreleased)

### Features Added

### Breaking Changes

### Bugs Fixed

### Other Changes

## 5.1.1 (2023-03-24)
Please refer to [`Microsoft.Azure.WebJobs.Extension.Storage.Blobs`](https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/storage/Microsoft.Azure.WebJobs.Extensions.Storage.Blobs/CHANGELOG.md) and [`Microsoft.Azure.WebJobs.Extension.Storage.Queues`](https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/storage/Microsoft.Azure.WebJobs.Extensions.Storage.Queues/CHANGELOG.md) for detailed list of changes.

## 5.1.0 (2023-02-21)
Please refer to [`Microsoft.Azure.WebJobs.Extension.Storage.Blobs`](https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/storage/Microsoft.Azure.WebJobs.Extensions.Storage.Blobs/CHANGELOG.md) and [`Microsoft.Azure.WebJobs.Extension.Storage.Queues`](https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/storage/Microsoft.Azure.WebJobs.Extensions.Storage.Queues/CHANGELOG.md) for detailed list of changes.

## 5.1.0-beta.1 (2023-02-07)
Please refer to [`Microsoft.Azure.WebJobs.Extension.Storage.Blobs`](https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/storage/Microsoft.Azure.WebJobs.Extensions.Storage.Blobs/CHANGELOG.md) and [`Microsoft.Azure.WebJobs.Extension.Storage.Queues`](https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/storage/Microsoft.Azure.WebJobs.Extensions.Storage.Queues/CHANGELOG.md) for detailed list of changes.

## 5.0.1 (2022-05-02)
- Implemented caching blobs in shared memory for faster I/O.
- Fixed queue message is not removed from the queue after stopping QueueListener. (#28156)

## 5.0.0 (2021-10-26)
- General availability of Microsoft.Azure.WebJobs.Extensions.Storage 5.0.0.
Please refer to [`Microsoft.Azure.WebJobs.Extension.Storage.Blobs`](https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/storage/Microsoft.Azure.WebJobs.Extensions.Storage.Blobs/CHANGELOG.md) and [`Microsoft.Azure.WebJobs.Extension.Storage.Queues`](https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/storage/Microsoft.Azure.WebJobs.Extensions.Storage.Queues/CHANGELOG.md) for detailed list of changes.

## 5.0.0-beta.5 (2021-07-09)
Please refer to [`Microsoft.Azure.WebJobs.Extension.Storage.Blobs`](https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/storage/Microsoft.Azure.WebJobs.Extensions.Storage.Blobs/CHANGELOG.md) and [`Microsoft.Azure.WebJobs.Extension.Storage.Queues`](https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/storage/Microsoft.Azure.WebJobs.Extensions.Storage.Queues/CHANGELOG.md) for detailed list of changes.

## 5.0.0-beta.4 (2021-05-18)
Please refer to [`Microsoft.Azure.WebJobs.Extension.Storage.Blobs`](https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/storage/Microsoft.Azure.WebJobs.Extensions.Storage.Blobs/CHANGELOG.md) and [`Microsoft.Azure.WebJobs.Extension.Storage.Queues`](https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/storage/Microsoft.Azure.WebJobs.Extensions.Storage.Queues/CHANGELOG.md) for detailed list of changes.

## 5.0.0-beta.3 (2021-03-09)
Please refer to [`Microsoft.Azure.WebJobs.Extension.Storage.Blobs`](https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/storage/Microsoft.Azure.WebJobs.Extensions.Storage.Blobs/CHANGELOG.md) and [`Microsoft.Azure.WebJobs.Extension.Storage.Queues`](https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/storage/Microsoft.Azure.WebJobs.Extensions.Storage.Queues/CHANGELOG.md) for detailed list of changes.

## 5.0.0-beta.2 (2021-02-09)
Please refer to [`Microsoft.Azure.WebJobs.Extension.Storage.Blobs`](https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/storage/Microsoft.Azure.WebJobs.Extensions.Storage.Blobs/CHANGELOG.md) and [`Microsoft.Azure.WebJobs.Extension.Storage.Queues`](https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/storage/Microsoft.Azure.WebJobs.Extensions.Storage.Queues/CHANGELOG.md) for detailed list of changes.

## 5.0.0-beta.1 (2020-11-10)
This is the first preview of the next generation of `Microsoft.Azure.WebJobs.Extension.Storage` which has been integrated with latest Azure Storage SDK that follows the [Azure SDK Design Guidelines for .NET](https://azure.github.io/azure-sdk/dotnet_introduction.html) which provide a number of core capabilities that are shared amongst all Azure SDKs, including the intuitive Azure Identity library, an HTTP Pipeline with custom policies, error-handling, distributed tracing, and much more.

The `Microsoft.Azure.WebJobs.Extension.Storage` offers drop-in replacement for scenarios where `Queue`, `QueueTrigger`, `Blob` and `BlobTrigger` attributes were bound to BCL types or user defined POCOs. Advanced scenarios may require code changes. `Table` attribute is not supported in this version.

This is a Public Preview version, so expect incompatible changes in subsequent releases as we improve the product. To provide feedback, please submit an issue in our [Azure SDK for .NET GitHub repo](https://github.com/Azure/azure-sdk-for-net/issues).

### Major changes and features 
The `Microsoft.Azure.WebJobs.Extension.Storage` has been split per storage service. Please refer to [`Microsoft.Azure.WebJobs.Extension.Storage.Blobs`](https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/storage/Microsoft.Azure.WebJobs.Extensions.Storage.Blobs/CHANGELOG.md) and [`Microsoft.Azure.WebJobs.Extension.Storage.Queues`](https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/storage/Microsoft.Azure.WebJobs.Extensions.Storage.Queues/CHANGELOG.md) for detailed list of changes.
