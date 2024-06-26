using System.ComponentModel;

namespace PKHeX.Core;

/// <summary>
/// Settings object to contain all parameters that can be configured for legality checks.
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class LegalitySettings
{
    public BulkAnalysisSettings Bulk { get; set; } = new();
    public FramePatternSettings FramePattern { get; set; } = new();
    public GameSpecificSettings Game { get; set; } = new();
    public HandlerSettings Handler { get; set; } = new();
    public HOMETransferSettings HOMETransfer { get; set; } = new();
    public NicknameSettings Nickname { get; set; } = new();
    public TradebackSettings Tradeback { get; set; } = new();
    public WordFilterSettings WordFilter { get; set; } = new();
}
