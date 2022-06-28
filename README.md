# Modbus Client Library for .NET
Yet another Modbus client library for .NET.

## Features
1. RTU, ASCII and TCP protocols via serial or network connection.
2. Implemented read/write functions (Modbus function codes):
   - Read Coils / Discrete Inputs / Holding Registers / Input Registers (1/2/3/4)
   - Write Single Coil / Holding Register (5/6)
   - Write Multiple Coils / Holding Registers (15/16)
3. Splitting single read/write requests into multiple requests with valid number of memory elements. 
4. Automatic reconnection to device.
5. Support of multiple devices on the same serial port (lock (SerialPort)).
6. Possibility of other Modbus function code (including user-defined) implementation.

## Not implemented and user-defined Modbus function codes
All implemented Read/Write methods internally use `PL.Modbus.Client.Command` method.
For Modbus TCP and Modbus ASCII this method can be used with any function code, since these protocols allow to receive responce data without knowing its size beforehand. For Modbus RTU descendant class should be created with overriden `PL.Modbus.Client.ReadRtuData` method.

## Examples
### ModbusClient
Simple Modbus client application.
### ModbusSpeedTest
Tests client-server connection and measures transaction rate.
### ModbusMemoryTest
Tests Modbus server by writing to random memory locations, reading back and comparing data.

## Documentation
[Modbus (Wikipedia)](https://en.wikipedia.org/wiki/Modbus)  
[Modbus Protocol Specification](https://modbus.org/docs/Modbus_Application_Protocol_V1_1b3.pdf)  
[Modbus Serial Line Protocol and Implementation Guide](https://modbus.org/docs/Modbus_over_serial_line_V1_02.pdf)
