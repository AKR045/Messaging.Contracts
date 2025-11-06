using System;
using System.Collections.Generic;

namespace Infrastructure.Messaging.HarasMessaging.Vendor.Request;

public sealed record GetVendorsRequest
(List<Guid> VendorIds);
