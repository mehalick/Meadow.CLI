﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Meadow.CLI.Core.DeviceManagement
{
    public enum HcomProtocolHeaderOffsets
    {
        HCOM_PROTOCOL_REQUEST_HEADER_SEQ_OFFSET = 0,
        HCOM_PROTOCOL_REQUEST_HEADER_VERSION_OFFSET = 2,
        HCOM_PROTOCOL_REQUEST_HEADER_RQST_TYPE_OFFSET = 4,
        HCOM_PROTOCOL_REQUEST_HEADER_EXTRA_DATA_OFFSET = 6,
        HCOM_PROTOCOL_REQUEST_HEADER_USER_DATA_OFFSET = 8,
    }
}
