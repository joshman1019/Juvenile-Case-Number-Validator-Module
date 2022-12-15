using Xunit;
using JCNV;

namespace JCNV.Tests;

public class UnitTest1
{
    /// <summary>
    /// Tests correctly formatted case numbers against the validator
    /// </summary>
    /// <param name="caseNumber"></param>
    /// <param name="caseType"></param>
    [Theory]
    [InlineData("00 JA 000000", CaseTypes.AbuseNeglectDependency)]
    [InlineData("22 JB 000001", CaseTypes.Delinquent)]
    [InlineData("21 JT 000001", CaseTypes.TerminationOfParentalRights)]
    [InlineData("21 JE 000001", CaseTypes.Emancipation)]
    [InlineData("21 JW 000001", CaseTypes.JudicialWaiver)]
    [InlineData("22 JR 000001", CaseTypes.ResponsibleIndividualsList)]
    [InlineData("01 JA 354117", CaseTypes.AbuseNeglectDependency)]
    [InlineData("22 JA 1", CaseTypes.AbuseNeglectDependency)]
    [InlineData("01 JB 354117", CaseTypes.Delinquent)]
    [InlineData("22 JB 1", CaseTypes.Delinquent)]
    [InlineData("01 JT 354117", CaseTypes.TerminationOfParentalRights)]
    [InlineData("22 JT 1", CaseTypes.TerminationOfParentalRights)]
    [InlineData("01 JE 354117", CaseTypes.Emancipation)]
    [InlineData("22 JE 1", CaseTypes.Emancipation)]
    [InlineData("01 JR 354117", CaseTypes.ResponsibleIndividualsList)]
    [InlineData("22 JR 1", CaseTypes.ResponsibleIndividualsList)]
    [InlineData("01 JW 354117", CaseTypes.JudicialWaiver)]
    [InlineData("22 JW 1", CaseTypes.JudicialWaiver)]
    public void TestCorrectFileNumberFormatting(string caseNumber, CaseTypes caseType)
    {
        var result = caseNumber.ConfirmValidJuvenileCaseNumber(caseType);
        Assert.True(result);
    }

    /// <summary>
    /// Tests incorrectly formatted case numbers against the validator
    /// </summary>
    /// <param name="caseNumber"></param>
    /// <param name="caseType"></param>
    [Theory]
    [InlineData("00 BA 000000", CaseTypes.AbuseNeglectDependency)]
    [InlineData("00 JA", CaseTypes.AbuseNeglectDependency)]
    [InlineData("0 JA 000000", CaseTypes.AbuseNeglectDependency)]
    [InlineData("00 JB 000000", CaseTypes.TerminationOfParentalRights)]
    [InlineData("00 JT 000000", CaseTypes.AbuseNeglectDependency)]
    [InlineData("00 000000", CaseTypes.AbuseNeglectDependency)]
    [InlineData("AA 00 000000", CaseTypes.AbuseNeglectDependency)]
    [InlineData("1 AA 12", CaseTypes.AbuseNeglectDependency)]
    [InlineData("AA AA AAAAAA", CaseTypes.AbuseNeglectDependency)]
    [InlineData("00AA000000", CaseTypes.AbuseNeglectDependency)]
    [InlineData("", CaseTypes.AbuseNeglectDependency)]
    [InlineData("", CaseTypes.Delinquent)]
    [InlineData("", CaseTypes.TerminationOfParentalRights)]
    [InlineData("", CaseTypes.Emancipation)]
    [InlineData("", CaseTypes.ResponsibleIndividualsList)]
    [InlineData("", CaseTypes.JudicialWaiver)]
    [InlineData("22 CVD 100", CaseTypes.Delinquent)]
    [InlineData("22 M 100", CaseTypes.Delinquent)]
    [InlineData("22 JA 100", CaseTypes.AbuseNeglectDependency)] // NOTE: Incorrect push for GitHub actions testing
    public void TestIncorrectFileNumberFormatting(string caseNumber, CaseTypes caseType)
    {
        var result = caseNumber.ConfirmValidJuvenileCaseNumber(caseType);
        Assert.False(result);
    }
}