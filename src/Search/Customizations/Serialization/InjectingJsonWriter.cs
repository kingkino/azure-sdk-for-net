﻿// 
// Copyright (c) Microsoft.  All rights reserved. 
// 
// Licensed under the Apache License, Version 2.0 (the "License"); 
// you may not use this file except in compliance with the License. 
// You may obtain a copy of the License at 
//   http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS, 
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
// See the License for the specific language governing permissions and 
// limitations under the License. 
// 

using System;
using Newtonsoft.Json;

namespace Microsoft.Azure.Search.Serialization
{
    /// <summary>
    /// Allows injection of arbitrary JSON during serialization via a callback.
    /// </summary>
    internal class InjectingJsonWriter : JsonWriter
    {
        private JsonWriter _innerWriter;
        private bool _wasStartProcessed;

        public InjectingJsonWriter(JsonWriter innerWriter)
        {
            _innerWriter = innerWriter;
            _wasStartProcessed = false;
        }

        public Action<JsonWriter> OnStart { get; set; }

        public override void Close()
        {
            _innerWriter.Close();
        }

        public override void Flush()
        {
            _innerWriter.Flush();
        }

        public override void WriteComment(string text)
        {
            _innerWriter.WriteComment(text);
        }

        public override void WriteEnd()
        {
            _innerWriter.WriteEnd();
        }

        public override void WriteEndArray()
        {
            _innerWriter.WriteEndArray();
        }

        public override void WriteEndConstructor()
        {
            _innerWriter.WriteEndConstructor();
        }

        public override void WriteEndObject()
        {
            _innerWriter.WriteEndObject();
        }

        public override void WriteNull()
        {
            _innerWriter.WriteNull();
        }

        public override void WritePropertyName(string name)
        {
            _innerWriter.WritePropertyName(name);
        }

        public override void WritePropertyName(string name, bool escape)
        {
            _innerWriter.WritePropertyName(name, escape);
        }

        public override void WriteRaw(string json)
        {
            _innerWriter.WriteRaw(json);
        }

        public override void WriteRawValue(string json)
        {
            _innerWriter.WriteRawValue(json);
        }

        public override void WriteStartArray()
        {
            _innerWriter.WriteStartArray();
            AfterStart();
        }

        public override void WriteStartConstructor(string name)
        {
            _innerWriter.WriteStartConstructor(name);
            AfterStart();
        }

        public override void WriteStartObject()
        {
            _innerWriter.WriteStartObject();
            AfterStart();
        }

        public override void WriteUndefined()
        {
            _innerWriter.WriteUndefined();
        }

        public override void WriteValue(bool value)
        {
            _innerWriter.WriteValue(value);
        }

        public override void WriteValue(bool? value)
        {
            _innerWriter.WriteValue(value);
        }

        public override void WriteValue(byte value)
        {
            _innerWriter.WriteValue(value);
        }

        public override void WriteValue(byte? value)
        {
            _innerWriter.WriteValue(value);
        }

        public override void WriteValue(byte[] value)
        {
            _innerWriter.WriteValue(value);
        }

        public override void WriteValue(char value)
        {
            _innerWriter.WriteValue(value);
        }

        public override void WriteValue(char? value)
        {
            _innerWriter.WriteValue(value);
        }

        public override void WriteValue(DateTime value)
        {
            _innerWriter.WriteValue(value);
        }

        public override void WriteValue(DateTime? value)
        {
            _innerWriter.WriteValue(value);
        }

        public override void WriteValue(DateTimeOffset value)
        {
            _innerWriter.WriteValue(value);
        }

        public override void WriteValue(DateTimeOffset? value)
        {
            _innerWriter.WriteValue(value);
        }

        public override void WriteValue(decimal value)
        {
            _innerWriter.WriteValue(value);
        }

        public override void WriteValue(decimal? value)
        {
            _innerWriter.WriteValue(value);
        }

        public override void WriteValue(double value)
        {
            _innerWriter.WriteValue(value);
        }

        public override void WriteValue(double? value)
        {
            _innerWriter.WriteValue(value);
        }

        public override void WriteValue(float value)
        {
            _innerWriter.WriteValue(value);
        }

        public override void WriteValue(float? value)
        {
            _innerWriter.WriteValue(value);
        }

        public override void WriteValue(Guid value)
        {
            _innerWriter.WriteValue(value);
        }

        public override void WriteValue(Guid? value)
        {
            _innerWriter.WriteValue(value);
        }

        public override void WriteValue(int value)
        {
            _innerWriter.WriteValue(value);
        }

        public override void WriteValue(int? value)
        {
            _innerWriter.WriteValue(value);
        }

        public override void WriteValue(long value)
        {
            _innerWriter.WriteValue(value);
        }

        public override void WriteValue(long? value)
        {
            _innerWriter.WriteValue(value);
        }

        public override void WriteValue(object value)
        {
            _innerWriter.WriteValue(value);
        }

        public override void WriteValue(sbyte value)
        {
            _innerWriter.WriteValue(value);
        }

        public override void WriteValue(sbyte? value)
        {
            _innerWriter.WriteValue(value);
        }

        public override void WriteValue(short value)
        {
            _innerWriter.WriteValue(value);
        }

        public override void WriteValue(short? value)
        {
            _innerWriter.WriteValue(value);
        }

        public override void WriteValue(string value)
        {
            _innerWriter.WriteValue(value);
        }

        public override void WriteValue(TimeSpan value)
        {
            _innerWriter.WriteValue(value);
        }

        public override void WriteValue(TimeSpan? value)
        {
            _innerWriter.WriteValue(value);
        }

        public override void WriteValue(uint value)
        {
            _innerWriter.WriteValue(value);
        }

        public override void WriteValue(uint? value)
        {
            _innerWriter.WriteValue(value);
        }

        public override void WriteValue(ulong value)
        {
            _innerWriter.WriteValue(value);
        }

        public override void WriteValue(ulong? value)
        {
            _innerWriter.WriteValue(value);
        }

        public override void WriteValue(Uri value)
        {
            _innerWriter.WriteValue(value);
        }

        public override void WriteValue(ushort value)
        {
            _innerWriter.WriteValue(value);
        }

        public override void WriteWhitespace(string ws)
        {
            _innerWriter.WriteWhitespace(ws);
        }

        private void AfterStart()
        {
            if (!_wasStartProcessed && OnStart != null)
            {
                OnStart(_innerWriter);
            }

            _wasStartProcessed = true;
        }
    }
}
