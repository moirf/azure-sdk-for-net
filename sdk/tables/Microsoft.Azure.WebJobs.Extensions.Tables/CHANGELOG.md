# Release History

## 1.2.0-beta.1 (Unreleased)

### Features Added

### Breaking Changes

### Bugs Fixed

### Other Changes

## 1.1.0 (2023-03-08)

### Bugs Fixed

- Custom defined entity models that implement `ITableEntity` explicitly will now be serialized properly ([#26514](https://github.com/Azure/azure-sdk-for-net/issues/26514))

- Added support for parsing JSON bytes to `TableEntity` to support out-of-process language workers.

## 1.0.0 (2022-04-11)

### Breaking Changes

- The `AddAzureTables` extension method has been renamed to `AddTables`.

## 1.0.0-beta.2 (2022-03-10)

### Bugs Fixed

- Use value comparison for byte arrays when upserting.

## 1.0.0-beta.1 (2022-01-11)

This is the first beta of the `Microsoft.Azure.WebJobs.Extensions.Tables` client library.
