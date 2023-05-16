
using Ardalis.SmartEnum;
namespace CalculatorManagement.Factories.ProbabilityTypes;

public abstract class ProbabilityEnum : SmartEnum<ProbabilityEnum>
{
    public static readonly ProbabilityEnum EnumCombinedWith = new CombinedWithEnum();
    public static readonly ProbabilityEnum EnumEither = new EitherEnum();
    public ProbabilityEnum(string name, int value) : base(name, value)
    {
    }
    private sealed class CombinedWithEnum : ProbabilityEnum
    {
        public CombinedWithEnum() : base(nameof(CombinedWith), 0)
        {
        }
    }
    private sealed class EitherEnum : ProbabilityEnum
    {
        public EitherEnum() : base(nameof(Either), 1)
        {
        }
    }
}
