namespace SerilogDemo.Domain;

public sealed class Contact
{
    public int ContactId { get; init; }
    public BusinessUnit BusinessUnit { get; init; }
    public string AgentName { get; init; }
    public int Duration { get; init; }

    public Contact(int contactId, BusinessUnit businessUnit, string agentName, int duration) =>
        (ContactId, BusinessUnit, AgentName, Duration) = (contactId, businessUnit, agentName, duration);
}
