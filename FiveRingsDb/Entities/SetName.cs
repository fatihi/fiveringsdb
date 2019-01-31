using System.Runtime.Serialization;

namespace FiveRingsDb.Entities
{
    public enum SetName
    {
        [EnumMember(Value="core-set")]
        CoreSet,
        [EnumMember(Value="tears-of-amaterasu")]
        TearsOfAmaterasu,
        [EnumMember(Value="for-honor-and-glory")]
        ForHonorAndGlory,
        [EnumMember(Value="into-the-forbidden-city")]
        IntoTheForbiddenCity,
        [EnumMember(Value="the-chrysanthemum-throne")]
        TheChrysanthemumThrone,
        [EnumMember(Value="fate-has-no-secrets")]
        FateHasNoSecrets,
        [EnumMember(Value="meditations-on-the-ephemeral")]
        MeditationsOnTheEphemeral,
        [EnumMember(Value="disciples-of-the-void")]
        DisciplesOfTheVoid,
        [EnumMember(Value="breath-of-the-kami")]
        BreathOfTheKami,
        [EnumMember(Value="tainted-lands")]
        TaintedLands,
        [EnumMember(Value="the-fires-within")]
        TheFiresWithin,
        [EnumMember(Value="the-ebb-and-flow")]
        TheEbbAndFlow,
        [EnumMember(Value="all-and-nothing")]
        AllAndNothing,
        [EnumMember(Value="elements-unbound")]
        ElementsUnbound,
        [EnumMember(Value="underhand-of-the-emperor")]
        UnderhandOfTheEmperor,
        [EnumMember(Value="children-of-the-empire")]
        ChildrenOfTheEmpire
    }
}