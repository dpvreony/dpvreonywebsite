using System.Collections.Generic;

namespace DPVreony.Website.Features.OpenSource
{
    public sealed record TierModel(string Name, string Description, IEnumerable<InvolvementModel> Items);
}
