﻿/*
 * ******************************************************************************
 *   Copyright 2014-2016 Spectra Logic Corporation. All Rights Reserved.
 *   Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *   this file except in compliance with the License. A copy of the License is located at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 *   or in the "license" file accompanying this file.
 *   This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *   CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *   specific language governing permissions and limitations under the License.
 * ****************************************************************************
 */

using System;
using System.IO;

namespace Ds3.Helpers.Streams
{
    internal class NonDisposablePutObjectRequestStream : ObjectRequestStream, IDisposable
    {
        public NonDisposablePutObjectRequestStream(Stream stream, long length) : base(stream, length)
        {
        }

        public NonDisposablePutObjectRequestStream(Stream stream, long offset, long length) : base(stream, offset, length)
        {
        }

        public new void Dispose()
        {
            //NonDisposable Stream
        }

        public void DisposeUnderlineStream()
        {
            base.Dispose();
        }
    }
}
