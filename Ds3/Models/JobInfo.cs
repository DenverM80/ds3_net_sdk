﻿/*
 * ******************************************************************************
 *   Copyright 2014 Spectra Logic Corporation. All Rights Reserved.
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

using Ds3.Calls;
using System;

namespace Ds3.Models
{
    public class JobInfo
    {
        public String BucketName { get; private set; }
        public String StartDate { get; private set; }
        public Guid JobId { get; private set; }
        public String Priority { get; private set; }
        public String RequestType { get; private set; }
        public JobStatus Status { get; private set; }

        public JobInfo(
            String bucketName,
            String startDate,
            Guid jobId,
            String priority,
            String requestType,
            JobStatus jobStatus)
        {
            this.BucketName = bucketName;
            this.StartDate = startDate;
            this.JobId = jobId;
            this.Priority = priority;
            this.RequestType = requestType;
            this.Status = jobStatus;
        }
    }
}
