using System;

namespace Infrastructure.Messaging;

public record General
(
    string MessageId,
    DateTimeOffset OccurredOn,
    string MessageType
  );
