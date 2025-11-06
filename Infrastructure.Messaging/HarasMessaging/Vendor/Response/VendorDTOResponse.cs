using System;
using System.Collections.Generic;

namespace Infrastructure.Messaging.HarasMessaging.Vendor.Response;

public sealed record VendorDTOResponse
   (
        List<Guid> Ids
    );
