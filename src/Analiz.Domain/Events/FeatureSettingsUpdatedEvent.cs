using FraudShield.TransactionAnalysis.Domain.Common;

namespace Analiz.Domain.Events;

public class FeatureSettingsUpdatedEvent : DomainEvent
{
    public Guid ConfigurationId { get; }
    public string Version { get; }
    public DateTime UpdatedAt { get; }

    public FeatureSettingsUpdatedEvent(Guid configurationId, string version)
    {
        ConfigurationId = configurationId;
        Version = version;
        UpdatedAt = DateTime.UtcNow;
    }
}