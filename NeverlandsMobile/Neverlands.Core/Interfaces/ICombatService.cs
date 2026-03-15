using Neverlands.Core.Models;
using Neverlands.Core.Models.Combat;

namespace Neverlands.Core.Interfaces;

public interface ICombatService
{
    CombatDecision AnalyzeFight(string html, UserProfile profile);
}
