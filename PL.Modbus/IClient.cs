using System;
using System.Collections.Generic;

namespace PL.Modbus
{
    /// <summary>
    /// Modbus client interface.
    /// </summary>
    public interface IClient : IDisposable
    {
        /// <summary>
        /// Gets and sets the data stream.
        /// </summary>
        Stream Stream { get; set; }

        /// <summary>
        /// Gets and sets the protocol.
        /// </summary>
        Protocol Protocol { get; set; }
       
        /// <summary>
        /// Gets and sets the server station address.
        /// </summary>
        byte StationAddress { get; set; }

        /// <summary>
        /// Gets and sets connect timeout, ms.
        /// </summary>
        int ConnectTimeout { get; set; }

        /// <summary>
        /// Gets and sets read timeout, ms.
        /// </summary>
        int ReadTimeout { get; set; }

        /// <summary>
        /// Gets and sets write timeout, ms.
        /// </summary>
        int WriteTimeout { get; set; }

        /// <summary>
        /// Gets and sets the delay between the end of the read operation and unlocking the stream, ms.
        /// </summary>
        int DelayAfterRead { get; set; }

        /// <summary>
        /// Executes Modbus command.
        /// </summary>
        /// <param name="functionCode">Modbus function code.</param>
        /// <param name="data">Request data.</param>
        /// <returns>Response data.</returns>
        byte[] Command(byte functionCode, byte[] data);

        /// <summary>
        /// Reads coils.
        /// </summary>
        /// <param name="address">First coil address.</param>
        /// <param name="count">Number of coils to read.</param>
        /// <returns>Coil values.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Count is 0.</exception>
        /// <exception cref="ArgumentException">(Address + count) > 65536.</exception>
        List<bool> ReadCoils(ushort address, ushort count);

        /// <summary>
        /// Reads discrete inputs.
        /// </summary>
        /// <param name="address">First discrete input address.</param>
        /// <param name="count">Number of discrete inputs to read.</param>
        /// <returns>Discrete inputs.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Count is 0.</exception>
        /// <exception cref="ArgumentException">(Address + count) > 65536.</exception>
        List<bool> ReadDiscreteInputs(ushort address, ushort count);

        /// <summary>
        /// Reads holding registers.
        /// </summary>
        /// <param name="address">First holding register address.</param>
        /// <param name="count">Number of holding registers to read.</param>
        /// <returns>Holding registers.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Count is 0.</exception>
        /// <exception cref="ArgumentException">(Address + count) > 65536.</exception>
        List<ushort> ReadHoldingRegisters(ushort address, ushort count);

        /// <summary>
        /// Reads input registers.
        /// </summary>
        /// <param name="address">First input register address.</param>
        /// <param name="count">Number of input registers to read.</param>
        /// <returns>Input registers.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Count is 0.</exception>
        /// <exception cref="ArgumentException">(Address + count) > 65536.</exception>
        List<ushort> ReadInputRegisters(ushort address, ushort count);

        /// <summary>
        /// Writes single coil.
        /// </summary>
        /// <param name="address">Coil address.</param>
        /// <param name="value">Coil value.</param>
        void WriteSingleCoil(ushort address, bool value);

        /// <summary>
        /// Writes single holding register.
        /// </summary>
        /// <param name="address">Holding register address.</param>
        /// <param name="value">Holding register value.</param>
        void WriteSingleHoldingRegister(ushort address, ushort value);

        /// <summary>
        /// Writes multiple coils.
        /// </summary>
        /// <param name="address">First coil address.</param>
        /// <param name="values">Coil values.</param>
        /// <exception cref="ArgumentOutOfRangeException">Values.Count is 0.</exception>
        /// <exception cref="ArgumentException">(Address + count) > 65536.</exception>
        void WriteMultipleCoils(ushort address, List<bool> values);

        /// <summary>
        /// Writes multiple holding registers.
        /// </summary>
        /// <param name="address">First holding register address.</param>
        /// <param name="values">Holding register values.</param>
        /// <exception cref="ArgumentOutOfRangeException">VAlues.Count is 0.</exception>
        /// <exception cref="ArgumentException">(Address + count) > 65536.</exception>
        void WriteMultipleHoldingRegisters(ushort address, List<ushort> values);
    }
}
