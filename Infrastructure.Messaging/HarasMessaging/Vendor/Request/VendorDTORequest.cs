using System.Collections.Generic;

namespace Infrastructure.Messaging.HarasMessaging.Vendor.Request;

public class VendorDTORequest
{
  public List<VendorRequest> Vendors { get; set; } = new();
}
