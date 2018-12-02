using System;
using System.Runtime.Serialization;

namespace Entities
{
    public enum SetName
    {
        [EnumMember(Value="Core Set")]
        CoreSet,
        [EnumMember(Value="Tears of Amaterasu")]
        TearsOfAmaterasu,
        [EnumMember(Value="For Honor and Glory")]
        ForHonorAndGlory,
        [EnumMember(Value="Into the Forbidden City")]
        IntoTheForbiddenCity,
        [EnumMember(Value="The Chrysanthemum Throne")]
        TheChrysanthemumThrone,
        [EnumMember(Value="Fate Has No Secrets")]
        FateHasNoSecrets,
        [EnumMember(Value="Meditations on the Ephemeral")]
        MeditationsOnTheEphemeral,
        [EnumMember(Value="Phoenix: Disciples of the Void")]
        PhoenixDisciplesOfTheVoid,
        [EnumMember(Value="Breath of the Kami")]
        BreathOfTheKami,
        [EnumMember(Value="Tainted Lands")]
        TaintedLands,
        [EnumMember(Value="The Fires Within")]
        TheFiresWithin,
        [EnumMember(Value="The Ebb and Flow")]
        TheEbbAndFlow,
        [EnumMember(Value="All and Nothing")]
        AllAndNothing,
        [EnumMember(Value="Elements Unbound")]
        ElementsUnbound,
        [EnumMember(Value="Scorpion: Underhand of the Emperor")]
        ScorpionUnderhandOfTheEmperor,
        [EnumMember(Value="Children of the Empire")]
        ChildrenOfTheEmpire

    }
}