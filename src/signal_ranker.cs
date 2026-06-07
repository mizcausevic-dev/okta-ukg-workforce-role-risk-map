using System;
using System.Collections.Generic;
using System.Linq;

namespace KineticGain.IdentitySignals;

public record AccessSignal(string Lane, int Exposure, int Savings, int Investment, string BoardStory);

public static class SignalRanker
{
    public static IReadOnlyList<AccessSignal> Signals => new[]
    {
        new AccessSignal("UKG to Okta lifecycle lag", 78, 24, 62, "Former-worker access should be closed before the next access-review packet."),
        new AccessSignal("Okta app sprawl by workforce role", 66, 31, 55, "Role-to-app mismatch is both a risk surface and a license-savings opportunity."),
        new AccessSignal("Manager attestation coverage", 59, 14, 68, "Board evidence improves when attestations follow real UKG reporting lines.")
    };

    public static IEnumerable<object> Rank() => Signals
        .Select(signal => new { signal.Lane, Priority = Math.Round(signal.Exposure * 0.45 + signal.Savings * 0.25 + signal.Investment * 0.30), signal.BoardStory })
        .OrderByDescending(signal => signal.Priority);
}

Console.WriteLine($"okta-ukg-workforce-role-risk-map: " + string.Join(" | ", SignalRanker.Rank()));
