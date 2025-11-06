using System.Collections.Generic;

namespace Infrastructure.Messaging.HarasMessaging.Vendor.Response;

public sealed record GetVendorsResponse
(
    List<VendorDTO> Vendors
    );
